using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace Draught
{

    [DataContract]
    public class Player
    {
        [DataMember]
        public string userName;

        [DataMember]
        public string password;

        [DataMember]
        public bool loggedIn;

        [DataMember]
        public IPortalCallBack PortalCallBack { get; set; }

    }
    [ServiceContract(Namespace = "Draught", CallbackContract = typeof(IPortalCallBack))]
    public interface IPortal
    {
        [OperationContract]
        bool signUp(string userName, string password);

        [OperationContract]
        bool logIn(string userName, string password);

        [OperationContract]
        bool Invite(string sender,string recipient);

        [OperationContract]
        void logOut();

        [OperationContract]
        void Subscribe();

       [OperationContract]
       List<Player> GetlistOfPlayers();

    }



    public interface IPortalCallBack
    {
        void OnInvitation(string sender, Player recipient); //To inform a user when an invitation from another player has been recieved

        [OperationContract]
        void OnLoggingInOrOut1(List<Player> loggedInList); //this event will be fired when a user logs in or out,to update the list of the logged in users. 
    }
    //[ServiceContract(Namespace="Draught")]
    interface IPortalEvents
    {
        [OperationContract(IsOneWay = true)]
        void OnLoggingInOrOut(List<Player> loggedInList); //this event will be fired when a user logs in or out,to update the list of the logged in users. 

    }


}
