using ALATLAS.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ALATLAS
{
    public partial class adminloign : System.Web.UI.Page
    {


        Cdbconnect dbconnect = new Cdbconnect();


        DataTable dt = new DataTable();


      

        protected void Page_Load(object sender, EventArgs e)
        {
            Div2.Visible = false;

            Session["adminid"] = null;
            Session["admintype"] = null;



            if (!Page.IsPostBack)
            {
                theDiv.Visible = false;
                // txtUserName.Attributes.Add("onfocus", "clearText(this,'Enter your email')");













            }

            ////////////////////////     من صفحة login
            if ((Request.QueryString["emile"] != null) && (Request.QueryString["pass"] != null) &&
                (Request.QueryString["firstname"] != null) && (Request.QueryString["lastname"] != null) &&
                (Request.QueryString["phone"] != null) && (Request.QueryString["phonehome"] != null))



            { 


              //  txtFirstNam.Text = Request.QueryString["firstname"];

              //  txtMiddleName.Text = Request.QueryString["lastname"];


              //  phone.Text = Request.QueryString["phone"];

              //  phonehome.Text = Request.QueryString["phonehome"];






              dbconnect.openconn();

             string querinsert = "insert into mybrowser(browserFirstName,browserLastName,browserEmile,browserpassword,accounttypeID ,NumberPhone,NumberHome)values('" + txtFirstNam.Text + "' ," +
                       "  '" + txtMiddleName.Text + "' ,'" + txtUserName.Text + "' , '" + txtPassword.Text + "'  ,1, '" + phone.Text + "' , '" + phonehome.Text + "'   )";



                 dbconnect.insertdata(querinsert);


                 dbconnect.closeconn();

                ///// accounttype=1 حساب عام publice





                txtUserName.Text = Request.QueryString["emile"];

                txtPassword.Text = Request.QueryString["pass"];




            }   ///// end page login


            Button1update.Visible = false;
            Textusernameupdate.Visible = false;
            Textpassupdate.Visible = false;
            TextBox1suchpass.Visible = false;

            BuAddData.Visible = true;





            if (Request.QueryString["update"] == "update")
            {


                txtUserName.Text = Request.QueryString["Textusernameupdate"];

                Button1update.Visible = false;
                Textusernameupdate.Visible = false;
                Textpassupdate.Visible = false;
                TextBox1suchpass.Visible = false;

                BuAddData.Visible = true;


            }



            /////////////////////////////update account


            if (Request.QueryString["chang"] == "update")
            {

                Literal1.Text = "ادخل الايميل الحالي";

                Literal4.Text = "ادخل الايميل الجديد";


                Literal2.Text = " ادخل كلمة المرور الحالية ";
                Literal5.Text = "ادخل كلمة المرور الجديدة ";
                Literal6.Text = "تاكيد كلمة المرور الجديد";

                Button1update.Visible = true;

                Textusernameupdate.Visible = true;
                Textpassupdate.Visible = true;

                TextBox1suchpass.Visible = true;


                BuAddData.Visible = false;

               
            }



        }/// <summary>enf load
        /// / 
        
        private bool isAdminmaster(string username, string password)
        {

            dbconnect.openconn();





            string queryselectprivate = "select browserID  from mybrowser where browseremile = '" + username + "' and browserpassword = '" + password + "' and accounttypeID = 2   ";


            dt.Clear();
            dt = dbconnect.selectdata(queryselectprivate);
            dbconnect.closeconn();

            // dt = dbconnect.cobject.SelectDataSet("mybrowser", "browserid", "browseremile like '" + username + "' and browserpassword like '" + password + "' ").Tables[0];



            if ((dt != null) && (dt.Rows.Count > 0))
            {
                Session["AdminId"] = dt.Rows[0][0];

                Session["admintype"] = "private";

              




                // dbconnect.insertdata(queryinsert);



                return true;
            }

            return false;


        }


        private bool isAdminEXIT(string username, string password)
        {






            string queryselect = "select browserID  from mybrowser where browseremile = '" + username + "' and browserpassword = '" + password + "' and accounttypeID =1   ";

            dbconnect.openconn();
            dt.Clear();
            dt = dbconnect.selectdata(queryselect);

            dbconnect.closeconn();
            // dt = dbconnect.cobject.SelectDataSet("mybrowser", "browserid", "browseremile like '" + username + "' and browserpassword like '" + password + "' ").Tables[0];




            if ((dt != null) && (dt.Rows.Count > 0))
            {
                Session["AdminId"] = dt.Rows[0][0];
                Session["admintype"] = "publice";






                //string queryinsert = "insert into AdminStracking(tableID,RecordID,dateModify,personID,AdminOperationTypeID,oldvalue,NewValue)" +
                //   "values(5, " + dt.Rows[0]["browserID"]+" , '" + DateTime.Now.ToString() + "'," + dt.Rows[0]["browserID"] +" ,7, '"+ HFMAC.Value + "' ,'" + Session.SessionID.ToString() + "')";






                return true;
            }

            return false;


        }





        private bool isAdminull(string username, string password)
        {






            string queryselect = "select browserID , browserEmile from mybrowser where browseremile = '" + username + "' and browserpassword = '" + password + "'    ";

            dbconnect.openconn();

            dt.Clear();
            dt = dbconnect.selectdata(queryselect);
            dbconnect.closeconn();
            // dt = dbconnect.cobject.SelectDataSet("mybrowser", "browserid", "browseremile like '" + username + "' and browserpassword like '" + password + "' ").Tables[0];




            if ((dt.Rows.Count == 0))
            {
                return true;




            }


            return false;




        }








        protected void toindex_Click1(object sender, EventArgs e)
        {




            dbconnect.openconn();





            string queryselectprivate22 = "select browserID  from mybrowser where browseremile = '" + txtUserName.Text + "' and browserpassword = '" + txtPassword.Text + "' and accounttypeID = 2   ";


            dt.Clear();
            dt = dbconnect.selectdata(queryselectprivate22);
            dbconnect.closeconn();

            if (dt.Rows.Count > 0)
            {
                mastrid9.Text = dt.Rows[0][0].ToString();

               



                Response.Redirect("index.aspx?tutorialbrowserid=" + mastrid9.Text);

            }

            else



                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalError();", true);




        }





        protected void BuAddData_Click1(object sender, EventArgs e)
        {



            if (isAdminEXIT(txtUserName.Text, txtPassword.Text))
            {
                Response.Redirect("index.aspx?admintype=" + "publice");



                LiMessage.Text = Session["AdminId"].ToString();

                theDiv.Visible = true;





                // else

                // LiMessage.Text = "<strong>warning</strong>th email or password is not correct ";
            }

            if (isAdminmaster(txtUserName.Text, txtPassword.Text))
            {
                Response.Redirect("myDashoard.aspx?type account=privatee");



                theDiv.Visible = true;

            }


            if (isAdminull(txtUserName.Text, txtPassword.Text))
            {
                Session["AdminID"] = "null";


                Div2.Visible = true;



            }




        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void updateData_Click1(object sender, EventArgs e)
        {



            dbconnect.openconn();





            string queryselectprivate = "select browserID  from mybrowser where browseremile like '" + txtUserName.Text + "' and browserpassword like '" + txtPassword.Text + "' and accounttypeID = 2   ";
            dt.Clear();

            dt = dbconnect.selectdata(queryselectprivate);

            dbconnect.closeconn();
            // dt = dbconnect.cobject.SelectDataSet("mybrowser", "browserid", "browseremile like '" + username + "' and browserpassword like '" + password + "' ").Tables[0];



            if ((dt != null) && (dt.Rows.Count > 0))
            {


                browserid.Text = dt.Rows[0][0].ToString();
                theDiv.Visible = false;







                dbconnect.openconn();

                string querupdate = "update mybrowser set browserEmile='"+ Textusernameupdate.Text + "' , browserpassword='"+ Textpassupdate.Text + "' where browserID="+browserid.Text+"   ";



                dbconnect.insertdata(querupdate);


                dbconnect.closeconn();





              //  Response.Redirect("adminloign.aspx?update=" + "update" + "&Textusernameupdate="+ Textusernameupdate.Text);
















            }
            else
                browserid.Text = "";
            theDiv.Visible = true;

            LiMessage.Text = "الايميل او كلمة المرور غير صحيحة يرجى التاكد واعادة المحاولة";





        }
        }
}