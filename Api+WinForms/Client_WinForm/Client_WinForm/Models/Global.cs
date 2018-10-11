using Client_WinForm.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_WinForm.Models
{
    class Global
    {
        public static string path = "http://localhost:62999/api/";
        public static User CurrentUser = new User();
        public static Game CurrentGame { get; set; }
    }
}
