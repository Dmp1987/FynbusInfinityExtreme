//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BidInfo
    {
        public long id { get; set; }
        public string BidderName { get; set; }
        public int CVR { get; set; }
        public System.DateTime LastEdit { get; set; }
        public int OfferNumber { get; set; }
    
        public virtual ContactInfo ContactInfo { get; set; }
        public virtual Documentation Documentation { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual ExpandedBidInfo ExpandedBidInfo { get; set; }
        public virtual PriceList PriceList { get; set; }
    }
}
