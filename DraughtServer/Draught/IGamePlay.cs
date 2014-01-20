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
        public Player player1;
        public Player player2;


    }

 

    [ServiceContract(Namespace = "Draught")]
    interface IGamePlay
    {
      
        //[OperationContract]
        //void changeLocation(int newX, int newY);
        
        [OperationContract]
        bool sendMessage(string sender,string message);

        [OperationContract]
        void makeMove(int pbIndex,string id,int x,int y);

        [OperationContract]
        void quitGame(string sender,string message);

        //[OperationContract]
        //List<Piece> getPieceList();



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
