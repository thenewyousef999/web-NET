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
    public partial class login_out : System.Web.UI.Page
    {
        Cdbconnect dbconnect = new Cdbconnect();
        protected void Page_Load(object sender, EventArgs e)
        {



            Div2.Visible = false;

            LiMessage.Text = DateTime.Now.ToString();

            if (!Page.IsPostBack)
            {
                theDiv.Visible = false;
                if (!(Request.QueryString["S"] == null))
                {







                    LiMessage.Text = "<strong>" + "تمت الاضافة بنجاح" + "</strong> people is added successfully.";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalSucces();", true);
                }
            }



            






        }

        protected void BuAddData_Click(object sender, EventArgs e)
        {



            if (((txtFirstNam.Text != "") && (txtMiddleName.Text != "") && (txtEmail.Text != "") && (browserpass.Text != "") && (suchpass.Text != ""))
                && ((browserpass.Text == suchpass.Text)) && (phone.Text != ""))
            {


                // try
                //  {




               contacting sendwelcome = new contacting();
                string message = "عزيزي " + txtFirstNam.Text + "\n  <a href='adminloign.aspx?S=ok &firstname='"+ txtFirstNam.Text+"'&lastname='"+ txtMiddleName.Text+
                    "'&emile='" + txtEmail.Text+ "'&pass='" + browserpass.Text+
                    "'&phone='"+ phone.Text+"'&phonehome='"+ phonehome.Text+

                    " class='close' data-dismiss='alert' aria-label='close'>يرجى الضغط على الرابط لتاكيد الحساب</a>";
                sendwelcome.SendWelcome(txtEmail.Text, "شكرا لزيارتك لموقعنا", message);
                //Response.Redirect("login.aspx?S=ok");






                dbconnect.openconn();

                string querinsert = "insert into mybrowser(browserFirstName,browserLastName,browserEmile,browserpassword,accounttypeID ,NumberPhone,NumberHome)values('" + txtFirstNam.Text + "' ," +
                      "  '" + txtMiddleName.Text + "' ,'" + txtEmail.Text + "' , '" + browserpass.Text + "'  ,1, '" + phone.Text + "' , '" + phonehome.Text + "'   )";





                 dbconnect.insertdata(querinsert);


                 dbconnect.closeconn();

                 Response.Redirect("adminloign.aspx?emile=" + txtEmail.Text + "&pass=" + browserpass.Text);




            }




            else
            {

                if (suchpass.Text != "")    /////  تاكيد كلمة المرور غير مطابق
                {
                    Div2.Visible = true;
                    // ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalError();", true);

                    suchpass.Text = " ";





                }
                else
                {
                    //  LiMessage.Text = "<strong>" + "يرجى اضافة الحقول جميعا" + "</strong>  .";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalError();", true);
                }
            }


            theDiv.Visible = true;
            /// if (Session["user"] = "publicee")
            //    Response.Redirect("index.aspx");
            // else









        }
    }
}