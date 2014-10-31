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
        ContactInfo GetContactInfo(int id);

        [OperationContract]
        Documentation GetDocumentation(int id);

        [OperationContract]
        Equipment GetEquipment(int id);

        [OperationContract]
        ExpandedBidInfo GetExpandedBifInfo(int id);

        [OperationContract]
        PriceList GetPriceList(int id);

        [OperationContract]
        BidInfo CreateBidInfo(BidInfo newBidInfo);

        [OperationContract]
        ContactInfo UpdateContactInfo(BidInfo bid, ContactInfo contact);

        [OperationContract]
        Documentation UpdateDocumentation(BidInfo bid, Documentation doc);

        [OperationContract]
        Equipment UpdateEquipment(BidInfo bid, Equipment eq);

        [OperationContract]
        ExpandedBidInfo UpdateExpandedBifInfo(BidInfo bid, ExpandedBidInfo exp);

        [OperationContract]
        PriceList UpdatePricelist(BidInfo bid, PriceList pl);

        [OperationContract]
        BidInfo UpdateBidInfo(BidInfo bid);

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
