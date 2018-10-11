using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server_Wep_api.Models
{
    public static class Global
    {
        public static List<User> UsersList = new List<User>();
        public static List<Game> GamesList = new List<Game>();
    }
}