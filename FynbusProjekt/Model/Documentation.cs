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
    public partial class Documentation
    {
        [DataMember]
        public long id { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DatoForRegistrering { get; set; }
        [DataMember]
        public string DokumentationsInfo { get; set; }
        [DataMember]
        public string RegistreringsNummer { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Tilladelse_Gyldig { get; set; }
        [DataMember]
        public Nullable<int> Tilladelse_Nummer { get; set; }
        [DataMember]
        public string Tilladelse_Type { get; set; }
        [DataMember]
        public string TrafikSelskab { get; set; }
        [DataMember]
        public string UdstedendeMyndighed { get; set; }
        [DataMember]
        public Nullable<long> KlarTilDrift_id { get; set; }

        [DataMember]
        public virtual BidInfo BidInfo { get; set; }
    }
}
