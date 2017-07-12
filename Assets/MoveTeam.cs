﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class MoveTeam : MonoBehaviour {
    
    public List<GameObject> Teams = new List<GameObject>();
    public List<Flag> FlagsList = new List<Flag>();

    public Color Red;
    public Color Yellow;
    public Color Green;
    public Color Blue;
    public Color Purple;

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

    private int currentPositionTeam = 0;


    // Use this for initialization

    private void OnDrawGizmos()
    {
        iTween.DrawLineGizmos(pathTeamOne);
        iTween.DrawLineGizmos(pathTeamTwo);
        iTween.DrawLineGizmos(pathTeamThree);
        iTween.DrawLineGizmos(pathTeamFour);
        iTween.DrawLineGizmos(pathTeamFive);
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

        Flag _currentFlag = FlagsList.Find(x => x.NumberColumnOfFlag == currentPositionTeam-1);
        _currentFlag.gameObject.GetComponent<SpriteRenderer>().color = currentColor;
    }

    public void MoveGOTeamForward(int numberTeam)
    {
        Vector3[] path = new Vector3[] { };
        
        switch (numberTeam+1)
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
        


        int i; 
        bool tryParse= int.TryParse(inputField.text, out i);
        Debug.Log(i);
        for (int j = 1; j <= i; j++)
        {
            if (currentPositionTeam <= path.Length - 2)
            {
                currentPositionTeam++;
                iTween.MoveTo(Teams[numberTeam], path[currentPositionTeam], 1f);

                
            }
            else
            {
                currentPositionTeam = 0;
                iTween.MoveTo(Teams[numberTeam], path[currentPositionTeam], 1f);
                
            }
        }
        Debug.Log("First"+ currentPositionTeam);


        switch (numberTeam + 1)
        {
            case 1:
                TeamOneCount= currentPositionTeam;
                break;
            case 2:
                TeamSecondCount = currentPositionTeam;
                break;
            case 3:
                TeamThirdCount = currentPositionTeam;
                break;
            case 4:
                TeamFourCount = currentPositionTeam;
                break;
            case 5:
                TeamFiveCount = currentPositionTeam;
                break;
        }

    }

    public void MoveGOTeamBack(int numberTeam)
    {
        Vector3[] path = new Vector3[] { };
        switch (numberTeam + 1)
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
        int i;
        bool tryParse = int.TryParse(inputField.text, out i);
        Debug.Log(i);
        for (int j = 1; j <= i; j++)
        {
            if (currentPositionTeam >= 1)
            {
                currentPositionTeam--;
                iTween.MoveTo(Teams[numberTeam], path[currentPositionTeam], 1f);

            }
            if (currentPositionTeam < 1)
            {
                currentPositionTeam = 0;
            }
        }
        Debug.Log("Second"+ currentPositionTeam);

        switch (numberTeam + 1)
        {
            case 1:
                TeamOneCount = currentPositionTeam;
                break;
            case 2:
                TeamSecondCount = currentPositionTeam;
                break;
            case 3:
                TeamThirdCount = currentPositionTeam;
                break;
            case 4:
                TeamFourCount = currentPositionTeam;
                break;
            case 5:
                TeamFiveCount = currentPositionTeam;
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
