using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentCRUDApp
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void BtnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}