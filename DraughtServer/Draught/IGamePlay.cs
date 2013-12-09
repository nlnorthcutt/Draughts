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
        string Name;

        [DataMember]
        List<Player> listOfPlayers;

        [DataMember]
        List<Piece> listOfPiece;


    }
    [DataContract]
    public class Piece
    {
        int xCoordinate;
        int yCoordinate;
        string color;

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
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }


    [ServiceContract(Namespace = "Draught", CallbackContract = typeof(IGamePlayCallback))]
    interface IGamePlay
    {
      
        [OperationContract]
        void move(int newX, int newY);

        [OperationContract]
        bool sendMessage(string recipient, string message);

        [OperationContract]
        bool makeMove(Piece piece, int x,int y);

        [OperationContract]
        void Subscribe();

        [OperationContract]
        void quitGame();

    }
    [ServiceContract(Namespace = "Draught")]
    interface IGamePlayEvents
    {
        void OnLoggingInOrOut(List<Player> loggedInList); //this event will be fired when a user logs out. 

    }

    public interface IGamePlayCallback
    {
        void OnInvitation(string sender, string recipient); //To inform a user when an invitaion from another player has been recieved
        void Playerturn(string userName); //To inform the player that it is his/her turn to play
        void messageRecieved(string sender, string message); //To inform a user when a message from the other player has been recieved
        void gameInterupted(); //To inform a player when the game has been interrupted by the other player
    }
}
