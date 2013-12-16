using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace Draught
{

    [ServiceContract(Namespace = "Draught", CallbackContract = typeof(IPortalCallBack))]
    public interface IPortal
    {
        [OperationContract]
        bool signUp(string userName, string password);

        [OperationContract]
        bool logIn(string userName, string password);

        [OperationContract]
        bool Invite(string recipient);

        [OperationContract]
        void logOut();

    }
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

    
    public interface IPortalCallBack
    {
        void OnInvitation(string sender, string recipient); //To inform a user when an invitaion from another player has been recieved
    }
    interface IPortalEvents
    {
        [OperationContract(IsOneWay = true)]
        void OnLoggingInOrOut(List<Player> loggedInList); //this event will be fired when a user logs out. 

    }


}
