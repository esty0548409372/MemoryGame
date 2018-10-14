using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Client_WinForm.Models;
using Newtonsoft.Json;

namespace Client_WinForm
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
            signInBTN.Enabled = false;
        }
        public void checkValidName(object sender, EventArgs e)
        {
            if (nameTXT.Text.Length < 2 || nameTXT.Text.Length > 10)
            {
                errorProvider1.SetError(nameTXT, "name must be between 2-10 chars");
            }
            else
            {
                errorProvider1.Clear();
                if (ageTXT.Text != "" && (Convert.ToInt32(ageTXT.Text) >= 18 || Convert.ToInt32(ageTXT.Text) <= 120))
                    signInBTN.Enabled = true;

            }
        }
        public void checkValidAge(object sender, EventArgs e)
        {
            int parsedValue;
            if (ageTXT.Text != "")
            {
                if (!int.TryParse(ageTXT.Text, out parsedValue))
                {
                    MessageBox.Show("This is a number only field");
                    ageTXT.Text = "";
                }
                else if (Convert.ToInt32(ageTXT.Text) < 18 || Convert.ToInt32(ageTXT.Text) > 120)
                {
                    errorProvider1.SetError(ageTXT, "age must be between 18-120");
                    ageTXT.Text = "";
                }
            }
            else
            {
                errorProvider1.Clear();
                if (nameTXT.Text.Length >= 2 || nameTXT.Text.Length <= 10)
                    signInBTN.Enabled = true;
            }
        }

        private void signInBTN_Click(object sender, EventArgs e)
        {
            dynamic credential;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.path + "User/SignIn");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                credential = new User { UserName = nameTXT.Text, Age = int.Parse(ageTXT.Text) };
                string credentialString = Newtonsoft.Json.JsonConvert.SerializeObject(credential, Formatting.None);
                streamWriter.Write(credentialString);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream(), ASCIIEncoding.ASCII))
            {
                string result = streamReader.ReadToEnd();
                if (result.Contains("true"))
                {
                    ChoosingPartner choosePartner = new ChoosingPartner();
                    Global.CurrentUser = credential;
                    choosePartner.Show();
                }
                else if (result.Contains("false"))
                {
                    MessageBox.Show("An existing user name on the system");
                    ageTXT.Text = "";
                    nameTXT.Text = "";
                    signInBTN.Enabled = false;
                }
                else MessageBox.Show(result);
            }
        }
    }
}
