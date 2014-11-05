using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
            submit.ServerClick += delegate(object o, EventArgs args)
            {

            };
        }

        void submit_ServerClick(object sender, EventArgs e)
        {
            
        }
    }
}