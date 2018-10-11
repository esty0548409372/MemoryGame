using Server_Wep_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server_Wep_api.Controllers
{
    public class GameController : ApiController
    {
        // GetAllCards - return all cards that are able to choose when the currentUser is exist. 
        //If there are no matching cards the game over end return matching message.
        //Else return the ableCardsList.
        [HttpGet]
        [Route("api/Game/GetAllCards/{userName}")]
        public HttpResponseMessage GetAllCards([FromUri]string userName)
        {
            Game currentGame;
            try
            {
                currentGame = Global.GamesList.FirstOrDefault(g => g.Player1.UserName == userName || g.Player2.UserName == userName);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "There is no game to this user");
            }

            return Request.CreateResponse(HttpStatusCode.OK, new { cardsList = currentGame.CardArray, currentTurn = currentGame.CurrentTurn });
        }

        public string GameOver(Game currentGame)
        {
            lock (Global.GamesList)
            {
                Global.GamesList.Remove(currentGame);
            }
            return "game over";
        }

        //updateCurrentDetails - The client sends a userName and the chosen cards results.The server will update the Game object CurrentTurn to the other player's name.
        //If the user managed to choose 2 cards with the same value - we will update the element in the CardArray that has the key of this card content - to the current user name.
        //After the update it will check if the game is over (all the element in the CardArray contains value), If yes - the winner user will get 1 point to the score property.
        [HttpPut]
        [Route("api/Game/updateCurrentDetails")]
        public HttpResponseMessage updateCurrentDetails([FromBody]dynamic turnDetails)
        {
            string currentTurn = turnDetails["currentTurn"];
            string card1 = turnDetails["card1"];
            string card2 = turnDetails["card2"];
            Game currentGame = Global.GamesList.FirstOrDefault(g => g.Player1.UserName == currentTurn || g.Player2.UserName == currentTurn);
            try
            {
                lock (currentGame)
                {
                    currentGame.CurrentTurn = currentGame.CurrentTurn == currentGame.Player1.UserName ? currentGame.Player2.UserName : currentGame.Player1.UserName;
                }
                if (card1 == card2)
                {
                    lock (Global.UsersList)
                    {
                        Global.UsersList.FirstOrDefault(u => u.UserName == currentTurn).Score++;
                    }
                    lock (currentGame)
                    {
                        currentGame.CardArray[card1] = currentTurn;
                        //foreach (var item in currentGame.CardArray)
                        //{
                        //    if (item.Value==null)
                        //    {
                        //        return Request.CreateResponse(HttpStatusCode.OK, "ok");
                        //    }
                        //}
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, "ok");
                }
                return Request.CreateResponse(HttpStatusCode.OK,"ok");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "BadRequest");
            }
        }
    }
}