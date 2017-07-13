using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Server;
using UnityEngine;


    public class GameControll : MonoBehaviour
    {

        public static GameControll Instance;
        public List<string> TeamsName = new List<string>();
        public GameObject InfoAboutTeams;
        public GameObject ImageBackground;
        public List<GameObject> TeamsPieck = new List<GameObject>();

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
                    Debug.Log("Data: code = " + data.Code);
                    Team(data);
                    break;

            }
            //Debug.Log("Data: code = " + data.Code);
        }

        void Team(Data data)
        {
        int i = 0;
        foreach (var team in data.NewGameInfo.TeamNames)
            {
            tmpTeams = Instantiate(InfoAboutTeams);
            Vector3 pos = tmpTeams.transform.position;
            Vector3 scale = tmpTeams.transform.localScale;
            tmpTeams.transform.SetParent(ImageBackground.transform);
            tmpTeams.transform.position = pos;
            tmpTeams.transform.localScale = scale;
            tmpTeams.GetComponent<InfoAboutTeams>().Name.text = team;
            tmpTeams.GetComponent<InfoAboutTeams>().OwnedLend.text = ""+0;
            tmpTeams.GetComponent<InfoAboutTeams>().Question.text = ""+0;
            GameObject teamsPickGO = Instantiate(TeamsPieck[i]);
            MoveTeam.Instance.Teams.Add(teamsPickGO); 
            i++;
        }
        }


        
}
