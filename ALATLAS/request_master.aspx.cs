using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ALATLAS
{
    public partial class request_master : System.Web.UI.Page
    {

        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {



            if (Convert.ToString(Session["adminID"]) != "")
            {
                id = Convert.ToString(Session["adminID"]);
            }



            if (Convert.ToString(Session["admintype"]) == "private")
            {
               //Literal1.Text = "صفحة اضافة عقار:  بيع -شراء - اجار - استاجار ";

                Response.Redirect("MYDashoard.aspx?state=" + "request_master");
            }


            else if (id == "")
            {

               // Literal1.Text = "صفحة شراء العقارات";
                Response.Redirect("adminloign.aspx");



            }





        }
    }
}