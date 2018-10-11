using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_WinForm.Models
{
   public class User
    {
        public string UserName { get; set; }
        public int Age { get; set; }
        public string PartnerUserName { get; set; }
        [DefaultValue(0)]
        public int Score { get; set; }
    }
}
