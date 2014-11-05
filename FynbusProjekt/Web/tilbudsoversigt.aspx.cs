using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;


namespace Web
{
    public partial class Tilbudsoversigt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new fynbusprojektEntities())
            {
                gvBidinfos.DataSource = db.BidInfo.ToList();

                gvBidinfos.CssClass = "table table-bordered table-condensed table-hover table-responsive table-striped";
                gvBidinfos.DataBind();
                gvBidinfos.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}