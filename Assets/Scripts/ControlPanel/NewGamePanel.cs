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
        public InputField GameNameInputField;
        public GameObject BlockPanel;
        public GameObject CloseButton;

        private int _teamsCount;
        private PanelController _panelController;
        private List<InputField> _teamNameInputFields;

        private void Start()
        {
            _teamsCount = 2;
            _panelController = FindObjectOfType<PanelController>();
            _teamNameInputFields = new List<InputField>();
            Teams.ForEach(x => _teamNameInputFields.Add(x.transform.GetChild(0).GetComponent<InputField>()));
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
                    teamName = _teamNameInputFields[i].placeholder.gameObject.GetComponent<Text>().text;
                }
                teamNames.Add(teamName);
            }

            string gameName = GameNameInputField.text;
            if (string.IsNullOrEmpty(gameName))
            {
                gameName = GameNameInputField.placeholder.gameObject.GetComponent<Text>().text;
            }
            _panelController.NewGame(gameName, teamNames);
        }

        public void ShowPanelCustom()
        {
            _teamNameInputFields.ForEach(x => x.text = "");
            for (int i = 2; i < 5; i++)
            {
                Teams[i].SetActive(false);
            }
            _teamsCount = 2;

            GameNameInputField.text = "";
            CloseButton.SetActive(true);
            BlockPanel.SetActive(true);
            gameObject.SetActive(true);
        }

        public void HideCustom()
        {
            BlockPanel.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
