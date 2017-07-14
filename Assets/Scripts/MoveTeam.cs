using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class MoveTeam : MonoBehaviour {


    public static MoveTeam Instance;
    public List<GameObject> Teams = new List<GameObject>();
    public List<Flag> FlagsList = new List<Flag>();


    public Color Red;
    public Color Yellow;
    public Color Green;
    public Color Blue;
    public Color Purple;
    public Color Ivory;

    public InputField inputField;


    new Vector3[] pathTeamOne = new Vector3[] { new Vector3(335.2465f, -3.003998f, 0), new Vector3(307.1f, -3.003998f, 0), new Vector3(278.6f, -3.003998f, 0), new Vector3(250.3f, -3.003998f, 0), new Vector3(222f, -3.003998f, 0), new Vector3(193.8f, -3.003998f, 0), new Vector3(193.8f, 25f, 0), new Vector3(193.8f, 53.5f, 0), new Vector3(193.8f, 82.2f, 0), new Vector3(193.8f, 110.9f, 0), new Vector3(193.8f, 139.1f, 0), new Vector3(222.3f, 139.1f, 0), new Vector3(251f, 139.1f, 0), new Vector3(279f, 139.1f, 0), new Vector3(307.5f, 139.1f, 0), new Vector3(335.5f, 139.1f, 0), new Vector3(335.5f, 110.4f, 0), new Vector3(335.5f, 82.2f, 0), new Vector3(335.5f, 54.5f, 0), new Vector3(335.5f, 25.5f, 0) };//, new Vector3(335.2465f, -3.003998f, 0) };
    new Vector3[] pathTeamTwo = new Vector3[] { new Vector3(335.2465f, -12.607f, 0), new Vector3(307.1f, -12.607f, 0), new Vector3(278.6f, -12.607f, 0), new Vector3(250.3f, -12.607f, 0), new Vector3(222f, -12.607f, 0), new Vector3(193.8f, -12.607f, 0), new Vector3(193.8f, 15.4f, 0), new Vector3(193.8f, 43.9f, 0), new Vector3(193.8f, 72.6f, 0), new Vector3(193.8f, 101.3f, 0), new Vector3(193.8f, 129.5f, 0), new Vector3(222.3f, 129.5f, 0), new Vector3(251f, 129.5f, 0), new Vector3(279f, 129.5f, 0), new Vector3(307.5f, 129.5f, 0), new Vector3(335.5f, 129.5f, 0), new Vector3(335.5f, 100.8f, 0), new Vector3(335.5f, 72.6f, 0), new Vector3(335.5f, 44.9f, 0), new Vector3(335.5f, 15.9f, 0) };//, new Vector3(335.2465f, -12.607f, 0)};
    new Vector3[] pathTeamThree = new Vector3[]{ new Vector3(335.2465f, -2.615997f, 0), new Vector3(296.7f, -2.615997f, 0), new Vector3(268.2f, -2.615997f, 0), new Vector3(239.9f, -2.615997f, 0), new Vector3(211.6f, -2.615997f, 0), new Vector3(182.8f, -2.615997f, 0), new Vector3(182.8f, 25.4f, 0), new Vector3(182.8f, 53.9f, 0), new Vector3(182.8f, 82.6f, 0), new Vector3(182.8f, 111.3f, 0), new Vector3(182.8f, 139.5f, 0), new Vector3(211.3f, 139.5f, 0), new Vector3(240f, 139.5f, 0), new Vector3(268f, 139.5f, 0), new Vector3(296.5f, 139.5f, 0), new Vector3(324.5f, 139.5f, 0), new Vector3(324.5f, 110.8f, 0), new Vector3(324.5f, 82.6f, 0), new Vector3(324.5f, 54.9f, 0), new Vector3(324.5f, 25.9f, 0) };//,new Vector3(335.2465f, -2.615997f, 0) };
    new Vector3[] pathTeamFour = new Vector3[]{ new Vector3(345.674f, -2.615997f, 0), new Vector3(317.5f, -2.615997f, 0), new Vector3(289f, -2.615997f, 0), new Vector3(260.7f, -2.615997f, 0), new Vector3(232.4f, -2.615997f, 0), new Vector3(203.8f, -2.615997f, 0), new Vector3(203.8f, 25.4f, 0), new Vector3(203.8f, 53.9f, 0), new Vector3(203.8f, 82.6f, 0), new Vector3(203.8f, 111.3f, 0), new Vector3(203.8f, 139.5f, 0), new Vector3(232.3f, 139.5f, 0), new Vector3(261f, 139.5f, 0), new Vector3(289f, 139.5f, 0), new Vector3(317.5f, 139.5f, 0), new Vector3(345.5f, 139.5f, 0), new Vector3(345.5f, 110.8f, 0), new Vector3(345.5f, 82.6f, 0), new Vector3(345.5f, 54.9f, 0), new Vector3(345.5f, 25.9f, 0) };//, new Vector3(345.674f, -2.615997f, 0) };
    new Vector3[] pathTeamFive = new Vector3[]{ new Vector3(335.586f, 6.987003f, 0), new Vector3(307.4f, 6.987003f, 0), new Vector3(278.9f, 6.987003f, 0), new Vector3(250.6f, 6.987003f, 0), new Vector3(222.3f, 6.987003f, 0), new Vector3(193.8f, 6.987003f, 0),new Vector3(193.8f, 35f, 0), new Vector3(193.8f, 63.5f, 0), new Vector3(193.8f, 92.2f, 0), new Vector3(193.8f, 120.9f, 0),new Vector3(193.8f, 149.1f, 0), new Vector3(222.3f, 149.1f, 0), new Vector3(251f, 149.1f, 0), new Vector3(279f, 149.1f, 0), new Vector3(307.5f, 149.1f, 0), new Vector3(335.5f, 149.1f, 0), new Vector3(335.5f, 120.4f, 0), new Vector3(335.5f, 92.2f, 0), new Vector3(335.5f, 64.5f, 0), new Vector3(335.5f, 35.5f, 0) };//, new Vector3(335.586f, 6.987003f, 0) };


    private int TeamOneCount = 0;
    private int TeamSecondCount = 0;
    private int TeamThirdCount = 0;
    private int TeamFourCount = 0;
    private int TeamFiveCount = 0;
    public float percent = 0.05f;

    float alphaF = 0.01f;
    float alphaS = 0.01f;
    float alphaTh = 0.01f;
    float alphaFou = 0.01f;
    float alphaFive = 0.01f;

    private int currentPositionTeam = 0;


    // Use this for initialization

    private void Awake()
    {
        Instance = this;
    }
    private void OnDrawGizmos()
    {
        iTween.DrawLineGizmos(pathTeamOne);
        iTween.DrawLineGizmos(pathTeamTwo);
        iTween.DrawLineGizmos(pathTeamThree);
        iTween.DrawLineGizmos(pathTeamFour);
        iTween.DrawLineGizmos(pathTeamFive);
    }


    public void MoveToHome(int currentTeam)
    {
        Vector3[] path = new Vector3[] { };

        switch (currentTeam + 1)
        {
            case 1:
                currentPositionTeam = TeamOneCount;
                path = pathTeamOne;
                break;
            case 2:
                path = pathTeamTwo;
                currentPositionTeam = TeamSecondCount;
                break;
            case 3:
                path = pathTeamThree;
                currentPositionTeam = TeamThirdCount;
                break;
            case 4:
                path = pathTeamFour;
                currentPositionTeam = TeamFourCount;
                break;
            case 5:
                path = pathTeamFive;
                currentPositionTeam = TeamFiveCount;
                break;
        }
        //iTween.MoveTo(Teams[currentTeam], path[0], 1f);

        NewMoveTeam(20 - currentPositionTeam, true, currentTeam, path);


        switch (currentTeam + 1)
        {
            case 1:
                TeamOneCount = 0;
                break;
            case 2:
                TeamSecondCount = 0;
                break;
            case 3:
                TeamThirdCount = 0;
                break;
            case 4:
                TeamFourCount = 0;
                break;
            case 5:
                TeamFiveCount = 0;
                break;
        }
    }


    public void OwnedLandForCurrentTeam(int currentTeam)
    {
        Color currentColor = Color.black;
        switch (currentTeam+1)
        {
            case 1:
                currentColor = Red;
                currentPositionTeam = TeamOneCount;
                break;
            case 2:
                currentColor = Yellow;
                currentPositionTeam = TeamSecondCount;
                break;
            case 3:
                currentColor = Green;
                currentPositionTeam = TeamThirdCount;
                break;
            case 4:
                currentColor = Blue;
                currentPositionTeam = TeamFourCount;
                break;
            case 5:
                currentColor = Purple;
                currentPositionTeam = TeamFiveCount;
                break;
        }

        Flag _currentFlag = FlagsList.Find(x => x.NumberColumnOfFlag == currentPositionTeam);
        _currentFlag.gameObject.GetComponent<SpriteRenderer>().color = Ivory;
        _currentFlag.FlagGameObject.GetComponent<SpriteRenderer>().color = currentColor;
       // _currentFlag.gameObject.GetComponentInChildren<SpriteRenderer>().color = currentColor;
        //Debug.Log("Current Flag" + _currentFlag.GetComponentInChildren<SpriteRenderer>().color);


        if (_currentFlag.IsEmpty)
        {
            int countLand = GameControll.Instance._infoAboutTeams[currentTeam].GetComponent<InfoAboutTeams>().CountLand +1;
            GameControll.Instance._infoAboutTeams[currentTeam].GetComponent<InfoAboutTeams>().CountLand = countLand;
            _currentFlag.TeamOwned = currentTeam;
            _currentFlag.IsEmpty = false;
            GameControll.Instance._infoAboutTeams[currentTeam].GetComponent<InfoAboutTeams>().OwnedLend.text = GameControll.Instance._infoAboutTeams[currentTeam].GetComponent<InfoAboutTeams>().CountLand.ToString();

        }
       else
        {
            if (GameControll.Instance._infoAboutTeams[_currentFlag.TeamOwned].GetComponent<InfoAboutTeams>().CountLand > 0 & (_currentFlag.TeamOwned != currentTeam))
            {
                Debug.Log("team own");
                int countL = GameControll.Instance._infoAboutTeams[_currentFlag.TeamOwned].GetComponent<InfoAboutTeams>().CountLand - 1;
                GameControll.Instance._infoAboutTeams[_currentFlag.TeamOwned].GetComponent<InfoAboutTeams>().CountLand = countL;

                GameControll.Instance._infoAboutTeams[_currentFlag.TeamOwned].GetComponent<InfoAboutTeams>().OwnedLend.text = GameControll.Instance._infoAboutTeams[_currentFlag.TeamOwned].GetComponent<InfoAboutTeams>().CountLand.ToString();

                _currentFlag.TeamOwned = currentTeam;
                int countLand = GameControll.Instance._infoAboutTeams[currentTeam].GetComponent<InfoAboutTeams>().CountLand + 1;
                GameControll.Instance._infoAboutTeams[currentTeam].GetComponent<InfoAboutTeams>().CountLand = countLand;
                GameControll.Instance._infoAboutTeams[currentTeam].GetComponent<InfoAboutTeams>().OwnedLend.text = GameControll.Instance._infoAboutTeams[currentTeam].GetComponent<InfoAboutTeams>().CountLand.ToString();
                _currentFlag.IsEmpty = false;
            }
        }
    }

    public void MoveGOTeamForward(int numberTeam, int count)
    {
        Vector3[] path = new Vector3[] { };
        float alpha = 0;
        
        switch (numberTeam+1)
        {
            case 1:
                currentPositionTeam = TeamOneCount;
                alpha = alphaF;
                path = pathTeamOne;
                break;
            case 2:
                path = pathTeamTwo;
                alpha = alphaS;
                currentPositionTeam = TeamSecondCount;
                break;
            case 3:
                path = pathTeamThree;
                alpha = alphaTh;
                currentPositionTeam = TeamThirdCount;
                break;
            case 4:
                path = pathTeamFour;
                alpha = alphaFou;
                currentPositionTeam = TeamFourCount;
                break;
            case 5:
                path = pathTeamFive;
                alpha = alphaFive;
                currentPositionTeam = TeamFiveCount;
                break;
        }

        NewMoveTeam(count, true, numberTeam, path);






        /*
        for (int j = 1; j <= i; j++)
        {
           
            if (currentPositionTeam <= path.Length - 2)
            {
                currentPositionTeam++;
                iTween.MoveTo(Teams[numberTeam], path[currentPositionTeam], 1f);
               // iTween.PutOnPath(Teams[numberTeam], path, percent*currentPositionTeam + alpha);


            }
            else
            {
                currentPositionTeam = 0;
                alpha = 0f;
                iTween.MoveTo(Teams[numberTeam], path[currentPositionTeam], 1f);
                //iTween.PutOnPath(Teams[numberTeam], path, percent * currentPositionTeam + alpha);

            }
            alpha += 0.0015f;

        }
        Debug.Log("First"+ currentPositionTeam);
        */

        switch (numberTeam + 1)
        {
            case 1:
                TeamOneCount= currentPositionTeam;
                alphaF = alpha;
                break;
            case 2:
                TeamSecondCount = currentPositionTeam;
                alphaS = alpha;
                break;
            case 3:
                TeamThirdCount = currentPositionTeam;
                alphaTh = alpha;
                break;
            case 4:
                TeamFourCount = currentPositionTeam;
                alphaFou = alpha;
                break;
            case 5:
                TeamFiveCount = currentPositionTeam;
                alphaFive = alpha;
                break;
        }

    }

    public void NewMoveTeam(int moveCount, bool isForward, int numberTeam, Vector3[] path)
    {
        //int moveCount = count;
        int targetPosition = currentPositionTeam + moveCount;
        Debug.Log(moveCount);

        List<int> movePath = new List<int>();
        //movePath.Add(currentPositionTeam);

        if (isForward)
        {
            targetPosition = currentPositionTeam + moveCount;
            Debug.Log(moveCount);
            movePath.Add(currentPositionTeam);

            for (int i = currentPositionTeam; i < targetPosition;)
            {
                i++;

                if (i == 20)
                    i = 0;

                if (i % 5 == 0)
                {
                    movePath.Add(i);
                }

                //Adding last pos
                if (i == targetPosition && (i % 5 != 0))
                {
                    movePath.Add(i);
                }
            }
        }
        else
        {
            targetPosition = currentPositionTeam - moveCount;
            Debug.Log(moveCount);
            movePath.Add(currentPositionTeam);

            for (int i = currentPositionTeam; i > targetPosition;)
            {
                i--;

                if (i < 0)
                {
                    if ((20 - i) % 5 == 0)
                    {
                        movePath.Add((20 - i));
                    }

                    //Adding last pos
                    if ((20 - i) == targetPosition && ((20 - i) % 5 != 0))
                    {
                        movePath.Add((20 - i));
                    }
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        movePath.Add(i);
                    }

                    //Adding last pos
                    if (i == targetPosition && (i % 5 != 0))
                    {
                        movePath.Add(i);
                    }

                }
            }

        }




        foreach (var move in movePath)
        {
            Debug.Log("Move Path: " + move);
        }


        float transitionCoefficient = 0.5f;
        float transitionTime = 0f;
        float previousTransitionTime = 0f;

        for (int i = 1; i < movePath.Count; i++)
        {
            if(isForward)
                transitionTime = (movePath[i] - movePath[i - 1]) * transitionCoefficient;
            else
                transitionTime = (movePath[i - 1] - movePath[i]) * transitionCoefficient;

        iTween.MoveTo(Teams[numberTeam], iTween.Hash("position", path[movePath[i]], "time", transitionTime,
                "delay", previousTransitionTime));

            previousTransitionTime += transitionTime;
        }

        currentPositionTeam = targetPosition;
    }


    public void MoveGOTeamBack(int numberTeam, int count)
    {
        Vector3[] path = new Vector3[] { };
        float alpha = 0;

        switch (numberTeam + 1)
        {
            case 1:
                currentPositionTeam = TeamOneCount;
                alpha = alphaF;
                path = pathTeamOne;
                break;
            case 2:
                path = pathTeamTwo;
                alpha = alphaS;
                currentPositionTeam = TeamSecondCount;
                break;
            case 3:
                path = pathTeamThree;
                alpha = alphaTh;
                currentPositionTeam = TeamThirdCount;
                break;
            case 4:
                path = pathTeamFour;
                alpha = alphaFou;
                currentPositionTeam = TeamFourCount;
                break;
            case 5:
                path = pathTeamFive;
                alpha = alphaFive;
                currentPositionTeam = TeamFiveCount;
                break;
        }

        NewMoveTeam(count, false, numberTeam, path);

        //int i = count;
        //Debug.Log(i);
        //for (int j = 1; j <= i; j++)
        //{
        //    if (currentPositionTeam >= 1)
        //    {
        //        currentPositionTeam--;
        //        iTween.MoveTo(Teams[numberTeam], path[currentPositionTeam], 1f);
        //       // iTween.PutOnPath(Teams[numberTeam], path, percent * currentPositionTeam + alpha);

        //    }
        //    if (currentPositionTeam < 1)
        //    {
        //        currentPositionTeam = 0;
        //        alpha = 0;
        //    }
        //    alpha += 0.0015f;
        //}
        //Debug.Log("Second"+ currentPositionTeam);

        switch (numberTeam + 1)
        {
            case 1:
                TeamOneCount = currentPositionTeam;
                alphaF = alpha;
                break;
            case 2:
                TeamSecondCount = currentPositionTeam;
                alphaS = alpha;
                break;
            case 3:
                TeamThirdCount = currentPositionTeam;
                alphaTh = alpha;
                break;
            case 4:
                TeamFourCount = currentPositionTeam;
                alphaFou = alpha;
                break;
            case 5:
                TeamFiveCount = currentPositionTeam;
                alphaFive = alpha;
                break;
        }

    }


    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        //iTween.PutOnPath(TeamOne, pathTeamOne, 1f);
        
    }
}
