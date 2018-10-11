using Client_WinForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace Client_WinForm.Forms
{
    public partial class Game : Form
    {
        public Dictionary<string, string> CardsList;
        string currentTurn;
        string clickedBtnTxt;

        public Game()
        {
            InitializeComponent();
            userNameLBL.Text = Global.CurrentUser.UserName;
        }

        public void NewTurn()
        {
            label1.Text = Global.CurrentUser.Score.ToString();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Global.path);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($@"Game/GetAllCards/{Global.CurrentUser.UserName}").Result;
            if (response.IsSuccessStatusCode)
            {
                string cardsString = response.Content.ReadAsStringAsync().Result;
                dynamic obj = JsonConvert.DeserializeObject(cardsString);
                currentTurn = obj["currentTurn"].ToString();
                var cards = obj["cardsList"];
                currentTurnLBL.Text = currentTurn;
                if (Global.CurrentUser.UserName == currentTurn)
                {
                    foreach (Button btn in cardsGroupBox.Controls)
                    {
                        btn.Enabled = true;
                    }
                    getAllCardsTMR.Enabled = false;
                    clickedBtnTxt = null;
                }
                else
                {
                    foreach (Button btn in cardsGroupBox.Controls)
                    {
                        btn.Enabled = false;
                    }
                    getAllCardsTMR.Enabled = true;
                }
                UpdateCards(cards);
            }
            else
            {
                MessageBox.Show(response.StatusCode.ToString());
            }
        }

        private void UpdateCards(dynamic cards)
        {
            CardsList = new Dictionary<string, string>();
            foreach (var item in cards)
            {
                CardsList.Add(item.Name, item.Value.Value);
            }
            int index = 0;
            int countCatchPairs = 0 ;
            foreach (var item in CardsList)
            {
                for (int i = 0; i < 2; i++)
                {

                    ((Button)cardsGroupBox.Controls[index]).Name = item.Key;
                    ((Button)cardsGroupBox.Controls[index]).Text = item.Value == null ? "?" : item.Key;
                    if (item.Value != null)
                    {
                        ((Button)cardsGroupBox.Controls[index]).Enabled = false;
                    }
                    index++;
                }
                if (item.Value != null)
                    countCatchPairs++;
            }
            if (countCatchPairs == 9)
                GameOver();
        }

        public void GameOver()
        {
            if(Global.CurrentUser.Score>4)
            {
                MessageBox.Show("You are the winner (: !!!!!  your score is:"+Global.CurrentUser.Score.ToString());
            }
            else MessageBox.Show("Your partner is the winner ):  your score is:" + Global.CurrentUser.Score.ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NewTurn();
        }

        private void card_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = (sender as Button).Name;
            (sender as Button).Enabled = false;
            if (clickedBtnTxt == null)
            {
                clickedBtnTxt = (sender as Button).Name;
            }
            else
            {
                dynamic credential;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.path + "Game/updateCurrentDetails");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    credential = new { currentTurn, card1 = clickedBtnTxt, card2 = (sender as Button).Name };
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
                        if (clickedBtnTxt == (sender as Button).Name)
                        {
                            Global.CurrentUser.Score++;
                            label1.Text = Global.CurrentUser.Score.ToString();
                            MessageBox.Show("TRUE!!!!");
                            CardsList[clickedBtnTxt] = Global.CurrentUser.UserName;
                            Global.CurrentUser.Score++;
                            getAllCardsTMR.Enabled = true;
                        }
                    }
                    else MessageBox.Show(result);
                }
            }
        }
    }
}
