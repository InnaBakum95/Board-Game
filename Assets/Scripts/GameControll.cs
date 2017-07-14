using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Server;
using UnityEngine;
using UnityEngine.UI;

public class GameControll : MonoBehaviour
    {

        public static GameControll Instance;
        public List<string> TeamsName = new List<string>();
        public GameObject InfoAboutTeams;
        public List<Color> colorTeam = new List<Color>();
        
        public Text Title; 
        public GameObject ImageBackground;
        public Text CountCoins;
        public List<GameObject> TeamsPieck = new List<GameObject>();

        
       
        public List<GameObject> _infoAboutTeams = new List<GameObject>(); 
        GameObject tmpTeams;





    private ServerClient _serverClient;



    private void Awake()
    {
        Instance = this;
    }
    private void Start()
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
            var action = (Codes)data.Code; 
            switch (action)
            {
                case Codes.NewGame:
                    CountCoins.text = data.ChallengeCoins.ToString();
                    Team(data);
                    break;

                case Codes.AnswerResult:
                    AnswerQuestions(data, data.AnswerIsCorrect);
                    break;

                case Codes.ChallengeCoins:
                    ChangeCoins(data);
                    break;

                case Codes.Move:
                    if (data.MoveForward)
                    {
                        MoveTeam.Instance.MoveGOTeamForward(data.CurrentTeam-1, data.Steps);
                    }
                    else
                    {
                        MoveTeam.Instance.MoveGOTeamBack(data.CurrentTeam-1, data.Steps);
                    }
                    break;

                case Codes.MoveToHome:
                    MoveTeam.Instance.MoveToHome(data.CurrentTeam-1);
                    break;

                case Codes.OwnTheLand:
                    MoveTeam.Instance.OwnedLandForCurrentTeam(data.CurrentTeam-1);
                    //foreach (var curTeams in _infoAboutTeams)
                    //{
                      //  curTeams.GetComponent<InfoAboutTeams>().OwnedLend.text = "" + curTeams.GetComponent<InfoAboutTeams>().CountLand;
                    //}
                    break;
            }
            //Debug.Log("Data: code = " + data.Code);
        }

    //void NewGameStart()
    //{

    //}
    void Team(Data data)
        {
        int i = 0;
        Title.text = data.NewGameInfo.GameName;


        MoveTeam.Instance.ClearFlagsAndTeamPeaks();

        for (int inc = 1; inc < ImageBackground.transform.childCount; inc++)
        {
            var row = ImageBackground.transform.GetChild(inc);
            Destroy(row.gameObject);
            _infoAboutTeams = new List<GameObject>();
        }

        foreach (var team in data.NewGameInfo.TeamNames)
            {
                tmpTeams = Instantiate(InfoAboutTeams);
                Vector3 pos = tmpTeams.transform.position;
                Vector3 scale = tmpTeams.transform.localScale;
                tmpTeams.transform.SetParent(ImageBackground.transform);
                tmpTeams.transform.position = pos;
                tmpTeams.transform.localScale = scale;
            //tmpTeams.GetComponent<InfoAboutTeams>().NamePanel.color = colorTeam[i];
            //tmpTeams.GetComponent<InfoAboutTeams>().OwnLandPanel.color = colorTeam[i];
            //tmpTeams.GetComponent<InfoAboutTeams>().QuestionPanel.color = colorTeam[i];

            tmpTeams.GetComponent<InfoAboutTeams>().Name.color = colorTeam[i];

            tmpTeams.GetComponent<InfoAboutTeams>().Name.text = team;
                tmpTeams.GetComponent<InfoAboutTeams>().OwnedLend.text = ""+ tmpTeams.GetComponent<InfoAboutTeams>().CountLand;
                tmpTeams.GetComponent<InfoAboutTeams>().Question.text = ""+ tmpTeams.GetComponent<InfoAboutTeams>().CountQuestion;
                _infoAboutTeams.Add(tmpTeams);
                GameObject teamsPickGO = Instantiate(TeamsPieck[i]);
                MoveTeam.Instance.Teams.Add(teamsPickGO); 
                i++;
            }
        }

    void AnswerQuestions(Data data, bool trueAns)
    {
        if (trueAns)
        {
			int countQuest = _infoAboutTeams[data.CurrentTeam - 1].GetComponent<InfoAboutTeams>().CountQuestion+1;
			_infoAboutTeams[data.CurrentTeam - 1].GetComponent<InfoAboutTeams>().CountQuestion = countQuest;
			
            _infoAboutTeams[data.CurrentTeam-1].GetComponent<InfoAboutTeams>().Question.text = _infoAboutTeams[data.CurrentTeam - 1].GetComponent<InfoAboutTeams>().CountQuestion.ToString();
			
		}
         if (!trueAns)
        {
            if (_infoAboutTeams[data.CurrentTeam - 1].GetComponent<InfoAboutTeams>().CountQuestion > 0)
            {
				int countQ = _infoAboutTeams[data.CurrentTeam - 1].GetComponent<InfoAboutTeams>().CountQuestion-1;
				_infoAboutTeams[data.CurrentTeam - 1].GetComponent<InfoAboutTeams>().CountQuestion = countQ;
                _infoAboutTeams[data.CurrentTeam-1].GetComponent<InfoAboutTeams>().Question.text = _infoAboutTeams[data.CurrentTeam - 1].GetComponent<InfoAboutTeams>().CountQuestion.ToString();
            }
			
        }
    }

     void ChangeCoins(Data data )
        {
        CountCoins.text = data.ChallengeCoins.ToString();
        }


        
}
