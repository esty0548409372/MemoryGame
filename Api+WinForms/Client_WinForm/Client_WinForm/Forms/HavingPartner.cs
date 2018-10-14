using Client_WinForm.Models;
using System;
using System.Windows.Forms;

namespace Client_WinForm.Forms
{
    public partial class HavingPartner : Form
    {
        public User Partner { get; set; }
        public HavingPartner()
        {
            InitializeComponent();

        }

        private void HavingPartner_Load(object sender, EventArgs e)
        {
            partnerNameValLBL.Text = Partner.UserName;
            partnerAgeValLBL.Text = Partner.Age.ToString();
        }

        private void startGameBTN_Click(object sender, EventArgs e)
        {
            Global.CurrentGame = new Game();
            Global.CurrentGame.Show();
        }
    }
}
