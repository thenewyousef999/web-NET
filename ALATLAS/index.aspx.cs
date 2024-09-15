using ALATLAS.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;
using System.Security.Policy;
using System.Web.DynamicData;



namespace ALATLAS
{
    public partial class index : System.Web.UI.Page
    {
        Cdbconnect dbconnect = new Cdbconnect();


        DataTable dt = new DataTable();


        string namebutton = "";


       // string admintype = "";


        public string javaid = "";



      // public string mesggbox = "";



        string button = "";

        public string stateview = "";




       public string comandshow = "";


        public double mathe = 0 ;



         public string firstnamewelcom = "";
         public string  lastnamewelcom = "";
         public string  emialewelocm = "";


        string viewfilterdelete = "";



        public void Sendcodee(string phone, string subject, string body)
        {
            //lonasamerekal199@gmail.com
            //rootlonamnroot123

            //


            //webmaster@alrubaye.com
            //abc3551356

            //lonasamerekal199@gmail.com
            //rootLONAmnroot123

            //files.000webhost.com
            //user name-pass
            //hhyousef99roo000webhostapp
            //abc3551356YOUSEF$


            //github

            //hanan99aa
            ///micrsoft
            ///hanan@yousefroot123.com
            ///rootyousefroot123


            ///azure
            ///web app
            ///hhyousef99roo000webhostapp.azurewebsites.net

            // username 
            //azureuser
            //pass :abc3551356YOUSEF$

            // رمز الهاتف لسوريا:
            //+963


            //mail.alrubaye.com
            //abc3551356

            string smtpAddress = "real.kassarint.com";
            int portNumber = 21;
            bool enableSSL = true;

            string emailFrom = "real@reeal.kassarint.com";
            string password = "EnHanan2024";
            string emailTo = phone;



            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                // Can set to false, if you are sending pure text.

                //  mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
                //  mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);


                }
            }



        }










        protected void Page_Load(object sender, EventArgs e)
        {

            // Sendcodee("lonasamerekal199@gmail.com", "رمز التحقق", "123654");

           // mathe = Math.Pow(10, 3);


           // Literal7.Text = mathe.ToString();




            addimagebutton.Visible = true;



            sendrequset.Visible = false;

            deletimagebutton.Visible = false;

            delettuorialbutton.Visible = false;




            if ((javaid == "") || (tutorialbrowserid.Text == ""))
            {

                Button1view.Visible = false;
                Button2add.Visible = false;


            }



            javaid = Request.QueryString["tutorialbrowserid"];

            tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];





            placee.Text = "الشارع:" + txtstreatname.Text + "-" + "بناء رقم:" + txtnumberbuild.Text;

            placetutorialee.Text =  "عنوان العقار:" +  DropDownList1.SelectedItem+ "-" + DropDownList3.SelectedItem + "-" +DropDownList4.SelectedItem+"   "+"   "+


               placee.Text;




           // placetutorialee.Text = DropDownList1.SelectedItem+ placetutorialee.Text;  //  البلد





            if (txtstatetutorial.Text == "solde")
            {

                pagename.Text = "صفحة بيع العقارات";




            }
            if (txtstatetutorial.Text == "take")
            {



                pagename.Text = "صفحة تاجير العقارات";

            }


            if (txtstatetutorial.Text == "rice")
            {



                pagename.Text = "صفحة شراء العقارات";

                


            }





            if (txtstatetutorial.Text == "take of")
            {

                pagename.Text = "صفحة استاجار العقارات";

            }
            if (txtstatetutorial.Text == "win")
            {


                pagename.Text = "صفحة ربح  مكتب العقارات";

            }








            if (!Page.IsPostBack)
            {

                //////////////////////////////////////////////////////////

                more.Visible = false;
                


                //////////////////////             ////////////////////////////////////////////

                Div1.Visible = false;

               // Panel55.Visible = false;


                Panel1solde.Visible = false;


                Panelfilter.Visible = false;

                ////////////////////////////////////   button function (حذف صورة -حذف عقار-اضافة صورة)
                addimagebutton.Visible = true;

                deletimagebutton.Visible = false;

                delettuorialbutton.Visible = false;

                ////////////////////////////////////////
                ///

                ////////////////////////////////////request    admin === browserid للحصول على browser
                ///


                if (Session["adminid"] == null)
                {
                    //  Response.Redirect("adminloign.aspx");
                }



                javaid= Request.QueryString["tutorialbrowserid"];

                tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];


                

                    Session["adminid"] = Request.QueryString["tutorialbrowserid"];



                    Session["admintype"] = "publice";

               
                //////////////////////////////////////////////
                ///


                if (tutorialbrowserid.Text != "")
                {
                    dbconnect.openconn();

                    string querinsert55showtmesseg = "select browserfirstName,browserlastName,browseremile from mybrowser where browserID=" + tutorialbrowserid.Text + "  ";

                    dt = dbconnect.selectdata(querinsert55showtmesseg);

                    dbconnect.closeconn();
                    if (dt.Rows.Count > 0)
                    {
                        firstnamewelcom = dt.Rows[0][0].ToString();
                        lastnamewelcom = dt.Rows[0][1].ToString();
                        emialewelocm = dt.Rows[0][2].ToString();

                    }

                }


                ///////////////////////////////////////////////   request pages:    solde _ rice _ take _ take of  نوع الطلب


                if ((Request.QueryString["state"] == "take") || (txtstatetutorial.Text == "take"))  // صفحة تاجير العقارات   ///// فقط قيمة ابتدائية يجب المحافظة عليها عند كل عملية request
                {
                    pagename.Text = "صفحة تاجير العقارات";
                    BuSearch.Visible = false;

                    txtstatetutorial.Text = "take";

                    more.Visible = false;


                    button = Request.QueryString["button"];

                    tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];

                    Panelfilter.Visible = false;

                   
                    UpdatePanel5.Visible = false;
                   

                    string queryselecttutorials = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke," +
                    "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils,Dateupdat,masad,Serviecother   " +
                    "from tutorials where State='" + txtstatetutorial.Text + "' and isactive='false'  and tutorialbrowserid=" + tutorialbrowserid.Text + "   ";


                    dbconnect.openconn();
                    dt.Clear();
               

                   dt = dbconnect.selectdata(queryselecttutorials);

                    dbconnect.closeconn();

                    if( (dt.Rows.Count > 0))
                    {


                        SqlDataSource1.SelectCommand = queryselecttutorials;

                        DataList1.Visible = true;


                        Panel1solde.Visible = false;


                       // Panel55.Visible = true;/// لتحميل الصور



                    }
                    else 

                    {


                        Panel1solde.Visible = true;

                        Button2_updatehaveperson.Visible = false;

                        DataList1.Visible = false;


                    }


                    if(button=="add")
                    {


                        Panel1solde.Visible = true;

                        Button2_updatehaveperson.Visible = false;

                        DataList1.Visible = false;

                        //Panel55.Visible = false;/// لتحميل الصور


                        Button1view.Visible = true;
                        Button2add.Visible = false;

                    }






                    if (button == "view")
                    {


                        SqlDataSource1.SelectCommand = queryselecttutorials;

                        DataList1.Visible = true;


                        Panel1solde.Visible = false;


                        //Panel55.Visible = true;/// لتحميل الصور


                        Button1view.Visible = false;
                        Button2add.Visible = true;

                    }






                }



                    if ((Request.QueryString["state"] == "solde") || (txtstatetutorial.Text == "solde"))    // صفحة البيع
                {

                    pagename.Text = "صفحة بيع العقارات";

                    txtstatetutorial.Text = "solde";

                    BuSearch.Visible = false;

                    more.Visible = false;

                    button = Request.QueryString["button"];


                    tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];


                    UpdatePanel5.Visible = false;
                  




                    string queryselecttutorials = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke," +
                    "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils,Dateupdat,masad, Serviecother " +
                    "from tutorials where State='" + txtstatetutorial.Text + "' and isactive='false'  and tutorialbrowserid=" + tutorialbrowserid.Text + "   ";


                    dbconnect.openconn();
                    dt.Clear();


                    dt = dbconnect.selectdata(queryselecttutorials);

                    dbconnect.closeconn();

                    if (dt.Rows.Count > 0)
                    {


                        SqlDataSource1.SelectCommand = queryselecttutorials;

                        DataList1.Visible = true;


                        Panel1solde.Visible = false;


                        Button2add.Visible = true;


                        Button1view.Visible = true;

                        Panelfilter.Visible = false;

                        //Panel55.Visible = true;/// لتحميل الصور


                    }
                    else
                    {

                        //Panel55.Visible = false;/// لتحميل الصور


                        Panel1solde.Visible = true;

                        Button2_updatehaveperson.Visible = false;
                    }



                    if (button == "add")
                    {


                        Panel1solde.Visible = true;

                        Button2_updatehaveperson.Visible = false;

                        DataList1.Visible = false;

                        //Panel55.Visible = false;/// لتحميل الصور


                        Button1view.Visible = true;
                        Button2add.Visible = false;

                    }






                    if (button == "view")
                    {


                        SqlDataSource1.SelectCommand = queryselecttutorials;

                        DataList1.Visible = true;


                        Panel1solde.Visible = false;


                        //Panel55.Visible = true;/// لتحميل الصور


                        Button1view.Visible = false;
                        Button2add.Visible = true;

                    }









                     }







                if ((Request.QueryString["state"] == "rice"))    //// صفحة الشراء
                {

                    pagename.Text = "صفحة شراء العقارات";
                    BuSearch.Visible = true;


                    more.Visible = true;

                    if (Request.QueryString["tut"] == "send")
                    {

                        string messegrequest = " عزيزي   ";

                        messegrequest = messegrequest + firstnamewelcom + " " + lastnamewelcom + " " + emialewelocm + " " + "تم تسجيل طلب شراءك لهذا العقار بنجاح سوف يتم التواصل معك قريبا";





                        Literal1.Text = "<strong>" + "</strong> تم  is add successfully."+ messegrequest;
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalSucces();", true);

                    }



                    txtstatetutorial.Text = "solde";

                    stateview = "للبيع";


                    pagstae0.Text = "rice";





        tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];


                    tutorialid.Text = Request.QueryString["tutorialID"];
                    Panel1solde.Visible = false;


                    //Panelfilter.Visible = true;

                    Button1view.Visible = false;
                    Button2add.Visible = false;



                    //Panelfilter.Visible = false;


                    UpdatePanel5.Visible = true;
                   

                    DataList1.Visible = false;


                    Label51.Text = "عقارات للبيع";







                    DropDownList9price11.Enabled = false;   //////   betoween
                    DropDownList5manysearch.Enabled = false;   ////   betoween


                    DropDownList10price22.Enabled = false;   //////   betoween
                    DropDownList5manysearchpow.Enabled = false;   ////   betoween



                    DropDownList5pricbetoweenvie11.Enabled = false;  ///// beteen

                    DropDownList5pricbettoweenview22.Enabled = false; //// betten



                    DropDownList5searchpriceaddmanyview.Enabled = false;  ////  view اقل من
                  
                    DropDownList5priclowfrom.Enabled = false;   //////  اقل من
                    DropDownList5powerlowfrom.Enabled = false;   //// اقل من


                    //   CheckBox1pricfilter.Enabled = false;
                    //  CheckBox1pricfilter.Checked = false;

                    //////////////////////////////////////////////////// تصفير


                    //// tutorialbrowserwinid=" + tutorialbrowserid.Text + "   ////  من اجل ان لا تعرض   GridView1messge

                    if (tutorialbrowserid.Text != "")
                    {

                        namebutton = "اضغط هنا لشراء هذا العقار";  /////  قيم ابتدائية

                        /// tutorialbrowserwinid= "+tutorialbrowserid.Text+" 

                        dbconnect.openconn();

                        string querWIN_tutorials0 = "update  tutorials  set   " +


                             "    namebutton='" + namebutton + "' ,tutorialbrowserwinid=" + tutorialbrowserid.Text + "   where   state='" + txtstatetutorial.Text + "'  ";



                        dbconnect.insertdata(querWIN_tutorials0);

                        dbconnect.closeconn();



                        ////////////////////////////////////////////////////////////
                        ///


                        dbconnect.openconn();

                        string querinsert55showtable = "select Reqtutorialid from requeststate where Reqbowserid=" + tutorialbrowserid.Text + "  " +

                            " and   reqState='" + txtstatetutorial.Text + "'  and browsercommentwin is not null ";

                        dt.Clear();
                        dt = dbconnect.selectdata(querinsert55showtable);

                        dbconnect.closeconn();


                        if (dt.Rows.Count > 0)
                        {


                            namebutton = " تم ارسال طلب شراء هذا العقار";

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                int tutorialID = Convert.ToInt32(dt.Rows[i][0].ToString());   //////   نجلب tutorialid

                                dbconnect.openconn();

                                string querWIN_tutorials = "update  tutorials  set  namebutton='" + namebutton + "' ,tutorialbrowserwinid=" + tutorialbrowserid.Text + " " +


                                     "        where  isactive='testwin' and  tutorialID= " + tutorialID + " and state='" + txtstatetutorial.Text + "'  ";



                                dbconnect.insertdata(querWIN_tutorials);

                                dbconnect.closeconn();
                            }



                        }






                        /////////////////////////////////







                        //////////////////////////

                        int j = 0;
                        dbconnect.openconn();

                        string querinsert55showtable99 = "show tables";

                        dt = dbconnect.selectdata(querinsert55showtable99);

                        dbconnect.closeconn();


                        if (dt.Rows.Count > 0)

                        {

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                if ((dt.Rows[i][0].ToString() == "viewfilter") || (Request.QueryString["tut"] == "send")&&(viewfilterdelete!="ch"))
                                {

                                     j= 1;



                                    SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                                "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state," +

                               " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid,masad,Serviecother  from  tutorials , mybrowser  " +
                                   "  where tutorialbrowserid=browserID  and  isactive in('true','testwin')   and state='solde' and  tutorialID in(select tutorialID from  viewfilter)    order by price desc     ";



                                    DataList2.Visible = true;


                                    DataList3.Visible = false;


                                }






                            }

                        }


                        
                        if((j==0)&&(viewfilterdelete!="ch"))
                        {

                            SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                             "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state," +

                            " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid ,masad,Serviecother from  tutorials , mybrowser  " +
                                "  where tutorialbrowserid=browserID  and  isactive in('true','testwin')   and state='solde'     order by price desc     ";



                            DataList2.Visible = true;


                            DataList3.Visible = false;




                        }




                    }

                    else if ((tutorialbrowserid.Text == "")&&(viewfilterdelete!="ch"))
                    {

                        SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                              "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state," +

                             " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid,masad,Serviecother from  tutorials , mybrowser  " +
                                 "  where tutorialbrowserid=browserID  and  isactive in('true','testwin')   and state='solde'     order by price desc     ";



                        DataList2.Visible = false;


                       

                            DataList3.Visible = true;


                    }









                }






                if ((Request.QueryString["state"] == "take of"))  // صفحة استاجار العقارات
                {

                    pagename.Text = "صفحة استأجار العقارات";

                    BuSearch.Visible = true;


                    more.Visible = true;


                    if (Request.QueryString["tut"] == "send")
                    {


                      string  messegrequest = " عزيزي   ";

                        messegrequest = messegrequest + firstnamewelcom + " " + lastnamewelcom + " " + emialewelocm + " " + "تم تسجيل طلب استاجارك لهذا العقار بنجاح سوف يتم التواصل معك قريبا";




                        Literal1.Text = "<strong>" + "</strong> "+messegrequest+ ""+" is add successfully.";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalSucces();", true);

                    }

                    txtstatetutorial.Text = "take";

                    stateview = "للاجار";




                    pagstae0.Text = "take of";




                    tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];



                    tutorialid.Text = Request.QueryString["tutorialID"];


                    Panel1solde.Visible = false;


                    Button1view.Visible = false;
                    Button2add.Visible = false;


                    // Panelfilter.Visible = true;


                    UpdatePanel5.Visible = true;
                   

                    //  Panelfilter.Visible = false;

                    DataList1.Visible = false;

                    Label51.Text = "عقارات للاجار";




                    DropDownList9price11.Enabled = false;   //////   betoween
                    DropDownList5manysearch.Enabled = false;   ////   betoween


                    DropDownList10price22.Enabled = false;   //////   betoween
                    DropDownList5manysearchpow.Enabled = false;   ////   betoween



                    DropDownList5pricbetoweenvie11.Enabled = false;  ///// beteen

                    DropDownList5pricbettoweenview22.Enabled = false; //// betten



                    DropDownList5searchpriceaddmanyview.Enabled = false;  ////  view اقل من
                    DropDownList5priclowfrom.Enabled = false;   //////  اقل من
                    DropDownList5powerlowfrom.Enabled = false;   //// اقل من



                    // CheckBox1pricfilter.Enabled = false;
                    // CheckBox1pricfilter.Checked = false;





                    ////////////////////////////////////////////////////   تصفير

                    namebutton = "";
                         namebutton = "اضغط هنا لاستاجار هذا العقار";




                    if (tutorialbrowserid.Text != "")
                    {
                        dbconnect.openconn();


                        string querWIN_tutorials0 = "update  tutorials  set  namebutton='" + namebutton + "' , tutorialbrowserwinid=" + tutorialbrowserid.Text + " " +


                                 "        where  isactive='testwin'  and state='" + txtstatetutorial.Text + "'  ";



                        dbconnect.insertdata(querWIN_tutorials0);

                        dbconnect.closeconn();





                        /////////////////////////////////////////


                        dbconnect.openconn();

                        string querinsert55showtable = "select Reqtutorialid from requeststate where Reqbowserid=" + tutorialbrowserid.Text + "  " +

                            " and   reqState='" + txtstatetutorial.Text + "'  and browsercommentwin is not null ";
                        dt.Clear();
                        dt = dbconnect.selectdata(querinsert55showtable);

                        dbconnect.closeconn();


                        if (dt.Rows.Count > 0)

                        {


                            namebutton = "تم ارسال طلب استاجار هذا العقار";

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                int tutorialIDy = Convert.ToInt32(dt.Rows[i][0].ToString());





                                dbconnect.openconn();

                                string querWIN_tutorials1 = "update  tutorials  set  namebutton='" + namebutton + "' ,tutorialbrowserwinid=" + tutorialbrowserid.Text + "  " +


                                         "        where  isactive='testwin' and  tutorialID= " + tutorialIDy + " and state='" + txtstatetutorial.Text + "'  ";



                                dbconnect.insertdata(querWIN_tutorials1);

                                dbconnect.closeconn();

                            }



                        }





                        int j = 0;
                        dbconnect.openconn();

                        string querinsert55showtable99 = "show tables";

                        dt = dbconnect.selectdata(querinsert55showtable99);

                        dbconnect.closeconn();

                       
                        if (dt.Rows.Count > 0)

                        {

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                if ((dt.Rows[i][0].ToString() == "viewfilter") || (Request.QueryString["tut"] == "send")&&(viewfilterdelete!="ch"))
                                {
                                    j = 1;




                                    SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                                "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state," +

                               " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid ,masad,Serviecother from  tutorials , mybrowser  " +
                                   "  where tutorialbrowserid=browserID  and  isactive in('true','testwin')   and state='take' and  tutorialID in(select tutorialID from  viewfilter)    order by price desc     ";



                                    DataList2.Visible = true;


                                    DataList3.Visible = false;

                                }

                            }

                        }





                        if ((j == 0)&&(viewfilterdelete!="ch"))
                        {

                            SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                             "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state," +

                            " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid,masad,Serviecother  from  tutorials , mybrowser  " +
                                "  where tutorialbrowserid=browserID  and  isactive in('true','testwin')   and state='take'     order by price desc     ";



                            DataList2.Visible = true;


                            DataList3.Visible = false;




                        }








                    }


                    else if((tutorialbrowserid.Text=="")&&(viewfilterdelete!="ch"))
                    {



                        SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                            "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state," +

                           " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid,masad,Serviecother from  tutorials , mybrowser  " +
                               "  where tutorialbrowserid=browserID  and  isactive in('true','testwin')   and state='take'     order by price desc     ";



                        DataList2.Visible = false;


                        DataList3.Visible = true;




                    }







                }

















                /////////////////////////////////////////////////////////////////////////end requwsr

                placetutorialee.Text = DropDownList1.SelectedItem + "-" + DropDownList3.SelectedItem + "-" + DropDownList4.SelectedItem;




                ////////////////////////////////////////////////////////////  for search 
                ///  بلد


                //////////////////////////////////////////////اضافة البلد

                string queryselectcountry = "select  distinct country   from tutorialspublic where country is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectcountry);

                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList1.Items.Clear();




                    DropDownList1.Items.Add(new ListItem("", "0"));

                   // DropDownList1.Items.Add(new ListItem("اضافة شي اخر", "1"));


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {


                        DropDownList1.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                    }




                }

                else if (dt.Rows.Count == 0)

                    DropDownList1.Items.Add(new ListItem("لايوجد", "0"));  //  البلد




                ///////////////////////////////// filter by country بحث حسب اللد


                string queryselectcountryfilter = "select distinct country   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive in('true','testwin') " +
                    " and country is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectcountryfilter);

                dbconnect.closeconn();


                if (dt.Rows.Count > 0)
                {


                    CheckBoxlista1country.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        CheckBoxlista1country.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));  /// filter by country


                    }

                }











                /////////////////////////////////////  اضافة المدينة


                // string queryselecity = "select distinct city  from tutorialspublic where city is not null";
                string queryselecity = "select distinct namecitynode   from countrypublic where    namrcountry='" + DropDownList1.SelectedItem.Text + "'     and  namrcountry  is not null";


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselecity);

                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList3.Items.Clear();

                    DropDownList3.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DropDownList3.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                    }

                }
                else if (dt.Rows.Count == 0)

                    DropDownList3.Items.Add(new ListItem("لايوجد", "0"));  //  مدينة








                ///////////////////////////////// filter by city بحث حسب اللد


                string queryselectcityfilter = "select distinct city   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive in('true','testwin') " +
                    " and city is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectcityfilter);


                dbconnect.closeconn();




                if (dt.Rows.Count > 0)
                {


                    CheckBoxlist2city.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        CheckBoxlist2city.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));


                    }

                }







                ///////////////////////////////////////////
                ///  اضافة المنطقة

                // string queryselealmanteka = "select distinct manteka   from tutorialspublic where manteka is not null";
                string queryselealmanteka = "select distinct namemantekanode    from citypublic where  namecity  ='" + DropDownList3.SelectedItem.Text + "'   and namecity  is not null";



                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselealmanteka);

                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList4.Items.Clear();

                    DropDownList4.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DropDownList4.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));



                    }


                }
                else if (dt.Rows.Count == 0)

                    DropDownList4.Items.Add(new ListItem("لايوجد", "0"));  //  منطقة 




                ///////////////////////////////// filter by manteka بحث حسب اللد


                string queryselemnatkafilter = "select distinct manteka   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive in('true','testwin') " +
                    " and manteka is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselemnatkafilter);


                dbconnect.closeconn();



                if (dt.Rows.Count > 0)
                {

                    CheckBoxList1manteka.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        CheckBoxList1manteka.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));


                    }

                }







                ////////////////////////////////////////////////////////////////////////////////    منطقة الفرعية



                //////////////////////////////////////////////////////////////////////////
                ///    تفرعات من المنطقة





                string queryselealmanteka00 = "select distinct namemantekanodenode     from mantekapublic where  namemanteka ='" + DropDownList4.SelectedItem.Text + "'   and namemanteka  is not null";



                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselealmanteka00);



                dbconnect.closeconn();



                DropDownList1mantekanode.Items.Add(new ListItem("حدد منطقة فرعية", "0"));

                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }










                /////////////////////////////////////////////////////////////
                ///   نوع العقار اضافة 




                string queryselettype = "select distinct tutorialType    from tutorialspublic   where tutorialType is not null ";


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselettype);

                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList2.Items.Clear();

                    DropDownList2.Items.Add(new ListItem("", "0"));



                    for (int i = 0; i < dt.Rows.Count; i++)

                    {
                        DropDownList2.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                    }


                }
                else if (dt.Rows.Count == 0)

                    DropDownList2.Items.Add(new ListItem("لايوجد", "0"));  //  نوع



                ///////////////////////////////// filter by type نوع العقار بحث حسب اللد


                string queryseletypefilter = "select distinct tutorialType   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive in('true','testwin') " +
                    " and tutorialType is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryseletypefilter);


                dbconnect.closeconn();



                if (dt.Rows.Count > 0)
                {

                    CheckBoxList1type.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        CheckBoxList1type.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));


                    }

                }





                ///////////////////////////////////////////////////////////////////////////////////////////////search
                ///
                //البحث حسب الثمن    filter




                string queryselectelprice = "select distinct price   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive in('true','testwin')" +

                    " and  price is not null order by price";



              //  dbconnect.openconn();

              //  dt.Clear();

               // dt = dbconnect.selectdata(queryselectelprice);


              //  dbconnect.closeconn();

              //  if (dt.Rows.Count > 0)
               // {
                 //   DropDownList9price11.Items.Clear();
                 //   DropDownList10price22.Items.Clear();

                  //  DropDownList5priclowfrom.Items.Clear();



                   // DropDownList5priclowfrom.Items.Add(new ListItem("", "0"));

                   // DropDownList9price11.Items.Add(new ListItem("", "0"));

                 //   DropDownList10price22.Items.Add(new ListItem("", "0"));

                    //for (int i = 0; i < dt.Rows.Count; i++)
                   // {

                       // DropDownList9price11.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));

                       // DropDownList10price22.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));


                       // DropDownList5priclowfrom.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1))); ////filter  اقل من


                   // }

               // }




                ///////////////////////////////////////////////   العملة



                //////////////////////////////////////////////////////////////////////////// عملة سعر العقار


                string queryselectmany = "select distinct many   from tutorialspublic where many is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectmany);

                dbconnect.closeconn();


                if (dt.Rows.Count > 0)
                {


                    DropDownList5many.Items.Clear();





                    DropDownList5many.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DropDownList5many.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));




                    }


                }

                else if (dt.Rows.Count == 0)

                    DropDownList5many.Items.Add(new ListItem("لايوجد", "0"));  //  عملة






                //////////////////////////////////////////////////////////////////////////////   filtter العملة




               string queryselectmanysearch = "select distinct many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  " +

                        " and  many is not null  ";




               // dbconnect.openconn();
               // dt.Clear();


              //  dt = dbconnect.selectdata(queryselectmanysearch);


               // dbconnect.closeconn();


                //if (dt.Rows.Count > 0)
                ////{


                  //  DropDownList5manysearch.Items.Clear();

                 //   DropDownList5manysearchpow.Items.Clear();

                   // DropDownList5powerlowfrom.Items.Clear();





                   // DropDownList5manysearch.Items.Add(new ListItem("", "0"));
                   // DropDownList5manysearchpow.Items.Add(new ListItem("", "0"));

                   // DropDownList5powerlowfrom.Items.Add(new ListItem("", "0"));
                   // for (int i = 0; i < dt.Rows.Count; i++)
                   // {

                      //  DropDownList5manysearch.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1))); ////filter

                       // DropDownList5manysearchpow.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1))); ////filter  /// 


                       // DropDownList5powerlowfrom.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1))); ////عملة اقل من  



                   // }



                     // }


                ////////////////////////////////////////////////////////////////////// للزبون ////////////////////////////////    اقل من عرض سعر العقار + العملة
                ///



                string queryselectmanyandpricesearchview = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  " +

                        " and  many is not null and  price is not null  ";




                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectmanyandpricesearchview);


                dbconnect.closeconn();


                if (dt.Rows.Count > 0)
                {


                    DropDownList5searchpriceaddmanyview.Items.Clear();

                    string yy = "";
                   // DropDownList5searchpriceaddmanyview.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        yy =  dt.Rows[i][0].ToString()+" " + dt.Rows[i][1].ToString();


                        DropDownList5searchpriceaddmanyview.Items.Add(new ListItem(yy, Convert.ToString(i))); ////عملة اقل من  



                    }








                }




                ////////////////////////////////////////////////////////////////////// للزبون ////////////////////////////////    beteen عرض سعر العقار + العملة
                ///



                string queryselectmanyandpricesearchviewbeteen = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  " +

                        " and  many is not null and  price is not null  ";




                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectmanyandpricesearchviewbeteen);


                dbconnect.closeconn();


                if (dt.Rows.Count > 0)
                {


                    DropDownList5pricbetoweenvie11.Items.Clear();


                    DropDownList5pricbettoweenview22.Items.Clear();

                    string yy = "";
                    // DropDownList5searchpriceaddmanyview.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        yy = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();


                        DropDownList5pricbetoweenvie11.Items.Add(new ListItem(yy, Convert.ToString(i))); ////عملة اقل من  

                        DropDownList5pricbettoweenview22.Items.Add(new ListItem(yy, Convert.ToString(i))); ////عملة اقل من  



                    }








                }







                /////////////////////////////////////////////////////////////////////   end filter by country_ city_manteka_ type_pric



                /////////////////////////////////////////////////////////////////////   end filter by country_ city_manteka_ type_pric




                /////////////////////////////////////////////////////////////
                ///   طابق العقار اضافة 




                string queryselecttabke = "select distinct tabke     from tutorialspublic where tabke is not null";


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselecttabke);

                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList5tabke.Items.Clear();


                    DropDownList5tabke.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList5tabke.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                }

                else if (dt.Rows.Count == 0)

                    DropDownList5tabke.Items.Add(new ListItem("لايوجد", "0"));  //  طابق



                /////////////////////////////////////////////////////////////
                ///   غرف العقار اضافة 




                string queryselectroom = "select distinct room      from tutorialspublic where room is not null";


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselectroom);

                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList6room.Items.Clear();

                    DropDownList6room.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList6room.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));



                }

                else if (dt.Rows.Count == 0)

                    DropDownList6room.Items.Add(new ListItem("لايوجد", "0"));  //  غرف




                /////////////////////////////////////////////////////////////
                ///   فرش العقار اضافة 




                string queryselectalfarch = "select distinct  alfarch       from tutorialspublic where alfarch is not null";


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselectalfarch);

                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDown7alfarch.Items.Clear();

                    DropDown7alfarch.Items.Add(new ListItem("", "0"));


                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDown7alfarch.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                }


                else if (dt.Rows.Count == 0)

                    DropDown7alfarch.Items.Add(new ListItem("لايوجد", "0"));  //  فرش




                /////////////////////////////////////////////////////////////
                ///   كسوة العقار اضافة 




                string queryselectalkasa = "select distinct alkasa        from tutorialspublic where alkasa is not null";


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselectalkasa);
                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList8alkasa.Items.Clear();

                    DropDownList8alkasa.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList8alkasa.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                }

                else if (dt.Rows.Count == 0)

                    DropDownList8alkasa.Items.Add(new ListItem("لايوجد", "0"));  //  كسوة




                /////////////////////////////////////////////////////////////
                ///   الاتجاهات العقار اضافة 




                string queryselectdirction = "select distinct dirction         from tutorialspublic where dirction is not null";


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselectdirction);
                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList5dirction.Items.Clear();

                    DropDownList5dirction.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList5dirction.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                }
                else if (dt.Rows.Count == 0)

                    DropDownList5dirction.Items.Add(new ListItem("لايوجد", "0"));  //  اتجاه


                /////////////////////////////////////////////////////////////
                ///   الملكية العقار اضافة 




                string queryselecthavinge = "select distinct havinge            from tutorialspublic  where havinge is not null";


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselecthavinge);
                dbconnect.closeconn();


                if (dt.Rows.Count > 0)
                {
                    DropDownList5havinge.Items.Clear();
                    DropDownList5havinge.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList5havinge.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));



                }

                else if (dt.Rows.Count == 0)

                    DropDownList5havinge.Items.Add(new ListItem("لايوجد", "0"));  //  ملكية



                /////////////////////////////////////////////////////////////
                ///   الاشارات العقار اضافة 




                string queryselectrefernc = "select distinct refernc             from tutorialspublic where refernc is not null";


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselectrefernc);
                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList5refernc.Items.Clear();


                    DropDownList5refernc.Items.Add(new ListItem("", "0"));


                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList5refernc.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                }

                else if (dt.Rows.Count == 0)

                    DropDownList5refernc.Items.Add(new ListItem("لايوجد", "0"));  //  اشارات



                /////////////////////////////////////////////////////////////
                ///   الكهرباء العقار اضافة 




                string queryselectelectron = "select distinct electron               from tutorialspublic where electron is not null";


                dbconnect.openconn();
                dt.Clear();
                dt = dbconnect.selectdata(queryselectelectron);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList5electron.Items.Clear();

                    DropDownList5electron.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList5electron.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));



                }

                else if (dt.Rows.Count == 0)

                    DropDownList5electron.Items.Add(new ListItem("لايوجد", "0"));  //  كهرباء







                /////////////////////////////////////////////////////////////
                ///   مصعد العقار اضافة 




                string queryselectemasad = "select distinct masad               from tutorialspublic where masad is not null";

                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselectemasad);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList5masad.Items.Clear();


                    DropDownList5masad.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList5masad.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));



                }

                else if (dt.Rows.Count == 0)

                    DropDownList5masad.Items.Add(new ListItem("لايوجد", "0"));  //  مصعد



                ///////////////////////////////////////////////////////////////




                /////////////////////////////////////////////////////////////
                ///   خدمات العقار اضافة 




                string queryselecteservic = "select distinct serviecother               from tutorialspublic where serviecother is not null";

                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselecteservic);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList5service.Items.Clear();


                    DropDownList5service.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList5service.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));



                }

                else if (dt.Rows.Count == 0)

                    DropDownList5service.Items.Add(new ListItem("لايوجد", "0"));  //  خدمات



                ///////////////////////////////////////////////////////////////
























                ////////////////////////////////////////////  العقار //////////////////////////////////
                ///







                if (Request.QueryString["updateimage"] == "updateimage")   //// اضافة صور جديدة للعقار(تعديل للصور العقار) comment
                {

                    tutoriallink.Text = "";

                    tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];

                    //tutorialid.Text = Request.QueryString["tutorialid"];

                    txtstatetutorial.Text = Request.QueryString["statetutorial"];   // حالة الصفحة

                    UpdatePanel5.Visible = false;
                   
                    Button2add.Visible = true;

                    more.Visible = false;


                    if (Request.QueryString["tut"] == "ok")  //نوع الدالة
                    {


                        Literal1.Text = "<strong>" + "</strong> تم تعديل عقارك بنجاح is update successfully.";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalSucces();", true);



                    }



                    if (Request.QueryString["tut"] == "del")  //نوع الدالة
                    {


                        Literal1.Text = "<strong>" + "</strong> تم حذف عقارك بنجاح is update successfully.";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalSucces();", true);



                    }



                    if (Request.QueryString["tut"] == "addimg")  //نوع الدالة
                    {


                        Literal1.Text = "<strong>" + "</strong> تم اضافة صورة لعقارك بنجاح is update successfully.";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalSucces();", true);



                    }






                    if (Request.QueryString["tut"] == "delimg")  //نوع الدالة
                    {


                        Literal1.Text = "<strong>" + "</strong> تم حذف صورة عقارك بنجاح is update successfully.";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalSucces();", true);



                    }



                    // string namestate = "";



                    Literal3.Text = "";



                    dbconnect.openconn();

                    string querinsertimage = "select tutorialID ,State from tutorials where " +
                        "tutorialbrowserid =" + tutorialbrowserid.Text + " and state='" + txtstatetutorial.Text + "' and  isactive ='false'  ";


                    dt.Clear();
                    dt = dbconnect.selectdata(querinsertimage);

                    dbconnect.closeconn();




                    if (dt.Rows.Count > 0)
                    {



                        // TextBox5.Text = dt.Rows.Count + " " + "عدد" + namestate + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;


                        //Panel55.Visible = true;/// لتحميل الصور

                        Panel1solde.Visible = false;

                        Panelfilter.Visible = false;



                        SqlDataSource1.SelectCommand = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke," +
                        "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils,Dateupdat, masad ,  Serviecother " +
                        "from tutorials where State='" + txtstatetutorial.Text + "' and isactive='false'  and tutorialbrowserid=" + tutorialbrowserid.Text + "   ";


                        DataList1.Visible = true;




                    }

                    //   else

                    // TextBox5.Text = dt.Rows.Count + " " + "لايوجد" + namestate + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;



                }














                if (Request.QueryString["adddata"] == "addtutorials")   //// اضافة عقار غرض  comment
                {



                    tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];

                    txtstatetutorial.Text = Request.QueryString["statetutorial"];

                    //  addtutorials();

                    more.Visible = false;


                    Literal1.Text = "<strong>" + "</strong> تم اضافة عقارك بنجاح is add successfully.";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalSucces();", true);



                    Panel1solde.Visible = false;

                    Panelfilter.Visible = false;

                    UpdatePanel5.Visible = false;
                  


                    //Panel55.Visible = true;/// لتحميل الصور



                    SqlDataSource1.SelectCommand = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke," +
                    "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils,Dateupdat,masad,Serviecother " +
                    "from tutorials where State='" + txtstatetutorial.Text + "' and isactive='false'  and tutorialbrowserid=" + tutorialbrowserid.Text + "   ";


                    DataList1.Visible = true;


                    button = Request.QueryString["button"];







                        Button1view.Visible = false;
                        Button2add.Visible = true;

                  


                }









                if (Request.QueryString["updatetutorials"] == "updatetutorials")   //// add+view  موجود سابقا  عرض تعديل العقار comment
                {



                    tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];

                    tutorialid.Text = Request.QueryString["tutorialid"];


                    txtstatetutorial.Text = Request.QueryString["statetutorial"];

                     button= Request.QueryString["button"];


                    more.Visible = false;


                    if (button == "view")
                    {



                        Button1view.Visible = true;
                        Button2add.Visible = false;

                    }





                    UpdatePanel5.Visible = false;
                   

                    DataList1.Visible = false;



                    //Panel55.Visible = false;

                    Panelfilter.Visible = false;

                    BuAddDatabrowser.Visible = false;


                    Panel1solde.Visible = true;

                    BuAddDatabrowser.Visible = false;
                    Button2_updatehaveperson.Visible = true;


                   // if (dt.Rows.Count > 0)

                   // {





                        dbconnect.openconn();

                        string querinsert55updattutorail = "select country,city,manteka,placetutorial," +
                            "tutorialType,tabke,room,alfarch,alkasa,dirction,havinge,refernc,electron,alatlalh,area,price ,tutorialDeatils,many,masad,Serviecother from  tutorials where " +
                            " tutorialID=" + tutorialid.Text + " and  State='" + txtstatetutorial.Text + "' and isactive='false'   ";

                        dt.Clear();
                        dt = dbconnect.selectdata(querinsert55updattutorail);

                        dbconnect.closeconn();

                        // Literal5.Text = tutorialidimage;

                        if (dt.Rows.Count > 0)

                        {




                            // DropDownList1.Items.Add(new ListItem(dt.Rows[0][0].ToString(), "0"));

                            // DropDownList3.Items.Add(new ListItem(dt.Rows[0][1].ToString(), "0"));
                            // DropDownList4.Items.Add(new ListItem(dt.Rows[0][2].ToString(), "0"));



                            DropDownList1.SelectedItem.Text = dt.Rows[0][0].ToString();

                            DropDownList3.SelectedItem.Text = dt.Rows[0][1].ToString();

                            DropDownList4.SelectedItem.Text = dt.Rows[0][2].ToString();



                            string cityupdate3 = dt.Rows[0][1].ToString();
                            string mantekupdate4 = dt.Rows[0][2].ToString();
                            string countryupdate1= dt.Rows[0][0].ToString();


                            TextBox4.Text = dt.Rows[0][3].ToString();



                            placetutorialee.Text = DropDownList1.SelectedItem + "-" + DropDownList3.SelectedItem + "-" + DropDownList4.SelectedItem;



                            //  DropDownList2.Items.Add(new ListItem(dt.Rows[0][4].ToString(), "1"));

                            //  DropDownList5tabke.Items.Add(new ListItem(dt.Rows[0][5].ToString(), "1"));

                            //  DropDownList6room.Items.Add(new ListItem(dt.Rows[0][6].ToString(), "1"));

                            //  DropDown7alfarch.Items.Add(new ListItem(dt.Rows[0][7].ToString(), "1"));

                            //  DropDownList8alkasa.Items.Add(new ListItem(dt.Rows[0][8].ToString(), "1"));

                            //  DropDownList5dirction.Items.Add(new ListItem(dt.Rows[0][9].ToString(), "1"));

                            // DropDownList5havinge.Items.Add(new ListItem(dt.Rows[0][10].ToString(), "1"));

                            // DropDownList5refernc.Items.Add(new ListItem(dt.Rows[0][11].ToString(), "1"));

                            //  DropDownList5electron.Items.Add(new ListItem(dt.Rows[0][12].ToString(), "1"));




                            DropDownList2.SelectedItem.Text = dt.Rows[0][4].ToString();

                            DropDownList5tabke.SelectedItem.Text = dt.Rows[0][5].ToString();

                            DropDownList6room.SelectedItem.Text = dt.Rows[0][6].ToString();


                            DropDown7alfarch.SelectedItem.Text = dt.Rows[0][7].ToString();

                            DropDownList8alkasa.SelectedItem.Text = dt.Rows[0][8].ToString();

                            DropDownList5dirction.SelectedItem.Text = dt.Rows[0][9].ToString();




                            DropDownList5havinge.SelectedItem.Text = dt.Rows[0][10].ToString();

                            DropDownList5refernc.SelectedItem.Text = dt.Rows[0][11].ToString();

                            DropDownList5electron.SelectedItem.Text = dt.Rows[0][12].ToString();








                            TextBox2alatlalh.Text = dt.Rows[0][13].ToString();
                            TextBox2area.Text = dt.Rows[0][14].ToString();
                            price.Text = dt.Rows[0][15].ToString();
                            txtdeatials.Text = dt.Rows[0][16].ToString();


                            //  DropDownList5many.Items.Add(new ListItem(dt.Rows[0][17].ToString()));


                            DropDownList5many.SelectedItem.Text = dt.Rows[0][17].ToString();


                            DropDownList5masad.SelectedItem.Text = dt.Rows[0][18].ToString();

                            DropDownList5service.SelectedItem.Text = dt.Rows[0][19].ToString();



                            ///////////////////////////////////////////////////////////////





                            //////////////////////////////////////////////////////////////////////////  ربط البلد مع المدينة مع المنطقة
                            ///

                            ////////////////////////////////////////////   country



                            //////////////////////////////////////////////اضافة البلد

                            string queryselectcountry1 = "select  distinct country   from tutorialspublic where country is not null  ";



                            dbconnect.openconn();
                            dt.Clear();


                            dt = dbconnect.selectdata(queryselectcountry1);

                            dbconnect.closeconn();

                            if (dt.Rows.Count > 0)
                            {
                                DropDownList1.Items.Clear();




                                DropDownList1.Items.Add(new ListItem(Convert.ToString(countryupdate1), "0"));

                                // DropDownList1.Items.Add(new ListItem("اضافة شي اخر", "1"));


                                for (int i = 0; i < dt.Rows.Count; i++)
                                {


                                    DropDownList1.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                                }




                            }

                            else if (dt.Rows.Count == 0)

                                DropDownList1.Items.Add(new ListItem("لايوجد", "0"));  //  البلد












                            //////////////////////////////city


                            // string queryselecity = "select distinct city  from tutorialspublic where city is not null";

                            string queryselecity44 = "select distinct namecitynode   from countrypublic where    namrcountry='" + DropDownList1.SelectedItem.Text + "'     and  namrcountry  is not null";



                            dbconnect.openconn();

                            dt.Clear();

                            dt = dbconnect.selectdata(queryselecity44);



                            dbconnect.closeconn();
                            DropDownList3.Items.Clear();





                            DropDownList3.Items.Add(new ListItem(Convert.ToString(cityupdate3), "0"));


                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)

                                    DropDownList3.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));

                            }


                            //////////////////////////////////////////////////////////   manteka by city
                            ///



                            string queryselealmanteka001 = "select distinct namemantekanode    from citypublic where  namecity='" + DropDownList3.SelectedItem.Text + "'   and namecity  is not null";



                            dbconnect.openconn();

                            dt.Clear();

                            dt = dbconnect.selectdata(queryselealmanteka001);



                            dbconnect.closeconn();

                            DropDownList4.Items.Clear();


                            DropDownList4.Items.Add(new ListItem(Convert.ToString(mantekupdate4), "0"));

                            if (dt.Rows.Count > 0)
                            {

                                for (int i = 0; i < dt.Rows.Count; i++)


                                    DropDownList4.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                            }


                            //////////////////////////////////////////
                            ///





                            string queryselealmanteka7 = "select distinct namemantekanode    from citypublic where  namecity='" + DropDownList3.SelectedItem.Text + "'   and namecity  is not null";



                            dbconnect.openconn();

                            dt.Clear();

                            dt = dbconnect.selectdata(queryselealmanteka7);



                            dbconnect.closeconn();

                            DropDownList4.Items.Clear();


                            DropDownList4.Items.Add(new ListItem(Convert.ToString(mantekupdate4), "0"));

                            if (dt.Rows.Count > 0)
                            {

                                for (int i = 0; i < dt.Rows.Count; i++)


                                    DropDownList4.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));
                            }






                            string queryselealmanteka11 = "select distinct namemantekanodenode      from mantekapublic where  namemanteka ='" + DropDownList4.SelectedItem.Text + "'   and namemanteka  is not null";



                            dbconnect.openconn();

                            dt.Clear();

                            dt = dbconnect.selectdata(queryselealmanteka11);



                            dbconnect.closeconn();

                            DropDownList1mantekanode.Items.Clear();


                        DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(mantekupdate4), "0"));

                        if (dt.Rows.Count > 0)
                            {

                                for (int i = 0; i < dt.Rows.Count; i++)


                                    DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));
                            }


















                            //////////////////////////////////////////////////////////////////////////










                        }



                   // }




                }





                /////////////////////////
                ///












            } //(!Page.IsPostBack)  





        }//end load pag











        //////////////////////////////////////////////////////////////////    ربط البلد مع المدنية مع المنطقة مع المنطقة الفرعية




        protected void almanteka_SelectedIndexChanged(object sender, EventArgs e)
        {

            string queryselealmanteka = "select distinct namemantekanodenode      from mantekapublic where  namemanteka ='" + DropDownList4.SelectedItem.Text + "'   and namemanteka  is not null";



            dbconnect.openconn();

            dt.Clear();

            dt = dbconnect.selectdata(queryselealmanteka);



            dbconnect.closeconn();


            DropDownList1mantekanode.Items.Clear();

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
            }








        }









        protected void selectcity(object sender, EventArgs e)
        {



            ///////////////////////////////////////////
            ///  اضافة المنطقة

            // string queryselealmanteka = "select distinct manteka   from tutorialspublic where manteka is not null";


            string queryselealmanteka = "select distinct namemantekanode    from citypublic where  namecity='" + DropDownList3.SelectedItem.Text + "'   and namecity  is not null";



            dbconnect.openconn();

            dt.Clear();

            dt = dbconnect.selectdata(queryselealmanteka);



            dbconnect.closeconn();

            DropDownList4.Items.Clear();


            DropDownList4.Items.Add(new ListItem("", "0"));

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    DropDownList4.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));
            }






            string queryselealmanteka11 = "select distinct namemantekanodenode      from mantekapublic where  namemanteka ='" + DropDownList4.SelectedItem.Text + "'   and namemanteka  is not null";



            dbconnect.openconn();

            dt.Clear();

            dt = dbconnect.selectdata(queryselealmanteka11);



            dbconnect.closeconn();

            DropDownList1mantekanode.Items.Clear();


            DropDownList1mantekanode.Items.Add(new ListItem(" لايوجد", "0"));

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
            }





        }






        protected void selectcountry(object sender, EventArgs e)
        {




            //////////////////////////////city


            // string queryselecity = "select distinct city  from tutorialspublic where city is not null";

            string queryselecity = "select distinct namecitynode   from countrypublic where    namrcountry='" + DropDownList1.SelectedItem.Text + "'     and  namrcountry  is not null";



            dbconnect.openconn();

            dt.Clear();

            dt = dbconnect.selectdata(queryselecity);



            dbconnect.closeconn();
            DropDownList3.Items.Clear();





            DropDownList3.Items.Add(new ListItem("", "0"));


            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)

                    DropDownList3.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));

            }


            //////////////////////////////////////////////////////////   manteka by city
            ///



            string queryselealmanteka = "select distinct namemantekanode    from citypublic where  namecity='" + DropDownList3.SelectedItem.Text + "'   and namecity  is not null";



            dbconnect.openconn();

            dt.Clear();

            dt = dbconnect.selectdata(queryselealmanteka);



            dbconnect.closeconn();

            DropDownList4.Items.Clear();


            DropDownList4.Items.Add(new ListItem("", "0"));

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    DropDownList4.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


            }




        }





















        /////////////////////////////////////////////////   ////   فلترة حسب السعر اقل من 
        /// <summary>


        protected void DDLAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {



            string queryselectmanyandpricesearchview = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  " +

                    " and  many is not null and  price is not null  ";




            dbconnect.openconn();
            dt.Clear();


            dt = dbconnect.selectdata(queryselectmanyandpricesearchview);

            

            dbconnect.closeconn();


            if (dt.Rows.Count > 0)
            {


                DropDownList5priclowfrom.Items.Clear();

                DropDownList5powerlowfrom.Items.Clear();



                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (i == Convert.ToUInt16(DropDownList5searchpriceaddmanyview.SelectedValue))

                    {
                        DropDownList5priclowfrom.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(0)));


                        DropDownList5powerlowfrom.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][1]), Convert.ToString(0)));
                    }

                }


            }









        }
        /// <summary>
        /// 
        /// 
        /// 
        /// ////////////////////////////////////////////////////////////////////////////////////////// فلترة حسب السعر   bettowen




        protected void pricbetoeenview11_SelectedIndexChanged(object sender, EventArgs e)
        {



            string queryselectmanyandpricesearchviewbetoeen = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  " +

                    " and  many is not null and  price is not null  ";




            dbconnect.openconn();
            dt.Clear();


            dt = dbconnect.selectdata(queryselectmanyandpricesearchviewbetoeen);



            dbconnect.closeconn();


            if (dt.Rows.Count > 0)
            {


                DropDownList9price11.Items.Clear();

                DropDownList5manysearch.Items.Clear();



                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (i == Convert.ToUInt16(DropDownList5pricbetoweenvie11.SelectedValue))

                    {
                        DropDownList9price11.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(0)));


                        DropDownList5manysearch.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][1]), Convert.ToString(0)));
                    }

                }


            }









        }




        /// <summary>
        /// ///////////
        /// </summary>



        protected void pricbetoeenview22_SelectedIndexChanged(object sender, EventArgs e)
        {



            string queryselectmanyandpricesearchviewbetoeen = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  " +

                    " and  many is not null and  price is not null  ";




            dbconnect.openconn();
            dt.Clear();


            dt = dbconnect.selectdata(queryselectmanyandpricesearchviewbetoeen);



            dbconnect.closeconn();


            if (dt.Rows.Count > 0)
            {


                DropDownList10price22.Items.Clear();

                DropDownList5manysearchpow.Items.Clear();



                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (i == Convert.ToUInt16(DropDownList5pricbettoweenview22.SelectedValue))

                    {
                        DropDownList10price22.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(0)));


                        DropDownList5manysearchpow.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][1]), Convert.ToString(0)));
                    }

                }


            }









        }









        ////////////////////////////////////////////////////////////////////////////////////////end fiter pric (low -bettoeen)

        [WebMethod]

        public static string ee1(string name, string pass)
        {

            return "jjj";

        }


            ///////////////////////////////////////////////////////////////////////////  login

            [WebMethod]

        public static string ee(string name, string pass)
        {
            string browseridee = "";

            Cdbconnect dbconnect = new Cdbconnect();


            DataTable dt = new DataTable();


            string queryselect = "select browserID  from mybrowser where NumberPhone = '" + name + "' and browserpassword = '" + pass + "' and accounttypeID =1   ";

            dbconnect.openconn();
            dt.Clear();
            dt = dbconnect.selectdata(queryselect);

            dbconnect.closeconn();
            // dt = dbconnect.cobject.SelectDataSet("mybrowser", "browserid", "browseremile like '" + username + "' and browserpassword like '" + password + "' ").Tables[0];




            if (dt.Rows.Count > 0)
            {


                browseridee = dt.Rows[0][0].ToString();


                return browseridee ;

                

            }






            string queryselectnull = "select browserID , browserEmile from mybrowser where NumberPhone = '" + name + "' and browserpassword = '" + pass + "'    ";

            dbconnect.openconn();

            dt.Clear();
            dt = dbconnect.selectdata(queryselectnull);
            dbconnect.closeconn();
            // dt = dbconnect.cobject.SelectDataSet("mybrowser", "browserid", "browseremile like '" + username + "' and browserpassword like '" + password + "' ").Tables[0];




            if ((dt.Rows.Count == 0))
            {

                return "not-active";

            }


            /////////////////////////////////////////////////////////////////////  master
            ///



            dbconnect.openconn();


            string queryselectprivate = "select browserID  from mybrowser where NumberPhone = '" + name + "' and browserpassword = '" + pass + "' and accounttypeID = 2   ";


            dt.Clear();
            dt = dbconnect.selectdata(queryselectprivate);
            dbconnect.closeconn();

            // dt = dbconnect.cobject.SelectDataSet("mybrowser", "browserid", "browseremile like '" + username + "' and browserpassword like '" + password + "' ").Tables[0];



            if ((dt != null) && (dt.Rows.Count > 0))
            {




                browseridee = dt.Rows[0][0].ToString();


                return "private";

            }




            //  return "not-active";

            return "error";



        }








        /////////////////////////////////////


        [WebMethod]        //////  اضافة حساب
        public static string eeadd(string namefirst, string namelast, string phone , string pass)

        {

            Cdbconnect dbconnect = new Cdbconnect();




            dbconnect.openconn();

            string querinsert = "insert into mybrowser(browserFirstName,browserLastName,browseremile,NumberPhone,browserpassword,accounttypeID )values('" + namefirst + "' ," +
                  "  '" + namelast + "' , '"+phone+"' ,  '" + phone + "' , '" + pass + "'  ,1   )";





            dbconnect.insertdata(querinsert);


            dbconnect.closeconn();





            return "ok";

        }



        /////////////////////////////////////////////////////
        ///

        [WebMethod]

        public static void Sendcod(string phone, string subject, string body)
        {
            //lonasamerekal199@gmail.com
            //rootlonamnroot123

            //


            //webmaster@alrubaye.com
            //abc3551356

            //lonasamerekal199@gmail.com
            //rootLONAmnroot123

            //files.000webhost.com
            //user name-pass
            //hhyousef99roo000webhostapp
            //abc3551356YOUSEF$


            //github

            //hanan99aa
            ///micrsoft
            ///hanan@yousefroot123.com
            ///rootyousefroot123


            ///azure
            ///web app
            ///hhyousef99roo000webhostapp.azurewebsites.net

            // username 
            //azureuser
            //pass :abc3551356YOUSEF$

            // رمز الهاتف لسوريا:
            //+963


            string smtpAddress = "reeal.kassarint.com";
                int portNumber = 21;
                bool enableSSL = false;

                string emailFrom = "lonasamerekal199@gmail.com";
                string password = "rootlonamnroot123";
                string emailTo = phone;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    // Can set to false, if you are sending pure text.

                    //  mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
                    //  mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);

                    
                    }
                }
          


        }











        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 





        protected void BuviewData_Click(object sender, EventArgs e)  // عرض العقارات الزبون
        {



            Response.Redirect("index.aspx?&state=" + txtstatetutorial.Text + "&button=view" + "&tutorialbrowserid=" + tutorialbrowserid.Text);

        }








        protected void addtutorial_Click(object sender, EventArgs e)  // اضافة العقارات  جديدة عرض نموذجا  لزبون
        {



            Response.Redirect("index.aspx?&state=" + txtstatetutorial.Text + "&button=add" + "&tutorialbrowserid=" + tutorialbrowserid.Text);



        }









        protected void BuAddData_Click(object sender, EventArgs e)    ////// اضافة عقار
            {





            if ((tutorialbrowserid.Text != "") && (txtstatetutorial.Text != "") )
            {


                placee.Text = "الشارع:" + txtstreatname.Text + "-" + "بناء رقم:" + txtnumberbuild.Text;





              string  country = DropDownList1.SelectedItem.Text;  //  البلد

                string city = DropDownList3.SelectedItem.Text; //  المدينة

                string manteka = DropDownList4.SelectedItem.Text +""+ DropDownList1mantekanode.SelectedItem.Text;  //  المنطقة

                //  string placetutor = txtstreatname.Text + "-" + txtnumberbuild.Text;  //  العنوان(رقم الشارع - رقم البناء)


                string tutorialtype = DropDownList2.SelectedItem.Text;  /// نوع العقار(منزل -فيلل)

                string tabake = DropDownList5tabke.SelectedItem.Text;   //   الطابق

                string room = DropDownList6room.SelectedItem.Text; ///      الغرف

                string alfarch = DropDown7alfarch.SelectedItem.Text;  ///    الفرش

                string alkasua = DropDownList8alkasa.SelectedItem.Text;//    الكسوة

                string dirction = DropDownList5dirction.SelectedItem.Text;///   الاتجاه

                string having = DropDownList5havinge.SelectedItem.Text;///    الملكية

                string refernce = DropDownList5refernc.SelectedItem.Text;//  الاشارات

                string electron = DropDownList5electron.SelectedItem.Text;///   الكهربا

                string many = DropDownList5many.SelectedItem.Text;   /// العملة

                string masad = DropDownList5masad.SelectedItem.Text;   /// مصعد

                string service = DropDownList5service.SelectedItem.Text;   /// خدمات البناء






                if ((price.Text != "") && (DropDownList5many.SelectedItem.Text != "") && (DropDownList1.SelectedItem.Text != "") && (DropDownList3.SelectedItem.Text != "") && (DropDownList4.SelectedItem.Text != "")&& (DropDownList2.SelectedItem.Text != ""))
                {




                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addtutoroial();", true);




                    comandshow = TextBox1.Text;


                    if (comandshow == "ok")
                    {



                        string querpower = "select  power from  manypower  where namemany='"+ many + "' ";


                        dbconnect.openconn();

                      dt=  dbconnect.selectdata(querpower);

                        dbconnect.closeconn();


                      int power99=  Convert.ToInt16( dt.Rows[0][0].ToString());


                        double price99 = Convert.ToDouble( price.Text);


                        double yypower = Convert.ToDouble (price99 * Math.Pow(10, power99));

                        Literal8.Text = Convert.ToString(yypower);


                        string querinsert = "insert into  tutorials(country ,city  ,manteka ,placetutorial ," +
                       "tutorialType,tabke,room,alfarch,alkasa,dirction ,havinge,refernc,electron ," +

                     " alatlalh ,area  ,price ,  " +

                                    "tutorialDeatils,state,tutorialbrowserid ,isactive,DateStart,many ,pricpower,masad,Serviecother) " +


                      "values( '" + country + "' , '" + city + "' ,  '" + manteka + "', '" + placee.Text + "' , '" + tutorialtype + "' , '" + tabake + "' , '" + room + "' , '" + alfarch + "' , '" + alkasua + "',  '" + dirction + "' , '" + having + "',  '" + refernce + "' , '" + electron + "' , " +



                    "'" + TextBox2alatlalh.Text + "',  '" + TextBox2area.Text + "' ,  " + price.Text + " ,'" + txtdeatials.Text + "', '" + txtstatetutorial.Text + "', " + tutorialbrowserid.Text + "  ," +

                    " 'false' , '" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "', '" + many + "',"+ yypower + ",'"+ masad+"','"+ service+"' )   ";




                        dbconnect.openconn();

                        dbconnect.insertdata(querinsert);




                        dbconnect.closeconn();


                        Response.Redirect("index.aspx?adddata=" + "addtutorials" + "&tutorialbrowserid=" + tutorialbrowserid.Text + "&statetutorial=" + txtstatetutorial.Text);

                   }

                    else

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "noadd();", true);








                }

                else if ((DropDownList1.SelectedItem.Text == "") || (DropDownList3.SelectedItem.Text == "") || (DropDownList4.SelectedItem.Text == "") || (price.Text == "") ||  (DropDownList5many.SelectedItem.Text == "") || (DropDownList2.SelectedItem.Text == ""))
                {

                    if (DropDownList1.SelectedItem.Text == "")


                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addcountry();", true);

                   // else Literaladdcountry.Text = "";


                    if (DropDownList3.SelectedItem.Text == "")
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addcity();", true);

                   // else Literaladdcity.Text = "";


                    if (DropDownList4.SelectedItem.Text == "")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addplace();", true);
                   // else Literaladdmanteka.Text = "";


                    if (DropDownList5many.SelectedItem.Text == "") 
                        
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addprice();", true);


                  //  else Literaladdmany.Text = "";


                    if ((DropDownList2.SelectedItem.Text == ""))

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addtype();", true);

                 //   else Literaltype.Text = "";


                    if(price.Text=="")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addprice();", true);



                }






            } 


        }




        //////////////////////////////////////////////
        ///



        protected void BuUPDATE_Datahave_Click(object sender, EventArgs e)  // تعديل عقار الزبون
        {

            string namestate = "";

            if (Request.QueryString["updatetutorials"] == "updatetutorials")


            {




                placetutorialee.Text = "الشارع:" + txtstreatname.Text + "-" + "بناء رقم:" + txtnumberbuild.Text;

                string country = DropDownList1.SelectedItem.Text;  //  البلد

                string city = DropDownList3.SelectedItem.Text; //  المدينة

                string manteka = DropDownList4.SelectedItem.Text+""+ DropDownList1mantekanode.SelectedItem.Text;  //  المنطقة

                //  string placetutor = txtstreatname.Text + "-" + txtnumberbuild.Text;  //  العنوان(رقم الشارع - رقم البناء)


                string tutorialtype = DropDownList2.SelectedItem.Text;  /// نوع العقار(منزل -فيلل)

                string tabake = DropDownList5tabke.SelectedItem.Text;   //   الطابق

                string room = DropDownList6room.SelectedItem.Text; ///      الغرف

                string alfarch = DropDown7alfarch.SelectedItem.Text;  ///    الفرش

                string alkasua = DropDownList8alkasa.SelectedItem.Text;//    الكسوة

                string dirction = DropDownList5dirction.SelectedItem.Text;///   الاتجاه

                string having = DropDownList5havinge.SelectedItem.Text;///    الملكية

                string refernce = DropDownList5refernc.SelectedItem.Text;//  الاشارات

                string electron = DropDownList5electron.SelectedItem.Text;///   الكهربا

                string many = DropDownList5many.SelectedItem.Text;  ///  العملة



                string masad = DropDownList5masad.SelectedItem.Text;   /// مصعد

                string service = DropDownList5service.SelectedItem.Text;   /// خدمات البناء











                if ((price.Text != "") && (DropDownList5many.SelectedItem.Text != "") && (DropDownList1.SelectedItem.Text != "") && (DropDownList3.SelectedItem.Text != "") && (DropDownList4.SelectedItem.Text != "") && (DropDownList2.SelectedItem.Text != ""))
                {



                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "updatetutoroial();", true);




                    comandshow = TextBox1.Text;


                    if (comandshow == "ok")
                    {

                        string querpower = "select  power from  manypower  where namemany='" + many + "' ";


                        dbconnect.openconn();

                        dt = dbconnect.selectdata(querpower);

                        dbconnect.closeconn();


                        int power99 = Convert.ToInt16(dt.Rows[0][0].ToString());


                        double price99 = Convert.ToDouble(price.Text);


                        double yypower = Convert.ToDouble(price99 * Math.Pow(10, power99));












                        string querupdate_tutorials = "update  tutorials  set  country='" + country + "' ,city ='" + city + "' ,manteka='" + manteka + "' ,placetutorial='" + placetutorialee.Text + "' ," +
                        "tutorialType='" + tutorialtype + "',tabke='" + tabake + "',room='" + room + "',alfarch='" + alfarch + "',alkasa='" + alkasua + "',dirction='" + dirction + "' ,havinge='" + having + "',refernc='" + refernce + "',electron='" + electron + "' ," +

                        " alatlalh='" + TextBox2alatlalh.Text + "' ,area='" + TextBox2area.Text + "'  ,price=" + price.Text + " , " +

                        "tutorialDeatils='" + txtdeatials.Text + "',Dateupdat ='" + String.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now) + "',many='" + many + "',pricpower="+ yypower + " ,  masad='"+masad+ "' , Serviecother='"+service+"'  " +


                            " where  tutorialID=" + tutorialid.Text + "   and  State='" + txtstatetutorial.Text + "' and isactive='false'    ";




                        dbconnect.openconn();

                        dbconnect.insertdata(querupdate_tutorials);

                        dbconnect.closeconn();

                        /////////////////////////////////////////////////view
                        ///



                        if (txtstatetutorial.Text == "solde")
                        {


                            namestate = "البيع";


                        }



                        if (txtstatetutorial.Text == "take")
                        {

                            namestate = "اجار";
                        }






                        TextBox5.Text = dt.Rows.Count + " " + "عدد" + namestate + " عقارات  : " + " ";

                        TextBox5.Visible = true;






                        //////////////////////////////////////////////////////////


                        Response.Redirect("index.aspx?updateimage=" + "updateimage" + "&tutorialbrowserid=" + tutorialbrowserid.Text + "&tutorialid=" + tutorialid.Text + "&statetutorial=" + txtstatetutorial.Text +"&tut=ok");
                    }

                   


                }



                else if ((DropDownList1.SelectedItem.Text == "") || (DropDownList3.SelectedItem.Text == "") || (DropDownList4.SelectedItem.Text == "") || (price.Text == "") || (DropDownList5many.SelectedItem.Text == "") || (DropDownList2.SelectedItem.Text == ""))
                {

                    if (DropDownList1.SelectedItem.Text == "")


                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addcountry();", true);

                    // else Literaladdcountry.Text = "";


                    if (DropDownList3.SelectedItem.Text == "")
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addcity();", true);

                    // else Literaladdcity.Text = "";


                    if (DropDownList4.SelectedItem.Text == "")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addplace();", true);
                    // else Literaladdmanteka.Text = "";


                    if (DropDownList5many.SelectedItem.Text == "")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addprice();", true);


                    //  else Literaladdmany.Text = "";


                    if ((DropDownList2.SelectedItem.Text == ""))

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addtype();", true);

                    //   else Literaltype.Text = "";


                    if (price.Text == "")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addprice();", true);



                }









                ////////////////////////////////////////////////////////////////////////

            }
           







        }







        /// <summary>
        /// //////////////////////////////////////////////////////  button function
        /// </summary>
        /// 

        ////////////////////////////////////////////////////////////// ارسال طلب شراء او اجار



        protected void send_request(object sender, EventArgs e)    ////// حدث ارسال طلب لعقار العقار
        {



            string messegrequest = "";


            string gostat = "";

            string namebutton2 = "";



            //   txtstatetutorial.Text = Request.QueryString["statetutorial"];


            //  tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];


            //   tutorialid.Text = Request.QueryString["tutorialID"];   //// لذلك نستخدم  للحصور على tutorialid العقار المحدد




            // Label11.Text = mesggbox;

          

            if (((txtstatetutorial.Text == "solde") || (txtstatetutorial.Text == "take"))  && (messegbox.Text=="ok" ) ) ////  صفحة البيع  أو الاستاجار
            {







                dbconnect.openconn();

                string querinsert55okwin = "select namebutton from tutorials where  tutorialID=" + tutorialid.Text + "  " +
                    " and state='" + txtstatetutorial.Text + "'  ";

                dt = dbconnect.selectdata(querinsert55okwin);

                dbconnect.closeconn();


                namebutton = "تم ارسال طلب استاجار هذا العقار";


                namebutton2 = " تم ارسال طلب شراء هذا العقار";

                if ((dt.Rows[0][0].ToString() != namebutton) && (dt.Rows[0][0].ToString() != namebutton2))


                {

                    dbconnect.openconn();

                    string querWIN_tutorials = "update  tutorials  set DateStart ='" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "'  ," +


                         " isactive='testwin' , tutorialbrowserwinid=" + tutorialbrowserid.Text + "     where  tutorialID=" + tutorialid.Text + " and state='" + txtstatetutorial.Text + "'   ";



                    dbconnect.insertdata(querWIN_tutorials);

                    dbconnect.closeconn();




                    ///////////////////////////////////////////////
                    ///


                    dbconnect.openconn();

                    string querinsert55showtmesseg = "select browserfirstName,browserlastName,browseremile from mybrowser where browserID=" + tutorialbrowserid.Text + "  ";

                    dt = dbconnect.selectdata(querinsert55showtmesseg);

                    dbconnect.closeconn();
                    

                    string firstname = dt.Rows[0][0].ToString();
                    string lastname = dt.Rows[0][1].ToString();
                    string emiale = dt.Rows[0][2].ToString();

                    if (txtstatetutorial.Text == "solde")
                    {
                        messegrequest = " عزيزي   ";

                        messegrequest = messegrequest + firstname + " " + lastname + " " + emiale + " " + "تم تسجيل طلب شراءك لهذا العقار بنجاح سوف يتم التواصل معك قريبا";

                    }

                    if (txtstatetutorial.Text == "take")

                    {
                        // messegrequest = " عزيزي الزبون تم تسجيل طلب استأجارك لهذا العقار بنجاح سوف يتم التواصل معك قريبا ";

                        messegrequest = " عزيزي   ";

                        messegrequest = messegrequest + firstname + " " + lastname + " " + emiale + " " + "  تم تسجيل طلب استأجارك لهذا العقار بنجاح سوف يتم التواصل معك قريبا";



                    }


                    dbconnect.openconn();

                    string querWIN_messg = "insert into  requeststate (Reqtutorialid,Reqbowserid,browsercommentwin,reqState) " +

                        " values( " + tutorialid.Text + ", " + tutorialbrowserid.Text + " , '" + messegrequest + "' ,'" + txtstatetutorial.Text + "' )";


                    dbconnect.insertdata(querWIN_messg);

                    dbconnect.closeconn();






                    /////////////////////////////


                    if (txtstatetutorial.Text == "solde")
                        gostat = "rice";
                    if (txtstatetutorial.Text == "take")
                        gostat = "take of";


                    Response.Redirect("index.aspx?state=" + gostat + "&tutorialid=" + tutorialid.Text + "&tutorialbrowserid=" + tutorialbrowserid.Text+"&tut=send");


                }



                //// سوف يظهر نموذج filter ذاته نموذج الاضافة






            }






        }

        /// <summary>
        /// //////////////   //////////////////////////////////////////   حذف العقار الزبون


        protected void delet_tutorial(object sender, EventArgs e)    ////// حدث حذف عقار العقار
        {

            //  tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];



            //  tutorialid.Text = Request.QueryString["id"];


            //  txtstatetutorial.Text = Request.QueryString["statetutorial"];

            if (tutorialid.Text != "")
            {

                dbconnect.openconn();


                string deletetutorial = "delete from  tutorials  where tutorialID =" + tutorialid.Text + "  and State='" + txtstatetutorial.Text + "' and isactive='false'   ";  /// id هو tutorialid للعقار

                ////////   حذف عقار الزبون المحدد ضمن datalist


                dbconnect.insertdata(deletetutorial);



                dbconnect.closeconn();





                Response.Redirect("index.aspx?updateimage=" + "updateimage" + "&tutorialbrowserid=" + tutorialbrowserid.Text + "&tutorialid=" + tutorialid.Text + "&statetutorial=" + txtstatetutorial.Text+"&tut=del");

            }
           
            



        }


        ////////////////////////////////////////  حذف صورة
        ///

        protected void delet_image(object sender, EventArgs e)    ////// حدث حذف صورة العقار
        {



           // tutorialid.Text = Request.QueryString["id"];   ///// id الصورة لعقار الزبون


          //  tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];


            if (tutorialid.Text != "")
            {

                dbconnect.openconn();


                string deletetutorialimage = "delete from  linkimage  where id =" + tutorialid.Text + "    ";  /// tutorialid هو id لصورة

                ////////   حذف عقار الزبون المحدد ضمن datalist


                dbconnect.insertdata(deletetutorialimage);


                dbconnect.closeconn();




                Response.Redirect("index.aspx?updateimage=" + "updateimage" + "&tutorialbrowserid=" + tutorialbrowserid.Text + "&imageid=" + tutorialid.Text + "&statetutorial=" + txtstatetutorial.Text+"&tut=delimg");

            }



        }



        ///////////
        /////////////////////////////////////////////
        /// <summary>   //////   اضافة صور للعقار
        /// 
        /// 
        /// 

        string getstring(int n)
        {
            string str = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
            str = str.Substring(0, str.Length - 2);
            return str;
        }
        /// 
        protected void onload_file(object sender, EventArgs e)    ////// حدث رفع صورة العقار
        {

            //  tutorialid.Text = Request.QueryString["id"];

            // tutorialid.Text = (DataList1.DataKeys[index].ToString());

            //  txtstatetutorial.Text = Request.QueryString["statetutorial"];

            tutorialid.Text = Request.QueryString["id"];

            // tutorialid.Text = (DataList1.DataKeys[index].ToString());

            txtstatetutorial.Text = Request.QueryString["statetutorial"];



            tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];



            // FileUpload1HasFiles = Request.QueryString["FileUploadzz"];
            //FileUpload1HasFiles= FileUpload1.PostedFile.FileName
            tutoriallink.Text = "";

            string patthte;
            string pass = "DF34345";

            // tutoriallink.Text = "";

           if ((FileUpload1.HasFiles) && (tutorialid.Text != ""))
           {
         

                pass = Convert.ToString(Session["adminID"]) + getstring(30);


                patthte = ("/files/" + pass + Path.GetExtension(FileUpload1.PostedFile.FileName));





                FileUpload1.SaveAs(Server.MapPath(patthte));



                tutoriallink.Visible = true;


                tutoriallink.Text = patthte;


                if ((tutoriallink.Text != ""))
                {


                    dbconnect.openconn();


                    string imgadd = "insert into linkimage(Tutoriallinke ,browserlinkid,tutorialslinkid) values( '" + tutoriallink.Text + "' , " + tutorialbrowserid.Text + "," + tutorialid.Text + " )   ";

                    ////////   تم ربط الصور مع عقار الزبون


                    dbconnect.insertdata(imgadd);

                    // Literal4.Text = "kuyyyyyyyyyyyyy";


                    dbconnect.closeconn();




                    SqlDataSource1.SelectCommand = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke," +
                              "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils ,Dateupdat,masad,Serviecother" +
                              "from tutorials where State='" + txtstatetutorial.Text + "' and isactive='false'  and tutorialbrowserid=" + tutorialbrowserid.Text + "   ";

                    DataList1.Visible = true;









                    Response.Redirect("index.aspx?updateimage=" + "updateimage" + "&tutorialbrowserid=" + tutorialbrowserid.Text + "&tutorialid=" + tutorialid.Text + "&statetutorial=" + txtstatetutorial.Text + "&tut=addimg");


                    /// عرض datalist لعقارات الزبون


                }

           }


            else if ((!FileUpload1.HasFiles) && (tutorialid.Text != ""))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notaddimag();", true);

                addimagebutton.Visible = true;

            }
            // {

            //  LiMessage.Text = "<strong>" + "يرجى اختيار صورة اولا للتحميل" + "</strong>  .";

            //  ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalError();", true);



            //  }



        }

        /// 
        /// 
        /// 
        /// 
        /// 
        /// /////////////////////

        protected void repat1deletimag_RowCommand(object sender, RepeaterCommandEventArgs e)  //  حذف صور  موجودة لعقار الزبون
        {

            if (e.CommandName == "deleteimage")   // حذف  صور عقار الزبون
            {


                tutorialid.Text = Request.QueryString["id"];   ///// id الصورة لعقار الزبون


                tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];


                deletimagebutton.Visible = true;

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "imagdelet();", true);



            }





        }






        /// <summary>
        /// ///////////////////////////


       

        protected void GridView2updatedata1_RowCommand(object sender, GridViewCommandEventArgs e)  // تعديل العقار -حذف العقار- اضافة صور للعقار 
        {

            if (e.CommandName == "updatetutorial")   // تعديل عقار الزبون
            {
                // int index = Convert.ToInt32(e.CommandArgument);

                //tutorialid.Text = (GridView2updatedata1.DataKeys[index].ToString());  /// ضمن datalist لانستطيع استخدام هذه التعليمة 

                txtstatetutorial.Text = Request.QueryString["statetutorial"];

                tutorialid.Text = Request.QueryString["id"];   //// لذلك نستخدم  للحصور على tutorialid العقار المحدد

                tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];




                Response.Redirect("index.aspx?updatetutorials=" + "updatetutorials" + "&tutorialid=" + tutorialid.Text + "&tutorialbrowserid=" + tutorialbrowserid.Text + "&statetutorial=" + txtstatetutorial.Text+ "&button=view");

                //// سوف يظهر نموذج التعديل ذاته نموذج الاضافة

            }



            ///////////////////////////////////////////////  
            ///

            if (e.CommandName == "inserteimage")    ///  اضافة صور جديدة للعقار== كتعديل للصور 
            {
                // int index = Convert.ToInt32(e.CommandArgument);

                tutorialid.Text = Request.QueryString["id"];

                // tutorialid.Text = (DataList1.DataKeys[index].ToString());

                txtstatetutorial.Text = Request.QueryString["statetutorial"];



                tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];

                addimagebutton.Visible = true;

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "imageadd();", true);


                /////////////////////////////////////////////upload button
                ///






            }






            if (e.CommandName == "deletetutorial")   //  حذف عقار الزبو
            {


                tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];



                tutorialid.Text = Request.QueryString["id"];


                txtstatetutorial.Text = Request.QueryString["statetutorial"];

                delettuorialbutton.Visible = true;

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tutorialdelet();", true);



            }





            if (e.CommandName == "addtutorial")   //  اضافة عقار جديد
            {


                tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];




                txtstatetutorial.Text = Request.QueryString["statetutorial"];


                DataList1.Visible = false;



                //Panel55.Visible = false;/// لتحميل الصور

                if (tutorialbrowserid.Text != "")
                {



                    Panel1solde.Visible = true;

                    BuAddDatabrowser.Visible = true;  /// اضافة هقار

                    Button2_updatehaveperson.Visible = false;  // تعديل عقار



                  



                }




            }






        }


        ////////////////////////////////////////////////  testwin طلب شراء او استاجار  للعقارات المعروضة من قبل master(isa = true)
        ///








        protected void GridView2win_RowCommand(object sender, GridViewCommandEventArgs e)  //    mydashoard
        {
           



            if (e.CommandName == "wintutorial")   //   
            {

                // int index = Convert.ToInt32(e.CommandArgument);

                //tutorialid.Text = (GridView2updatedata1.DataKeys[index].ToString());  /// ضمن datalist لانستطيع استخدام هذه التعليمة 

                txtstatetutorial.Text = Request.QueryString["statetutorial"];


                tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];


                tutorialid.Text = Request.QueryString["tutorialID"];   //// لذلك نستخدم  للحصور على tutorialid العقار المحدد

                //tutorialid.Text = Label8tutorialid.Text;


                // DataList1.DataKeys[index]

                


              messegbox.Text = Request.QueryString["messg"];   //// لذلك نستخدم  للحصور على tutorialid العقار المحدد



                dbconnect.openconn();

                string querinsert55okwin = "select namebutton from tutorials where  tutorialID=" + tutorialid.Text + "  " +
                    " and state='" + txtstatetutorial.Text + "'  ";

                dt = dbconnect.selectdata(querinsert55okwin);

                dbconnect.closeconn();


              string  namebutton = "تم ارسال طلب استاجار هذا العقار";


              string  namebutton2 = " تم ارسال طلب شراء هذا العقار";

                if ((dt.Rows[0][0].ToString() != namebutton) && (dt.Rows[0][0].ToString() != namebutton2))
                {

                    sendrequset.Visible = true;

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showmessok();", true);

                }

                else if ((dt.Rows[0][0].ToString() == namebutton) || (dt.Rows[0][0].ToString() == namebutton2))
                {
                    Literal1.Text = "<strong>" + "</strong>  هذا الطلب مرسل سابقا.";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalSucces();", true);


                }

                //////////////////////////////////////////////////////////////


                ///////////////////////////////////////  


            }

        }



           
        














        /// <summary>
        /// //////////////////////////////////   filtera  ذاته بالحساب mydashoard لان البحث حسب isactive =true فقط 

        protected void BuSearch_Click(object sender, EventArgs e)
        {


            viewfilterdelete = "ch";



            string tts = null;

            string ttsprice1 = null;

            string ttsprice2 = null;

            string ttmanypower1 = null;

            string ttmanypower2 = null;

            //  string ss = null;
            //  string[] ff = null;
            string ssall = null;

            int i;
            // int j = 1;

           
            dbconnect.openconn();

            string querinsert55showtable = "show tables";

            dt = dbconnect.selectdata(querinsert55showtable);

            dbconnect.closeconn();


            if (dt.Rows.Count > 0)

            {

                for (i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i][0].ToString() == "filtercountry")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();



                        dbconnect.openconn();

                        string querinsert55showtabledrop = "drop table filtercountry ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }

                    ///////////////////////////////////////////////////filter city filtercity

                    if (dt.Rows[i][0].ToString() == "filtercity")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();


                        dbconnect.openconn();

                        string querinsert55showtabledrop = "drop table filtercity ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }



                    ////////////////////////////////////////////////////////////////// filtermanteka


                    if (dt.Rows[i][0].ToString() == "filtermanteka")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();


                        dbconnect.openconn();

                        string querinsert55showtabledrop = "drop table filtermanteka ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }



                    //////////////////////////////////////////////////////////////////////////////  filtertype


                    if (dt.Rows[i][0].ToString() == "filtertype")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();


                        dbconnect.openconn();

                        string querinsert55showtabledrop = "drop table filtertype ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }

                    ///////////////////////////////////////////////////////  filterprice//////////////////////



                    if (dt.Rows[i][0].ToString() == "filterprice")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();


                        dbconnect.openconn();

                        string querinsert55showtabledrop = "drop table filterprice ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }




                    ///////////////////////////////////////////////////////  filterpricelow;//////////////////////



                    if (dt.Rows[i][0].ToString() == "filterpricelow")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();


                        dbconnect.openconn();

                        string querinsert55showtabledrop = "drop table filterpricelow ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }


                    ///////////////////////////////////////////  viewfilter  //////////////////
                    ///








                    if (dt.Rows[i][0].ToString() == "viewfilter")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();



                        dbconnect.openconn();
                        string querinsert55showtabledrop = "drop view viewfilter ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }





                    ////////////////////////////// end viewfilter//////////////////////////








                    //////////////////////////////////////////// end filterprice ///////////////////////////////

                }


            }



            //////////////////////////////////////////////////////////////////////////////////////////////////////


            //// isactive in('true','testwin')   true : تكون مدخلة من master , teswin: هي مرحلة اختيار للاtrue  يعني true=testwin هي ذاتها و وهي حجز true
            ///
            //   testwin هي حجز للtrue

            ///////////////////////////////////////////////////////////////////////////   filter countery
            i = 0;



            foreach (ListItem item in CheckBoxlista1country.Items)
            {
                //  ss = "ss";


                //  ColoumnParam[] Coloumns = new ColoumnParam[j];


                if (item.Selected)
                {

                    tts = item.Text;

                    // Items.Add(new ListItem(item.Text,item.Value));


                    // ColoumnParam[] Coloumns = new ColoumnParam[i];



                    //Coloumns[i] = new ColoumnParam("country", ColoumnType.NVarChar, item.Text);





                    //  tts[i] = dt.DataSet(item.Text);
                    //  dt =  item.Text;

                    // ListBox1.Items.Add(new ListItem(tts,"0")) ;

                    // ttsb[i] = ListBox1.Items[i].ToString();


                    //  DataList2.Visible = true;

                    // SqlDataSource22.ConnectionString = "<%$ ConnectionStrings:odb99ConnectionString %>";

                    // item.Enabled = false;

                    //  ss = ss+item.Value;  // اسم المنظر
                    // Literal6.Text = ss;

                    // ff[i] = ss;




                    //  SqlDataSource22.SelectCommand = "select distinct  tutorialID,tutorialType,price,country,city,placetutorial," +
                    //         "manteka,area,alatlalh,tabke,havinge,refernc,room ,alfarch,alkasa from  sscountry   ";


                    // Literal6.Text = Coloumns[i].ColoumnsData.ToString() ;



                    if (i == 0)
                    {


                        dbconnect.openconn();

                        string querinsert55table = "create table filtercountry ( tutorialID  int )";


                        dbconnect.selectdata(querinsert55table);
                        dbconnect.closeconn();

                        // Literal9filtercountry.Text = "filtercountry";





                        dbconnect.openconn();

                        string querinsert55 = "insert into filtercountry  ( select  tutorialID  from tutorials where State='" + txtstatetutorial.Text + "' " +
                           "and isactive in('true','testwin') and country =  '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();

                    }



                    i = i + 1;

                    if (i > 1)
                    {


                        dbconnect.openconn();

                        string querinsert55 = "insert into filtercountry  ( select  tutorialID from tutorials where State='" + txtstatetutorial.Text + "' " +
                           "and isactive in('true','testwin') and country =  '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();


                    }




                    //  ss = ss+Coloumns[i].ColoumnsData.ToString();





                    // string rr= tts[i].ToString();



                    //  Literal6.Text = rr;


                    // j = j + 1;


                    //  Literal6.Text = Convert.ToString(j);





                }

                //dbconnect.openconn();/

                // string querinsert55 = "create view "+ss+ " as ( select  tutorialID,tutorialType,price,country,city,placetutorial," +
                //         "manteka,area,alatlalh,tabke,havinge,refernc,room ,alfarch,alkasa,state as state"+i+" from tutorials where State='solde' " +
                //       "and isactive='true' and country like  '%" + tts + "%'  )  ";

                // dbconnect.selectdata(querinsert55);
                //   dbconnect.closeconn();

                // if (i == 1)

                //    ssall = ss;

                // else if (i > 1)




                // ssall = ssall + "  " + "INNER JOIN" + "  " + ss + "  " + "on"+ "  " +"state"+ Convert.ToString(i-1) + "="+"state"+Convert.ToString(i);


            }


            ///////////////////////////           //////////////////////////////////////////////////// filter city




            i = 0;

            foreach (ListItem item in CheckBoxlist2city.Items)
            {


                if (item.Selected)
                {

                    tts = item.Text;




                    if (i == 0)
                    {


                        dbconnect.openconn();

                        string querinsert55table = "create table filtercity ( tutorialID  int )";

                        dbconnect.selectdata(querinsert55table);
                        dbconnect.closeconn();

                        // Literal9filtercity.Text = "filtercity";

                        dbconnect.openconn();

                        string querinsert55 = "insert into filtercity  ( select  tutorialID  from tutorials where State='" + txtstatetutorial.Text + "' " +
                           "and isactive in('true','testwin') and city =  '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();

                    }



                    i = i + 1;

                    if (i > 1)
                    {


                        dbconnect.openconn();

                        string querinsert55 = "insert into filtercity  ( select  tutorialID  from tutorials where State='" + txtstatetutorial.Text + "' " +
                           "and isactive in('true','testwin') and city =  '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();


                    }





                }
            }



            //////////////////////////////////////////////          end filter city      ////////////////////////////////////////////////////////
            ///


            ///////////////////////////////////////// filtermanteka  CheckBoxList1manteka





            i = 0;

            foreach (ListItem item in CheckBoxList1manteka.Items)
            {


                if (item.Selected)
                {

                    tts = item.Text;




                    if (i == 0)
                    {


                        dbconnect.openconn();

                        string querinsert55table = "create table filtermanteka ( tutorialID  int )";

                        dbconnect.selectdata(querinsert55table);
                        dbconnect.closeconn();

                        //  Literal9filtermanteka.Text = "filtermanteka";

                        dbconnect.openconn();

                        string querinsert55 = "insert into filtermanteka  ( select  tutorialID  from tutorials where State='" + txtstatetutorial.Text + "' " +
                           "and isactive in('true','testwin')  and manteka = '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();

                    }



                    i = i + 1;

                    if (i > 1)
                    {


                        dbconnect.openconn();

                        string querinsert55 = "insert into filtermanteka  ( select  tutorialID  from tutorials where State='" + txtstatetutorial.Text + "' " +
                           "and isactive in('true','testwin')  and manteka =  '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();


                    }





                }
            }



            //////////////////////////////////////////////      end  filtermanteka         ////////////////////////////////////////////////////////



            ////////////////////////////////////////////////  CheckBoxList1type    ////////////////////////////////////////////



            i = 0;

            foreach (ListItem item in CheckBoxList1type.Items)
            {


                if (item.Selected)
                {

                    tts = item.Text;




                    if (i == 0)
                    {


                        dbconnect.openconn();

                        string querinsert55table = "create table filtertype ( tutorialID  int )";

                        dbconnect.selectdata(querinsert55table);
                        dbconnect.closeconn();

                        //Literal9filtertype.Text = "filtertype";

                        dbconnect.openconn();

                        string querinsert55 = "insert into filtertype  ( select  tutorialID  from tutorials where State='" + txtstatetutorial.Text + "' " +

                           "and isactive in('true','testwin')  and tutorialType = '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();

                    }



                    i = i + 1;

                    if (i > 1)
                    {


                        dbconnect.openconn();

                        string querinsert55 = "insert into filtertype  ( select  tutorialID  from tutorials where State='" + txtstatetutorial.Text + "'  " +

                           "and isactive in('true','testwin')  and tutorialType =  '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();


                    }


                    //


                }
            }






            /////////////////////////////////////////////  end filter type//////////////////////////////////



            /////////////////////////////////////////  price ////////////////////////////////////////DropDownList9price1  between  DropDownList10price2

                    /////////////////////////////// price betoween //////////////////////////////////////////////////
                    ///

            i = 0;

            // foreach (ListItem item in CheckBoxList1type.Items)
            // {



          //  if ((CheckBox1pricfilter.Checked == true))

          //  {




              if((DropDownList5pricbetoweenvie11.Enabled==true)&&(DropDownList5pricbettoweenview22.Enabled==true))
                {



                 //  if ((DropDownList9price11.SelectedItem.Text != "") && (DropDownList5manysearch.SelectedItem.Text != "") && (DropDownList10price22.SelectedItem.Text != "") && (DropDownList5manysearchpow.SelectedItem.Text != ""))
                 //   { 


                    ttsprice1 = DropDownList9price11.SelectedItem.Text;


                    ttmanypower1 = DropDownList5manysearch.SelectedItem.Text;

                    string querpower = "select  power from  manypower  where namemany='" + ttmanypower1 + "' ";


                    dbconnect.openconn();

                    dt = dbconnect.selectdata(querpower);

                    dbconnect.closeconn();


                    int power99 = Convert.ToInt16(dt.Rows[0][0].ToString());


                    double price99 = Convert.ToDouble(ttsprice1);


                    double yypower = Convert.ToDouble(price99 * Math.Pow(10, power99));



                    ////////////////////////////////////////////////////////////



                    ttsprice2 = DropDownList10price22.SelectedItem.Text;

                    ttmanypower2 = DropDownList5manysearchpow.SelectedItem.Text;





                    string querpower2 = "select  power from  manypower  where namemany='" + ttmanypower2 + "' ";


                    dbconnect.openconn();

                    dt = dbconnect.selectdata(querpower2);

                    dbconnect.closeconn();


                    int power9922 = Convert.ToInt16(dt.Rows[0][0].ToString());


                    double price9922 = Convert.ToDouble(ttsprice2);


                    double yypower22 = Convert.ToDouble(price9922 * Math.Pow(10, power9922));










                    //if (i == 0)
                    // {


                    dbconnect.openconn();

                    string querinsert55table = "create table filterprice ( tutorialID  int)";


                    //  , tutorialType nvarchar(100) null ,price float null," +

                    //     "country  nvarchar(100) null ,city nvarchar(100) null ,placetutorial nvarchar (1000) null," +

                    //    "manteka  nvarchar(100) null ,area  nvarchar(500) null,alatlalh nvarchar(500) null,tabke nvarchar(1000) null," +

                    //    "havinge nvarchar(100)null,refernc nvarchar(100) null,room nvarchar(100) null ," +

                    //    "alfarch  nvarchar(100) null ,alkasa nvarchar(100) null )";



                    dbconnect.selectdata(querinsert55table);
                    dbconnect.closeconn();

                    // Literal9filterprice.Text = "filterprice";

                    dbconnect.openconn();

                    string querinsert55 = "insert into filterprice  ( select  tutorialID from tutorials where State='" + txtstatetutorial.Text + "' " +

                       "and isactive in('true','testwin')    and pricpower >=" + yypower + " and pricpower <=" + yypower22 + "    order by price   )  ";

                    dbconnect.selectdata(querinsert55);
                    dbconnect.closeconn();


                    Literal9filterprice.Text = yypower + " " + yypower22 + " " + "=>x>=" + " ";


                    //, tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke,havinge,refernc,room ,alfarch,alkasa

                    //}



                    //i = i + 1;

                    // if (i > 1)
                    // {


                    // dbconnect.openconn();

                    //  string querinsert55 = "insert into filterprice  ( select  tutorialID , tutorialType,price,country,city,placetutorial," +
                    //      "manteka,area,alatlalh,tabke,havinge,refernc,room ,alfarch,alkasa from tutorials where State='solde' " +
                    //     "and isactive='true' and price like  '%" + tts + "%'  )  ";

                    //  dbconnect.selectdata(querinsert55);
                    //  dbconnect.closeconn();


                  // }




                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////price low اقل من


                if ((DropDownList5searchpriceaddmanyview.Enabled==true))
                {

                  // if ((DropDownList5priclowfrom.SelectedItem.Text != "") && (DropDownList5powerlowfrom.SelectedItem.Text != ""))
                  //{




                    string ttsprice1low = DropDownList5priclowfrom.SelectedItem.Text;


                    string ttmanypower1low = DropDownList5powerlowfrom.SelectedItem.Text;


                    string querpowerlow = "select  power from  manypower  where namemany='" + ttmanypower1low + "' ";


                    dbconnect.openconn();

                    dt = dbconnect.selectdata(querpowerlow);

                    dbconnect.closeconn();


                    int power99low = Convert.ToInt16(dt.Rows[0][0].ToString());


                    double price99low = Convert.ToDouble(ttsprice1low);


                    double yypowerlow = Convert.ToDouble(price99low * Math.Pow(10, power99low));



                    ////////////////////////////////////////////////////////////




                    dbconnect.openconn();

                    string querinsert55tablelow = "create table filterpricelow ( tutorialID  int)";



                    dbconnect.selectdata(querinsert55tablelow);
                    dbconnect.closeconn();

                    // Literal9filterprice.Text = "filterprice";

                    dbconnect.openconn();

                    string querinsert55low = "insert into filterpricelow  ( select  tutorialID from tutorials where State='" + txtstatetutorial.Text + "' " +

                       "and isactive in('true','testwin')     and pricpower <=" + yypowerlow + "    order by price   )  ";

                    dbconnect.selectdata(querinsert55low);
                    dbconnect.closeconn();









                //  }



                }


           // }

            ////////////////////////////////////  end price ///////////////////////////






            ///////////////////////////////////////////////////////////////////////////////////////// end filter 
            ///
            /// 
            /// 
            ///

            //  ColoumnParam[] Coloumns = new ColoumnParam[6];

            ssall = "";

            dbconnect.openconn();

            string querinsert55showtable2 = "show tables";

            dt = dbconnect.selectdata(querinsert55showtable2);

            if (dt.Rows.Count > 0)

            {
                ssall = "tutorials" + " ";

                for (i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i][0].ToString() == "filtercountry")

                    {

                        //Coloumns[1] = new ColoumnParam("country", ColoumnType.NVarChar, dt.Rows[i][0].ToString());

                        ssall = ssall + " " + "INNER JOIN   filtercountry  on  tutorials.tutorialID=filtercountry.tutorialID";

                    }

                    if (dt.Rows[i][0].ToString() == "filtercity")
                    {


                        // Coloumns[2] = new ColoumnParam("city", ColoumnType.NVarChar, dt.Rows[i][0].ToString());


                        ssall = ssall + " " + "INNER JOIN   filtercity  on   tutorials.tutorialID=filtercity.tutorialID";



                    }



                    if (dt.Rows[i][0].ToString() == "filtermanteka")
                    {


                        // Coloumns[3] = new ColoumnParam("manteka", ColoumnType.NVarChar, dt.Rows[i][0].ToString());
                        ssall = ssall + " " + "INNER JOIN   filtermanteka  on  tutorials.tutorialID=filtermanteka.tutorialID";



                    }


                    if (dt.Rows[i][0].ToString() == "filtertype")
                    {


                        //Coloumns[4] = new ColoumnParam("type", ColoumnType.NVarChar, dt.Rows[i][0].ToString());
                        ssall = ssall + " " + "INNER JOIN   filtertype  on   tutorials.tutorialID=filtertype.tutorialID";



                    }



                    if (dt.Rows[i][0].ToString() == "filterprice")  /////  price betoween
                    {


                        // Coloumns[5] = new ColoumnParam("price", ColoumnType.NVarChar, dt.Rows[i][0].ToString());

                        ssall = ssall + "  " + " INNER JOIN filterprice  on tutorials.tutorialID=filterprice.tutorialID";


                    }




                    if (dt.Rows[i][0].ToString() == "filterpricelow")   /////////  price low اقل من 
                    {


                        // Coloumns[5] = new ColoumnParam("price", ColoumnType.NVarChar, dt.Rows[i][0].ToString());

                        ssall = ssall + "  " + " INNER JOIN filterpricelow  on tutorials.tutorialID=filterpricelow.tutorialID";


                    }




                }

            }


            /////////////////////////////////////////////////////////
            ///    جلب بيانات مالك العقار(الزبون)ا   


              Literal6.Text = ssall;

            if ((ssall != "") && (ssall != "tutorials" + " "))
            {

                dbconnect.openconn();

                string querinsert55createview = " create view viewfilter as (select tutorials.tutorialID, tutorials.tutorialType, tutorials.price, tutorials.country," +
                    " tutorials.city, tutorials.placetutorial," +

                              "tutorials.manteka,tutorials.area,tutorials.alatlalh,tutorials.tabke,tutorials.havinge,tutorials.refernc,tutorials.room ," +

                              "tutorials.alfarch,tutorials.alkasa,tutorials.dirction , tutorials.electron ,tutorials.DateStart ,tutorials.tutorialbrowserid,tutorials.many," +

                              "tutorials.state ,tutorials.tutorialbrowserwinid,tutorials.masad, tutorials.Serviecother " +

                              "    from" +

                              "    " + ssall + "   where State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  ) ";


                ///  استخدمنا  INNER JOIN  لدمج الجدوال اول تقاطع ما بين جدوال من خلال معرف


                //  اما استخدامنا where يكون مفق الربط بالمفاتح الاجبني حصرا

                dbconnect.selectdata(querinsert55createview);


                dbconnect.closeconn();





                if  (txtstatetutorial.Text == "solde")

                    stateview = "للبيع";

                if  (txtstatetutorial.Text == "take")

                    stateview = "للاجار";



                // Literal6.Text = ssall;



                SqlDataSource22.SelectCommand = " select  * from  viewfilter   ";


           




                if (tutorialbrowserid.Text != "")
                {

                    DataList2.Visible = true;


                    DataList3.Visible = false;

                }
                else if (tutorialbrowserid.Text == "")
                {

                    DataList2.Visible = false;


                    DataList3.Visible = true;



                }




                DropDownList5searchpriceaddmanyview.Enabled = false;  ////  view اقل من
                DropDownList5priclowfrom.Enabled = false;   //////  اقل من
                DropDownList5powerlowfrom.Enabled = false;   //// اقل من


                ////////////////bettoen ////////////
                ///



                DropDownList9price11.Enabled = false;   //////   betoween
                DropDownList5manysearch.Enabled = false;   ////   betoween


                DropDownList10price22.Enabled = false;   //////   betoween
                DropDownList5manysearchpow.Enabled = false;   ////   betoween



                DropDownList5pricbetoweenvie11.Enabled = false;

                DropDownList5pricbettoweenview22.Enabled = false;


                Button1filtterpriclow.Text = "تفعيل اقل من";

                Button2filterprice.Text = "تفعيل bettwen";


                /////  messeg للزبون

                // SqlDataSource2messege.SelectCommand = "SELECT  browsercomment from mybrowser, tutorials  WHERE browserID =" + tutorialbrowserid.Text + " " +
                ///    "and  State='" + txtstatetutorial.Text + "' and isactive in('testwin')  ";






                // select tutorialID from tutorials where tutorialID =?



            }
            else

                Literal6.Text = "لاتوجد نتائج للبحث ";






          //  DropDownList9price11.Enabled = false;
          //  DropDownList10price22.Enabled = false;
          //  DropDownList5manysearch.Enabled = false;

          //  DropDownList5manysearchpow.Enabled = false;

          //  DropDownList5priclowfrom.Enabled = false;   //////  اقل من
          //  DropDownList5powerlowfrom.Enabled = false;   //// اقل من



          //  Button2filterprice.Text = "اضغط لتفعيل البحث السعر";


          //  CheckBox1pricfilter.Enabled = false;
          //  CheckBox1pricfilter.Checked = false;


          //  Literal9filterprice.Visible = false;




        }


        protected void BuSearch0_Click(object sender, EventArgs e)
        {
        }



        protected void Button2filterprice0_Click(object sender, EventArgs e)
        {
        }


        protected void Button2filterprice_Click(object sender, EventArgs e)
        {


            //////////////////////////////////////////////////////////////////////////////  السعر bettown


            if ((DropDownList5pricbetoweenvie11.Enabled == true) && (DropDownList5pricbettoweenview22.Enabled == true))
            {




                // if (DropDownList9price11.Enabled == true)
                {
                    //    DropDownList9price11.Enabled = false;
                    //    DropDownList10price22.Enabled = false;
                    //    DropDownList5manysearch.Enabled = false;

                    //   DropDownList5manysearchpow.Enabled = false;


                    DropDownList9price11.Enabled = false;   //////   betoween
                    DropDownList5manysearch.Enabled = false;   ////   betoween


                    DropDownList10price22.Enabled = false;   //////   betoween
                    DropDownList5manysearchpow.Enabled = false;   ////   betoween



                    DropDownList5pricbetoweenvie11.Enabled = false;

                    DropDownList5pricbettoweenview22.Enabled = false;



                    Button2filterprice.Text = "تفعيل bettwen";


                 



                    //   CheckBox1pricfilter.Enabled = false;


                }


            }





            /// ////////////////////////////////////////////////////////////////////////////////////////// فلترة حسب السعر   bettowen


            else if ((DropDownList5pricbetoweenvie11.Enabled == false) && (DropDownList5pricbettoweenview22.Enabled == false))
            {

                string queryselectelprice = "select distinct price   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive in('true','testwin')" +

                        " and  price is not null order by price";

                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselectelprice);
                dbconnect.closeconn();



                if (dt.Rows.Count > 0)
                {

                    //CheckBox1pricfilter.Checked = true;

                    //CheckBox1pricfilter.Enabled = false;


                    Button2filterprice.Text = "الغاء تفعيل bettwen";


                    DropDownList9price11.Enabled = true;   //////   betoween
                    DropDownList5manysearch.Enabled = true;   ////   betoween


                    DropDownList10price22.Enabled = true;   //////   betoween
                    DropDownList5manysearchpow.Enabled = true;   ////   betoween



                    DropDownList5pricbetoweenvie11.Enabled = true;

                    DropDownList5pricbettoweenview22.Enabled = true;






                    ///////////////////////////////////////////

                    string queryselectmanyandpricesearchviewbetoeen = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  " +

                        " and  many is not null and  price is not null  ";




                    dbconnect.openconn();
                    dt.Clear();


                    dt = dbconnect.selectdata(queryselectmanyandpricesearchviewbetoeen);



                    dbconnect.closeconn();


                    if (dt.Rows.Count > 0)
                    {


                        DropDownList9price11.Items.Clear();

                        DropDownList5manysearch.Items.Clear();



                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            if (i == Convert.ToUInt16(DropDownList5pricbetoweenvie11.SelectedValue))

                            {
                                DropDownList9price11.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(0)));


                                DropDownList5manysearch.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][1]), Convert.ToString(0)));
                            }

                        }


                    }




                    /// <summary>
                    /// ///////////
                    /// </summary>




                    string queryselectmanyandpricesearchviewbetoeen22 = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  " +

                            " and  many is not null and  price is not null  ";




                    dbconnect.openconn();
                    dt.Clear();


                    dt = dbconnect.selectdata(queryselectmanyandpricesearchviewbetoeen22);



                    dbconnect.closeconn();


                    if (dt.Rows.Count > 0)
                    {


                        DropDownList10price22.Items.Clear();

                        DropDownList5manysearchpow.Items.Clear();



                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            if (i == Convert.ToUInt16(DropDownList5pricbettoweenview22.SelectedValue))

                            {
                                DropDownList10price22.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(0)));


                                DropDownList5manysearchpow.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][1]), Convert.ToString(0)));
                            }

                        }


                    }





                    else if (dt.Rows.Count == 0)
                    {

                        DropDownList9price11.Enabled = false;   //////   betoween
                        DropDownList5manysearch.Enabled = false;   ////   betoween


                        DropDownList10price22.Enabled = false;   //////   betoween
                        DropDownList5manysearchpow.Enabled = false;   ////   betoween



                        DropDownList5pricbetoweenvie11.Enabled = false;

                        DropDownList5pricbettoweenview22.Enabled = false;



                        Button2filterprice.Text = "الغاء تفعيل between";



                    }







                }



            }









            ////////////////////////////////////////////////////////////////////////////////////////end fiter pric (low -bettoeen)











        }


            ///////////////////////////////////////////////////////////////////////////  السعر اقل


            protected void Button2filterpricelow_Click(object sender, EventArgs e)
            {




               if (  DropDownList5searchpriceaddmanyview.Enabled == true)
                { 


                  DropDownList5priclowfrom.Enabled = false;   //////  اقل من
                  DropDownList5powerlowfrom.Enabled = false;   //// اقل من
                   DropDownList5searchpriceaddmanyview.Enabled = false;

                Button1filtterpriclow.Text = "تفعيل اقل من";




            // CheckBox1pricfilter.Enabled = false;
           
 
                }

               else if (DropDownList5searchpriceaddmanyview.Enabled == false)

                //  else if (DropDownList9price11.Enabled == false)
               {

                  string queryselectelprice = "select distinct price   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive in('true','testwin')" +

                     " and  price is not null order by price";

                 dbconnect.openconn();

                 dt.Clear();

                 dt = dbconnect.selectdata(queryselectelprice);
                   dbconnect.closeconn();



                if (dt.Rows.Count > 0)
                 {

                  //  CheckBox1pricfilter.Checked = true;

                 //  CheckBox1pricfilter.Enabled = false;

              //////////////////////////////////////////////////////////////////////////////////////////////

                  DropDownList5priclowfrom.Enabled = true;   //////  اقل من
                   DropDownList5powerlowfrom.Enabled = true;   //// اقل من
                    DropDownList5searchpriceaddmanyview.Enabled = true;


                    Button1filtterpriclow.Text = "الغاء تفعيل اقل من";




                    string queryselectmanyandpricesearchview = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive in('true','testwin')  " +

                  " and  many is not null and  price is not null  ";




                    dbconnect.openconn();
                    dt.Clear();


                    dt = dbconnect.selectdata(queryselectmanyandpricesearchview);



                    dbconnect.closeconn();


                    if (dt.Rows.Count > 0)
                    {


                        DropDownList5priclowfrom.Items.Clear();

                        DropDownList5powerlowfrom.Items.Clear();



                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            if (i == Convert.ToUInt16(DropDownList5searchpriceaddmanyview.SelectedValue))

                            {
                                DropDownList5priclowfrom.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(0)));


                                DropDownList5powerlowfrom.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][1]), Convert.ToString(0)));
                            }

                        }


                    }











                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }

                else if (dt.Rows.Count == 0)
                  {


                //     DropDownList9price11.Enabled = false;
                //    DropDownList10price22.Enabled = false;
                //   DropDownList5manysearch.Enabled = false;

                //  DropDownList5manysearchpow.Enabled = false;



                  DropDownList5priclowfrom.Enabled = false;   //////  اقل من
                 DropDownList5powerlowfrom.Enabled = false;   //// اقل من



                    Button1filtterpriclow.Text = "الغاء تفعيل اقل من";




                 // CheckBox1pricfilter.Enabled = false;
                 // CheckBox1pricfilter.Checked = false;

                ////   Literal9filterprice.Visible = false;


                  }




                 }


                //////////////////////////////////////////////////////////////////////
                ///




              









             }

















        protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
        {

          




        }

        protected void SqlDataSource244_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void DataList3_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource3_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }




       // protected void datalistalogin_RowCommand(object sender, RepeaterCommandEventArgs e)  //  حذف صور  موجودة لعقار الزبون
       // {

        //    if (e.CommandName == "logoin99")   // حذف  صور عقار الزبون
         //   {


          //      tutorialid.Text = Request.QueryString["id"];   ///// id الصورة لعقار الزبون


              //  tutorialbrowserid.Text = Request.QueryString["tutorialbrowserid"];
//
             //   if(javaid=="")

             //   ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ff();", true);





          //  }





       // }











    }
}