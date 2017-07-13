using System.Collections.Generic;
using Assets.Scripts.Server;
using UnityEngine;

namespace Assets.Scripts.ControlPanel
{
    public class PanelController : MonoBehaviour
    {

        public Transform RowsPanel;
        public GameObject RowPrefab;

        public GameObject NewGamePanel;

        private ServerClient _serverClient;
        private ChallengeCoins _challengeCoins;
        private List<TeamRow> _teamRows;

        private void Start ()
        {
            _challengeCoins = FindObjectOfType<ChallengeCoins>();
            InitializeServer();
        }

        private void InitializeServer()
        {
            _serverClient = GetComponent<ServerClient>();
            _serverClient.OnReceiveData = OnReceiveData;
        }

        private void OnReceiveData(Data data)
        {
            Debug.Log("Data: code = " + data.Code);
            var action = (Codes) data.Code;
            switch (action)
            {
                case Codes.NewGame:
                    SetupNewGame(data.NewGameInfo);
                    break;

                case Codes.Move:
                    OnMove(data.CurrentTeam, data.Steps, data.MoveForward);
                    break;

                case Codes.MoveToHome:
                    OnMoveToHome(data.CurrentTeam);
                    break;

                case Codes.ChallengeCoins:
                    OnSendChallengeCoins(data.ChallengeCoins);
                    break;
            }
        }
        
        public void NewGame(string gameName, byte startCoins, List<string> teams)
        {
            _serverClient.SendData(new Data()
            {
                Code = (byte) Codes.NewGame,
                NewGameInfo = new NewGameInfo()
                {
                     GameName = gameName,
                     TeamNames = teams
                }
            });
        }

        private void SetupNewGame(NewGameInfo newGameInfo)
        {
            for (int i = 1; i < RowsPanel.childCount; i++)
            {
                var row = RowsPanel.GetChild(i);
                Destroy(row.gameObject);
            }

            _teamRows = new List<TeamRow>();

            for (int i = 0; i < newGameInfo.TeamNames.Count; i++)
            {
                var newObj = Instantiate(RowPrefab, RowsPanel);
                newObj.transform.localScale = Vector3.one;
                var teamRow = newObj.GetComponent<TeamRow>();
                teamRow.SetTeamInfo(i+1, newGameInfo.TeamNames[i]);
                _teamRows.Add(teamRow);
            }

            _challengeCoins.SetChallengeCoins(0);
            NewGamePanel.SetActive(false);
        }

        public void Move(byte team, byte steps, bool isForward)
        {
            _serverClient.SendData(new Data()
            {
                Code = (byte)Codes.Move,
                CurrentTeam = team,
                Steps = steps,
                MoveForward = isForward
            });
        }

        private void OnMove(byte team, byte steps, bool moveForward)
        {
            var teamRow = _teamRows[team - 1];
            teamRow.SetCurrentLocation(steps, moveForward);
        }

        public void MoveToHome(byte team)
        {
            _serverClient.SendData(new Data()
            {
                Code = (byte) Codes.MoveToHome,
                CurrentTeam = team
            });
        }
        
        private void OnMoveToHome(byte team)
        {
            var teamRow = _teamRows[team - 1];
            teamRow.SetHomeLocation();
        }

        public void SendAnswerResult(byte team, bool isCorrect)
        {
            _serverClient.SendData(new Data()
            {
                Code = (byte)Codes.AnswerResult,
                CurrentTeam = team,
                AnswerIsCorrect = isCorrect
            });
        }

        public void OwnTheLand(byte team)
        {
            _serverClient.SendData(new Data()
            {
                Code = (byte) Codes.OwnTheLand,
                CurrentTeam = team
            });
        }

        public void SendChallengeCoinsValue(int coinsAmount)
        {
            _serverClient.SendData(new Data()
            {
                Code = (byte)Codes.ChallengeCoins,
                ChallengeCoins = coinsAmount
            });
        }

        private void OnSendChallengeCoins(int challengeCoins)
        {
            _challengeCoins.SetChallengeCoins(challengeCoins);
        }
    }
}
