using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.OleDb;

namespace Draught
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode=ConcurrencyMode.Multiple)]
    public class Service1 : IPortal,IGamePlay
    {

        static Action<List<Player>> m_Event = delegate { };
        List<Game> games=new List<Game>();
        Game game = new Game();
        List<Player> users=new List<Player>();
        Player invitedPlayer=new Player();
        //List<Piece> listOfPieces = new List<Piece>();
        Player invitee=new Player();

        //Piece p1 = new Piece();
        //Piece p2 = new Piece();
        //Piece p3 = new Piece();
        //Piece p4 = new Piece();
        //Piece p5 = new Piece();
        //Piece p6 = new Piece();
        //Piece p7 = new Piece();
        //Piece p8 = new Piece();
        //Piece p9 = new Piece();
        //Piece p10 = new Piece();
        //Piece p11 = new Piece();
        //Piece p12 = new Piece();
        //Piece p13 = new Piece();
        //Piece p14 = new Piece();
        //Piece p15 = new Piece();
        //Piece p16 = new Piece();
        //Piece p17 = new Piece();
        //Piece p18 = new Piece();
        //Piece p19 = new Piece();
        //Piece p20 = new Piece();
        //Piece p21 = new Piece();
        //Piece p22 = new Piece();
        //Piece p23 = new Piece();
        //Piece p24 = new Piece();

        public Service1()
        {
    

        

        }

        OleDbConnection connect = new OleDbConnection();
        //public List<Piece> getPieceList()
        //{
        //    return listOfPieces;
        //}

        /// <summary>
        /// This method is used by the piece to move.
        /// </summary>
        //public void changeLocation(int newX, int newY)
        //{
        //    pc.XCoordinate = newX;
        //    pc.YCoordinate = newY;
        //}
        /// <summary>
        /// This method will be called when a user is signing up for the game
        /// </summary>
        /// <param name="userName">The username that the user desires to use in the game,also used as his/her id</param>
        /// <param name="password">The password that the user desires to use in the game.</param>
        /// <returns>Returns true if the sign up is successful and false otherwise</returns>
       
   /***************************************************************************************************/

        public bool signUp(string userName, string password)
        {
            try
            {
                connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../../Database/DraughtDB.accdb;Persist Security Info=False;";
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;

                cmd.CommandText = "INSERT INTO RegistrationTable VALUES('" + userName + "','" + password + "')";
                cmd.ExecuteNonQuery();

                connect.Close();
                return true;
            }
            catch
            {
                return false;
            }
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
            string result;
            try
            {
                connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../../Database/DraughtDB.accdb;Persist Security Info=False;";
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;

                cmd.CommandText = "SELECT Password FROM RegistrationTable WHERE Username ='"+userName+"'";
                result=Convert.ToString(cmd.ExecuteScalar());
                connect.Close();
                if (result == password)
                {
                    Player user = new Player();
                    user.userName = userName;
                    user.password = password;
                    user.loggedIn = true;
                    user.PortalCallBack = OperationContext.Current.GetCallbackChannel<IPortalCallBack>();
                    users.Add(user);
                    updateList();
                    //fireEvent();
                    return true;
                    //game.listOfPiece = listOfPieces;
                    //game.listOfPlayers = users;
                    //games.Add(game);
                }
                else
                {
                    return false;

                }

            }
            catch
            {
                return false;
                
            }
 
        }

        private void updateList()
        {
  
                for (int i = 0; i < users.Count-1; i++)
                {
                    List<Player> tempPlayers = new List<Player>();
                    tempPlayers.AddRange(users);
                    // create a new users list
                    
                    // copy all users to it, except for users[i]

                    tempPlayers.RemoveAt(i);
                    if (tempPlayers.Count > 0)
                    {
                       users[i].PortalCallBack.OnLoggingInOrOut1(tempPlayers); 
                    }
                    
                }
            
        }

    /************************************************************************************************/
        /// <summary>
        /// This method will be used by a player to invite another player to oplay
        /// </summary>
        /// <param name="recipient">The player to be invited</param>
        /// <returns>Returns true if the invitation was successfully sent and false otherwise </returns>
        public bool Invite(string sender,string recipient)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].userName == recipient)
                {
                    invitedPlayer = users[i];
                    invitee.userName = sender;
                    return inviteSelectedPlayer();

                }
            }
                return false ;
        }

    /*****************************************************************************************************/
        /// <summary>
        /// This method will be called when a user is logging out from the game app
        /// </summary>
        public bool logOut(string name)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].userName == name)
                {
                    users.RemoveAt(i);
                }
            }
            for(int i=0;i<users.Count;i++)
            {
                    if (users.Count > 0)
                    {
                        users[i].PortalCallBack.OnLoggingInOrOut1(users);
                    }

                    return true;
            }
            return false;
        }

    /*****************************************************************************************************/
        /// <summary>
        /// This method will be called when a player is sending a message to another player
        /// </summary>
        /// <param name="recipient">The player that the message is intended for</param>
        /// <param name="message">The message being sent</param>
        /// <returns>Retruns true if the message is successfully sent and false otherwise</returns>
        public bool sendMessage(string sender, string message)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].player1.userName == sender)
                {
                    games[i].player2.PortalCallBack.messageRecieved(message);
                }
                else if (games[i].player2.userName == sender)
                {
                    games[i].player1.PortalCallBack.messageRecieved(message);
                }
                
            }

                return true;
        }

     /****************************************************************************************************/
        public bool inviteSelectedPlayer()
        {
            bool accepted = true;
            accepted=invitedPlayer.PortalCallBack.OnInvitation(invitee.userName,invitedPlayer);
            if (accepted)
            {
                Game newGame = new Game();
         
                newGame.player1=invitedPlayer;

                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].userName == invitee.userName)
                    {
                        newGame.player2 = users[i];

                    }

                }

               
                games.Add(newGame);
                
            }
            return accepted;

        }

     /****************************************************************************************************/
        /// <summary>
        /// This method will be called when a player wants to move the piece on the board
        /// </summary>
        /// <param name="piece">The piece to be moved</param>
        /// <param name="boardSquare">The square on the board that the piece will be moved to</param>
        /// <returns>True if successful and false otherwise</returns>
        public void makeMove(int pbIndex,string id,int xPos,int yPos)
        {
            for (int i = 0; i < games.Count; i++)
            { 
                if (games[i].player1.userName == id)
                {
                    games[i].player2.PortalCallBack.updateChanges(pbIndex, xPos, yPos);
                }
                else if (games[i].player2.userName == id)
                {
                    games[i].player1.PortalCallBack.updateChanges(pbIndex, xPos, yPos);
                }

          
            }
          
        }
      

    /*************************************************************************************************/
        /// <summary>
        /// This method is called when a player wantws to quit the game
        /// </summary>
        public void quitGame(string sender,string message)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].player1.userName == sender)
                {
                    games[i].player2.PortalCallBack.gameInterupted(message);
                }
                else if (games[i].player2.userName == sender)
                {
                    games[i].player1.PortalCallBack.gameInterupted(message);
                }

            }

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
        public void Subscribe()
        {
            IPortalEvents player = OperationContext.Current.GetCallbackChannel<IPortalEvents>();
            m_Event += player.OnLoggingInOrOut;
        }
        public void fireEvent()
        {
            m_Event(users);
        }

        public List<Player> GetlistOfPlayers()
        {
            return users;
        }
        public void setOpponent(string userName)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].userName == userName)
                {
                    invitedPlayer.opponent = users[i];
                    //users[i].PortalCallBack.loadGame();
                }
            }
    
        }
        public void updateScore(string userName,int pieceNr)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].player1.userName == userName)
                {
                    games[i].player2.PortalCallBack.onScoreChange(pieceNr);
                }
                else if (games[i].player2.userName == userName)
                {
                    games[i].player1.PortalCallBack.onScoreChange(pieceNr);
                }

            }
            
        }

    }
}
