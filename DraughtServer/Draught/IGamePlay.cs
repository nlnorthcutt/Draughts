using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Draught
{
    [DataContract]
    public class Player
    {
        [DataMember]
        string userName;

        [DataMember]
        string password;

        [DataMember]
        bool loggedIn;

        [DataMember]
        public IGamePlayCallback GamePlayCallBack { get; set; };

    }

     [DataContract]
    public class Game
    {
        [DataMember]
        string Name;

        [DataMember]
        List<Player> listOfPlayers;

        [DataMember]
        List<Piece> listOfPiece;

         [DataMember]
        List<BoardSquare> listOfBoardSquares;


    }

    [ServiceContract(Namespace = "Draught", CallbackContract = typeof(IGamePlayCallback))]
    interface IGamePlay
    {
        [OperationContract]
        bool signUp(string userName, string password);

        [OperationContract]
        bool logIn(string userName, string password);

        [OperationContract]
        bool Invite(string recipient);

        [OperationContract]
        void logOut();

        [OperationContract]
        bool sendMessage(string recipient,string message);

        [OperationContract]
        bool makeMove(Piece piece,BoardSquare boardSquare);

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
        void OnInvitation(string sender,string recipient) ; //To inform a user when an invitaion from another player has been recieved
        void Playerturn(string userName); //To inform the player that it is his/her turn to play
        void messageRecieved(string sender,string sender); //To inform a user when a message from theother player has been recieved
        void gameInterupted(); //To inform a player when the game has been interrupted by the other player
    }
}
