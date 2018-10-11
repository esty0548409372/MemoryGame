using Server_Wep_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Server_Wep_api.Controllers
{
    public class UserController : ApiController
    {

        //SignIn - sign in to a new game
        //If the user is valid - adding him to the UserList, and return true. Else - return a matching error
        [HttpPost]
        [Route("api/User/SignIn")]
        public HttpResponseMessage SignIn([FromBody]User newUser)
        {

            try
            {
                lock (Global.UsersList)
                {
                    Global.UsersList.Add(newUser);
                }

            }
            catch (HttpRequestValidationException)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "BadRequest");
            }

            return Request.CreateResponse(HttpStatusCode.OK, true);
        }

        //GetAllUsers - get the list of the other users that looks for a partner to the game.
        [HttpGet]
        [Route("api/User/GetAllUsers/{UserName}")]
        public List<User> GetAllUsers([FromUri]string UserName)
        {
            List<User> listUser = Global.UsersList.Where(p => p.PartnerUserName == null && p.UserName != UserName).ToList();
            return listUser;
        }

        //GetCurrentUser - get the details of the current user.
        [HttpGet]
        [Route("api/User/GetCurrentUser/{UserName}")]
        public User GetCurrentUser([FromUri]string userName)
        {
            return Global.UsersList.FirstOrDefault(p => p.UserName == userName);
        }

        //UpdatePartnersDetails - The client sends a userName that he choosed to a partner.
        //The server will update his details to the chosen partner.
        //And the PartnerUserName property of chosen partner, to his name.
        //If the update completed succefuly - return "ok"
        //Else - return a matching error.
        [HttpPut]
        [Route("api/User/UpdatePartnersDetails")]
        public HttpResponseMessage UpdatePartnersDetails([FromBody]dynamic partners)
        {
            User currentPlayer = Global.UsersList.FirstOrDefault(p => p.UserName == partners["userName"].ToString());
            User partnerPlayer = Global.UsersList.FirstOrDefault(p => p.UserName == partners["partnerUserName"].ToString());
            try
            {
                lock (Global.UsersList)
                {
                    currentPlayer.PartnerUserName = partnerPlayer.UserName;
                    partnerPlayer.PartnerUserName = currentPlayer.UserName;
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "BadRequest");
            }
            Game newGame = new Game() { };
            newGame.Player1 = currentPlayer;
            newGame.Player2 = partnerPlayer;
            newGame.CurrentTurn = currentPlayer.UserName;
            Random rnd = new Random();
            const string chars = "123456789";
            try
            {
                lock (Global.GamesList)
                {
                    newGame.CardArray = new Dictionary<string, string>();
                    for (int i = 0; i < 9; i++)
                    {
                        //char c = chars[rnd.Next(chars.Length)];
                        newGame.CardArray.Add(chars[i].ToString(), null);
                        //chars.Split()
                    }
                    Global.GamesList.Add(newGame);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "BadRequest");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "ok");
        }

        //createNewGame - craete a new Game object with the 2 users as players, and the current userName as the CurrentTurn.
        //add the new game to the GamesList.
        //If the creating completed succefuly - return ok"
        //Else - return a matching error.
       
    }
}