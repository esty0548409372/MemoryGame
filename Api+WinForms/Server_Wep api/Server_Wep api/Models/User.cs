using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Server_Wep_api.Models
{
    public class User
    {  
        [Required(ErrorMessage = "UserName is required")] // Required Field
        [MinLength(2)]   //Minimum Length of Name should be 2
        [MaxLength(10)]  //Maximum Length of Name should be 10
        public string UserName { get; set; }

        [Required(ErrorMessage = "Age is required")] // Required Field
        [Range(18, 120, ErrorMessage = "Age should be between 18 and 120")]
        public int Age { get; set; }

        public string PartnerUserName { get; set; }

        [DefaultValue(0)]
        public int Score { get; set; }
    }
}