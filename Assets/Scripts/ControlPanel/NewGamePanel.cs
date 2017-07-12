using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Server;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ControlPanel
{
    public class NewGamePanel : MonoBehaviour
    {
        public List<GameObject> Teams;
        public InputField StartCoinsInputField;

        private int _teamsCount;
        private PanelController _panelController;

        private void Start()
        {
            _teamsCount = 2;
            _panelController = FindObjectOfType<PanelController>();
        }

        public void AddTeam()
        {
            if (_teamsCount >= 5) return;

            _teamsCount++;
            var team = Teams[_teamsCount - 1];
            team.SetActive(true);
        }

        public void RemoveTeam()
        {
            if (_teamsCount <= 2) return;

            var team = Teams[_teamsCount - 1];
            team.transform.GetChild(0).GetComponent<InputField>().text = "";
            team.SetActive(false);
            _teamsCount--;
        }

        public void StartNewGame()
        {
            var data = new Data();
            var teamNames = new List<string>();
            for (int i = 0; i < _teamsCount; i++)
            {
                string teamName = Teams[i].transform.GetChild(0).GetComponent<InputField>().text;
                if (string.IsNullOrEmpty(teamName))
                {
                    teamName = "Team " + (i+1).ToString();
                }
                teamNames.Add(teamName);
            }
            string startCoinsText = StartCoinsInputField.text;
            byte startCoins = string.IsNullOrEmpty(startCoinsText) ? (byte) 0 : Convert.ToByte(startCoinsText);
            _panelController.NewGame("Test", startCoins, teamNames);
        }
    }
}
