﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ALATLAS
{
    public partial class REQuestSOLDE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["adminID"] == null)

                Response.Redirect("AdminLoign.aspx");


            else
            Response.Redirect("myDashoard.aspx?requset=" +"requset_solde");

           
        }
    }
}