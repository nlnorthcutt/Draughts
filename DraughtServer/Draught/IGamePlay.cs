using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data.OleDb;
using System.Drawing;

namespace Draught
{
    [DataContract]
    public class Game
    {
        [DataMember]
        public string Name;

        [DataMember]
        public List<Player> listOfPlayers;

        [DataMember]
        public List<Piece> listOfPiece;



    }
    [DataContract]
    public class Piece
    {
        int xCoordinate;
        int yCoordinate;
        string color;
        int correspondingBS;

        [DataMember]
        public int XCoordinate
        {
            get { return xCoordinate; }
            set { xCoordinate = value; }
        }

        [DataMember]
        public int YCoordinate
        {
            get { return yCoordinate; }
            set { yCoordinate = value; }
        }
        [DataMember]
        public int CorrespondingBS
        {
            get { return correspondingBS; }
            set { correspondingBS = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        
        
    }


    [ServiceContract(Namespace = "Draught")]
    interface IGamePlay
    {
      
        [OperationContract]
        void changeLocation(Piece pc,int newX, int newY);

        [OperationContract]
        bool sendMessage(string recipient, string message);

        [OperationContract]
        bool makeMove(Piece piece, int x,int y);

        [OperationContract]
        void quitGame();

        [OperationContract]
        List<Piece> getPieceList();



    }
    //[ServiceContract(Namespace = "Draught")]
    //interface IGamePlayEvents
    //{
    //    void OnLoggingInOrOut(List<Player> loggedInList); //this event will be fired when a user logs out. 

    //}
    //[ServiceContract (Namespace= "Draught")]
    //public interface IGamePlayCallback
    //{
    //    [OperationContract]
    //    void OnLoggingInOrOut1(List<Player> loggedInList);
    //    //void OnInvitation(string sender, string recipient); //To inform a user when an invitaion from another player has been recieved
    //    //void Playerturn(string userName); //To inform the player that it is his/her turn to play
    //    //void messageRecieved(string sender, string message); //To inform a user when a message from the other player has been recieved
    //    //void gameInterupted(); //To inform a player when the game has been interrupted by the other player
    //}
}
