
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server_Wep_api.Models
{
    public class Game
    {
        public User Player1 { get; set; }
        public User Player2 { get; set; }
        public string CurrentTurn { get; set; }
        public Dictionary<string, string> CardArray { get; set; }
    }
}