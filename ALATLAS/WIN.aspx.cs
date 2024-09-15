using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ALATLAS
{
    public partial class WIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["adminID"] == null)

                //   Response.Redirect("index.aspx?state=" + "solde");

                Response.Redirect("AdminLoign.aspx");





            else if (Convert.ToString(Session["admintype"]) == "publice")
            {
               // Literal1.Text = " صفحة بيع العقارات";

                Response.Redirect("index.aspx?state=" + "win");
            }


            else if (Convert.ToString(Session["admintype"]) == "private")
            {
                //Literal1.Text = "صفحة شراء عقارات";

                Response.Redirect("MYDashoard.aspx?state=" + "win");
            }
        


        }
    }
}