using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.OleDb;

namespace Draught
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IPortal,IGamePlay
    {

        static Action<List<Player>> m_Event = delegate { };
        List<Game> games=new List<Game>();
        Game game = new Game();
        List<Player> users=new List<Player>();
        Player invitedPlayer;
        List<Piece> listOfPieces = new List<Piece>();
        Player invitee;

        Piece p1 = new Piece();
        Piece p2 = new Piece();
        Piece p3 = new Piece();
        Piece p4 = new Piece();
        Piece p5 = new Piece();
        Piece p6 = new Piece();
        Piece p7 = new Piece();
        Piece p8 = new Piece();
        Piece p9 = new Piece();
        Piece p10 = new Piece();
        Piece p11 = new Piece();
        Piece p12 = new Piece();
        Piece p13 = new Piece();
        Piece p14 = new Piece();
        Piece p15 = new Piece();
        Piece p16 = new Piece();
        Piece p17 = new Piece();
        Piece p18 = new Piece();
        Piece p19 = new Piece();
        Piece p20 = new Piece();
        Piece p21 = new Piece();
        Piece p22 = new Piece();
        Piece p23 = new Piece();
        Piece p24 = new Piece();

        public Service1()
        {
            p1.XCoordinate = 296;
            p1.YCoordinate = 35;
            p1.Color = "white";
            p1.CorrespondingBS = 1;
            listOfPieces.Add(p1);

            p2.XCoordinate = 398;
            p2.YCoordinate = 35;
            p2.Color = "white";
            p2.CorrespondingBS = 3;
            listOfPieces.Add(p2);


            p3.XCoordinate = 495;
            p3.YCoordinate = 35;
            p3.Color = "white";
            p3.CorrespondingBS = 5;
            listOfPieces.Add(p3);

            p4.XCoordinate = 595;
            p4.YCoordinate = 35;
            p4.Color = "white";
            p4.CorrespondingBS = 7;
            listOfPieces.Add(p4);

            p5.XCoordinate = 254;
            p5.YCoordinate = 85;
            p5.Color = "white";
            p5.CorrespondingBS = 9;
            listOfPieces.Add(p5);

            p6.XCoordinate = 346;
            p6.YCoordinate = 85;
            p6.Color = "white";
            p6.CorrespondingBS = 11;
            listOfPieces.Add(p6);

            p7.XCoordinate = 448;
            p7.YCoordinate = 85;
            p7.Color = "white";
            p7.CorrespondingBS = 13;
            listOfPieces.Add(p7);

            p8.XCoordinate = 547;
            p8.YCoordinate = 85;
            p8.Color = "white";
            p8.CorrespondingBS = 15;
            listOfPieces.Add(p8);

            p9.XCoordinate = 293;
            p9.YCoordinate = 135;
            p9.Color = "white";
            p9.CorrespondingBS = 17;
            listOfPieces.Add(p9);

            p10.XCoordinate = 398;
            p10.YCoordinate = 135;
            p10.Color = "white";
            p10.CorrespondingBS = 19;
            listOfPieces.Add(p10);

            p11.XCoordinate = 496;
            p11.YCoordinate = 135;
            p11.Color = "white";
            p11.CorrespondingBS = 21;
            listOfPieces.Add(p11);

            p12.XCoordinate = 595;
            p12.YCoordinate = 135;
            p12.Color = "white";
            p12.CorrespondingBS = 23;
            listOfPieces.Add(p12);

            //Black pieces
            p13.XCoordinate = 296;
            p13.YCoordinate = 291;
            p13.Color = "black";
            p13.CorrespondingBS = 41;
            listOfPieces.Add(p13);

            p14.XCoordinate = 398;
            p14.YCoordinate = 291;
            p14.Color = "black";
            p14.CorrespondingBS = 43;
            listOfPieces.Add(p14);

            p15.XCoordinate = 495;
            p15.YCoordinate = 291;
            p15.Color = "black";
            p15.CorrespondingBS = 45;
            listOfPieces.Add(p15);

            p16.XCoordinate = 595;
            p16.YCoordinate = 291;
            p16.Color = "black";
            p16.CorrespondingBS = 47;
            listOfPieces.Add(p16);

            p17.XCoordinate = 254;
            p17.YCoordinate = 342;
            p17.Color = "black";
            p17.CorrespondingBS = 49;
            listOfPieces.Add(p17);

            p18.XCoordinate = 346;
            p18.YCoordinate = 342;
            p18.Color = "black";
            p18.CorrespondingBS = 51;
            listOfPieces.Add(p18);

            p19.XCoordinate = 448;
            p19.YCoordinate = 342;
            p19.Color = "black";
            p19.CorrespondingBS = 53;
            listOfPieces.Add(p19);

            p20.XCoordinate = 547;
            p20.YCoordinate = 338;
            p20.Color = "black";
            p20.CorrespondingBS = 55;
            listOfPieces.Add(p20);

            p21.XCoordinate = 304;
            p21.YCoordinate = 393;
            p21.Color = "black";
            p21.CorrespondingBS = 57;
            listOfPieces.Add(p21);

            p22.XCoordinate = 398;
            p22.YCoordinate = 393;
            p22.Color = "black";
            p22.CorrespondingBS = 59;
            listOfPieces.Add(p22);

            p23.XCoordinate = 496;
            p23.YCoordinate = 389;
            p23.Color = "black";
            p23.CorrespondingBS = 61;
            listOfPieces.Add(p23);

            p24.XCoordinate = 595;
            p24.YCoordinate = 393;
            p24.Color = "black";
            p24.CorrespondingBS = 63;
            listOfPieces.Add(p24);

            game.Name = "Game1";

        }

        OleDbConnection connect = new OleDbConnection();
        public List<Piece> getPieceList()
        {
            return listOfPieces;
        }

        /// <summary>
        /// This method is used by the piece to move.
        /// </summary>
        public void changeLocation(Piece pc,int newX, int newY)
        {
            pc.XCoordinate = newX;
            pc.YCoordinate = newY;
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
            for (int i = 1; i < users.Count; i++)
			{
			 users[i].PortalCallBack.OnLoggingInOrOut1(users);
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

                }
            }
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
        public void inviteSelectedPlayer()
        {
            invitedPlayer.PortalCallBack.OnInvitation(invitee.userName,invitedPlayer);
        }

     /****************************************************************************************************/
        /// <summary>
        /// This method will be called when a player wants to move the piece on the board
        /// </summary>
        /// <param name="piece">The piece to be moved</param>
        /// <param name="boardSquare">The square on the board that the piece will be moved to</param>
        /// <returns>True if successful and false otherwise</returns>
        public bool makeMove(Piece piece, int xPos,int yPos)
        {
            return true;
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
    }
}
