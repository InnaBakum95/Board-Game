using System.Collections.Generic;
using Assets.Scripts.Server;
using UnityEngine;

namespace Assets.Scripts.ControlPanel
{
    public class PanelController : MonoBehaviour
    {

        private ServerClient _serverClient;

        private void Start ()
        {
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

        }


        public void Move(byte team, byte steps, bool isForward)
        {
            _serverClient.SendData(new Data()
            {
                Code = 102,
                CurrentTeam = team,
                Steps = steps,
                MoveForward = isForward
            });
        }

        public void TestMove()
        {
            Move(1,2,true);
        }

        public void NewGame(string gameName, byte startCoins, List<string> teams)
        {
            _serverClient.SendData(new Data()
            {
                Code = (byte) Codes.NewGame,
                NewGameInfo = new NewGameInfo()
                {
                     GameName = gameName,
                     CoinsAmount = startCoins,
                     TeamNames = teams
                }
            });
        }

    }
}
