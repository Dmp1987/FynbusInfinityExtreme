using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new fynbusEntities();
            var bidinfo = new BidInfo()
            {
                BidderName = "Hans ole"
            };
            db.BidInfo.Add(bidinfo);
            db.SaveChanges();

            var bidinfoList = db.BidInfo.ToList();
            db.BidInfo.Remove(bidinfo);
            db.SaveChanges();

            var bidinfoList2 = db.BidInfo.ToList<BidInfo>();
            var x = 0;
        }
    }
}