using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ALATLAS
{
    public partial class ricepage : System.Web.UI.Page
    {

        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Convert.ToString(Session["adminID"]) != "")
            {
                id = Convert.ToString(Session["adminID"]);
            }

           // if (Session["adminID"] == null)

            //    Response.Redirect("index.aspx?state=" + "rice" );







           if (Convert.ToString(Session["admintype"]) == "publice")
            {
                if (id != "")
                {

                    Literal1.Text = "صفحة شراء العقارات";
                    Response.Redirect("index.aspx?state=" + "rice" + "&tutorialbrowserid=" + id);

                }
                else if (id == "")

                {
                    Literal1.Text = "صفحة شراء العقارات";

                    Response.Redirect("index.aspx?state=" + "rice");
                }

            }

            if (Convert.ToString(Session["admintype"]) == "private")

            {
                if (id != "")
                {


                    Literal1.Text = "صفحة شراء العقارات";
                    Response.Redirect("MYDashoard.aspx?state=" + "rice" + "&tutorialbrowserid=" + id);


                }

                else if(id=="")
                {

                    Literal1.Text = "صفحة شراء العقارات";
                    Response.Redirect("adminloign.aspx");



                }



            }

            

        }
    }
}