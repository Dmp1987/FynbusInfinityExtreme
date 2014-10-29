using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Model;

namespace API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetName(int id);

        [OperationContract]
        BidInfo GetBidinfo(int id);

        [OperationContract]
        object GetContactInfo(int id);

        [OperationContract]
        object GetDocumentation(int id);

        [OperationContract]
        object GetEquipment(int id);

        [OperationContract]
        object GetExpandedBifInfo(int id);

        [OperationContract]
        object GetPriceList(int id);

        [OperationContract]
        BidInfo CreateBidInfo(string newBid);

        [OperationContract]
        object CreateContactInfo(BidInfo newBid);

        [OperationContract]
        object CreateDocumentation(BidInfo newBid);

        [OperationContract]
        object CreateEquipment(BidInfo newBid);

        [OperationContract]
        object CreateExpandedBifInfo(BidInfo newBid);

        [OperationContract]
        object CreatePriceList(BidInfo newBid);

        [OperationContract]
        object UpdateBidInfo(object newBid);

        //[OperationContract]
        //object UpdateContactInfo(BidInfo newBid);

        //[OperationContract]
        //object UpdateDocumentation(BidInfo newBid);

        //[OperationContract]
        //object UpdateEquipment(BidInfo newBid);

        //[OperationContract]
        //object UpdateExpandedBidInfo(BidInfo newBid);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
