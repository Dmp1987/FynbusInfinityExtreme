//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    [DataContract]
    public partial class ContactInfo
    {
        [DataMember]
        public long id { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Kommune { get; set; }
        [DataMember]
        public Nullable<int> Postnummer { get; set; }
        [DataMember]
        public string Vejnavn { get; set; }
        [DataMember]
        public Nullable<int> Vejnummer { get; set; }

        [DataMember]
        public virtual BidInfo BidInfo { get; set; }
    }
}
