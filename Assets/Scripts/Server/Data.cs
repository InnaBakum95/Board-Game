using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Server
{
    [Serializable]
    public class Data
    {
        [SerializeField] public byte Code;
        [SerializeField] public byte TeamsCount;
        [SerializeField] public byte CurrentTeam;
        [SerializeField] public byte Steps;
        [SerializeField] public bool MoveForward;
        [SerializeField] public NewGameInfo NewGameInfo;

    }

    [Serializable]
    public class NewGameInfo
    {
        [SerializeField] public string GameName;
        [SerializeField] public List<string> TeamNames;
        [SerializeField] public int CoinsAmount;
    }

    
    //public class Team
    //{
    //    [SerializeField] public string Name;
    //    [SerializeField] public Color Color;
    //}
}