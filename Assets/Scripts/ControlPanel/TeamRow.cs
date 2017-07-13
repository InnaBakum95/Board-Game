using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.ControlPanel;
using UnityEngine;
using UnityEngine.UI;

public class TeamRow : MonoBehaviour
{

    public Text TeamNameText;
    public Text CurrentLocationText;

    public InputField MoveStepsInputField;

    private int _teamNumber;
    private int _currentLocation;

    private PanelController _panelController;

	private void Start ()
	{
	    _panelController = FindObjectOfType<PanelController>();
	}

    public void SetTeamInfo(int teamNumber, string teamName)
    {
        _teamNumber = teamNumber;
        TeamNameText.text = teamName;
        SetHomeLocation();
    }

    public void Move(bool isForward)
    {
        string stepsText = MoveStepsInputField.text;
        if (string.IsNullOrEmpty(stepsText)) return;
        byte steps = Convert.ToByte(stepsText);
        byte team = Convert.ToByte(_teamNumber);
        _panelController.Move(team, steps, isForward);
    }

    public void SetCurrentLocation(byte steps, bool moveForward)
    {
        int addSteps = steps;
        if (!moveForward)
        {
            addSteps = -addSteps;
        }
        int newLocation = _currentLocation + addSteps;

        #region DontSeeThisIfes :D
        
        if (newLocation > 100)
        {
            newLocation -= 100;
        }
        else if (newLocation > 80)
        {
            newLocation -= 80;
        }
        else if (newLocation > 60)
        {
            newLocation -= 60;
        }
        else if (newLocation > 40)
        {
            newLocation -= 40;
        }
        else if (newLocation > 20)
        {
            newLocation -= 20;
        }
        else if (newLocation <= -80)
        {
            newLocation += 100;
        }
        else if (newLocation <= -60)
        {
            newLocation += 80;
        }
        else if (newLocation <= -40)
        {
            newLocation += 60;
        }
        else if (newLocation <= -20)
        {
            newLocation += 40;
        }
        else if (newLocation <= 0)
        {
            newLocation += 20;
        }

        #endregion

        SetLocation(newLocation);
    }

    private void SetLocation(int location)
    {
        _currentLocation = location;
        CurrentLocationText.text = location.ToString();
    }

    public void SetHomeLocation()
    {
        SetLocation(1);
    }

    public void MoveToHome()
    {
        byte team = Convert.ToByte(_teamNumber);
        _panelController.MoveToHome(team);
    }

    public void SendAnswerResult(bool isCorrect)
    {
        byte team = Convert.ToByte(_teamNumber);
        _panelController.SendAnswerResult(team, isCorrect);
    }
    public void OwnTheLand()
    {
        byte team = Convert.ToByte(_teamNumber);
        _panelController.OwnTheLand(team);
    }
}
