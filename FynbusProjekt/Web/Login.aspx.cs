using System;
using System.Collections.Generic;
using System.Linq;
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
            submit.ServerClick += submit_ServerClick;
        }

        void submit_ServerClick(object sender, EventArgs e)
        {

            FormsAuthentication.RedirectFromLoginPage(Brugernavn.Value, true);
        }
    }
}