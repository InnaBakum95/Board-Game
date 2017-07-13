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
        private List<InputField> _teamNameInputFields;

        private void Start()
        {
            _teamsCount = 2;
            _panelController = FindObjectOfType<PanelController>();
            _teamNameInputFields = new List<InputField>();
            Teams.ForEach(x => _teamNameInputFields.Add(x.transform.GetChild(0).GetComponent<InputField>()));
            gameObject.SetActive(false);
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
                string teamName = _teamNameInputFields[i].text;
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

        public void ShowPanelCustom()
        {
            _teamNameInputFields.ForEach(x => x.text = "");
            StartCoinsInputField.text = 15.ToString();
            for (int i = 2; i < 5; i++)
            {
                Teams[i].SetActive(false);
            }
            _teamsCount = 2;
            gameObject.SetActive(true);
        }
    }
}
