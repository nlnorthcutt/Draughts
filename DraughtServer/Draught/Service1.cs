﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Draught
{

    public class Service1 : IPortal,IGamePlay
    {
        /// <summary>
        /// This method is used by the piece to move.
        /// </summary>
        public void move()
        {  
        }
        /// <summary>
        /// This method will be called when a user is signing up for the game
        /// </summary>
        /// <param name="userName">The username that the user desires to use in the game,also used as his/her id</param>
        /// <param name="password">The password that the user desires to use in the game.</param>
        /// <returns>Returns true if the sign up is successful and false otherwise</returns>
       
   /***************************************************************************************************/

        public bool signUp(string userName, string password)
        {
           return true;
        }
        /// <summary>
        /// This method will be used by the player to log in
        /// </summary>
        /// <param name="userName">Player's registerd username</param>
        /// <param name="password">Player's registered password</param>
        /// <returns>Returns true if the logging in successful and false otherwise</returns>
      
    /***********************************************************************************************/

        public bool logIn(string userName, string password)
        {
            return true;
        }

    /************************************************************************************************/
        /// <summary>
        /// This method will be used by a player to invite another player to oplay
        /// </summary>
        /// <param name="recipient">The player to be invited</param>
        /// <returns>Returns true if the invitation was successfully sent and false otherwise </returns>
        public bool Invite(string recipient)
        {
            return true;
        }

    /*****************************************************************************************************/
        /// <summary>
        /// This method will be called when a user is logging out from the game app
        /// </summary>
        public void logOut()
        {

        }

    /*****************************************************************************************************/
        /// <summary>
        /// This method will be called when a player is sending a message to another player
        /// </summary>
        /// <param name="recipient">The player that the message is intended for</param>
        /// <param name="message">The message being sent</param>
        /// <returns>Retruns true if the message is successfully sent and false otherwise</returns>
        public bool sendMessage(string recipient, string message)
        {
            return true;
        }

     /****************************************************************************************************/
        /// <summary>
        /// This method will be called when a player wants to move the piece on the board
        /// </summary>
        /// <param name="piece">The piece to be moved</param>
        /// <param name="boardSquare">The square on the board that the piece will be moved to</param>
        /// <returns>True if successful and false otherwise</returns>
        public bool makeMove(Piece piece, BoardSquare boardSquare)
        {
            return true;
        }
        /// <summary>
        /// This methods will be used to subscribe to the events
        /// </summary>
        public void Subscribe()
        {

        }

    /*************************************************************************************************/
        /// <summary>
        /// This method is called when a player wantws to quit the game
        /// </summary>
        public void quitGame()
        {

        }

    /**************************************************************************************************/
        /// <summary>
        /// This method will be called when a game is to be called
        /// </summary>
        /// <param name="game">The game that is to be saved</param>
        /// <returns>True if the game is successfully saved and false otherwise</returns>
        public bool saveGame(Game game)
        {
            return true;
        }
    }
}
