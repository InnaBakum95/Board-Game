using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTeam : MonoBehaviour {

    //new Vector3[] pathTeamOne = new Vector3[] { new Vector3(14.89f, -14.89f,0), new Vector3(8.83f, -14.89f, 0), new Vector3(2.96f, -14.89f, 0), new Vector3(-2.89f, -14.89f, 0), new Vector3(-8.72f, -14.89f, 0), new Vector3(-14.6f, -14.89f, 0), new Vector3(-14.6f, -8.82f, 0), new Vector3(-14.6f, -2.9f, 0), new Vector3(-14.6f, 2.98f, 0), new Vector3(-14.6f, 8.71f, 0), new Vector3(-14.6f, 14.73f, 0), new Vector3(-8.63f, 14.73f, 0), new Vector3(-2.7f, 14.73f, 0), new Vector3(3.03f, 14.73f, 0), new Vector3(8.86f, 14.73f, 0), new Vector3(14.69f, 14.73f, 0), new Vector3(14.69f, 8.76f, 0), new Vector3(14.69f, 2.88f, 0), new Vector3(14.69f, -3f, 0), new Vector3(14.69f, -8.82f, 0), new Vector3(14.69f, -14.89f, 0) };
    //new Vector3[] pathTeamTwo = new Vector3[] { new Vector3(14.89f,-16.87f,0), new Vector3(8.83f, -16.87f, 0), new Vector3(2.96f, -16.87f, 0), new Vector3(-2.89f, -16.87f, 0), new Vector3(-8.72f, -16.87f, 0), new Vector3(-14.6f, -16.87f, 0), new Vector3(-14.6f, -10.8f, 0), new Vector3(-14.6f, -4.88f, 0), new Vector3(-14.6f, 1f, 0), new Vector3(-14.6f, 6.73f, 0), new Vector3(-14.6f, 12.75f, 0), new Vector3(-8.63f, 12.75f, 0), new Vector3(-2.7f, 12.75f, 0), new Vector3(3.03f, 12.75f, 0), new Vector3(8.86f, 12.75f, 0), new Vector3(14.69f, 12.75f, 0), new Vector3(14.69f, 6.78f, 0), new Vector3(14.69f, 0.9f, 0), new Vector3(14.69f, -4.98f, 0), new Vector3(14.69f, -10.8f, 0), new Vector3(14.89f, -16.87f, 0), };
    //new Vector3[] pathTeamThree = new Vector3[] { new Vector3(12.74f, -14.81f,0), new Vector3(6.68f, -14.81f, 0), new Vector3(0.81f, -14.81f, 0), new Vector3(-5.04f, -14.81f, 0), new Vector3(-10.87f, -14.81f, 0), new Vector3(-16.75f, -14.81f, 0), new Vector3(-16.75f, -8.74f, 0), new Vector3(-16.75f, -2.82f, 0), new Vector3(-16.75f, 3.06f, 0), new Vector3(-16.75f, 8.79f, 0), new Vector3(-16.75f, 14.81f, 0), new Vector3(-10.78f, 14.81f, 0), new Vector3(-4.85f, 14.81f, 0), new Vector3(0.88f, 14.81f, 0), new Vector3(6.71f, 14.81f, 0), new Vector3(12.54f, 14.81f, 0), new Vector3(12.54f, 8.84f, 0), new Vector3(12.54f, 2.96f, 0), new Vector3(12.54f, -2.92f, 0), new Vector3(12.54f, -8.74f, 0), new Vector3(12.74f, -14.81f, 0), };
    //new Vector3[] pathTeamFour = new Vector3[] { new Vector3(17.04f, -14.81f,0), new Vector3(10.98f, -14.81f, 0), new Vector3(5.11f, -14.81f, 0), new Vector3(-0.74f, -14.81f, 0), new Vector3(-6.57f, -14.81f, 0), new Vector3(-12.45f, -14.81f, 0), new Vector3(-12.45f, -8.74f, 0), new Vector3(-12.45f, -2.82f, 0), new Vector3(-12.45f, 3.06f, 0), new Vector3(-12.45f, 8.79f, 0), new Vector3(-12.45f, 14.81f, 0), new Vector3(-6.48f, 14.81f, 0), new Vector3(-0.55f, 14.81f, 0), new Vector3(5.18f, 14.81f, 0), new Vector3(11.01f, 14.81f, 0), new Vector3(16.84f, 14.81f, 0), new Vector3(16.84f, 8.84f, 0), new Vector3(16.84f, 2.96f, 0), new Vector3(16.84f, -2.92f, 0), new Vector3(16.84f, -8.74f, 0), new Vector3(17.04f, -14.81f, 0)};
    //new Vector3[] pathTeamFive = new Vector3[] { new Vector3(14.96f, -12.83f,0), new Vector3(8.9f, -12.83f,0), new Vector3(3.03f, -12.83f, 0), new Vector3(-2.82f, -12.83f, 0), new Vector3(-8.65f, -12.83f, 0), new Vector3(-14.53f, -12.83f, 0), new Vector3(-14.53f, -6.76f, 0), new Vector3(-14.53f, -0.84f, 0), new Vector3(-14.53f, 5.04f, 0), new Vector3(-14.53f, 10.77f, 0), new Vector3(-14.53f, 16.79f, 0), new Vector3(-8.56f, 16.79f, 0), new Vector3(-2.63f, 16.79f, 0), new Vector3(3.1f, 16.79f, 0), new Vector3(8.93f, 16.79f, 0), new Vector3(14.76f, 16.79f, 0), new Vector3(14.76f, 10.82f, 0), new Vector3(14.76f, 4.94f, 0), new Vector3(14.76f, -0.94f, 0), new Vector3(14.76f, -6.76f, 0), new Vector3(14.96f, -12.83f, 0)};

    public GameObject TeamOne;
    public GameObject TeamTwo;
    public GameObject TeamThree;
    public GameObject TeamFour;
    public GameObject TeamFive;
    public InputField inputField;
    new Vector3[] pathTeamOne = new Vector3[] { new Vector3(335.2465f, -3.003998f, 0), new Vector3(307.1f, -3.003998f, 0), new Vector3(278.6f, -3.003998f, 0), new Vector3(250.3f, -3.003998f, 0), new Vector3(222f, -3.003998f, 0), new Vector3(193.8f, -3.003998f, 0), new Vector3(193.8f, 25f, 0), new Vector3(193.8f, 53.5f, 0), new Vector3(193.8f, 82.2f, 0), new Vector3(193.8f, 110.9f, 0), new Vector3(193.8f, 139.1f, 0), new Vector3(222.3f, 139.1f, 0), new Vector3(251f, 139.1f, 0), new Vector3(279f, 139.1f, 0), new Vector3(307.5f, 139.1f, 0), new Vector3(335.5f, 139.1f, 0), new Vector3(335.5f, 110.4f, 0), new Vector3(335.5f, 82.2f, 0), new Vector3(335.5f, 54.5f, 0), new Vector3(335.5f, 25.5f, 0) };//, new Vector3(335.2465f, -3.003998f, 0) };
    new Vector3[] pathTeamTwo = new Vector3[] { new Vector3(335.2465f, -12.607f, 0), new Vector3(307.1f, -12.607f, 0), new Vector3(278.6f, -12.607f, 0), new Vector3(250.3f, -12.607f, 0), new Vector3(222f, -12.607f, 0), new Vector3(193.8f, -12.607f, 0), new Vector3(193.8f, 15.4f, 0), new Vector3(193.8f, 43.9f, 0), new Vector3(193.8f, 72.6f, 0), new Vector3(193.8f, 101.3f, 0), new Vector3(193.8f, 129.5f, 0), new Vector3(222.3f, 129.5f, 0), new Vector3(251f, 129.5f, 0), new Vector3(279f, 129.5f, 0), new Vector3(307.5f, 129.5f, 0), new Vector3(335.5f, 129.5f, 0), new Vector3(335.5f, 100.8f, 0), new Vector3(335.5f, 72.6f, 0), new Vector3(335.5f, 44.9f, 0), new Vector3(335.5f, 15.9f, 0) };//, new Vector3(335.2465f, -12.607f, 0)};
    new Vector3[] pathTeamThree = new Vector3[]{ new Vector3(335.2465f, -2.615997f, 0), new Vector3(296.7f, -2.615997f, 0), new Vector3(268.2f, -2.615997f, 0), new Vector3(239.9f, -2.615997f, 0), new Vector3(211.6f, -2.615997f, 0), new Vector3(182.8f, -2.615997f, 0), new Vector3(182.8f, 25.4f, 0), new Vector3(182.8f, 53.9f, 0), new Vector3(182.8f, 82.6f, 0), new Vector3(182.8f, 111.3f, 0), new Vector3(182.8f, 139.5f, 0), new Vector3(211.3f, 139.5f, 0), new Vector3(240f, 139.5f, 0), new Vector3(268f, 139.5f, 0), new Vector3(296.5f, 139.5f, 0), new Vector3(324.5f, 139.5f, 0), new Vector3(324.5f, 110.8f, 0), new Vector3(324.5f, 82.6f, 0), new Vector3(324.5f, 54.9f, 0), new Vector3(324.5f, 25.9f, 0) };//,new Vector3(335.2465f, -2.615997f, 0) };
    new Vector3[] pathTeamFour = new Vector3[]{ new Vector3(345.674f, -2.615997f, 0), new Vector3(317.5f, -2.615997f, 0), new Vector3(289f, -2.615997f, 0), new Vector3(260.7f, -2.615997f, 0), new Vector3(232.4f, -2.615997f, 0), new Vector3(203.8f, -2.615997f, 0), new Vector3(203.8f, 25.4f, 0), new Vector3(203.8f, 53.9f, 0), new Vector3(203.8f, 82.6f, 0), new Vector3(203.8f, 111.3f, 0), new Vector3(203.8f, 139.5f, 0), new Vector3(232.3f, 139.5f, 0), new Vector3(261f, 139.5f, 0), new Vector3(289f, 139.5f, 0), new Vector3(317.5f, 139.5f, 0), new Vector3(345.5f, 139.5f, 0), new Vector3(345.5f, 110.8f, 0), new Vector3(345.5f, 82.6f, 0), new Vector3(345.5f, 54.9f, 0), new Vector3(345.5f, 25.9f, 0) };//, new Vector3(345.674f, -2.615997f, 0) };
    new Vector3[] pathTeamFive = new Vector3[]{ new Vector3(335.586f, 6.987003f, 0), new Vector3(307.4f, 6.987003f, 0), new Vector3(278.9f, 6.987003f, 0), new Vector3(250.6f, 6.987003f, 0), new Vector3(222.3f, 6.987003f, 0), new Vector3(193.8f, 6.987003f, 0),new Vector3(193.8f, 35f, 0), new Vector3(193.8f, 63.5f, 0), new Vector3(193.8f, 92.2f, 0), new Vector3(193.8f, 120.9f, 0),new Vector3(193.8f, 149.1f, 0), new Vector3(222.3f, 149.1f, 0), new Vector3(251f, 149.1f, 0), new Vector3(279f, 149.1f, 0), new Vector3(307.5f, 149.1f, 0), new Vector3(335.5f, 149.1f, 0), new Vector3(335.5f, 120.4f, 0), new Vector3(335.5f, 92.2f, 0), new Vector3(335.5f, 64.5f, 0), new Vector3(335.5f, 35.5f, 0) };//, new Vector3(335.586f, 6.987003f, 0) };


    private int TeamOneCount = 0;
    private int TeamSecondCount = 1;
    private int TeamThirdCount = 1;
    private int TeamFourCount = 1;
    private int TeamFiveCount = 1;


    // Use this for initialization

    private void OnDrawGizmos()
    {
        iTween.DrawLineGizmos(pathTeamOne);
        iTween.DrawLineGizmos(pathTeamTwo);
        iTween.DrawLineGizmos(pathTeamThree);
        iTween.DrawLineGizmos(pathTeamFour);
        iTween.DrawLineGizmos(pathTeamFive);
    }

    public void MoveGOTeamForward(GameObject gO, int numberTeam)
    {
        Vector3[] path = new Vector3[] { };
        switch (numberTeam)
        {
            case 1:
                path = pathTeamOne;
                break;
            case 2:
                path = pathTeamTwo;
                break;
            case 3:
                path = pathTeamThree;
                break;
            case 4:
                path = pathTeamFour;
                break;
            case 5:
                path = pathTeamFive;
                break;
        }


        int i; 
        bool tryParse= int.TryParse(inputField.text, out i);
        for (int j = 1; j <= i; j++)
        {
            if (TeamOneCount <= path.Length - 2)
            {
                TeamOneCount++;
                iTween.MoveTo(gO, path[TeamOneCount], 1f);

                
            }
            else
            {
                TeamOneCount = 0;
                iTween.MoveTo(gO, path[TeamOneCount], 1f);
                
            }
        }
        Debug.Log("First"+TeamOneCount);
        
    }

    public void MoveGOTeamBack(GameObject gO, int numberTeam)
    {
        Vector3[] path = new Vector3[] { };
        switch (numberTeam)
        {
            case 1:
                path = pathTeamOne;
                break;
            case 2:
                path = pathTeamTwo;
                break;
            case 3:
                path = pathTeamThree;
                break;
            case 4:
                path = pathTeamFour;
                break;
            case 5:
                path = pathTeamFive;
                break;
        }
        int i;
        bool tryParse = int.TryParse(inputField.text, out i);
        for (int j = 1; j <= i; j++)
        {
            if (TeamOneCount >= 1)
            {
                TeamOneCount--;
                iTween.MoveTo(gO, path[TeamOneCount], 1f);

            }
            if (TeamOneCount < 1)
            {
                TeamOneCount = 0;
            }
        }
        Debug.Log("Second"+TeamOneCount);

    }


    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        //iTween.PutOnPath(TeamOne, pathTeamOne, 1f);
        
    }
}
