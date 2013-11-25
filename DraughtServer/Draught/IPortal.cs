using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace Draught
{
   
    [ServiceContract(Namespace = "Draught", CallbackContract = typeof(IGamePlayCallback))]
    public interface IPortal
    {
        [OperationContract]
        void move(Piece peice,int newX,int newY);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Draught.ContractType".
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
    [DataContract]
    public class BoardSquare
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
}
