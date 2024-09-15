using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ALATLAS
{
    public partial class take_of : System.Web.UI.Page
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Convert.ToString(Session["adminID"]) != "")
            {

                id = Convert.ToString(Session["adminID"]);
            }

          //  if (Session["adminID"] == null)
          //  {
                //  Response.Redirect("AdminLoign.aspx");
           //     Response.Redirect("index.aspx?state=" + "take of") ;


         //   }



            if (Convert.ToString(Session["admintype"]) == "publice")
            {

                if (id != "")
                {

                    Literal1.Text = " صفحة استأجار العقارات";

                    Response.Redirect("index.aspx?state=" + "take of" + "&tutorialbrowserid=" + id);
                }

                else if (id == "")
                {

                    Literal1.Text = " صفحة استأجار العقارات";

                    Response.Redirect("index.aspx?state=" + "take of");
                }

            }





            if (Convert.ToString(Session["admintype"]) == "private")

            {
                if (id != "")
                {


                    Literal1.Text = "صفحة شراء العقارات";
                    Response.Redirect("MYDashoard.aspx?state=" + "take of" + "&tutorialbrowserid=" + id);


                }

                else if (id == "")
                {

                    Literal1.Text = "صفحة شراء العقارات";
                    Response.Redirect("adminloign.aspx");



                }



            }



        








    }
    }
}