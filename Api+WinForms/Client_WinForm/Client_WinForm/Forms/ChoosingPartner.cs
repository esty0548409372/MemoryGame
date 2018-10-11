using Client_WinForm.Forms;
using Client_WinForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace Client_WinForm
{
    public partial class ChoosingPartner : Form
    {
        List<User> usersList;

        public ChoosingPartner()
        {
            InitializeComponent();
        }

        public void FillDataGrid()
        {
          usersList= GetAllUsers();
          dataGridViwe_UsersList.DataSource = usersList.Select(c => new { c.UserName, c.Age }).ToList();
        }

        public dynamic GetAllUsers()
        {
            List<User> users;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Global.path);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($@"User/GetAllUsers/{Global.CurrentUser.UserName}").Result;
            if (response.IsSuccessStatusCode)
            {
                var usersJson = response.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<User>>(usersJson).ToList();
                return users;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
            
        }

        private void choosePartnerBTN_Click(object sender, EventArgs e)
        {
            var chosenPartnerId = dataGridViwe_UsersList.CurrentCell.RowIndex;
            string chosenPartnerName = usersList[chosenPartnerId].UserName;
            dynamic credential;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.path + "User/UpdatePartnersDetails");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                credential = new { userName=Global.CurrentUser.UserName, partnerUserName=chosenPartnerName };
                string credentialString = Newtonsoft.Json.JsonConvert.SerializeObject(credential, Formatting.None);
                streamWriter.Write(credentialString);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream(), ASCIIEncoding.ASCII))
            {
                string result = streamReader.ReadToEnd();
                if (result.Contains("ok"))
                {
                    Global.CurrentUser.PartnerUserName = chosenPartnerName;
                    HavingPartner havingPartner = new HavingPartner();
                    havingPartner.Partner = usersList[chosenPartnerId];
                    checkUserDetailsTMR.Enabled = false;
                    UpdatePartners.Enabled = false;
                    havingPartner.Show();
                }
                else MessageBox.Show(result);
            }


        }
        void HavePartner()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Global.path);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"User/GetCurrentUser/{Global.CurrentUser.UserName}").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                dynamic user = JsonConvert.DeserializeObject(result);
                if (user["PartnerUserName"] != null)
                {
                    Global.CurrentUser.PartnerUserName = user["PartnerUserName"];
                    checkUserDetailsTMR.Enabled = false;
                    UpdatePartners.Enabled = false;
                    Global.CurrentGame = new Game();
                    Global.CurrentGame.Show();
                }
            }
        }



        private void checkUserDetailsTMR_Tick(object sender, EventArgs e)
        {
            HavePartner();
        }

        private void UpdatePartners_Tick(object sender, EventArgs e)
        {
            FillDataGrid();
        }
    }
}
