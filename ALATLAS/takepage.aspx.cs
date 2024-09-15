using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ALATLAS
{
    public partial class takepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string id = Convert.ToString(Session["adminID"]);

            if (Session["adminID"] == null)
            {
                Response.Redirect("AdminLoign.aspx");


            }
            else if (Convert.ToString(Session["admintype"]) == "publice")
            {
                Literal1.Text = " صفحة تاجير العقارات";

                Response.Redirect("index.aspx?state=" + "take"+ "&tutorialbrowserid=" + id);
            }


            else if (Convert.ToString(Session["admintype"]) == "private")
            {
                Literal1.Text = "صفحة تاجير عقارات";

                Response.Redirect("MYDashoard.aspx?state=" + "take");
            }

        }
    }
}