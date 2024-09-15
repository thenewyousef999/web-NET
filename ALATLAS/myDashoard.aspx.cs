using ALATLAS.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBManager;
using System.Web.DynamicData;
using System.Reflection.Emit;



namespace ALATLAS
{
    public partial class myDashoard : System.Web.UI.Page
    {

        Cdbconnect dbconnect = new Cdbconnect();


        tutorials tutor = new tutorials();


        DataTable dt = new DataTable();


        public string browseridview;

        string namebutton = "";

        //  string statetutorial ;   ////  لتخزين حالة state فيه

        // string tutorialidimage;

        //////////////////////////  


        ////////////////////////////////////////////////////////////////////////  function search
        ///
        string firstnameupdate = "";
        string lastnameupdate = "";

        string phonupdate = "";
        string phonhomeupdate = "";
        ///     




        string deletbrowsernull = "";
      

        string viewfilterdrop = "";   /// <summary>
        /// / حل مشكلة العرض من جدول الفلترة
        /// </summary>

        string updateREFresh = "";

        public string messegdate = "";

        public string remmber = "";


        //////////////////////////////////  تعديل التسميات




       // DropDownList5statetutorial.Items.Add(new ListItem(" ", "0"));

               // DropDownList5statetutorial.Items.Add(new ListItem("عروض بيع", "1"));
               // DropDownList5statetutorial.Items.Add(new ListItem("طلبات شراء", "2"));

               // DropDownList5statetutorial.Items.Add(new ListItem("طلبات استئجار", "3"));

               // DropDownList5statetutorial.Items.Add(new ListItem("عروض ايجار", "4"));






        public void updatenamestate_pric()
        {



            dbconnect.openconn();


            string updatenamestate_price_solde = " update tutorials set namesatae='عروض بيع' , namepricestate='سعر العقار' where state='solde'   ";

           dbconnect.insertdata(updatenamestate_price_solde);


            dbconnect.closeconn();




            dbconnect.openconn();

            string updatenamestate_price_take = " update tutorials set namesatae='عروض ايجار' , namepricestate='اجرة العقار' where state='take'    ";

           dbconnect.insertdata(updatenamestate_price_take);


            dbconnect.closeconn();



            ///////////////////////////////rice
            dbconnect.openconn();

            string updatenamestate_price_rice = " update tutorials set namesatae='طلبات شراء' , namepricestate='سعر العقار المطلوب شراءه' where state='rice'   ";

            dbconnect.insertdata(updatenamestate_price_rice);


            dbconnect.closeconn();

            //////////////////////////////////////////take_of

            dbconnect.openconn();

            string updatenamestate_price_take_of = " update tutorials set namesatae='طلبات استئجار' , namepricestate='اجرة العقار المطلوب استئجاره' where state='take_of'   ";

           dbconnect.insertdata(updatenamestate_price_take_of);


            dbconnect.closeconn();






        }


    /// <summary>
    /// /////////////////////////////
    /// </summary>
    public void addtutorials()   ////   اضافة عقار للزبون عرض
        {


            dbconnect.openconn();

            string querinsert55 = "select browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment from mybrowser where " +
                "browserid =" + browserid.Text + "  ";

            dt.Clear();
            dt = dbconnect.selectdata(querinsert55);

            dbconnect.closeconn();

            TextBox2.Text = dt.Rows[0][0].ToString();
            TextBox3.Text = dt.Rows[0][1].ToString();

            Button2_updatehaveperson.Visible = false;


            // Literal5.Text = tutorialidimage;

            if (dt.Rows.Count > 0)

            {




                txtFirstNam.Text = dt.Rows[0][0].ToString();
                txtMiddleName.Text = dt.Rows[0][1].ToString();
                textphone.Text = dt.Rows[0][2].ToString();
                textphonhome.Text = dt.Rows[0][3].ToString();
                TextBox6browsercommint.Text = dt.Rows[0][4].ToString();




                txtFirstNam.ReadOnly = true;
                txtMiddleName.ReadOnly = true;
                textphone.ReadOnly = true;
                textphonhome.ReadOnly = true;
                TextBox6browsercommint.ReadOnly = true;





                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;

                Panel11.Visible = true;

                // Panel55.Visible = true;


                  


                Button1_person.Visible = false;


                GridView1.Visible = true;


                SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where browserID='" + browserid.Text + "'  ";


                countsold.Visible = false;









                Label4.Visible = true;
                txtstreatname.Visible = true;

                Label5.Visible = true;
                txtnumberbuild.Visible = true;




                DropDownList1.Enabled = true;
                DropDownList3.Enabled = true;
                DropDownList4.Enabled = true;




                DropDownList2.Enabled = true;
                DropDownList5tabke.Enabled = true;
                DropDownList6room.Enabled = true;
                DropDown7alfarch.Enabled = true;
                DropDownList8alkasa.Enabled = true;
                DropDownList5dirction.Enabled = true;
                DropDownList5havinge.Enabled = true;
                DropDownList5refernc.Enabled = true;
                DropDownList5electron.Enabled = true;

                DropDownList5many.Enabled = true;

                Button1_person.Visible = false;
                Button2_addhaveperson.Visible = true;



                //  placetutorialee.Text = "";

                //  TextBox4.Text = " ";

                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;

                Panel11.Visible = true;

                Panel55.Visible = false;
                Panel6.Visible = false;



            }






        }



        ///////////////////////////////////////////////////////////////////end function search


      



        protected void Page_Load(object sender, EventArgs e)
        {


            placetutorialee.Text = DropDownList1.SelectedItem + "-" + DropDownList3.SelectedItem + "-" + DropDownList4.SelectedItem + "-" +
                  DropDownList1mantekanode.SelectedItem +"-"+ Literal24allmanteka.Text;



            TextBox4.Text = txtstreatname.Text + "-" + txtnumberbuild.Text;



            countsold.Visible = false;


            yessrequestsolde.Visible = false;
           





            deletebrowser.Visible = false;

            delettuorialbutton.Visible = false;

            deletrequsetrice.Visible = false;
            deletrequsetsolde.Visible = false;





            yessrequestrice.Visible = true;
            addimagebutton1.Visible = true;
            sendrequset.Visible = true;





            if (txtstatetutorial.Text == "solde")
            {
                Button22.Text = "جميع الزبائن الذين لديهم عقارات للبيع";

               // pagename.Text = "صفحة بيع العقارات";

              

            }
            if (txtstatetutorial.Text == "take")
            {
                Button22.Text = "جميع الزبائن الذين لديهم عقارات للاجار";


               // pagename.Text = "صفحة تاجير العقارات";




            }



            if (txtstatetutorial.Text == "take of")
            {

               // pagename.Text = "صفحة استاجار العقارات";





            }



            if (txtstatetutorial.Text == "rice")
            {

               // pagename.Text = "صفحة شراءالعقارات";





            }





            if (txtstatetutorial.Text == "win")
            {


                pagename.Text = "صفحة ربح  مكتب العقارات";

            }



           
           if(remmbertext.Text == "remmber")
            {


               // pagename.Text = "صفحة العقارات الذين لديهم تذكرة";

            }





            //////////////////////////


            TextBox5.Text = "";


           // if (Request.QueryString["pagename"] != "")
           // {

             //   pagename.Text = Request.QueryString["pagename"];
           // }





            if (!Page.IsPostBack)
            {
                Literal24searchall.Visible = false;
                CheckBoxList1searchbrowserstate.Visible = false;

                //////////////////////////////////////////////////////////////////////
                ///



               // if (Request.QueryString["pagename"] != "")
               // {
                   // pagename.Text = Request.QueryString["pagename"];

               // }


                ///////////////////////////////////////



                yessrequestrice.Visible = false;
               
                yessrequestsolde.Visible = false;
              

                addimagebutton1.Visible = false;
                sendrequset.Visible = false;

                Button4deletwin.Visible = false;





                deletebrowser.Visible = false;

                delettuorialbutton.Visible = false;

                deletrequsetrice.Visible = false;
                deletrequsetsolde.Visible = false;


                /////////////////////////////////////////////  page_master
                ///




                DropDownList5statetutorial.Items.Clear();

                DropDownList5statetutorial.Items.Add(new ListItem(" ", "0"));

                DropDownList5statetutorial.Items.Add(new ListItem("عروض بيع", "1"));
                DropDownList5statetutorial.Items.Add(new ListItem("طلبات شراء", "2"));

                DropDownList5statetutorial.Items.Add(new ListItem("طلبات استئجار", "3"));

                DropDownList5statetutorial.Items.Add(new ListItem("عروض ايجار", "4"));







                updatenamestate_pric();







                CheckBoxList1searchbrowserstate.Items.Add(new ListItem("عروض  بيع", "1"));
                CheckBoxList1searchbrowserstate.Items.Add(new ListItem("طلبات  شراء", "2"));

                CheckBoxList1searchbrowserstate.Items.Add(new ListItem("طلبات استئجار", "3"));

                CheckBoxList1searchbrowserstate.Items.Add(new ListItem("عروض ايجار", "4"));


                CheckBoxList1searchbrowserstate.Items.Add(new ListItem("زبائن لديهم تذكرة", "5"));






                //////////////////////////////////////////////////////////////  start page
                ///



                Session["admintype"] = "private";

                Literal14.Text = Convert.ToString(Session["adminID"]);


                if (txtstatetutorial.Text == "solde")
                    Button22.Text = "جميع الزبائن الذين لديهم عقارات للبيع";
                if (txtstatetutorial.Text == "take")
                    Button22.Text = "جميع الزبائن الذين لديهم عقارات للاجار";





                Literal3.Text = "";
                Literal7.Text = "";

                placetutorialee.Text = DropDownList1.SelectedItem + "-" + DropDownList3.SelectedItem + "-" + DropDownList4.SelectedItem;


              Button2_updatehaveperson.Visible = false;

                Button2_person_update.Visible = false;

                countsold.Visible = false;


                TextBox5.Visible = false;


               Button2_updatehaveperson.Visible = false;


                DataList1.Visible = false;


                ///////////////////filter ////////  + win 

                Panelfilter.Visible = false;


                Panel5datewin.Visible = false;

               // Panelmanywin.Visible = false;



                /////////////////////////////////


                Panel1.Visible = false;

                Panel11.Visible = false;   /// بيانات الزبون



                Panel2.Visible = false;  /// للعقار
                Panel3.Visible = false;    // للعقار
                Panel4.Visible = false;    //للعقار

                Panel55.Visible = false;   //  للعقار




                countsold.Visible = false;



                ///////////////////////////////////////////////   request pages master :    solde _ rice _ take _ take of


                ////////////////////////////////////////////////////////////////////   page requset master
                ///


                if ((Request.QueryString["state"] == "request_master"))  
                {



                   
                    pagename.Text = "اضف عقار : للبيع- للشراء- للأجار -للاستاجار";



                   // if (Request.QueryString["pagename"] != "")
                   // {
                   //     pagename.Text = Request.QueryString["pagename"];
                   // }

                    TextBox5.Text = "";
                    // txtstatetutorial.Text = "request_master";


                    Button22.Text = "جميع الزبائن الذين لديهم عقارات لدى المكتب";


                    Panel1.Visible = true;


                    TextBox2.Text = "";

                    TextBox3.Text = "";




                    Panelfilter.Visible = false;



                    if (Literal27_click.Text == "ok")
                    {
                        Literal24searchall.Visible = true;
                        CheckBoxList1searchbrowserstate.Visible = true;

                    }


                    else if(Literal27_click.Text != "ok")
                    {

                        Literal24searchall.Visible = false;
                        CheckBoxList1searchbrowserstate.Visible = false;


                    }






                    Literal27_click.Text = Request.QueryString[null];



                }









                ////////////////////////////////////////////////   end page request master











                if ((Request.QueryString["state"] == "take") || (txtstatetutorial.Text == "take"))  // صفحة تاجير العقارات   ///// فقط قيمة ابتدائية يجب المحافظة عليها عند كل عملية request
                {
                    pagename.Text = "صفحة تاجير العقارات";


                    txtstatetutorial.Text = "take";


                    Button22.Text = "جميع الزبائن الذين لديهم عقارات للاجار";


                    Panel1.Visible = true;


                    Panelfilter.Visible = false;


                }




                if ((Request.QueryString["state"] == "solde") || (txtstatetutorial.Text == "solde"))    // صفحة البيع
                {

                    pagename.Text = "صفحة بيع العقارات";

                    txtstatetutorial.Text = "solde";

                    Button22.Text = "جميع الزبائن الذين لديهم عقارات للبيع";

                    Panel1.Visible = true;




                    Panelfilter.Visible = false;

                }




                if ((Request.QueryString["state"] == "rice"))    //// صفحة الشراء
                {

                    pagename.Text = "صفحة شراء العقارات";

                    //GridViewrice.Visible = false;
                    //GridViewrequestsolde.Visible = false;
                    //GridViewsold.Visible = false;

                    //Panel11.Visible = false;

                    // DataList1.Visible = true;

                    txtstatetutorial.Text = "solde";

                    Panel1.Visible = false;

                    Panelfilter.Visible = true;


                    Label51.Text = "عقارات للبيع";






                    // DropDownList9price11.Enabled = true;
                    //  DropDownList10price22.Enabled = true;

                    DropDownList9price11.Enabled = false;   //////   betoween
                    DropDownList5manysearch.Enabled = false;   ////   betoween


                    DropDownList10price22.Enabled = false;   //////   betoween
                    DropDownList5manysearchpow.Enabled = false;   ////   betoween



                    DropDownList5pricbetoweenvie11.Enabled = false;  ///// beteen

                    DropDownList5pricbettoweenview22.Enabled = false; //// betten



                    DropDownList5searchpriceaddmanyview.Enabled = false;  ////  view اقل من

                    DropDownList5priclowfrom.Enabled = false;   //////  اقل من
                    DropDownList5powerlowfrom.Enabled = false;   //// اقل من






                    namebutton = "اضغط هنا لشراء هذا العقار";



                    dbconnect.openconn();


                    string querWIN_tutorials0 = "update  tutorials  set  namebutton='" + namebutton + "' " +


                             "        where  isactive='true'  and state='solde'  ";



                    dbconnect.insertdata(querWIN_tutorials0);

                    dbconnect.closeconn();







                    ////////////////////////////////////////////////////////  view filter
                    ///


                    int j = 0;
                    dbconnect.openconn();

                    string querinsert55showtable99 = "show tables";

                    dt = dbconnect.selectdata(querinsert55showtable99);

                    dbconnect.closeconn();


                    if (dt.Rows.Count > 0)

                    {

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            if ((dt.Rows[i][0].ToString() == "viewfilter") && (viewfilterdrop != "ch"))
                            {
                                j = 1;




                                SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                              "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state,masad,Serviecother,dateother,namesatae,namepricestate," +

                              " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                               "  where tutorialbrowserid=browserID  and  isactive ='true'   and state='solde' and  tutorialID in(select tutorialID from  viewfilter)    order by price desc     ";



                                DataList2.Visible = true;




                            }

                        }

                    }





                    if ((j == 0)&& (viewfilterdrop != "ch"))
                    {

                        SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                         "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state,masad,Serviecother,dateother,namesatae,namepricestate," +

                        " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                            "  where tutorialbrowserid=browserID  and  isactive ='true'   and state='solde'     order by price desc     ";



                        DataList2.Visible = true;





                    }







                }






                if ((Request.QueryString["state"] == "take of"))  // صفحة استاجار العقارات
                {

                    pagename.Text = "صفحة استأجار العقارات";


                    Panel1.Visible = false;

                    //   Panelfilter.Visible = true;
                    //  DropDownList9price11.Enabled = true;
                    //  DropDownList10price22.Enabled = true;

                    txtstatetutorial.Text = "take";



                    Panelfilter.Visible = true;

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





                    namebutton = "اضغط هنا لاستاجار هذا العقار";



                    dbconnect.openconn();


                    string querWIN_tutorials0 = "update  tutorials  set  namebutton='" + namebutton + "' " +


                             "        where  isactive='true'  and state='take'  ";



                    dbconnect.insertdata(querWIN_tutorials0);

                    dbconnect.closeconn();



                    ////////////////////////////////////////////////////////  view filter
                    ///


                    int j = 0;
                    dbconnect.openconn();

                    string querinsert55showtable99 = "show tables";

                    dt = dbconnect.selectdata(querinsert55showtable99);

                    dbconnect.closeconn();


                    if (dt.Rows.Count > 0)

                    {

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            if ((dt.Rows[i][0].ToString() == "viewfilter") && (viewfilterdrop!="ch") )
                            {
                                j = 1;




                                SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                              "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state,masad,Serviecother,dateother,namesatae,namepricestate," +

                              " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                               "  where tutorialbrowserid=browserID  and  isactive ='true'   and state='take' and  tutorialID in(select tutorialID from  viewfilter)    order by price desc     ";



                                DataList2.Visible = true;


                                break;


                            }


                        }

                    }





                    if ((j == 0)&&(viewfilterdrop!="ch"))
                    {

                        SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                         "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,state,masad,Serviecother,dateother,namesatae,namepricestate," +

                        " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                            "  where tutorialbrowserid=browserID  and  isactive ='true'   and state='take'     order by price desc     ";



                        DataList2.Visible = true;


                      


                    }











                    //////////////////












                }

                ////////////////////////////////////////صفحة ربح المكتب



                if ((Request.QueryString["state"] == "win") || (txtstatetutorial.Text == "win"))    // صفحة البيع
                {

                    pagename.Text = "صفحة ربح المكتب";

                    txtstatetutorial.Text = "win";

                    // Panelfilter.Visible = true;


                    //  Panel1.Visible = false;

                    DataList2.Visible = true;


                    Panel5datewin.Visible = true;

                   


                    string queryselecteldate = "select distinct     DateStart   from tutorials where isactive='win' and" +
                        " DateStart is not null order by DateStart desc";




                    dbconnect.openconn();

                    dt.Clear();

                    dt = dbconnect.selectdata(queryselecteldate);



                    dbconnect.closeconn();

                    if (dt.Rows.Count > 0)
                    {
                        DropDownList5winoldedate.Items.Clear();
                        DropDownList6winneewdate.Items.Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            string date = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(Convert.ToString(dt.Rows[i][0])));

                            DropDownList5winoldedate.Items.Add(new ListItem(date, Convert.ToString(i)));

                            DropDownList6winneewdate.Items.Add(new ListItem(date, Convert.ToString(i)));



                            //  DropDownList5winoldedate.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));

                            //  DropDownList6winneewdate.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));

                        }

                    }






                    string queryselectelpricwin = "select distinct manywinmany   from tutorials where isactive='win' and" +
                        " manywinmany is not null order by manywinmany desc";



                    /////   manywinmany :   عملة عمولة المكتب

                    /////

                    dbconnect.openconn();

                    dt.Clear();

                    dt = dbconnect.selectdata(queryselectelpricwin);



                    dbconnect.closeconn();

                    if (dt.Rows.Count > 0)
                    {


                        DropDownList5manyreferens.Items.Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {


                            DropDownList5manyreferens.Items.Add(new ListItem(dt.Rows[i][0].ToString(), Convert.ToString(i)));



                        }


                    }






                    SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                            "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,masad,Serviecother,dateother,namesatae,namepricestate," +

                           " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                               "  where tutorialbrowserid=browserID  and   isactive='win'  and state='win'  order by DateStart desc     ";



                    DataList2.Visible = true;









                }



                ///////////////////////////////////////////////////////////////////////  request page (طلبات البيع -طلبات الشراء طلبات الاجار _طلبات الاستاجار)
                ///

                if (Request.QueryString["requset"] == "requset_solde")   ////// صفحة طلبات البيع

                {


                    pagename.Text = "صفحة طلبات بيع العقارات ";

                    txtstatetutorial.Text = "requset_solde";


                    SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                            "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,masad,Serviecother,dateother,namesatae,namepricestate," +

                           " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                               "  where tutorialbrowserid=browserID  and isactive='false'   and state='solde'      ";








                    dbconnect.openconn();

                    string querinsert55showname = "select tutorialID  from  tutorials where isactive='false' and state='solde' ";


                    dt.Clear();
                    dt = dbconnect.selectdata(querinsert55showname);

                    dbconnect.closeconn();

                    if (dt.Rows.Count > 0)
                    {


                        namebutton = "اضغط للموافقة على طلب بيع هذا العقار";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            int id = Convert.ToInt16(dt.Rows[i][0].ToString());


                            dbconnect.openconn();


                            string querWIN_tutorials0 = "update  tutorials  set  namebutton='" + namebutton + "'  " +


                                     "        where  isactive='false'  and state='solde' and tutorialID =" + id + "  ";



                            dbconnect.insertdata(querWIN_tutorials0);

                            dbconnect.closeconn();




                        }




                    }








                    DataList2.Visible = true;






                }


                if (Request.QueryString["requset"] == "requset_rice")   ////// صفحة طلبات الشراء

                {


                    pagename.Text = "صفحة طلبات شراء العقارات ";

                    txtstatetutorial.Text = "requset_rice";



                    SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                        "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many, winmany,manywinmany,tutorialbrowserwinid,masad,Serviecother,dateother,namesatae,namepricestate," +

                        " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  from  tutorials INNER JOIN  requeststate on Reqtutorialid=tutorialID" +

                      

                           "  INNER JOIN mybrowser on tutorialbrowserid=browserID  where isactive='testwin'   and state='solde'    ";










                    dbconnect.openconn();

                    string querinsert55showname = "select tutorialID,Reqbowserid  from  tutorials , requeststate where Reqtutorialid=tutorialID and isactive='testwin' and state='solde' ";


                    dt.Clear();
                    dt = dbconnect.selectdata(querinsert55showname);

                    dbconnect.closeconn();

                    if (dt.Rows.Count > 0)
                    {


                        namebutton = "اضغط للموافقة على طلب شراء هذا العقار";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            int id = Convert.ToInt16(dt.Rows[i][0].ToString());

                            int idreqbrowser = Convert.ToInt16(dt.Rows[i][1].ToString());


                            dbconnect.openconn();


                            string querWIN_tutorials0 = "update  tutorials  set  namebutton='" + namebutton + "',tutorialbrowserwinid="+ idreqbrowser + "  " +


                                     "        where  isactive='testwin'  and state='solde' and tutorialID =" + id + "  ";



                            dbconnect.insertdata(querWIN_tutorials0);

                            dbconnect.closeconn();




                        }




                    }









                    DataList2.Visible = true;






                }


                if (Request.QueryString["requset"] == "requset_take")   ////// صفحة طلبات الاجار

                {


                    pagename.Text = "صفحة طلبات اجارات العقارات ";

                    txtstatetutorial.Text = "requset_take";


                    SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                            "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,masad,Serviecother,dateother,namesatae,namepricestate," +

                           " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                               "  where tutorialbrowserid=browserID  and isactive='false'   and state='take'      ";









                    dbconnect.openconn();

                    string querinsert55showname = "select tutorialID  from  tutorials where isactive='false' and state='take' ";


                    dt.Clear();
                    dt = dbconnect.selectdata(querinsert55showname);

                    dbconnect.closeconn();

                    if (dt.Rows.Count > 0)
                    {


                        namebutton = "اضغط للموافقة على طلب تاجير هذا العقار";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            int id = Convert.ToInt16(dt.Rows[i][0].ToString());


                            dbconnect.openconn();


                            string querWIN_tutorials0 = "update  tutorials  set  namebutton='" + namebutton + "'  " +


                                     "        where  isactive='false'  and state='take' and tutorialID =" + id + "  ";



                            dbconnect.insertdata(querWIN_tutorials0);

                            dbconnect.closeconn();




                        }




                    }






                    DataList2.Visible = true;




                }


                if (Request.QueryString["requset"] == "requset_take_of")   ////// صفحة طلبات الاستاجار

                {



                    pagename.Text = "صفحة طلبات استاجارات العقارات ";

                    txtstatetutorial.Text = "requset_take_of";

                 




                    dbconnect.openconn();

                    string querinsert55showname = "select tutorialID,Reqbowserid  from  tutorials , requeststate where Reqtutorialid=tutorialID and isactive='testwin' and state='take' ";


                    dt.Clear();
                    dt = dbconnect.selectdata(querinsert55showname);

                    dbconnect.closeconn();

                    if (dt.Rows.Count > 0)
                    {


                        namebutton = "اضغط للموافقة على طلب استاجار هذا العقار";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            int id = Convert.ToInt16(dt.Rows[i][0].ToString());

                            int idreqbrowser = Convert.ToInt16(dt.Rows[i][1].ToString());

                            dbconnect.openconn();


                            string querWIN_tutorials0 = "update  tutorials  set  namebutton='" + namebutton + "' , tutorialbrowserwinid=" + idreqbrowser + "  " +


                                     "        where  isactive='testwin'  and state='take' and tutorialID =" + id + "  ";



                            dbconnect.insertdata(querWIN_tutorials0);

                            dbconnect.closeconn();




                        }




                    }










                    SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke," +

                        "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many, winmany,manywinmany,tutorialbrowserwinid,dateother,namesatae,namepricestate," +

                        " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment,masad,Serviecother  from  tutorials ,mybrowser where tutorialbrowserid=browserID  " +

                        "and isactive='testwin'   and state='take' and  tutorialID in(select  Reqtutorialid from requeststate where reqState='take')  ";
                        
                       // "INNER JOIN  requeststate on Reqtutorialid=tutorialID" +



                         //  "  INNER JOIN mybrowser on tutorialbrowserid=browserID  where isactive='testwin'   and state='take'    ";







                    DataList2.Visible = true;




                }





                ///////////
                ///////////////////////////////////////////////////////////////////requser query   ////////////////////////////////////
                ///

                ///////////////////////////////////////////////////////////////////  end request page









                //////////////////////////////////////////////اضافة البلد

                string queryselectcountry = "select distinct country   from tutorialspublic where country is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectcountry);


                Literal6.Text = dt.Rows.Count.ToString();

                dbconnect.closeconn();



                if (dt.Rows.Count > 0)
                {

                    DropDownList1.Items.Clear();


                    DropDownList1.Items.Add(new ListItem("سوريا", "0" ));


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                       

                        DropDownList1.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));

                        
                    }




                }

                else if(dt.Rows.Count==0)

                DropDownList1.Items.Add(new ListItem("لايوجد", "0"));  //  البلد

                //state='"+txtstatetutorial.Text+ "' and isactive='true'" +

           //////////     ///////////////////////////////// filter by country بحث حسب اللد


                string queryselectcountryfilter = "select distinct country   from tutorials where  state='" + txtstatetutorial.Text+ "' and isactive='true' " +
                    " and country is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectcountryfilter);



               // Literal6.Text = txtstatetutorial.Text;

                dbconnect.closeconn();



                if (dt.Rows.Count > 0)
                {


                    CheckBoxlista1country.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        CheckBoxlista1country.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));  /// filter by country


                    }

                }




                /////////////////////////////////////  اضافة المدينة    //////////////////////////////////////////


                //string queryselecity = "select  distinct city  from tutorialspublic where city is not null";


                string queryselecity = "select distinct namecitynode   from countrypublic where    namrcountry='" + DropDownList1.SelectedItem.Text + "'     and  namrcountry  is not null";



                dbconnect.openconn();

                dt.Clear();
                dt = dbconnect.selectdata(queryselecity);



                dbconnect.closeconn();


                if (dt.Rows.Count > 0)
                {

                    DropDownList3.Items.Clear();


                    DropDownList3.Items.Add(new ListItem("دمشق", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DropDownList3.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));

                        
                    }

                }
                else if (dt.Rows.Count == 0)

                    DropDownList3.Items.Add(new ListItem("لايوجد", "0"));  //  مدينة







                ///////////////////////////////// filter by city بحث حسب اللد


                string queryselectcityfilter = "select distinct city   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive='true' " +
                    " and city is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectcityfilter);



                // Literal6.Text = txtstatetutorial.Text;

                dbconnect.closeconn();



                CheckBoxlist2city.Items.Clear();

                if (dt.Rows.Count > 0)
                {


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        CheckBoxlist2city.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));


                    }

                }












                ///////////////////////////////////////////
                ///  اضافة المنطقة

                //  string queryselealmanteka = "select distinct manteka   from tutorialspublic where manteka is not null";

                string queryselealmanteka = "select distinct namemantekanode    from citypublic where  namecity  ='" + DropDownList3.SelectedItem.Text + "'   and namecity  is not null";



                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselealmanteka);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                    DropDownList4.Items.Clear();

                    DropDownList4.Items.Add(new ListItem("مزة", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DropDownList4.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));

                       

                    }


                }
                else if (dt.Rows.Count == 0)

                    DropDownList4.Items.Add(new ListItem("لايوجد", "0"));  //  منطقة 






                ///////////////////////////////// filter by manteka بحث حسب اللد


                string queryselemnatkafilter = "select distinct manteka   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive='true' " +
                    " and manteka is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselemnatkafilter);



                Literal6.Text = dt.Rows.Count.ToString();

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



                DropDownList1mantekanode.Items.Add(new ListItem("/", "0"));

                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));
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
                        DropDownList2.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));

                       
                    }


                }
                else if (dt.Rows.Count == 0)

                    DropDownList2.Items.Add(new ListItem("لايوجد", "0"));  //  نوع








                ///////////////////////////////// filter by type نوع العقار بحث حسب اللد


                string queryseletypefilter = "select distinct tutorialType   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive='true' " +
                    " and tutorialType is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryseletypefilter);



                // Literal6.Text = txtstatetutorial.Text;

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




                string queryselectelprice = "select distinct price   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive='true'" +

                    " and  price is not null order by price";

               // dbconnect.openconn();

               // dt.Clear();

              //  dt = dbconnect.selectdata(queryselectelprice);



              //  dbconnect.closeconn();

               // if (dt.Rows.Count > 0)
               // {
                  //  DropDownList9price11.Items.Clear();
                  //  DropDownList10price22.Items.Clear();

                   // for (int i = 0; i < dt.Rows.Count; i++)
                   // {

                     //   DropDownList9price11.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));

                    //    DropDownList10price22.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));

                  //  }

              //  }




                ///////////////////////////////////////////////   العملة



                //////////////////////////////////////////////////////////////////////////// عملة سعر العقار


                string queryselectmany = "select distinct many   from tutorialspublic where many is not null  ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectmany);




                dbconnect.closeconn();


                if (dt.Rows.Count > 0)
                {


                    DropDownList5manywin.Items.Clear();//// عملة عمولة المكتب

                    DropDownList99manywin.Items.Clear();//// عملة عمولة المكتب


                    DropDownList5many.Items.Clear();



                    DropDownList5many.Items.Add(new ListItem("", "0"));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DropDownList5many.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));




                        DropDownList5manywin.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));   /// win ربح المكتب


                        DropDownList99manywin.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));   /// win ربح المكتب



                        //DropDownList99manywin  : نوع عمولة المكتب اثناء شراء او استاجار العقار

                        ////  DropDownList5manywin :  نوع عمولة المكتب اثناء معالجة طالبات شراء او استاجار العقار


                        ////   DropDownList5many: تحديد سعر للعقار اثناء عملية بيع او تاجير العقار

                    }


                }

                else if (dt.Rows.Count == 0)

                    DropDownList5many.Items.Add(new ListItem("لايوجد", "0"));  //  عملة






                //////////////////////////////////////////////////////////////////////////////   filtter العملة


                string queryselectmanysearch = "select distinct many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive='true'  " +

                        " and  many is not null  ";




               // dbconnect.openconn();
               // dt.Clear();


               // dt = dbconnect.selectdata(queryselectmanysearch);




               // dbconnect.closeconn();


               // if (dt.Rows.Count > 0)
               // {


                  //  DropDownList5manysearch.Items.Clear();


                   // DropDownList5manysearchpower.Items.Clear();


                   // for (int i = 0; i < dt.Rows.Count; i++)
                   // {

                       // DropDownList5manysearch.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i))); ////filter


                       // DropDownList5manysearchpower.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i))); ////filter



                        ///  DropDownList5manysearch : تحديد العملة اثناء البحث


                  //  }



                //}

                /////////////////////////////////////////////////////////////
                ///



                ////////////////////////////////////////////////////////////////////// fiter low from فلترة سعر اقل من ////////////////////////////////    اقل من عرض سعر العقار + العملة
                ///



                string queryselectmanyandpricesearchview = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive='true'  " +

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

                        yy = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();


                        DropDownList5searchpriceaddmanyview.Items.Add(new ListItem(yy, Convert.ToString(i))); ////عملة اقل من  



                    }








                }




                ////////////////////////////////////////////////////////////////////// فلترة سعر between ////////////////////////////////    beteen عرض سعر العقار + العملة
                ///



                string queryselectmanyandpricesearchviewbeteen = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive='true' " +

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


                        DropDownList5tabke.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));


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


                        DropDownList6room.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));



                }

                else if (dt.Rows.Count == 0)

                    DropDownList6room.Items.Add(new ListItem("لايوجد", "0"));  //  غرف



                /////////////////////////////////////////////////////////////
                ///   فرش العقار اضافة 




                string queryselectalfarch = "select distinct alfarch       from tutorialspublic where alfarch is not null";

                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselectalfarch);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDown7alfarch.Items.Clear();


                    DropDown7alfarch.Items.Add(new ListItem("", "0"));


                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDown7alfarch.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));


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


                        DropDownList8alkasa.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));


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


                        DropDownList5dirction.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));


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


                        DropDownList5havinge.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));


                
                }

                else if (dt.Rows.Count == 0)

                    DropDownList5havinge.Items.Add(new ListItem("لايوجد", "0"));  //  ملكية



                /////////////////////////////////////////////////////////////
                ///   الاشارات العقار اضافة 




                string queryselectrefernc = "select distinct refernc   from tutorialspublic where refernc is not null";

                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselectrefernc);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {
                    DropDownList5refernc.Items.Clear();


                    DropDownList5refernc.Items.Add(new ListItem("", "0"));


                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList5refernc.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));


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


                        DropDownList5electron.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));



                }

                else if (dt.Rows.Count == 0)

                    DropDownList5electron.Items.Add(new ListItem("لايوجد", "0"));  //  كهرباء



                ///////////////////////////////////////////////////////////////

                //////////////////////////////////////////////////////////////////////   masad
                ///




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




                /////////////////////////////////////////////////////// 1- add + update زبون 



                if (Request.QueryString["updateperson"] == "updateperson")  ///  عرض تعديل بيانات الزبون comment
            {


                browserid.Text = Request.QueryString["browseridview"];



                txtstatetutorial.Text = Request.QueryString["statetutorial"];  /// حالة الصفحة


                    dbconnect.openconn();

                    string querinsert55 = "select browserfirstName,browserlastName from mybrowser where " +
                        "browserid =" + browserid.Text + "  ";

                    dt.Clear();
                    dt = dbconnect.selectdata(querinsert55);

                    dbconnect.closeconn();

                    TextBox2.Text = dt.Rows[0][0].ToString();

                    TextBox3.Text = dt.Rows[0][1].ToString();





                    Panel1.Visible = true;

                    GridView1.Visible = true;


                SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where browserID='" + browserid.Text + "'  ";


                countsold.Visible = false;


                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;

                Panel11.Visible = true;
                Panel55.Visible = false;
                Panel6.Visible = false;

                GridView1.Visible = true;

                DataList1.Visible = false;




                dbconnect.openconn();


                string querupdate = "select browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment from mybrowser where " +
                       "browserid =" + browserid.Text + "  ";

                dt.Clear();
                dt = dbconnect.selectdata(querupdate);



                    dbconnect.closeconn();
                    // Literal5.Text = tutorialidimage;

                    if (dt.Rows.Count > 0)

                    {
                       // Literal4.Text = dt.Rows[0][4].ToString();




                       txtFirstNam.Text = dt.Rows[0][0].ToString();
                       txtMiddleName.Text = dt.Rows[0][1].ToString();
                       textphone.Text = dt.Rows[0][2].ToString();
                       textphonhome.Text = dt.Rows[0][3].ToString();
                       TextBox6browsercommint.Text = dt.Rows[0][4].ToString();


                        txtFirstNam.ReadOnly = false;
                        txtMiddleName.ReadOnly = false;
                        textphone.ReadOnly = false;
                        textphonhome.ReadOnly = false;
                         TextBox6browsercommint.ReadOnly = false;




                      Button1_person.Visible = false;

                      Button2_person_update.Visible = true;




                     }

                }







              if (Request.QueryString["sk"] == "viewupdatperson")   //عرض تعديل بيانات زبون موجود   button click
              {



                browserid.Text = Request.QueryString["browseridview"];

                txtstatetutorial.Text = Request.QueryString["statetutorial"];

              



                Panel11.Visible = true;

                Panel1.Visible = true;

                // Searchee();
                /////////////////////////////////
                           ///

                dbconnect.openconn();

                string querisearch = "select browserID  from mybrowser where  browserID='"+ browserid .Text+ "'  ";


                dt.Clear();
                dt = dbconnect.selectdata(querisearch);


                dbconnect.closeconn();

                Literal4.Text = dt.Rows.Count.ToString();


                if (dt.Rows.Count == 0)
                {



                    //Literal4.Text = "==0";

                    Panel11.Visible = true;

                    Button1_person.Visible = true;



                    Panel2.Visible = false;
                    Panel3.Visible = false;
                    Panel4.Visible = false;

                    Panel6.Visible = false;

                    Panel55.Visible = false;




                    txtFirstNam.ReadOnly = false;
                    txtMiddleName.ReadOnly = false;
                    textphone.ReadOnly = false;
                    textphonhome.ReadOnly = false;
                    TextBox6browsercommint.ReadOnly = false;


                    textphone.Text = "";
                    textphonhome.Text = "";
                    TextBox6browsercommint.Text = "";


                    txtFirstNam.Text = TextBox2.Text;

                    txtMiddleName.Text = TextBox3.Text;
                    DataList1.Visible = false;

                }


                else if (dt.Rows.Count > 0)
                {
                  //  Literal4.Text = ">0";
                    //  TextBox2.Text = firstnameupdate;

                    //  TextBox3.Text = lastnameupdate;


                    GridView1.Visible = true;


                    SqlDataSource55.SelectCommand = "select browserID,browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where browserID='" + browserid.Text + "'  ";

                    countsold.Visible = false;


                    Panel1.Visible = true;

                    Panel11.Visible = false;

                    Panel2.Visible = false;
                    Panel3.Visible = false;
                    Panel4.Visible = false;

                    Panel6.Visible = false;

                    Panel55.Visible = false;


                    Button1_person.Visible = false;

                    DataList1.Visible = false;


                }



              }


              if (Request.QueryString["s"] == "add")  /// جديد عرض اضافة زبون button clik
              {

                txtstatetutorial.Text = Request.QueryString["statetutorial"];


                    Button22.Text = "جميع الزبائن الذين لديهم عقارات لدى المكتب";


                    txtFirstNam.Text = Request.QueryString["firstname"];


                txtMiddleName.Text = Request.QueryString["lasname"];

                textphone.Text = Request.QueryString["phonee"];


                textphonhome.Text = Request.QueryString["phonehomee"];

                TextBox6browsercommint.Text = Request.QueryString["TextBox6browsercommint"];


                txtFirstNam.ReadOnly = true;
                txtMiddleName.ReadOnly = true;
                textphone.ReadOnly = true;
                textphonhome.ReadOnly = true;

                TextBox6browsercommint.ReadOnly = true;

                Panel1.Visible = true;

                Panel11.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;


                Button1_person.Visible = false;

               

                placetutorialee.Text = DropDownList1.SelectedItem + ""+ "-" + DropDownList3.SelectedItem +" "+ "-" + DropDownList4.SelectedItem;



                Literal1.Text = "<strong>" + " Success! </ strong > Data is added successfully." + "</strong> people is added successfully.";


                string queryselectprivate = "select browserid from mybrowser where browserFirstName = '" + txtFirstNam.Text + "' and browserLastName = '" + txtMiddleName.Text + "' and NumberPhone = '" + textphone.Text + "' and NumberHome='" + textphonhome.Text + "'   ";



                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(queryselectprivate);


                //  dt = dbconnect.cobject.SelectDataSet("mybrowser"," browserID", " browserFirstName like '" + txtFirstNam.Text + "' and browserLastName like '" + txtMiddleName.Text + "' and NumberPhone = '" + textphone.Text + "' and NumberHome='" + textphonhome.Text + "'   ").Tables[0];

                if (dt.Rows.Count > 0)

                    browseridview = dt.Rows[0][0].ToString();

                browserid.Text = dt.Rows[0][0].ToString();


                    dbconnect.closeconn();


               }



            ///////////////////////////////////////////////////////

              

           ////////////////////    العقار         /////////// ///////////// ///// ////////////////////







               if (Request.QueryString["updateimage"] == "updateimage")   //// اضافة صور جديدة للعقار(تعديل للصور العقار)   عرض
                   {

                    tutoriallink.Text = "";

                    TextBox5.Text = "";

                    browserid.Text = Request.QueryString["browseridview"];

                    tutorialid.Text = Request.QueryString["tutorialid"];

                    txtstatetutorial.Text = Request.QueryString["statetutorial"];   // حالة الصفحة



                    pagename.Text = Request.QueryString["pagename"];





                    if (Request.QueryString["up"] =="ok")
                    {

                        Literal9.Text = LiMessage.Text = "<strong>" + "تم تعديل العقار بنجاح" + "</strong>  .";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalError();", true);

                    }

                    yessrequestrice.Visible = false;
                   
                    yessrequestsolde.Visible = false;
                   



                    addimagebutton1.Visible = false;
                    sendrequset.Visible = false;



                    Button4deletwin.Visible = false;
                    deletebrowser.Visible = false;
                    delettuorialbutton.Visible = false;
                    deletrequsetrice.Visible = false;
                    deletrequsetsolde.Visible = false;



                    //string namestate = "";



                    TextBox5.Visible = true;
                    Literal3.Text = "";
                    Literal7.Text = "";


                    dbconnect.openconn();

                    string querinsert55 = "select browserfirstName,browserlastName from mybrowser where " +
                        "browserid =" + browserid.Text + "  ";

                    dt.Clear();
                    dt = dbconnect.selectdata(querinsert55);

                    dbconnect.closeconn();

                    TextBox2.Text = dt.Rows[0][0].ToString();

                    TextBox3.Text = dt.Rows[0][1].ToString();





                    GridView1.Visible = true;


                    SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where browserID='" + browserid.Text + "'  ";

                    Panel1.Visible = true;




                    dbconnect.openconn();

                    string querinsertimage = "select tutorialID ,State from tutorials where " +
                        "tutorialbrowserid =" + browserid.Text + " and  isactive <>'false' and isactive<>'win' ";


                    dt.Clear();
                    dt = dbconnect.selectdata(querinsertimage);

                    dbconnect.closeconn();

                    //////////////////////////////////////////







                    /////////////////////////////////

                    if (dt.Rows.Count > 0)
                    {



                        TextBox5.Text = dt.Rows.Count + " " + "عدد" + " " + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;

                        upload.Visible = false;

                        Panel55.Visible = false;/// لتحميل الصور

                        Panel2.Visible = false;
                        Panel3.Visible = false;
                        Panel4.Visible = false;

                        Panel11.Visible = false;

                        Panel6.Visible = false;
                        Panel1.Visible = true;


                        SqlDataSource1.SelectCommand = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke," +
                        "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils,Dateupdat,masad,Serviecother,namesatae,state,dateother ,namepricestate " +
                        "from tutorials where   isactive <>'false' and isactive<>'win'  and tutorialbrowserid=" + browserid.Text + "   ";



                        DataList1.Visible = true;

                        countsold.Visible = false;



                    }

                    else

                        TextBox5.Text = dt.Rows.Count + " " + "لايوجد" + " " + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;



               }









                if (Request.QueryString["updatetutorials"] == "updatetutorials")   //// add+view  موجود سابقا  عرض تعديل العقار comment
                {

                   // txtstatetutorial.Text = "";

                    browserid.Text = Request.QueryString["browseridview"];

                    tutorialid.Text = Request.QueryString["tutorialid"];


                    txtstatetutorial.Text = Request.QueryString["statetutorial"];

                    updateREFresh = "websrvice";


                    pagename.Text = Request.QueryString["pagename"];

                   



                    dbconnect.openconn();

                    string querinsert55 = "select browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment from mybrowser where " +
                        "browserid =" + browserid.Text + "  ";

                    dt.Clear();
                    dt = dbconnect.selectdata(querinsert55);

                    dbconnect.closeconn();

                    TextBox2.Text = dt.Rows[0][0].ToString();
                    TextBox3.Text = dt.Rows[0][1].ToString();

                    Button2_updatehaveperson.Visible = false;


                    // Literal5.Text = tutorialidimage;




                    Panel1.Visible = true;
                    Panel2.Visible = true;
                    Panel3.Visible = true;
                    Panel4.Visible = true;

                    Panel11.Visible = true;

                    // Panel55.Visible = true;


                    DataList1.Visible = false;



                    Panel55.Visible = false;


                    Panel6.Visible = false;

                    Button1_person.Visible = false;
                    Button2_addhaveperson.Visible = false;


                    Button2_person_update.Visible = false;




                    Button1_person.Visible = false;
                    Button2_addhaveperson.Visible = false;



                    Button2_updatehaveperson.Visible = true;




                    GridView1.Visible = true;


                    SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where browserID='" + browserid.Text + "'  ";


                    countsold.Visible = false;





                    if (dt.Rows.Count > 0)

                    {


                        txtFirstNam.Text = dt.Rows[0][0].ToString();
                        txtMiddleName.Text = dt.Rows[0][1].ToString();
                        textphone.Text = dt.Rows[0][2].ToString();
                        textphonhome.Text = dt.Rows[0][3].ToString();
                        TextBox6browsercommint.Text = dt.Rows[0][4].ToString();






                        txtFirstNam.ReadOnly = true;
                        txtMiddleName.ReadOnly = true;
                        textphone.ReadOnly = true;
                        textphonhome.ReadOnly = true;
                        TextBox6browsercommint.ReadOnly = true;

                      


                        dbconnect.openconn();

                        string querinsert55updattutorail = "select browserfirstName,browserlastName,NumberPhone,NumberHome,country,city,manteka,placetutorial," +
                            "tutorialType,tabke,room,alfarch,alkasa,dirction,havinge,refernc,electron,alatlalh,area,price ,tutorialDeatils,browsercomment,many,masad,serviecother,namesatae,dateother,remmber from mybrowser, tutorials where " +
                            "tutorialbrowserid=browserid and tutorialID=" + tutorialid.Text + "  and isactive='true'   ";

                        dt.Clear();
                        dt = dbconnect.selectdata(querinsert55updattutorail);

                        dbconnect.closeconn();

                        // Literal5.Text = tutorialidimage;

                        if (dt.Rows.Count > 0)

                        {
                            // Literal4.Text = dt.Rows[0][4].ToString();


                            TextBox2.Text = dt.Rows[0][0].ToString();
                            TextBox3.Text = dt.Rows[0][1].ToString();


                            txtFirstNam.Text = dt.Rows[0][0].ToString();
                            txtMiddleName.Text = dt.Rows[0][1].ToString();
                            textphone.Text = dt.Rows[0][2].ToString();
                            textphonhome.Text = dt.Rows[0][3].ToString();




                            // DropDownList1.Items.Clear();
                            // DropDownList3.Items.Clear();
                            // DropDownList4.Items.Clear();




                            //  DropDownList1.Items.Add(new ListItem(dt.Rows[0][4].ToString(), Convert.ToString( countcontry+1)));

                            DropDownList1.SelectedItem.Text = dt.Rows[0][4].ToString();


                           // DropDownList3.Items.Add(new ListItem(dt.Rows[0][5].ToString(), "0"));

                            DropDownList3.SelectedItem.Text = dt.Rows[0][5].ToString();

                            string cityupdate= dt.Rows[0][5].ToString();

                            // DropDownList4.Items.Add(new ListItem(dt.Rows[0][6].ToString(), "0"));


                           /// DropDownList4.SelectedItem.Text = dt.Rows[0][6].ToString();

                            string mantekupdate= dt.Rows[0][6].ToString();

                            Literal24allmanteka.Text= dt.Rows[0][6].ToString();


                            TextBox4.Text = dt.Rows[0][7].ToString();

                            placetutorialee.Text = dt.Rows[0][7].ToString();

                            if (DropDownList4.SelectedItem.Text!="حدد منطقة")

                            placetutorialee.Text = DropDownList1.SelectedItem + "-" + DropDownList3.SelectedItem + "-" + DropDownList4.SelectedItem;


                            else if(DropDownList4.SelectedItem.Text=="حدد منطقة")

                                placetutorialee.Text = DropDownList1.SelectedItem + "-" + DropDownList3.SelectedItem + "-" + Literal24allmanteka.Text;



                            // DropDownList2.Items.Clear();
                            //  DropDownList5tabke.Items.Clear();
                            //  DropDownList6room.Items.Clear();
                            //  DropDown7alfarch.Items.Clear();
                            //  DropDownList8alkasa.Items.Clear();
                            //  DropDownList5dirction.Items.Clear();
                            //  DropDownList5havinge.Items.Clear();
                            //  DropDownList5refernc.Items.Clear();
                            //  DropDownList5electron.Items.Clear();
                            //  DropDownList5many.Items.Clear();




                            // DropDownList2.Items.Add(new ListItem(dt.Rows[0][8].ToString(), "1"));


                            DropDownList2.SelectedItem.Text = dt.Rows[0][8].ToString();



                         //   DropDownList5tabke.Items.Add(new ListItem(dt.Rows[0][9].ToString(), "1"));

                            DropDownList5tabke.SelectedItem.Text = dt.Rows[0][9].ToString();

                           // DropDownList6room.Items.Add(new ListItem(dt.Rows[0][10].ToString(), "1"));


                            DropDownList6room.SelectedItem.Text = dt.Rows[0][10].ToString();

                           // DropDown7alfarch.Items.Add(new ListItem(dt.Rows[0][11].ToString(), "1"));


                            DropDown7alfarch.SelectedItem.Text = dt.Rows[0][11].ToString();

                           // DropDownList8alkasa.Items.Add(new ListItem(dt.Rows[0][12].ToString(), "1"));


                            DropDownList8alkasa.SelectedItem.Text = dt.Rows[0][12].ToString();

                           // DropDownList5dirction.Items.Add(new ListItem(dt.Rows[0][13].ToString(), "1"));


                            DropDownList5dirction.SelectedItem.Text = dt.Rows[0][13].ToString();

                          //  DropDownList5havinge.Items.Add(new ListItem(dt.Rows[0][14].ToString(), "1"));


                            DropDownList5havinge.SelectedItem.Text = dt.Rows[0][14].ToString();

                         //   DropDownList5refernc.Items.Add(new ListItem(dt.Rows[0][15].ToString(), "1"));


                            DropDownList5refernc.SelectedItem.Text = dt.Rows[0][15].ToString();


                          //  DropDownList5electron.Items.Add(new ListItem(dt.Rows[0][16].ToString(), "1"));



                            DropDownList5electron.SelectedItem.Text = dt.Rows[0][16].ToString();


                            TextBox2alatlalh.Text = dt.Rows[0][17].ToString();
                            TextBox2area.Text = dt.Rows[0][18].ToString();
                            price.Text = dt.Rows[0][19].ToString();
                            txtdeatials.Text = dt.Rows[0][20].ToString();


                            TextBox6browsercommint.Text = dt.Rows[0][21].ToString();   ////  اضافة ملاحظات للزبون
                          //  DropDownList5many.Items.Add(new ListItem(dt.Rows[0][22].ToString()));



                            DropDownList5many.SelectedItem.Text = dt.Rows[0][22].ToString();


                            DropDownList5masad.SelectedItem.Text = dt.Rows[0][23].ToString();
                            DropDownList5service.SelectedItem.Text = dt.Rows[0][24].ToString();

                            DropDownList5statetutorial.SelectedItem.Text = dt.Rows[0][25].ToString();


                            TextBox8dateother.Text = dt.Rows[0][26].ToString();

                            if (dt.Rows[0][27].ToString() == "remmber")

                                CheckBox1remmber.Checked = true;
                            else if(dt.Rows[0][27].ToString() != "remmber")
                                CheckBox1remmber.Checked = false;


                            Label4.Visible = true;
                            txtstreatname.Visible = true;

                            Label5.Visible = true;
                            txtnumberbuild.Visible = true;




                            DropDownList1.Enabled = true;
                            DropDownList3.Enabled = true;
                            DropDownList4.Enabled = true;

                            DropDownList1mantekanode.Enabled = true;


                            DropDownList2.Enabled = true;
                            DropDownList5tabke.Enabled = true;
                            DropDownList6room.Enabled = true;
                            DropDown7alfarch.Enabled = true;
                            DropDownList8alkasa.Enabled = true;
                            DropDownList5dirction.Enabled = true;
                            DropDownList5havinge.Enabled = true;
                            DropDownList5refernc.Enabled = true;
                            DropDownList5electron.Enabled = true;



                            DropDownList5masad.Enabled = true;
                            DropDownList5service.Enabled = true;



                            DropDownList5many.Enabled = true;

                            DropDownList5statetutorial.Enabled = true;

                            ///////////////////////////////////////////////////////////////////
                            ///
                            TextBox8dateother.Enabled = true;


                            //////////////////////////////////////////////////////////////////////////  ربط البلد مع المدينة مع المنطقة
                            ///




                            //////////////////////////////city


                            // string queryselecity = "select distinct city  from tutorialspublic where city is not null";

                            string queryselecity44 = "select distinct namecitynode   from countrypublic where    namrcountry='" + DropDownList1.SelectedItem.Text + "'     and  namrcountry  is not null";



                            dbconnect.openconn();

                            dt.Clear();

                            dt = dbconnect.selectdata(queryselecity44);



                            dbconnect.closeconn();
                            DropDownList3.Items.Clear();





                            DropDownList3.Items.Add(new ListItem(Convert.ToString(cityupdate), "0"));


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


                            DropDownList4.Items.Add(new ListItem("مزة", "0"));

                            if (dt.Rows.Count > 0)
                            {

                                for (int i = 0; i < dt.Rows.Count; i++)


                                    DropDownList4.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


                            }

                            //Convert.ToString(mantekupdate)

                            //////////////////////////////////////////
                            ///








                            string queryselealmanteka11 = "select distinct namemantekanodenode      from mantekapublic where  namemanteka ='" + DropDownList4.SelectedItem.Text + "'   and namemanteka  is not null";



                            dbconnect.openconn();

                            dt.Clear();

                            dt = dbconnect.selectdata(queryselealmanteka11);



                            dbconnect.closeconn();

                            DropDownList1mantekanode.Items.Clear();

                            DropDownList1mantekanode.Items.Add(new ListItem("/", "0"));
                            if (dt.Rows.Count > 0)
                            {

                                for (int i = 0; i < dt.Rows.Count; i++)


                                    DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));
                            }






                            //////////////////////////////////////////////////////////////////////////  copy نسخة عن العقار

                            if ( Request.QueryString["copy"]=="copy")
                            {


                                pagename.Text = Request.QueryString["pagename"];

                                Button2_addhaveperson.Visible =true;
                                Button2_addhaveperson.Text = "اضافة نسخة عن : " +" "+ DropDownList5statetutorial.SelectedItem.Text;


                                Button2_updatehaveperson.Visible = false;









                            }








                            //////////////////////////////////////



                        }








                    }




                }






                if (Request.QueryString["adddata"] == "addtutorials")   //// اضافة عقار غرض  comment
                {


                    pagename.Text = Request.QueryString["pagename"];


                    browserid.Text = Request.QueryString["browseridview"];

                    txtstatetutorial.Text = Request.QueryString["statetutorial"];

                    addtutorials();
                    TextBox5.Text = "";



                    // if (txtstatetutorial.Text == "solde")
                    //   Button22.Text = "جميع الزبائن الذين لديهم عقارات للبيع";
                    //if (txtstatetutorial.Text == "take")
                    //    Button22.Text = "جميع الزبائن الذين لديهم عقارات للاجار";






                }







                if ( (Request.QueryString["sok"] == "view"))  ///  عرض اضافة صور للعقار المضاف الجديدد

                 {


                    pagename.Text = Request.QueryString["pagename"];


                    yessrequestrice.Visible = false;
                    addimagebutton1.Visible = false;

                    sendrequset.Visible = false;




                    browserid.Text =  Request.QueryString["browseridview"];




                        








                    imagbrowser.Text = browserid.Text;



                 txtstatetutorial.Text = Request.QueryString["statetutorial"];





                    if (txtstatetutorial.Text == "solde")
                        Button22.Text = "جميع الزبائن الذين لديهم عقارات للبيع";
                    if (txtstatetutorial.Text == "take")
                        Button22.Text = "جميع الزبائن الذين لديهم عقارات للاجار";

                    if (txtstatetutorial.Text == "rice")
                        Button22.Text = "جميع الزبائن الذين لديهم  طلب شراءعقار";

                    if (txtstatetutorial.Text == "take_of")
                        Button22.Text = "جميع الزبائن الذين لديهم استاجار عقار ";



                    Literal9.Text = LiMessage.Text = "<strong>" + "تم اضافة العقار بنجاح" + "</strong>  .";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalError();", true);



                    GridView1.Visible = true;


                SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where browserID='" + browserid.Text + "'  ";


                countsold.Visible = false;







                string image = " select max(tutorialID) from tutorials where  tutorialbrowserid = " + browserid.Text + " ";
                ///  id للعقار هذا الزبون


                dbconnect.openconn();
                dt.Clear();

                dt = dbconnect.selectdata(image);


                if (dt.Rows.Count > 0)

                    iamgviewtut.Text = dt.Rows[0][0].ToString();

                tutorialidimagetxt.Text = iamgviewtut.Text;

                tutorialid.Text = dt.Rows[0][0].ToString();


                    dbconnect.closeconn();







                dbconnect.openconn();

                string querinsert55 = "select browserfirstName,browserlastName,NumberPhone,NumberHome,country,city,manteka,placetutorial," +
                    "tutorialType,tabke,room,alfarch,alkasa,dirction,havinge,refernc,electron,alatlalh,area,price ,tutorialDeatils,browsercomment,many,masad,Serviecother,namesatae,dateother  from mybrowser, tutorials where " +
                    "tutorialbrowserid=browserid and tutorialID=" + tutorialidimagetxt.Text + " and  State='" + txtstatetutorial.Text + "' and isactive='true'   ";

                   dt.Clear();
                   dt= dbconnect.selectdata(querinsert55);

                    dbconnect.closeconn();

                    // Literal5.Text = tutorialidimage;

                  if (dt.Rows.Count > 0)

                  {
                    // Literal4.Text = dt.Rows[0][4].ToString();


                    TextBox2.Text = dt.Rows[0][0].ToString();
                    TextBox3.Text = dt.Rows[0][1].ToString();


                    txtFirstNam.Text = dt.Rows[0][0].ToString() ;
                    txtMiddleName.Text = dt.Rows[0][1].ToString();
                    textphone.Text =dt.Rows[0][2].ToString() ;
                    textphonhome.Text =dt.Rows[0][3].ToString() ;
                    



                    txtFirstNam.ReadOnly = true;
                    txtMiddleName.ReadOnly = true;
                    textphone.ReadOnly = true;
                    textphonhome.ReadOnly = true;

                    TextBox6browsercommint.ReadOnly = true;




                    DropDownList1.Items.Clear();
                    DropDownList3.Items.Clear();
                    DropDownList4.Items.Clear();


                    DropDownList1.Items.Add(new ListItem( dt.Rows[0][4].ToString(),"1"));

                    DropDownList3.Items.Add(new ListItem( dt.Rows[0][5].ToString(),"1"));
                    DropDownList4.Items.Add(new ListItem( dt.Rows[0][6].ToString(),"1"));

                    TextBox4.Text = dt.Rows[0][7].ToString();

                    Label4.Visible = false;
                    txtstreatname.Visible = false;

                    Label5.Visible = false;
                    txtnumberbuild.Visible = false;



                    placetutorialee.Text = DropDownList1.SelectedItem + "-" + DropDownList3.SelectedItem + "-" + DropDownList4.SelectedItem;



                    DropDownList1.Enabled = false;
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                        DropDownList1mantekanode.Enabled = false;



                    DropDownList2.Items.Clear();
                    DropDownList5tabke.Items.Clear();
                    DropDownList6room.Items.Clear();
                    DropDown7alfarch.Items.Clear();
                    DropDownList8alkasa.Items.Clear();
                    DropDownList5dirction.Items.Clear();
                    DropDownList5havinge.Items.Clear();
                    DropDownList5refernc.Items.Clear();
                    DropDownList5electron.Items.Clear();
                    DropDownList5many.Items.Clear();


                        DropDownList5masad.Items.Clear();
                        DropDownList5service.Items.Clear();

                        DropDownList5statetutorial.Items.Clear();









                        DropDownList2.Items.Add(new ListItem( dt.Rows[0][8].ToString(),"1"));
                    DropDownList5tabke.Items.Add(new ListItem( dt.Rows[0][9].ToString(),"1"));
                    DropDownList6room.Items.Add(new ListItem( dt.Rows[0][10].ToString(),"1"));
                    DropDown7alfarch.Items.Add(new ListItem( dt.Rows[0][11].ToString(),"1"));
                    DropDownList8alkasa.Items.Add(new ListItem( dt.Rows[0][12].ToString(),"1"));
                    DropDownList5dirction.Items.Add(new ListItem( dt.Rows[0][13].ToString(),"1"));
                    DropDownList5havinge.Items.Add(new ListItem( dt.Rows[0][14].ToString(),"1"));
                    DropDownList5refernc.Items.Add(new ListItem( dt.Rows[0][15].ToString(),"1"));
                    DropDownList5electron.Items.Add(new ListItem( dt.Rows[0][16].ToString(),"1"));


                    TextBox2alatlalh.Text = dt.Rows[0][17].ToString();
                    TextBox2area.Text = dt.Rows[0][18].ToString();
                    price.Text = dt.Rows[0][19].ToString();
                    txtdeatials.Text = dt.Rows[0][20].ToString();


                    TextBox6browsercommint.Text= dt.Rows[0][21].ToString();   ////  اضافة ملاحظات للزبون
                    DropDownList5many.Items.Add(new ListItem(dt.Rows[0][22].ToString()));

                        DropDownList5masad.Items.Add(new ListItem(dt.Rows[0][23].ToString(),"1"));

                        DropDownList5service.Items.Add(new ListItem(dt.Rows[0][24].ToString(),"1"));

                        DropDownList5statetutorial.Items.Add(new ListItem(dt.Rows[0][25].ToString(), "1"));

                        TextBox8dateother.Text = Convert.ToString(dt.Rows[0][26]);



                    DropDownList2.Enabled = false;
                    DropDownList5tabke.Enabled = false;
                    DropDownList6room.Enabled = false;
                    DropDown7alfarch.Enabled = false;
                    DropDownList8alkasa.Enabled = false;
                    DropDownList5dirction.Enabled = false;
                    DropDownList5havinge.Enabled = false;
                    DropDownList5refernc.Enabled = false;
                    DropDownList5electron.Enabled = false;


                        DropDownList5masad.Enabled = false;
                        DropDownList5service.Enabled = false;



                        DropDownList5many.Enabled = false;

                        DropDownList5statetutorial.Enabled = false;


                        TextBox8dateother.Enabled = false;

                    TextBox2alatlalh.ReadOnly = true;
                    TextBox2area.ReadOnly = true;
                    price.ReadOnly = true;
                    txtdeatials.ReadOnly = true;

                }

               

                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;

                Panel11.Visible = true;

                Panel55.Visible = true;


                Panel6.Visible = true;

                Button1_person.Visible = false;
                 // Button2_addhaveperson.Visible = false;

                    DataList1.Visible = false;


                    Button2_addhaveperson.Visible = false;

                Literal3.Text = "<strong>" + " Success! </ strong > Data is added successfully." + "</strong> تم اضافة الزبون مع عقاره بنجاح";

                Literal7.Text = "<strong>" + " Success! </ strong > Data is added successfully." + "</strong>  يرجى اضافة صور للعقار في حال وجود صور ";



                //GridViewsold.Visible = true;





                }



                ////////////////////////////////////////////////////end request query
                ///
                ////////////////////////////////////////////////////////////////////////////////////  Refresh



            } //(!Page.IsPostBack)  }





        }/// <summary>  end load page




        //////////////////////////////////////////////////////////////////    ربط البلد مع المدنية مع المنطقة مع المنطقة الفرعية




        protected void almanteka_SelectedIndexChanged(object sender, EventArgs e)
        {

            string queryselealmanteka = "select distinct namemantekanodenode      from mantekapublic where  namemanteka ='" + DropDownList4.SelectedItem.Text + "'   and namemanteka  is not null";



            dbconnect.openconn();

            dt.Clear();

            dt = dbconnect.selectdata(queryselealmanteka);



            dbconnect.closeconn();


            DropDownList1mantekanode.Items.Clear();


            DropDownList1mantekanode.Items.Add(new ListItem("/ ", "0"));

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));
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


            DropDownList4.Items.Add(new ListItem("حدد منطقة ", "0"));

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


            DropDownList1mantekanode.Items.Add(new ListItem("/ ", "0"));
            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));
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





            DropDownList3.Items.Add(new ListItem("حدد مدينة", "0"));


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


            DropDownList4.Items.Add(new ListItem("حدد منطقة", "0"));

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    DropDownList4.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


            }




        }







        /////////////////////////////////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////   ////   فلترة حسب السعر اقل من 
        /// <summary>


        protected void DDLAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {



            string queryselectmanyandpricesearchview = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive='true'  " +

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








        /// ////////////////////////////////////////////////////////////////////////////////////////// فلترة حسب السعر   bettowen




        protected void pricbetoeenview11_SelectedIndexChanged(object sender, EventArgs e)
        {



            string queryselectmanyandpricesearchviewbetoeen = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive='true'  " +

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



            string queryselectmanyandpricesearchviewbetoeen = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive='true'  " +

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



        /// <summary>
        /// ////////////////////////////////////// update name (تعديل التسميات()
        /// 

       

        ////////////////////////////////////////////////////



        public string getstring(int n)
        {
            string str = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
            str = str.Substring(0, str.Length - 2);
            return str;
        }




        protected void upload_Click(object sender, EventArgs e)
        {
            string patthte;
            string pass = "DF34345";



            if (FileUpload1.HasFile)
            {
                // try
                //{

                pass = Convert.ToString(Session["adminID"]) + getstring(30);


                patthte = ("/files/" + pass + Path.GetExtension(FileUpload1.PostedFile.FileName));





                FileUpload1.SaveAs(Server.MapPath(patthte));



                // tutoriallink.Visible = true;
                tutoriallink.Text = patthte;







                ////////////////////////////////////////////////////////////






                dbconnect.openconn();


                string imgadd = "insert into linkimage(Tutoriallinke ,browserlinkid,tutorialslinkid) values( '" + tutoriallink.Text + "' , " + imagbrowser.Text + "," + iamgviewtut.Text + " )   ";

                ////////   تم ربط الصور مع عقار الزبون


                dbconnect.insertdata(imgadd);

                Literal4.Text = "kuyyyyyyyyyyyyy";


                dbconnect.closeconn();



                Response.Redirect("MYDashoard.aspx?sok=" + "view" + "&browseridview=" + browserid.Text + "&statetutorial=" + txtstatetutorial.Text);

            }
            else
            {
                Literal9.Text = LiMessage.Text = "<strong>" + "يرجى اختيار صورة اولا للتحميل" + "</strong>  .";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalError();", true);


            }



            // catch (Exception )
            // {

            //}
            //}


        }

        protected void BuAddDatahave_Click(object sender, EventArgs e)   /// button add عقار للزبون
        {

            // if(  Request.QueryString["adddata"] == "addtutorials")
            // {

           string comandshow = "";


            string date = "";

            string nameprice = "";

            string namestate = "";

            string remmbertrue = "";


            if ((browserid.Text != "") )
            {


                //  try
                //  {


                textplcae.Text = "الشارع:" + txtstreatname.Text + "-" + "بناء رقم:" + txtnumberbuild.Text;

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

                string many = DropDownList5many.SelectedItem.Text;   /// العملة


                string masad = DropDownList5masad.SelectedItem.Text;   /// مصعد


                string servic = DropDownList5service.SelectedItem.Text;   /// خدمات البناء






                if (txtstatetutorial.Text == "solde")
                     namebutton = "اضغط هنا لشراء هذا العقار";


                if (txtstatetutorial.Text == "take")
                     namebutton = "اضغط هنا  لاستأجار هذا العقار";





                TextBox6.Visible = true;
                if ((price.Text != "") && (DropDownList5many.SelectedItem.Text != "") && (DropDownList1.SelectedItem.Text != "") && (DropDownList2.SelectedItem.Text != "") && (DropDownList3.SelectedItem.Text != "حدد مدينة") && (DropDownList4.SelectedItem.Text != "حدد منطقة") &&(DropDownList5statetutorial.SelectedItem.Text!="/"))
                {



                 ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addtutoroial();", true);


                   comandshow = TextBox6.Text;


                    if (comandshow == "ok")
                   {



                        string querpower2 = "select  power from  manypower  where namemany='" + many + "' ";


                        dbconnect.openconn();

                        dt = dbconnect.selectdata(querpower2);

                        dbconnect.closeconn();


                        int power9922 = Convert.ToInt16(dt.Rows[0][0].ToString());


                        double price9922 = Convert.ToDouble(price.Text);


                        double powerprice99 = Convert.ToDouble(price9922 * Math.Pow(10, power9922));



                        /////////////////////////////////////////////////
                        ///



                        //DropDownList5statetutorial.Items.Add(new ListItem(" ", "0"));

                        // DropDownList5statetutorial.Items.Add(new ListItem("عروض بيع", "1"));
                        // DropDownList5statetutorial.Items.Add(new ListItem("طلبات شراء", "2"));

                        // DropDownList5statetutorial.Items.Add(new ListItem("طلبات استئجار", "3"));

                        // DropDownList5statetutorial.Items.Add(new ListItem("عروض ايجار", "4"));




                        txtstatetutorial.Text = "";


                        if (DropDownList5statetutorial.SelectedItem.Text=="عروض بيع")
                        {
                            txtstatetutorial.Text = "solde";
                            namestate = "عروض بيع";

                            nameprice = "سعر العقار";

                        }

                        if (DropDownList5statetutorial.SelectedItem.Text=="عروض ايجار")
                        {
                            txtstatetutorial.Text = "take";

                            namestate = "عروض ايجار";

                            nameprice = "ايجار العقار";

                        }

                        if (DropDownList5statetutorial.SelectedItem.Text=="طلبات شراء")
                        {
                            txtstatetutorial.Text = "rice";

                            namestate = "طلبات شراء";
                            nameprice = "سعر العقار";

                        }
                        if (DropDownList5statetutorial.SelectedItem.Text=="طلبات استئجار")
                        {
                            txtstatetutorial.Text = "take_of";

                            namestate = "طلبات استئجار";
                            nameprice = "ايجار العقار";

                        }


                        /////////////

                        if (TextBox8dateother.Text != "")
                        {

                            date = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(TextBox8dateother.Text));
                        }
                        else if (TextBox8dateother.Text == "")
                        {

                            date = String.Format("{0:yyyy-MM-dd }", DateTime.Now);

                        }


                        //////////////




                        if (CheckBox1remmber.Checked == true)
                        {
                            remmbertrue = "remmber";

                            if (browserid.Text != "")
                            {

                                string updateremmber = "update mybrowser set remmberbrowser='remmber'  where browserid='" + browserid.Text + "' ";


                                dbconnect.openconn();

                                dbconnect.insertdata(updateremmber);

                                dbconnect.closeconn();



                            }


                        }

                        ////////////////////////////////////////////////


                        string querinsert = "insert into  tutorials(country ,city  ,manteka ,placetutorial ," +
                             "tutorialType,tabke,room,alfarch,alkasa,dirction ,havinge,refernc,electron ," +

                              " alatlalh ,area  ,price , " +

                             "tutorialDeatils,state,tutorialbrowserid ,isactive,DateStart,many,namebutton,pricpower, masad      ,Serviecother,mantekaother,namesatae,dateother, namepricestate ,remmber  ) " +


                                "values( '" + country + "' , '" + city + "' ,  '" + manteka + "', '" + textplcae.Text + "' , '" + tutorialtype + "' , '" + tabake + "' , '" + room + "' , '" + alfarch + "' , '" + alkasua + "',  '" + dirction + "' , '" + having + "',  '" + refernce + "' , '" + electron + "' , " +



                              "'" + TextBox2alatlalh.Text + "',  '" + TextBox2area.Text + "' ,  " + price.Text + " ,'" + txtdeatials.Text + "', '" + txtstatetutorial.Text + "', " + browserid.Text + "  ," +

                              " 'true', '" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "', '" + many + "','" + namebutton + "'," + powerprice99 + ",'" + masad + "','" + servic + "','" + DropDownList4.SelectedItem.Text + "', '" + namestate + "'," +

                               "'" + date + "' , '"+ nameprice + "' , '"+ remmbertrue+"' )   ";


                    


                          dbconnect.openconn();

                          dbconnect.insertdata(querinsert);


                          dbconnect.closeconn();


                          Response.Redirect("MYDashoard.aspx?sok=" + "view" + "&browseridview=" + browserid.Text + "&statetutorial=" + txtstatetutorial.Text);


                        

                     }



                }
                
                else if((DropDownList1.SelectedItem.Text == "") || (DropDownList3.SelectedItem.Text == "حدد مدينة") || (price.Text == "") || (DropDownList4.SelectedItem.Text == "حدد منطقة") || (DropDownList2.SelectedItem.Text == "") || (DropDownList5many.SelectedItem.Text=="")||(DropDownList5statetutorial.SelectedItem.Text=="/"))
                {


                   if (DropDownList1.SelectedItem.Text == "")

                       ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addcountry();", true);


                    if (DropDownList3.SelectedItem.Text == "حدد مدينة")
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addcity();", true);



                    if (DropDownList4.SelectedItem.Text == "حدد منطقة")

                          ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addplace();", true);



                    if (DropDownList5many.SelectedItem.Text == "" )
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addprice();", true);



                    if ((DropDownList2.SelectedItem.Text == ""))
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addtype();", true);


                    if (price.Text == "")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addprice();", true);


                    if (DropDownList5statetutorial.SelectedItem.Text == "/")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addstate();", true);





                }



            }
            else
            
                LiMessage.Text = "<strong>Warning!</strong> " + "لم تتم الاضافة";

            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "noadd();", true);


        }









        protected void GridView4_RowDataBound(object sender, GridViewRowEventArgs e)
        {


            // Label Label2AcountType = (Label)e.Row.FindControl("Label2AcountType");





        }





        protected void GridView4remmberdelete_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if ((e.CommandName == "remmber"))  /// ازالة التذكير
            {
                txtstatetutorial.Text = Request.QueryString["statetutorial"];

                tutorialid.Text = Request.QueryString["id"];   //// لذلك نستخدم buttonlink للحصور على id العقار المحدد


               // Label51.Text = tutorialid.Text;

                if (tutorialid.Text != "")
                {
                    dbconnect.openconn();

                    string querinsert55remm = "update  tutorials set remmber='nullee' where  tutorialID = '" + tutorialid.Text + "'  ";


                    dbconnect.insertdata(querinsert55remm);

                    dbconnect.closeconn();
                }
             
                //////////////////////////////////////////   لمعرفة اذا كان الزبون ايضا يجب ازالة التذكير



                if(browserid.Text!="")
                {





                    dbconnect.openconn();

                    string querinsert55 = "select tutorialID  from tutorials where " +
                        "tutorialbrowserid =" + browserid.Text + " and remmber='remmber'    ";

                    dt.Clear();
                    dt = dbconnect.selectdata(querinsert55);

                    dbconnect.closeconn();

                    if(dt.Rows.Count==0)
                    {


                        dbconnect.openconn();

                        string querinsert55remmb = "update  mybrowser set remmberbrowser='nulle' where  browserid='" + browserid.Text + "'  ";


                        dbconnect.insertdata(querinsert55remmb);

                        dbconnect.closeconn();






                        dbconnect.openconn();

                        string querinsert5522 = "select browserID  from mybrowser where " +
                            "browserID =" + browserid.Text + " and remmberbrowser='remmber'    ";

                        dt.Clear();
                        dt = dbconnect.selectdata(querinsert5522);






                    }




                    if ((pagename.Text == "صفحة العقارات الذين لديهم تذكرة"))
                    {

                        SqlDataSource1.SelectCommand = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +
                               "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils ,Dateupdat,masad,Serviecother,namesatae,state,dateother " +
                               "from tutorials where  isactive <>'false' and isactive<>'win'  and tutorialbrowserid=" + browserid.Text + " and remmber='remmber'   ";



                        remmber = "العقارات الذين لديهم حالة تذكرة";

                        DataList1.Visible = true;




                        dbconnect.openconn();

                        string querinsertimageuu = "select tutorialID ,State from tutorials where " +
                            "tutorialbrowserid =" + browserid.Text + "  and isactive <>'false' and isactive<>'win'  and remmber='remmber' ";


                        dt.Clear();
                        dt = dbconnect.selectdata(querinsertimageuu);

                        dbconnect.closeconn();




                        if (dt.Rows.Count > 0)
                        {





                            TextBox5.Text = dt.Rows.Count + " " + "عدد" + "" + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;





                        }







                    }
                    else
                    {


                        SqlDataSource1.SelectCommand = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +
                              "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils ,Dateupdat,masad,Serviecother,namesatae,state,dateother " +
                              "from tutorials where  isactive <>'false' and isactive<>'win'  and tutorialbrowserid=" + browserid.Text + "    ";




                        DataList1.Visible = true;







                        dbconnect.openconn();

                        string querinsertimageuu = "select tutorialID ,State from tutorials where " +
                            "tutorialbrowserid =" + browserid.Text + "  and isactive <>'false' and isactive<>'win'   ";


                        dt.Clear();
                        dt = dbconnect.selectdata(querinsertimageuu);

                        dbconnect.closeconn();




                        if (dt.Rows.Count > 0)
                        {





                            TextBox5.Text = dt.Rows.Count + " " + "عدد" + "" + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;





                        }










                    }









                }










            }


        }




            protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
            {

            if ((e.CommandName == "addNEW"))  /// اضافة عقار جديد
            {
                int index = Convert.ToInt32(e.CommandArgument);

                // browserid.Text = "jknjkn";

                pagename.Text = Request.QueryString["pagename"];


                TextBox5.Text = "";


                browserid.Text = (GridView1.DataKeys[index].Value.ToString());

                GridView1.SelectedIndex = index;

                // browserid.Text = GridView1.SelectedRow.Cells[1].Text;

                // browserid.Text = (GridView1.SelectedRow.FindControl("Label41s") as Label).Text;

                DataList1.Visible = false;



                //  browserid.Text = GridView1.SelectedRow.Cells[1].Text;

                if (browserid.Text != "")
                {
                    textphone.Visible = true;

                    textphonhome.Visible = true;





                    addtutorials();


                    Response.Redirect("MYDashoard.aspx?adddata=" + "addtutorials" + "&browseridview=" + browserid.Text + "&statetutorial=" + txtstatetutorial.Text);




                }



            }

              if (e.CommandName == "view")   //// عرض العقارات
              {
                int index = Convert.ToInt32(e.CommandArgument);


                browserid.Text = (GridView1.DataKeys[index].Value.ToString());

               




                dbconnect.openconn();

                string querinsert55 = "select browserfirstName,browserlastName from mybrowser where " +
                    "browserid =" + browserid.Text + "  ";

                dt.Clear();
                dt = dbconnect.selectdata(querinsert55);

                dbconnect.closeconn();

                TextBox2.Text = dt.Rows[0][0].ToString();

                TextBox3.Text = dt.Rows[0][1].ToString();



                TextBox5.Visible = true;


                Panel1.Visible = true;

                GridView1.Visible = true;

                Literal3.Text = "";
                Literal7.Text = "";


                SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment from mybrowser where browserID='" + browserid.Text + "'  ";



                Panel1.Visible = true;

                GridView1.Visible = true;

                Literal3.Text = "";
                Literal7.Text = "";





                    dbconnect.openconn();

                    string querinsertimage = "select tutorialID ,State from tutorials where " +
                        "tutorialbrowserid =" + browserid.Text + "  and isactive <>'false' and isactive<>'win'  ";


                    dt.Clear();
                    dt = dbconnect.selectdata(querinsertimage);

                    dbconnect.closeconn();




                    if (dt.Rows.Count > 0)
                    {



                      

                        TextBox5.Text = dt.Rows.Count + " " + "عدد" + "" + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;


                        upload.Visible = false;

                        Panel55.Visible = false;/// لتحميل الصور

                        Panel2.Visible = false;
                        Panel3.Visible = false;
                        Panel4.Visible = false;

                        Panel11.Visible = false;

                        Panel6.Visible = false;









                       SqlDataSource1.SelectCommand = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +
                           "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils ,Dateupdat,masad,Serviecother,namesatae,state,dateother " +
                           "from tutorials where  isactive <>'false' and isactive<>'win'  and tutorialbrowserid=" + browserid.Text + "   ";



                        remmber = "";

                         DataList1.Visible = true;


                        countsold.Visible = false;



                       dbconnect.openconn();

                        string querinsertimageremmber = "select   remmberbrowser from mybrowser where browserID='" + browserid.Text + "'  ";



                       dt.Clear();
                        dt = dbconnect.selectdata(querinsertimageremmber);

                        dbconnect.closeconn();



                        if ((dt.Rows[0][0].ToString() == "remmber")&& ( pagename.Text =="صفحة العقارات الذين لديهم تذكرة"))

                        {

                          
                          SqlDataSource1.SelectCommand = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +
                               "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils ,Dateupdat,masad,Serviecother,namesatae,state,dateother " +
                               "from tutorials where  isactive <>'false' and isactive<>'win'  and tutorialbrowserid=" + browserid.Text + " and remmber='remmber'   ";



                           remmber = "العقارات الذين لديهم حالة تذكرة";


                           DataList1.Visible = true;










                          dbconnect.openconn();

                              string querinsertimage22 = "select tutorialID ,State from tutorials where " +
                            "tutorialbrowserid =" + browserid.Text + "  and isactive <>'false' and isactive<>'win' and remmber='remmber'  ";


                          dt.Clear();
                              dt = dbconnect.selectdata(querinsertimage22);

                          dbconnect.closeconn();




                            if (dt.Rows.Count > 0)
                           {





                              TextBox5.Text = dt.Rows.Count + " " + "عدد" + "" + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;




                            }











                        }




                    }

                else

                    TextBox5.Text = dt.Rows.Count + " " + "لايوجد" + " " + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;



               }

            if (e.CommandName == "updatebrowser")    /// تعديل بيانات الزبون
            {


                pagename.Text = Request.QueryString["pagename"];
                int index = Convert.ToInt32(e.CommandArgument);

                browserid.Text = (GridView1.DataKeys[index].Value.ToString());




                dbconnect.openconn();

                string querinsert55 = "select browserfirstName,browserlastName from mybrowser where " +
                    "browserid =" + browserid.Text + "  ";

                dt.Clear();
                dt = dbconnect.selectdata(querinsert55);

                dbconnect.closeconn();

                TextBox2.Text = dt.Rows[0][0].ToString();

                TextBox3.Text = dt.Rows[0][1].ToString();



                Panel1.Visible = true;

                GridView1.Visible = true;


                SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where browserID='" + browserid.Text + "'  ";


                countsold.Visible = false;


                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;

                Panel11.Visible = true;
                Panel55.Visible = false;
                Panel6.Visible = false;

                GridView1.Visible = true;

                DataList1.Visible = false;





                dbconnect.openconn();

                string querupdate = "select browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment from mybrowser where " +
                       "browserid =" + browserid.Text + "  ";

                dt.Clear();
                dt = dbconnect.selectdata(querupdate);



                // Literal5.Text = tutorialidimage;

                if (dt.Rows.Count > 0)

                {
                    // Literal4.Text = dt.Rows[0][4].ToString();




                    txtFirstNam.Text = dt.Rows[0][0].ToString();
                    txtMiddleName.Text = dt.Rows[0][1].ToString();
                    textphone.Text = dt.Rows[0][2].ToString();
                    textphonhome.Text = dt.Rows[0][3].ToString();
                    TextBox6browsercommint.Text = dt.Rows[0][4].ToString();




                    dbconnect.closeconn();




                    txtFirstNam.ReadOnly = false;
                    txtMiddleName.ReadOnly = false;
                    textphone.ReadOnly = false;
                    textphonhome.ReadOnly = false;
                    TextBox6browsercommint.ReadOnly = false;




                    Button1_person.Visible = false;

                    Button2_person_update.Visible = true;







                    Response.Redirect("MYDashoard.aspx?updateperson=" + "updateperson" + "&browseridview=" + browserid.Text+ "&statetutorial="+txtstatetutorial.Text);



                }




            }



            if (e.CommandName == "deletebrowser")    /// حذف  الزبون
            {


                int index = Convert.ToInt32(e.CommandArgument);

                browserid.Text = (GridView1.DataKeys[index].Value.ToString());





                ////////////   اذا الزبون ليه طلبات شراء او استاجار على غقاارته لايجب حذفه 


                /////   teswin  : عنده طلب استاجار او شراء للعقار

                dbconnect.openconn();



                string yy = "select tutorialID from tutorials where  isactive ='testwin' " +

                    " and tutorialbrowserid=" + browserid.Text + "   ";
                



                dbconnect.openconn();

                dt = dbconnect.selectdata(yy);

                dbconnect.closeconn();


                if (dt.Rows.Count > 0)
                {







                    if(txtstatetutorial.Text=="solde")


                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notdeletebrowsersold();", true);   ////  لايمكن حذف الزبون لان لديه عقارات طلب شراء او استجار


                    else if(txtstatetutorial.Text=="take")


                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notdeletebrowsertake();", true);   ////  لايمكن حذف الزبون لان لديه عقارات طلب شراء او استجار






                }



                if ((dt.Rows.Count == 0) )    //////  

                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "browserdelet();", true);


                    deletebrowser.Visible = true;

                }

              






            }


        }


        /// <summary>
        /// //////////////////////////////////////////////////// button statac delete bowser
        /// 




        protected void delet_browser(object sender, EventArgs e)  // حذف الزبون )
        {

            if (browserid.Text != "")
            {

                dbconnect.openconn();

                string quer55delet = "delete from mybrowser where " +
                    "browserid =" + browserid.Text + "  ";


                dbconnect.insertdata(quer55delet);


                TextBox2.Text = "";

                TextBox3.Text = "";

                Literal3.Text = "";
                Literal7.Text = "";

                countsold.Visible = false;

                Panel1.Visible = true;

                GridView1.Visible = true;







                ///////////////////////////////////////  view deletbrowser
                ///













                if ((Literal26.Text == "ok") || (deletbrowsernull == "ok"))
                {


                    SqlDataSource55.SelectCommand = "select browserID, browserfirstName, browserlastName, NumberPhone, NumberHome, browsercomment  from mybrowser " +

                                 " where browserID not in( select  browserid  from  filterstate)";



                                GridView1.Visible = true;


                       

                }



                if ((Literal26.Text == "yes") || (deletbrowsernull == "yes"))
                {



                    SqlDataSource55.SelectCommand = "select browserID, browserfirstName, browserlastName, NumberPhone, NumberHome, browsercomment  from mybrowser " +

                                 " where browserID in( select  browserid  from  filterstate)";


                                GridView1.Visible = true;


                }


                if ((Literal26.Text == "no") || (deletbrowsernull == "no"))
                {



                    Response.Redirect("MYDashoard.aspx?state=" + "request_master");


                }


                    TextBox5.Visible = false;



                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;

                Panel11.Visible = false;
                Panel55.Visible = false;
                Panel6.Visible = false;


                DataList1.Visible = false;
            }


        }



            /////////////////////////////////  update عقار + صور



            protected void repatedeimage_command(object sender, RepeaterCommandEventArgs e)  //  حذف صور  موجودة لعقار الزبون
            {

              if (e.CommandName == "deleteimage")   // حذف  صور عقار الزبون
              {

                pagename.Text = Request.QueryString["pagename"];

                tutorialid.Text = Request.QueryString["id"];   ///// id الصورة لعقار الزبون


                dbconnect.openconn();


                string deletetutorialimage = "delete from  linkimage  where id =" + tutorialid.Text + "    ";  /// tutorialid هو id لصورة

                ////////   حذف عقار الزبون المحدد ضمن datalist


                dbconnect.insertdata(deletetutorialimage);


                dbconnect.closeconn();




                Response.Redirect("MYDashoard.aspx?updateimage=" + "updateimage" + "&browseridview=" + browserid.Text + "&imageid=" + tutorialid.Text + "&statetutorial=" + txtstatetutorial.Text);



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

              //  txtstatetutorial.Text = Request.QueryString["statetutorial"];

                tutorialid.Text = Request.QueryString["id"];   //// لذلك نستخدم buttonlink للحصور على id العقار المحدد

                //tutorialid.Text = Label8tutorialid.Text;


                pagename.Text = Request.QueryString["pagename"];
                // DataList1.DataKeys[index]


                DataList1.Visible = false;




                dbconnect.openconn();



                string yy = "select tutorialID,state from tutorials where   isactive ='true' " +

                    " and tutorialbrowserid=" + browserid.Text + " and  tutorialID=" + tutorialid.Text + "  ";

               


                dbconnect.openconn();

                dt = dbconnect.selectdata(yy);

                dbconnect.closeconn();


                if (dt.Rows.Count > 0)
                {



                    if (dt.Rows[0][1].ToString() != "")

                        txtstatetutorial.Text = dt.Rows[0][1].ToString();




                    Response.Redirect("MYDashoard.aspx?updatetutorials=" + "updatetutorials" + "&tutorialid=" + tutorialid.Text + "&browseridview=" + browserid.Text + "&statetutorial=" + txtstatetutorial.Text);

                    //// سوف يظهر نموذج التعديل ذاته نموذج الاضافة


                }
               if ((dt.Rows.Count == 0) && (txtstatetutorial.Text == "solde"))   //////  في حالة يكون العقار مطلوب للشراء او استاجار

               {
                     ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notupdatesold();", true);


                }

                 if ((dt.Rows.Count == 0) && (txtstatetutorial.Text == "take"))

                 {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notupdatetak();", true);


                 }

            }

            ////////////  /////////////////////////////////////////////////////////////////   اضافة نسخة عن العقار


            if (e.CommandName == "copyother")   // اضافة نسخة عقار الزبون
            {


                pagename.Text = Request.QueryString["pagename"];

                txtstatetutorial.Text = Request.QueryString["statetutorial"];

                tutorialid.Text = Request.QueryString["id"];   //// لذلك نستخدم buttonlink للحصور على id العقار المحدد


                DataList1.Visible = false;


                dbconnect.openconn();




                    Response.Redirect("MYDashoard.aspx?updatetutorials=" + "updatetutorials" + "&tutorialid=" + tutorialid.Text + "&browseridview=" + browserid.Text + "&statetutorial=" + txtstatetutorial.Text+"&copy="+"copy");

                  
            }




           //////////////////////////////////     ////////////////  ///////////////////////////////////////////////  
                ///

                if (e.CommandName == "inserteimage")    ///  اضافة صور جديدة للعقار== كتعديل للصور 
            {
                // int index = Convert.ToInt32(e.CommandArgument);

                pagename.Text = Request.QueryString["pagename"];
                tutorialid.Text = Request.QueryString["id"];

                // tutorialid.Text = (DataList1.DataKeys[index].ToString());

                txtstatetutorial.Text = Request.QueryString["statetutorial"];

                /////////////////////////////////////////////upload button
                ///

                



                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "imageadd();", true);








            }






            if (e.CommandName == "deletetutorial")   //  حذف عقار الزبو
            {


                pagename.Text = Request.QueryString["pagename"];

                tutorialid.Text = Request.QueryString["id"];


                txtstatetutorial.Text = Request.QueryString["statetutorial"];




                dbconnect.openconn();



                string yy = "select tutorialID from tutorials where  isactive ='testwin' " +

                    " and tutorialbrowserid =" + browserid.Text + " and  tutorialID =" + tutorialid.Text + "  ";




                dbconnect.openconn();

                dt = dbconnect.selectdata(yy);

                dbconnect.closeconn();


                if (dt.Rows.Count == 0)
                {


                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tutorialdelet();", true);

                    delettuorialbutton.Visible = true;

                }



                if ((dt.Rows.Count > 0) && (txtstatetutorial.Text == "solde"))    //////  في حالة يكون العقار مطلوب للشراء او استاجار


                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notdeletetutorialsold();", true);


                }

                if ((dt.Rows.Count > 0) && (txtstatetutorial.Text == "take"))

                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notdeletetutorialtake();", true);


                }














            }



        }


        /////////////////////////////////////////////////// حذف العقار 

        protected void delet_tutorial(object sender, EventArgs e)  // اضافة صور للعقار )هل انت تري= اضافة صورة )
        {


            if ((tutorialid.Text != "") && (browserid.Text != ""))
            {
                dbconnect.openconn();


                string deletetutorial = "delete from  tutorials  where tutorialID =" + tutorialid.Text + "  and isactive='true'   ";  /// id هو tutorialid للعقار

                ////////   حذف عقار الزبون المحدد ضمن datalist


                dbconnect.insertdata(deletetutorial);



                dbconnect.closeconn();





                Response.Redirect("MYDashoard.aspx?updateimage=" + "updateimage" + "&browseridview=" + browserid.Text + "&tutorialid=" + tutorialid.Text + "&statetutorial=" + txtstatetutorial.Text);




            }

        }



        /// <summary>
        /// ////////////////////////////////////////////////////  button static اضافة صور للعقار
        protected void onload_file(object sender, EventArgs e)  // اضافة صور للعقار )هل انت تري= اضافة صورة )
        {



            string patthte;
            string pass = "DF34345";

            // tutoriallink.Text = "";

           

                if( (FileUpload3.HasFile)&&(tutorialid.Text!=""))
                {


                    pass = Convert.ToString(Session["adminID"]) + getstring(30);


                    patthte = ("/files/" + pass + Path.GetExtension(FileUpload3.PostedFile.FileName));





                    FileUpload3.SaveAs(Server.MapPath(patthte));



                    // TextBoxlinkimag.Visible = true;


                    TextBoxlinkimag.Text = patthte;


                    if ((TextBoxlinkimag.Text != ""))
                    {


                        dbconnect.openconn();


                        string imgadd = "insert into linkimage(Tutoriallinke ,browserlinkid,tutorialslinkid) values( '" + TextBoxlinkimag.Text + "' , " + browserid.Text + "," + tutorialid.Text + " )   ";

                        ////////   تم ربط الصور مع عقار الزبون


                        dbconnect.insertdata(imgadd);

                        // Literal4.Text = "kuyyyyyyyyyyyyy";


                        dbconnect.closeconn();





                    dbconnect.openconn();

                    string querinsertimage = "select tutorialID ,State from tutorials where " +
                        "tutorialbrowserid =" + browserid.Text + "  and isactive <>'false' and isactive<>'win'  ";


                    dt.Clear();
                    dt = dbconnect.selectdata(querinsertimage);

                    dbconnect.closeconn();




                      if (dt.Rows.Count > 0)
                      {










                        SqlDataSource1.SelectCommand = "select tutorialID,tutorialType,price,country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +
                                  "havinge,refernc,room ,alfarch,alkasa,dirction,electron,DateStart,many,tutorialDeatils ,Dateupdat,masad,Serviecother,namesatae,state,dateother" +
                                  "from tutorials where   isactive='true'  and tutorialbrowserid=" + browserid.Text + "   ";

                        DataList1.Visible = true;


                      }






                        Response.Redirect("MYDashoard.aspx?updateimage=" + "updateimage" + "&browseridview=" + browserid.Text + "&tutorialid=" + tutorialid.Text + "&statetutorial=" + txtstatetutorial.Text);


                        /// عرض datalist لعقارات الزبون


                    }

                
   
                 }

            else if((tutorialid.Text!="")&&(!FileUpload3.HasFile))
            {


                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notaddimag();", true);



            }






        }









        protected void BuUPDATE_Datahave_Click(object sender, EventArgs e)  // تعديل عقار الزبون
             {

            string namestate = "";

            string nameprice = "";

            string om = "";

            string date = "";

            string remmbertrue = "";



            if (Request.QueryString["updatetutorials"] == "updatetutorials")
            {






                textplcae.Text = "الشارع:" + txtstreatname.Text + "-" + "بناء رقم:" + txtnumberbuild.Text;

                string country = DropDownList1.SelectedItem.Text;  //  البلد

                string city = DropDownList3.SelectedItem.Text; //  المدينة

                string manteka = DropDownList4.SelectedItem.Text +" " + DropDownList1mantekanode.SelectedItem.Text;  //  المنطقة

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


                string servic = DropDownList5service.SelectedItem.Text;   /// خدمات البناء



                ////////////////////////////








                //////////////////////////////

                if ((price.Text != "") && (DropDownList5many.SelectedItem.Text != "") && (DropDownList1.SelectedItem.Text != "") && (DropDownList3.SelectedItem.Text != "") && (DropDownList4.SelectedItem.Text != "حدد منطقة") && (DropDownList2.SelectedItem.Text != "")&&(DropDownList5statetutorial.SelectedItem.Text!=""))
                {


                    TextBox6.Visible = true;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "updatetutoroial();", true);

                    om = TextBox6.Text;

                    if (om == "ok")
                    {




                        string querpower2 = "select  power from  manypower  where namemany='" + many + "' ";


                        dbconnect.openconn();

                        dt = dbconnect.selectdata(querpower2);

                        dbconnect.closeconn();


                        int power9922 = Convert.ToInt16(dt.Rows[0][0].ToString());


                        double price9922 = Convert.ToDouble(price.Text);


                        double powerprice99update = Convert.ToDouble(price9922 * Math.Pow(10, power9922));


                        //////////////////////////////////////


                        if (TextBox8dateother.Text != "")
                        {

                            date = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(TextBox8dateother.Text));
                        }
                        else if (TextBox8dateother.Text == "")
                        {

                            date = String.Format("{0:yyyy-MM-dd }", DateTime.Now);

                        }



                        if (CheckBox1remmber.Checked == true)
                        {


                            remmbertrue = "remmber";


                            if (browserid.Text != "")
                            {

                                string updateremmber = "update mybrowser set remmberbrowser='remmber'  where browserid='" + browserid.Text + "' ";


                                dbconnect.openconn();

                                dbconnect.insertdata(updateremmber);

                                dbconnect.closeconn();



                            }





                        }



                            //DropDownList5statetutorial.Items.Add(new ListItem(" ", "0"));

                            // DropDownList5statetutorial.Items.Add(new ListItem("عروض بيع", "1"));
                            // DropDownList5statetutorial.Items.Add(new ListItem("طلبات شراء", "2"));

                            // DropDownList5statetutorial.Items.Add(new ListItem("طلبات استئجار", "3"));

                            // DropDownList5statetutorial.Items.Add(new ListItem("عروض ايجار", "4"));






                            txtstatetutorial.Text = "";



                        if (DropDownList5statetutorial.SelectedItem.Text == "عروض بيع")
                        {
                            txtstatetutorial.Text = "solde";
                            namestate = "عروض بيع";

                            nameprice = "سعر العقار";

                        }

                        if (DropDownList5statetutorial.SelectedItem.Text == "عروض ايجار")
                        {
                            txtstatetutorial.Text = "take";

                            namestate = "عروض ايجار";

                            nameprice = "ايجار العقار";

                        }

                        if (DropDownList5statetutorial.SelectedItem.Text == "طلبات شراء")
                        {
                            txtstatetutorial.Text = "rice";

                            namestate = "طلبات شراء";
                            nameprice = "سعر العقار";

                        }
                        if (DropDownList5statetutorial.SelectedItem.Text == "طلبات استئجار")
                        {
                            txtstatetutorial.Text = "take_of";

                            namestate = "طلبات استئجار";
                            nameprice = "ايجار العقار";

                        }










                        //////////////////////////////


                        string querupdate_tutorials = "update  tutorials  set  country='" + country + "' ,city ='" + city + "' ,manteka='" + manteka + "' ,placetutorial='" + textplcae.Text + "' ," +
                          "tutorialType='" + tutorialtype + "',tabke='" + tabake + "',room='" + room + "',alfarch='" + alfarch + "',alkasa='" + alkasua + "',dirction='" + dirction + "' ,havinge='" + having + "',refernc='" + refernce + "',electron='" + electron + "' ," +

                          " alatlalh='" + TextBox2alatlalh.Text + "' ,area='" + TextBox2area.Text + "'  ,price=" + price.Text + " , " +

                          "tutorialDeatils='" + txtdeatials.Text + "',Dateupdat ='" + String.Format("{0:yyyy-MM-dd hh:mm:ss }", DateTime.Now) + "',many='" + many + "', pricpower=" + powerprice99update + "  , masad='" + masad + "',serviecother='" + servic + "',  mantekaother='" + DropDownList4.SelectedItem.Text + "',namesatae='" + namestate + "',  state = '" + txtstatetutorial.Text + "' , " +

                          "  dateother='" + date + "'   ,  namepricestate='"+ nameprice + "', remmber='"+ remmbertrue+"'  " +


                            " where  tutorialID=" + tutorialid.Text + "    and isactive='true'    ";




                            dbconnect.openconn();

                            dbconnect.insertdata(querupdate_tutorials);

                            dbconnect.closeconn();

                       

                          /////////////////////////////////////////////////view
                          ///


                        dbconnect.openconn();

                        string querinsert55 = "select browserfirstName,browserlastName from mybrowser where " +
                            "browserid =" + browserid.Text + "   ";

                        dt.Clear();
                        dt = dbconnect.selectdata(querinsert55);

                        dbconnect.closeconn();

                        TextBox2.Text = dt.Rows[0][0].ToString();

                        TextBox3.Text = dt.Rows[0][1].ToString();


                        TextBox5.Text = dt.Rows.Count + " " + "عدد" + namestate + " عقارات  : " + " " + TextBox2.Text + "  " + TextBox3.Text;

                        TextBox5.Visible = true;

                        Panel2.Visible = false;
                        Panel3.Visible = false;
                        Panel4.Visible = false;

                        Panel11.Visible = false;
                        Panel55.Visible = false;
                        Panel6.Visible = false;



                          GridView1.Visible = true;


                          SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where browserID='" + browserid.Text + "'  ";




                           countsold.Visible = false;
                        //////////////////////////////////////////////////////////


                        if (CheckBox1remmber.Checked == false)
                        {




                            dbconnect.openconn();

                            string querinsert = "select tutorialID  from tutorials where " +
                                "tutorialbrowserid =" + browserid.Text + " and remmber='remmber'    ";

                            dt.Clear();
                            dt = dbconnect.selectdata(querinsert);

                            dbconnect.closeconn();

                            if (dt.Rows.Count == 0)
                            {


                                dbconnect.openconn();

                                string querinsert55remmb = "update  mybrowser set remmberbrowser='nulle' where  browserid='" + browserid.Text + "'  ";


                                dbconnect.insertdata(querinsert55remmb);

                                dbconnect.closeconn();








                            }


                        }




                        ////////////////////
                        Response.Redirect("MYDashoard.aspx?updateimage=" + "updateimage" + "&browseridview=" + browserid.Text + "&tutorialid=" + tutorialid.Text + "&statetutorial=" + txtstatetutorial.Text+"&up="+"ok");

                       


                    }



                }



                else if ((DropDownList1.SelectedItem.Text == "") || (DropDownList3.SelectedItem.Text == "") || (price.Text == "") || (DropDownList4.SelectedItem.Text == "حدد منطقة")|| (DropDownList2.SelectedItem.Text == "") || (DropDownList5many.SelectedItem.Text == "")||(DropDownList5statetutorial.SelectedItem.Text==""))
                {

                    if (DropDownList1.SelectedItem.Text == "")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addcountry();", true);


                    if (DropDownList3.SelectedItem.Text == "")
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addcity();", true);


                    if (DropDownList4.SelectedItem.Text == "حدد منطقة")
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addplace();", true);
                   

                    if (DropDownList5many.SelectedItem.Text == "")
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addprice();", true);


                    if ((DropDownList2.SelectedItem.Text == ""))
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addtype();", true);


                    if (price.Text == "")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addprice();", true);



                    if (DropDownList5statetutorial.SelectedItem.Text == "")

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "addstate();", true);




                }









                ////////////////////////////////////////////////////////////////////////

            }
            else
            
                LiMessage.Text = "<strong>Warning!</strong> " + "لم تتم النعديل";


            





        }





        ////////////////////////////////////////////////////////////////////////////   ربح العقار   mydashoard






        protected void GridView2win_RowCommand(object sender, GridViewCommandEventArgs e)  // بيع شؤراء (طلبات بيع0الشراء-اجا-استاجار)( العقار  mydashoard
        {
           
            if (e.CommandName == "wintutorial")   // ربح المكتب   (شراء او استاجار العقار) 
            {
                // int index = Convert.ToInt32(e.CommandArgument);

                //tutorialid.Text = (GridView2updatedata1.DataKeys[index].ToString());  /// ضمن datalist لانستطيع استخدام هذه التعليمة 

                txtstatetutorial.Text = Request.QueryString["statetutorial"];

                tutorialid.Text = Request.QueryString["id"];   //// لذلك نستخدم buttonlink للحصور على id العقار المحدد

                //tutorialid.Text = Label8tutorialid.Text;


                // DataList1.DataKeys[index]

                ////////////////////////////////////////////////
                ///
                yessrequestsolde.Visible = true;
                deletrequsetsolde.Visible = true;
                yessrequestrice.Visible = true;
                deletrequsetrice.Visible = true;






                if ((txtstatetutorial.Text == "solde") || (txtstatetutorial.Text == "take"))
                {

                    //// حالة true








                 //  Panelmanywin.Visible = true;  //// عمولة المكتب

                   // Panel11.Visible = true;

                  //  Button1_person.Visible = false;

                  //  Button2_person_update.Visible = false;



                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showmessok();", true);



                    ////////////////////////////         ////////////////////////////////////////////////










                }  ////  if ((txtstatetutorial.Text == "solde") || (txtstatetutorial.Text == "take"






                    if (txtstatetutorial.Text == "requset_solde")
                    {




                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "requestsendsoltake();", true);
                    ////تم تحويل   isactive من false الى  true 

                    /////////////////////////////////////////////

                  


                     }  









                if (txtstatetutorial.Text == "requset_take")
                {




                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "requestsendsoltake();", true);

                    ////تم تحويل   isactive من false الى  true 

                   


                }  // if (txtstatetutorial.Text == "requset_take")






                if (txtstatetutorial.Text == "requset_rice")
                {

                    //  Panelmanywin.Visible = true;  //// عمولة المكتب


                   // ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "mm();", true);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "requestsendrictakeof11();", true);



                    ////تم تحويل   isactive من false الى  true 




                }  // if (txtstatetutorial.Text == "requset_rice")






                if (txtstatetutorial.Text == "requset_take_of")
                {

                   // Panelmanywin.Visible = true;  //// عمولة المكتب


                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "requestsendrictakeof11();", true);


                   


                }  // if (txtstatetutorial.Text == "requset_take_of")






                if (txtstatetutorial.Text == "win")
                {

                    ///////////////////  عرض تفاصيل شاري او مستاجر العقار
                    int idbrowser = 0;


                    dbconnect.openconn();

                    string queriss = "select tutorialbrowserwinid , winmany, manywinmany  from tutorials where  tutorialid=" + tutorialid.Text+"  ";
                   

                    dt.Clear();
                    dt = dbconnect.selectdata(queriss);


                    dbconnect.closeconn();


                    TextBox8manywin.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();


                    if (dt.Rows.Count>0)
                    {



                        idbrowser = Convert.ToUInt16(dt.Rows[0][0].ToString());


                        dbconnect.openconn();

                        string querissbrowser = "select browserFirstName,browserLastName,accounttypeID ,NumberPhone,NumberHome,browsercomment,typebrowser" +

                            " from mybrowser where  browserID=" + idbrowser + "  ";
                       

                        dt.Clear();
                        dt = dbconnect.selectdata(querissbrowser);


                        dbconnect.closeconn();



                        TextBox9name1view.Text = dt.Rows[0][0].ToString();

                        TextBox10name2view.Text = dt.Rows[0][1].ToString();

                        TextBox11phonview.Text = dt.Rows[0][2].ToString();

                        TextBox12homeview.Text = dt.Rows[0][3].ToString();

                        TextBox13notview.Text = dt.Rows[0][4].ToString();








                    }


                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showmessokviewwin();", true);





                }  // if (txtstatetutorial.Text == "requset_take_of")








            }

        }

        /////////////////////////////////////////////////////////////////////   button  static (شراء-استاجار العقار(


        protected void sold99takee99(object sender, EventArgs e)    ///  موافق على  شراء-استاجار العقارات  mydashoard
        {



            string gostat = "";

            int idbrowser = 0;



            if ((TextBox99manywin.Text != "") && (Textname1form.Text != "") && (Textname2form.Text != ""))  /////   صفحة شراء او استاجار العقارات
            {


                dbconnect.openconn();

                string queriss = "select browserID  from mybrowser where browserfirstName = '" + Textname1form.Text + "' and browserlastName = '" + Textname2form.Text + "'  ";


                dt.Clear();
                dt = dbconnect.selectdata(queriss);


                dbconnect.closeconn();


                if ((dt.Rows.Count == 0) || (dt.Rows.Count > 1))
                {

                    Literal11.Text = "==0||>1";

                    dbconnect.openconn();

                    string querinsert = "insert into mybrowser(browserFirstName,browserLastName,accounttypeID ,NumberPhone,NumberHome,browsercomment)values('" + Textname1form.Text + "' ," +
                                 "  '" + Textname2form.Text + "'  ,1, '" + Textnumphform.Text + "' , '" + Textnummopform.Text + "', '" + Textnotform.Text + "'  )";



                    dbconnect.insertdata(querinsert);


                    dbconnect.closeconn();





                    dbconnect.openconn();

                    string queriss2 = "select max(browserID)  from mybrowser   ";    //////   ربط العقار مع مالكه الحالي


                    dt.Clear();
                    dt = dbconnect.selectdata(queriss2);


                    dbconnect.closeconn();



                    idbrowser = Convert.ToUInt16(dt.Rows[0][0].ToString());



                }

                else if (dt.Rows.Count == 1)
                {


                    Literal11.Text = "==1";

                    idbrowser = Convert.ToUInt16(dt.Rows[0][0].ToString());

                }









                // if (TextBox6manywin.Text == "")   //// عمولة المكتب 
                //    TextBox6manywin.Text = "0";




                if (txtstatetutorial.Text == "solde")
                    namebutton = "  حذف العقار - عرض بيانات شاري هذا العقار";


                if (txtstatetutorial.Text == "take")
                    namebutton = "عرض بيانات  مستاجر هذا العقار  - حذف العقار  ";


                /// tutorialbrowserwinid="+ idbrowser + " زبون العقار الشاري او المستاجر


                string manywin = DropDownList99manywin.SelectedItem.Text;   ///   عملة ربح العقار












                string querpower2 = "select  power from  manypower  where namemany='" + manywin + "' ";


                dbconnect.openconn();

                dt = dbconnect.selectdata(querpower2);

                dbconnect.closeconn();


                int power9922 = Convert.ToInt16(dt.Rows[0][0].ToString());


                int price9922 = Convert.ToInt16(TextBox99manywin.Text);


                double yypower22 = Convert.ToDouble(price9922 * Math.Pow(10, power9922));














                dbconnect.openconn();

                string querWIN_tutorials = "update  tutorials  set DateStart ='" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "'  ," +


                     " isactive='win'  ,winmany=" + TextBox99manywin.Text + "  ,  manywinmany='" + manywin + "' , namebutton='" + namebutton + "',tutorialbrowserwinid=" + idbrowser + ",pricpowerwin="+ yypower22 + "    " +

                     "    where  tutorialID=" + tutorialid.Text + " and state='" + txtstatetutorial.Text + "'  ";

                ////winmany , manywinmany  عمولة المكتب حسب العملة 


                dbconnect.insertdata(querWIN_tutorials);

                dbconnect.closeconn();





                // Response.Redirect("MYDashoard.aspx?wintutorial=" + "wintutorial" + "&statetutorial=" + txtstatetutorial.Text + "&tutorialid=" + tutorialid.Text);


                //state


                if (txtstatetutorial.Text == "solde")
                    gostat = "rice";
                if (txtstatetutorial.Text == "take")
                    gostat = "take of";


                Response.Redirect("MYDashoard.aspx?state=" + gostat + "&tutorialid=" + tutorialid.Text);



                //// سوف يظهر نموذج filter ذاته نموذج الاضافة

            }

            else if((tutorialid.Text!="")&&((TextBox99manywin.Text == "") || (Textname1form.Text == "") || (Textname2form.Text == "")) )
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notsold99tak99many();", true);




            }







        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////// button staic client (request solde-take) && (request ric-takeof)
        /// ( معالجة طلبات البيع - تاجير )  و (معالجة طلبات شراء - استاجار)

        ////////////////////////////////////////////////////////////////////    

        protected void yessrequestsoldetakebutton(object sender, EventArgs e)    ///  موافق على طلبات بيع-تاجير العقارات  mydashoard
        {




            if ((txtstatetutorial.Text == "requset_solde") && (tutorialid.Text != ""))
            {

                ////تم تحويل   isactive من false الى  true 

                namebutton = " عقار للبيع";

                dbconnect.openconn();

                string querWIN_tutorials = "update  tutorials  set DateStart ='" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "'  ," +


                     " isactive='true'   , namebutton='" + namebutton + "'   " +

                     "    where  tutorialID=" + tutorialid.Text + " and state='solde'  ";


                dbconnect.insertdata(querWIN_tutorials);

                dbconnect.closeconn();







                Response.Redirect("MYDashoard.aspx?requset=" + "requset_solde");



            }  // if (txtstatetutorial.Text == "requset_solde")










            if ((txtstatetutorial.Text == "requset_take") && (tutorialid.Text != ""))
            {




                ////تم تحويل   isactive من false الى  true 

                namebutton = " عقار للايجار";

                dbconnect.openconn();

                string querWIN_tutorials = "update  tutorials  set DateStart ='" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "'  ," +


                     " isactive='true'   , namebutton='" + namebutton + "'   " +

                     "    where  tutorialID=" + tutorialid.Text + " and state='take'  ";


                dbconnect.insertdata(querWIN_tutorials);

                dbconnect.closeconn();


                Response.Redirect("MYDashoard.aspx?requset=" + "requset_take");





            }  // if (txtstatetutorial.Text == "requset_take")




        }




        protected void deletrequsetsoldetakebutton(object sender, EventArgs e)    /// طلب بيع - استاجار العقار الربح خ   mydashoard
        {
           

              ///// حذف الطلب فقط   من الزيون اليوزر 
              
            if ((txtstatetutorial.Text == "requset_solde")&&(tutorialid.Text!=""))
            {
                    ///    حذف الطلب المدخل من الزبون

               // namebutton = " عقار للبيع";

                dbconnect.openconn();

                string querWIN_tutorialsdel = "delete from  tutorials  where  tutorialID=  "+tutorialid.Text+"  and state='solde' and isactive='false'   ";





                dbconnect.insertdata(querWIN_tutorialsdel);

                dbconnect.closeconn();







                Response.Redirect("MYDashoard.aspx?requset=" + "requset_solde");



            }  // if (txtstatetutorial.Text == "requset_solde")










            if( (txtstatetutorial.Text == "requset_take")&&(tutorialid.Text!=""))
            {



                //// حذف الطلب المدخل من الزبون

              //  namebutton = " عقار للايجار";

                dbconnect.openconn();

                string querWIN_tutorialsdel = "delete  from  tutorials     where  tutorialID=" + tutorialid.Text + " and state='take'  and isactive='false'   ";


                dbconnect.insertdata(querWIN_tutorialsdel);

                dbconnect.closeconn();


                Response.Redirect("MYDashoard.aspx?requset=" + "requset_take");



            }  // if (txtstatetutorial.Text == "requset_take")




        }




        protected void yessrequestricetakeofbutton(object sender, EventArgs e)    ///   موافق على طلب شراء العقار   mydashoard
        {







            if ((txtstatetutorial.Text == "requset_rice")&&(tutorialid.Text!=""))
            {

              //  Panelmanywin.Visible = true;  //// عمولة المكتب





                ////تم تحويل   isactive من testwin الى  win 

                namebutton = " حذف العقار - اعرض بيانات شاري هذا العقار";


                string manywin = DropDownList5manywin.SelectedItem.Text;   ///   عملة ربح العقار




                if ((TextBox6manywin.Text != ""))
                {





                    string querpower2 = "select  power from  manypower  where namemany='" + manywin + "' ";


                    dbconnect.openconn();

                    dt = dbconnect.selectdata(querpower2);

                    dbconnect.closeconn();


                    int power9922 = Convert.ToInt16(dt.Rows[0][0].ToString());


                    int price9922 = Convert.ToInt16(TextBox6manywin.Text);


                    double yypower22 = Convert.ToDouble(price9922 * Math.Pow(10, power9922));









                    dbconnect.openconn();

                    string querWIN_tutorials = "update  tutorials  set DateStart ='" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "'  ," +


                         " isactive='win'  ,winmany=" + TextBox6manywin.Text + "  ,  manywinmany='" + manywin + "' , namebutton='" + namebutton + "', pricpowerwin="+ yypower22 + "    " +

                         "    where  tutorialID=" + tutorialid.Text + " and state='solde'  ";

                    ////winmany , manywinmany  عمولة المكتب حسب العملة 


                    dbconnect.insertdata(querWIN_tutorials);

                    dbconnect.closeconn();





                    Response.Redirect("MYDashoard.aspx?requset=" + "requset_rice");
                }

                else if((tutorialid.Text!="")&&(TextBox6manywin.Text==""))
                {

                  

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notsendrequestmany();", true);




                }





            }  // if (txtstatetutorial.Text == "requset_rice")






            if ((txtstatetutorial.Text == "requset_take_of")&&(tutorialid.Text!=""))
            {

              //  Panelmanywin.Visible = true;  //// عمولة المكتب


              //  ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "requestsendrictakeof();", true);


                ////تم تحويل   isactive من testwin الى  win 

                namebutton = " حذف العقار - عرض بيانات  مستاجر هذا العقار";


                string manywin = DropDownList5manywin.SelectedItem.Text;   ///   عملة ربح العقار




                if ((TextBox6manywin.Text != ""))
                {





                    string querpower2 = "select  power from  manypower  where namemany='" + manywin + "' ";


                    dbconnect.openconn();

                    dt = dbconnect.selectdata(querpower2);

                    dbconnect.closeconn();


                    int power9922 = Convert.ToInt16(dt.Rows[0][0].ToString());


                    int price9922 = Convert.ToInt16(TextBox6manywin.Text);


                    double yypower22 = Convert.ToDouble(price9922 * Math.Pow(10, power9922));















                    dbconnect.openconn();

                    string querWIN_tutorials = "update  tutorials  set DateStart ='" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "'  ," +


                         " isactive='win'  ,winmany=" + TextBox6manywin.Text + "  ,  manywinmany='" + manywin + "' , namebutton='" + namebutton + "' , pricpowerwin="+ yypower22 + "    " +

                         "    where  tutorialID=" + tutorialid.Text + " and state='take'  ";

                    ////winmany , manywinmany  عمولة المكتب حسب العملة 


                    dbconnect.insertdata(querWIN_tutorials);

                    dbconnect.closeconn();









                    Response.Redirect("MYDashoard.aspx?requset=" + "requset_take_of");
                }

                else if((tutorialid.Text!="")&&(TextBox6manywin.Text==""))
                {



                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "notsendrequestmany();", true);


                }





            }  // if (txtstatetutorial.Text == "requset_take_of")







        }



        protected void deletrequsetricetakeofbutton(object sender, EventArgs e)    ///    ,الاستاجار  (اعادة teswin الي  true حذف طلب شراء العقار   mydashoard
        {





            if ((txtstatetutorial.Text == "requset_rice")&&(tutorialid.Text!=""))
            {

                //  Panelmanywin.Visible = true;  //// عمولة المكتب





                ////تم تحويل   isactive من testwin الى  true 

                namebutton = " عقار للبيع";


               /// string manywin = DropDownList5manywin.SelectedItem.Text;   ///   عملة ربح العقار




                //if ((TextBox6manywin.Text != ""))
                //{




                    dbconnect.openconn();

                    string querWIN_tutorials = "update  tutorials  set DateStart ='" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "'  ," +


                         " isactive='true'    , namebutton='" + namebutton + "'    " +

                         "    where  tutorialID=" + tutorialid.Text + " and state='solde'  ";

                    ////winmany , manywinmany  عمولة المكتب حسب العملة 


                    dbconnect.insertdata(querWIN_tutorials);

                    dbconnect.closeconn();





                    Response.Redirect("MYDashoard.aspx?requset=" + "requset_rice");
              




            }  // if (txtstatetutorial.Text == "requset_rice")






            if ((txtstatetutorial.Text == "requset_take_of")&&(tutorialid.Text!=""))
            {

                //  Panelmanywin.Visible = true;  //// عمولة المكتب


                //  ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "requestsendrictakeof();", true);


                ////تم تحويل   isactive من testwin الى  true 

                namebutton = " عقار للايجار";


               // string manywin = DropDownList5manywin.SelectedItem.Text;   ///   عملة ربح العقار




              //  if ((TextBox6manywin.Text != ""))
               // {




                    dbconnect.openconn();

                    string querWIN_tutorials = "update  tutorials  set DateStart ='" + String.Format("{0:yyyy-MM-dd }", DateTime.Now) + "'  ," +


                         " isactive='true'   , namebutton='" + namebutton + "'    " +

                         "    where  tutorialID=" + tutorialid.Text + " and state='take'  ";

                    ////winmany , manywinmany  عمولة المكتب حسب العملة 


                    dbconnect.insertdata(querWIN_tutorials);

                    dbconnect.closeconn();









                    Response.Redirect("MYDashoard.aspx?requset=" + "requset_take_of");
               





            }  // if (txtstatetutorial.Text == "requset_take_of")






        }






        protected void deletwintutor(object sender, EventArgs e)    /// طلب بيع - استاجار العقار الربح خ   mydashoard
        {


            ///// حذف الطلب فقط   من الزيون اليوزر 

            if ((txtstatetutorial.Text == "win") && (tutorialid.Text != ""))
            {






                dbconnect.openconn();

                string querWIN_tutorialsdel = "delete from  tutorials  where  tutorialID=  " + tutorialid.Text + "   and isactive='win'   ";





                dbconnect.insertdata(querWIN_tutorialsdel);

                dbconnect.closeconn();



                SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +

                        "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,masad,Serviecother,dateother,namesatae," +

                       " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                           "  where tutorialbrowserid=browserID  and isactive='win'   order by DateStart desc     ";



                DataList2.Visible = true;




            }


        }









         protected void budatewin_Click(object sender, EventArgs e)    /// فلترة الربح حسب التاريخ   mydashoard
        {

                   string ttsdatewinold = "";

                  string ttsdatewinnew = "";

            if ((DropDownList5winoldedate.SelectedItem.Text != "") && (DropDownList6winneewdate.SelectedItem.Text != ""))

            {

                ttsdatewinold = DropDownList5winoldedate.SelectedItem.Text;

                ttsdatewinnew = DropDownList6winneewdate.SelectedItem.Text;








                ////  لا نستخدم هنا فقط شرط state='"+txtstatetutorial.text+"  :لان txtstatetutorial.text=win بينما state فقط (solde or take )




                SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +

                        "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,masad,Serviecother,dateother,namesatae," +

                       " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment,winmany,manywinmany,tutorialbrowserwinid  from  tutorials , mybrowser  " +


                           "   where  DateStart  between  '" + ttsdatewinold + "' and '" + ttsdatewinnew + "'  " +

                           "  and tutorialbrowserid=browserID  and isactive='win'  order by DateStart desc  ";

                         //  "and  tutorialID  in(select  tutorialID from  viewewin)  ";









                  string manywin = DropDownList5manyreferens.SelectedItem.Text;   /// العملة



                   dbconnect.openconn();


                  string querupcountwin = "select sum(pricpowerwin) from tutorials where DateStart  between  '" + ttsdatewinold + "' and '" + ttsdatewinnew + "'" +

                    "      and isactive='win'     ";     ///// عملة العقار


                  dt.Clear();
                  dt = dbconnect.selectdata(querupcountwin);

                  dbconnect.closeconn();

                  if (dt.Rows.Count > 0)
                  {

                    Textcountwin.Text = dt.Rows[0][0].ToString();

                   // DropDownList5manyreferens.SelectedItem.Text = manywin;


                  }




                   DataList2.Visible = true;




            }


          }


        protected void budateallwin_Click(object sender, EventArgs e)    //// عرض الربح الاجمالي  mydashoard
        {


           






            SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +

                    "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,masad,Serviecother,dateother,namesatae," +

                   " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                       "  where tutorialbrowserid=browserID  and isactive='win'   order by DateStart desc     ";






            string many = DropDownList5manyreferens.SelectedItem.Text;   /// العملة



            dbconnect.openconn();


            string querupcountwin = "select sum(pricpowerwin) from tutorials where isactive='win'  ";



            dt.Clear();
            dt = dbconnect.selectdata(querupcountwin);

            dbconnect.closeconn();

            if (dt.Rows.Count > 0)
            {

                Textcountwin.Text = dt.Rows[0][0].ToString();

               // DropDownList5manyreferens.SelectedItem.Text = many;


               
            }




            DataList2.Visible = true;








        }





        protected void budatewinsold_Click(object sender, EventArgs e)    //// عرض الربح  المكتب من بيع العقارات 
        {


            Literal10win.Text = "اعقارات المباعة";




            SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +

                    "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,masad,Serviecother,dateother,namesatae," +

                   " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                       "  where tutorialbrowserid=browserID  and isactive='win'   and state='solde'  order by DateStart desc     ";







            string manywin = DropDownList5manyreferens.SelectedItem.Text;   /// العملة



            dbconnect.openconn();


            string querupcountwin = "select sum(pricpowerwin) from tutorials where isactive='win'  " +

                    "   and state='solde'    ";


            dt.Clear();
            dt = dbconnect.selectdata(querupcountwin);

            dbconnect.closeconn();

            if (dt.Rows.Count > 0)
            {

                Textcountwin.Text = dt.Rows[0][0].ToString();

               // DropDownList5manyreferens.SelectedItem.Text = manywin;


            }





            DataList2.Visible = true;




        }







        protected void budatewintake_Click(object sender, EventArgs e)    //// عرض الربح  المكتب من اجارات العقارات 
        {
           

            Literal10win.Text = "اعقارات المؤجرة";


            string manywin = DropDownList5manyreferens.SelectedItem.Text;   /// العملة




            SqlDataSource22.SelectCommand = " select tutorialID, tutorialType, price, country,city,placetutorial,manteka,area,alatlalh,tabke,namepricestate," +

                    "havinge,refernc,room ,alfarch,alkasa,dirction ,electron ,DateStart  ,tutorialbrowserid,many,masad,Serviecother,dateother,namesatae," +

                   " browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  , winmany,manywinmany,tutorialbrowserwinid from  tutorials , mybrowser  " +
                       "  where tutorialbrowserid=browserID  and isactive='win'   and state='take'  order by DateStart desc     ";



            DataList2.Visible = true;






            dbconnect.openconn();


            string querupcountwin = "select sum(pricpowerwin)  from tutorials where isactive='win'  " +

                    "    and state='take'    ";


            dt.Clear();
            dt = dbconnect.selectdata(querupcountwin);

            dbconnect.closeconn();

            if (dt.Rows.Count > 0)
            {

                Textcountwin.Text = dt.Rows[0][0].ToString();

               // DropDownList5manyreferens.SelectedItem.Text = manywin;

              


            }


        }









        /// <summary>
        /// /////////////////// ///////////////////////////////////////////////////////////////////////////// end عقار
        /// </summary>
        /// 
        /// 
        /// 
        /// 
        ///////////////////////////////////////////////////////////////////////////  add + update person
        protected void BuAddData_Click(object sender, EventArgs e)  /// button add  للزبون   mydashoard
        {

            string note = "";


            if ((txtFirstNam.Text != "") && (txtMiddleName.Text != "") )
            {






                dbconnect.openconn();

                string querinsert = "insert into mybrowser(browserFirstName,browserLastName,accounttypeID ,NumberPhone,NumberHome,browsercomment)values('" + txtFirstNam.Text + "' ," +
                             "  '" + txtMiddleName.Text + "'  ,3, '" + textphone.Text + "' , '" + textphonhome.Text + "', '"+TextBox6browsercommint.Text+"'  )";



                dbconnect.insertdata(querinsert);


                dbconnect.closeconn();



                if (TextBox6browsercommint.Text == "")
                {

                    Response.Redirect("MyDashoard.aspx?s=" + "add" + "&firstname=" + txtFirstNam.Text + "&lasname=" + txtMiddleName.Text +
                                              "&phonee=" + textphone.Text + "&phonehomee=" + textphonhome.Text + "&TextBox6browsercommint=" + TextBox6browsercommint.Text + "&statetutorial=" + txtstatetutorial.Text);

                }




                else if(TextBox6browsercommint.Text!="")
                {

                    note = "تم تخزين الملاحظة لقرائتها يرجى الضغط على زر تعديل الزبون";

                    Response.Redirect("MyDashoard.aspx?s=" + "add" + "&firstname=" + txtFirstNam.Text + "&lasname=" + txtMiddleName.Text +
                                             "&phonee=" + textphone.Text + "&phonehomee=" + textphonhome.Text + "&TextBox6browsercommint=" + note + "&statetutorial=" + txtstatetutorial.Text);



                }


            }
         

            if ((txtFirstNam.Text == "") || (txtMiddleName.Text == "") )
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalError();", true);
               Panel11.Visible = true;
               Panel2.Visible = false;

            }




        }





        protected void updateDatae_Click(object sender, EventArgs e)  ////  button لتعديل بيانات الزبون   mydashoard
        {
            //   if (Request.QueryString["updateperson"] == "updateperson")
            // {

            if (textphone.Text == "")
                phonupdate = "/";

            else if (textphone.Text != "")
                phonupdate = textphone.Text;


            if (textphonhome.Text == "")
                phonhomeupdate = "/";

            else if (textphonhome.Text != "")
                phonhomeupdate = textphonhome.Text;


       

            ////////////////////////////


            if ((txtFirstNam.Text != "") && (txtMiddleName.Text != "") )

            {


                dbconnect.openconn();



            string querupdate_person = " update  mybrowser set  browserfirstName='" + txtFirstNam.Text + "' ,  browserlastName='" + txtMiddleName.Text + "' ,  " +
                "NumberPhone='" + phonupdate + "' ,  NumberHome='" + phonhomeupdate + "'  ,  browsercomment='" + TextBox6browsercommint.Text + "'   where " +

                   "browserid =" + browserid.Text + "  ";



            dbconnect.insertdata(querupdate_person);

            dbconnect.closeconn();








              dbconnect.openconn();


              string querupdate = "select browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where " +
                   "browserid =" + browserid.Text + "  ";

               dt.Clear();
               dt = dbconnect.selectdata(querupdate);

               dbconnect.closeconn();

              if (dt.Rows.Count > 0)
              {

                firstnameupdate = dt.Rows[0][0].ToString();

                lastnameupdate = dt.Rows[0][1].ToString();





                    //TextBox2.Text = dt.Rows[0][0].ToString();  لانها تعطي ذات القيم for box

                    //TextBox3.Text = dt.Rows[0][1].ToString();











                    Response.Redirect("MYDashoard.aspx?sk=" + "viewupdatperson" + "&browseridview=" + browserid.Text + "&statetutorial=" + txtstatetutorial.Text);


               }


             }




            if ((txtFirstNam.Text == "") || (txtMiddleName.Text == ""))

            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "ShowModalError();", true);
                Panel11.Visible = true;
                Panel2.Visible = false;

            }

          


        }










/// <summary>
/// /////////////////////////////////////////////////////////////////////  filter  //////////////////////////////////// //////////////////////


        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void SqlDataSource43_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }








        protected void Buddnew_Click(object sender, EventArgs e)   // جديد
            {

               Literal27_click.Text = "0";



                Response.Redirect("MYDashoard.aspx?state=" + "request_master"+"&null="+"0");






            }





        protected void BuAddSearch_null_Click(object sender, EventArgs e)   // زبائن ليس لهم عقارات
            {



          //  Response.Redirect("MYDashoard.aspx?state=" + "request_master");


            Literal26.Text = "ok";

            deletbrowsernull = "ok";

              Literal27_click.Text = "jj";


            Literal24searchall.Visible = false;
            CheckBoxList1searchbrowserstate.Visible = false;

           


            SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment" +

                "  from mybrowser  where browserID  not in( select  tutorialbrowserid  from  tutorials   )  ";


            GridView1.Visible = true;




        }



        protected void BuddSearchbrowser_Click(object sender, EventArgs e)   // فلترة حسب الاسم   mydashoard
            {



            Literal26.Text = "no";
            deletbrowsernull = "no";

            //Response.Redirect("MYDashoard.aspx?state=" + "request_master");


            Literal27_click.Text = "jj";

            Literal24searchall.Visible = false;
            CheckBoxList1searchbrowserstate.Visible = false;




            //  CheckBoxList1searchbrowserstate.Items.Clear();

            // TextBox5.Text = "";
            countsold.Visible = false;

            browserid.Text = "";

            TextBox7.Text = TextBox2.Text;










            dbconnect.openconn();

            string queriss = "select browserID  from mybrowser where browserfirstName like '%" + TextBox2.Text + "%' or browserlastName like '%" + TextBox3.Text + "%' and  browserlastName is not null and browserfirstName is not null  "; 
               



            dt.Clear();
            dt = dbconnect.selectdata(queriss);


            dbconnect.closeconn();

            Literal4.Text = dt.Rows.Count.ToString();


            

            if ( (dt.Rows.Count==0)||((TextBox2.Text=="")&&(TextBox3.Text=="")) )
            {


                GridView1.Visible = false;

              // Literal4.Text = "==0";

               Panel11.Visible = true;

                Button1_person.Visible = true;


                // if (TextBox2.Text != "")
                //    txtFirstNam.Text = TextBox2.Text;

                // else if (TextBox2.Text == "")
                // {
                //     txtFirstNam.Text = "/";
                //     TextBox2.Text = "";
                //}


                // if (TextBox3.Text != "")
                //     txtMiddleName.Text = TextBox3.Text;

                // else if (TextBox3.Text == "")
                // {
                // txtMiddleName.Text = "";
                //   TextBox3.Text = "/";
                //  }





                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;

                Panel6.Visible = false;

                Panel55.Visible = false;






                txtFirstNam.ReadOnly = false;
                txtMiddleName.ReadOnly = false;
                textphone.ReadOnly = false;
                textphonhome.ReadOnly = false;
                TextBox6browsercommint.ReadOnly = false;


                textphone.Text = "";
                textphonhome.Text = "";
                TextBox6browsercommint.Text = "";


               




                DataList1.Visible = false;

            }


             else if (dt.Rows.Count>0)
             {
            //   Literal4.Text = ">0";

                SqlDataSource55.SelectCommand = "select browserID, browserfirstName,browserlastName,NumberPhone,NumberHome,browsercomment  from mybrowser where browserfirstName like '%" + TextBox2.Text + "%' or browserlastName like '%" + TextBox3.Text + "%'    ";



                //SqlDataSource55.SelectCommand = "SELECT browserID, browserfirstName, browserlastName, NumberPhone, NumberHome,browsercomment FROM mybrowser" +



                // "where browserfirstName = '%"+TextBox2.Text+"%' or  browserlastName = '%"+TextBox3.Text+"%'    ";



                GridView1.Visible = true;




                Panel11.Visible = false;

                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;

                Panel6.Visible = false;

                Panel55.Visible = false;


                Button1_person.Visible = false;

                DataList1.Visible = false;




            }




        }







        protected void BuAddSearch_All_Click(object sender, EventArgs e)  /// الذين لديهم عقارات (بيع_اجار) حسب حالة الصفحة عرض جميع بيانات الزبائن mydashoard
        {



           // Response.Redirect("MYDashoard.aspx?state=" + "request_master");


            Literal24searchall.Visible = true;
            CheckBoxList1searchbrowserstate.Visible = true;

            Literal27_click.Text = "ok";


            int i = 0;


            Literal26.Text  = "yes";

            deletbrowsernull = "yse";



            string statebrowser = "";

          //if (Request.QueryString["state"] == "request_master")
          //{
                Literal24searchall.Text = "يرجى تحديد نوع العقار للبحث عن زبون العقار";

                ///////////////////////////////////////////////


                dbconnect.openconn();

                string querinsert55showtable = "show tables";

                dt = dbconnect.selectdata(querinsert55showtable);

                if (dt.Rows.Count > 0)

                {

                    for (i = 0; i < dt.Rows.Count; i++)
                    {

                        if (dt.Rows[i][0].ToString() == "filterstatee")
                        {

                           


                            string querinsert55showtabledrop = "drop table filterstatee ";

                            dbconnect.selectdata(querinsert55showtabledrop);

                            dbconnect.closeconn();


                        }





                    }


                }
            

                        /////////////////////////////////////
                        dbconnect.openconn();

                string querinsert55table = "create table filterstatee ( browserid  int )";


                dbconnect.selectdata(querinsert55table);
                dbconnect.closeconn();




            /////////////////////////////
            ///



            //////////////////////////////////////////////////////////////////
            ///
            foreach (ListItem item in CheckBoxList1searchbrowserstate.Items)
            {

               

                        if (item.Selected)
                        {

                            statebrowser = item.Value;



                          for (int j = 1; j <= 4; j++)
                          {

                            if (statebrowser == "1")
                            {
                                txtstatetutorial.Text = "solde";



                                pagename.Text = "صفحة طلبات بيع عقارات";

                            Button22.Text = "جميع الزبائن الذين لديهم عقارات للبيع";

                                





                                dbconnect.openconn();

                                string querinsertsolde = "insert into filterstatee  ( select browserID  from mybrowser " +

                              " where browserID in( select  tutorialbrowserid  from  tutorials  where State='" + txtstatetutorial.Text + "' and isactive <>'false' and isactive<>'win') )  ";


                                dbconnect.selectdata(querinsertsolde);
                                dbconnect.closeconn();




                            }




                            if (statebrowser == "4")
                            {
                                txtstatetutorial.Text = "take";

                                Button22.Text = "جميع الزبائن الذين لديهم عقارات للاجار";



                                 pagename.Text = "صفحة طلبات ايجار عقارات";


                            dbconnect.openconn();

                                string querinserttake = "insert into filterstatee  ( select browserID  from mybrowser " +

                              " where browserID in( select  tutorialbrowserid  from  tutorials  where State='" + txtstatetutorial.Text + "' and isactive <>'false' and isactive<>'win')  ) ";


                                dbconnect.selectdata(querinserttake);
                                dbconnect.closeconn();

                            }




                            if (statebrowser == "2")
                            {
                                txtstatetutorial.Text = "rice";

                                Button22.Text = "جميع الزبائن الذين يريدون شراء عقارات ";


                                pagename.Text = "صفحة عروض شراء العقارات";




                            dbconnect.openconn();

                                string querinsertrice = "insert into filterstatee  ( select browserID  from mybrowser " +

                               " where browserID in( select  tutorialbrowserid  from  tutorials  where State='" + txtstatetutorial.Text + "' and isactive <>'false' and isactive<>'win'))   ";


                                dbconnect.selectdata(querinsertrice);
                                dbconnect.closeconn();


                            }




                            if (statebrowser == "3")
                            {
                                txtstatetutorial.Text = "take_of";

                                Button22.Text = "جميع الزبائن الذين يريدون استاجار عقارات ";



                               pagename.Text = "صفحة عروض استئجار العقارات";




                            dbconnect.openconn();

                                string querinserttake_of = "insert into filterstatee  ( select browserID  from mybrowser " +

                               " where browserID in( select  tutorialbrowserid  from  tutorials  where State='" + txtstatetutorial.Text + "' and isactive <>'false' and isactive<>'win') )  ";


                                dbconnect.selectdata(querinserttake_of);
                                dbconnect.closeconn();




                            }








                            if (statebrowser == "5")
                            {
                              remmbertext.Text = "remmber";


                               pagename.Text = "صفحة العقارات الذين لديهم تذكرة";






                            dbconnect.openconn();

                               string querinserttake_of = "insert into filterstatee  ( select browserID  from mybrowser " +

                                " where remmberbrowser='remmber') ";

                                 dbconnect.selectdata(querinserttake_of);
                                 dbconnect.closeconn();




                             }










                           }

                        }



                    
                    
                 //}

            }






            SqlDataSource55.SelectCommand = "select browserID, browserfirstName, browserlastName, NumberPhone, NumberHome, browsercomment  from mybrowser " +

                " where browserID in( select  browserid  from  filterstatee)";
            GridView1.Visible = true;

            countsold.Visible = true;



            Panel11.Visible = false;

            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;

            Panel6.Visible = false;

            Panel55.Visible = false;


            Button1_person.Visible = false;

            DataList1.Visible = false;





            dbconnect.openconn();

            string querisscount = "select browserID, browserfirstName, browserlastName, NumberPhone, NumberHome, browsercomment  from mybrowser " +

                " where browserID in( select  browserid  from  filterstatee)";


            dt.Clear();
            dt = dbconnect.selectdata(querisscount);


            dbconnect.closeconn();

            countsold.Text ="عدد الاجمالي"+ dt.Rows.Count.ToString();






        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
         {





          }

        protected void DataList53_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BuSearch_Click(object sender, EventArgs e)    ///  وصفحة الاستأجارات و الاستاجار الفلترة في صفحة الشراء
        {

            viewfilterdrop = "ch";  /////   خل مشكلة العرض من الجدول filer

            string tts = null;

            string ttsprice1 = null;

            string ttsprice2 = null;

          

          //  string ss = null;
          //  string[] ff = null;
         string ssall = null;

            int i ;
            // int j = 1;


            dbconnect.openconn();

            string querinsert55showtable = "show tables";

            dt=dbconnect.selectdata(querinsert55showtable);

             if(dt.Rows.Count >0)

            {

                for (i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i][0].ToString() == "filtercountry")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();



                        string querinsert55showtabledrop = "drop table filtercountry ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }

                    ///////////////////////////////////////////////////filter city filtercity

                     if (dt.Rows[i][0].ToString() == "filtercity")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();



                        string querinsert55showtabledrop = "drop table filtercity ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }



                    ////////////////////////////////////////////////////////////////// filtermanteka


                    if (dt.Rows[i][0].ToString() == "filtermanteka")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();



                        string querinsert55showtabledrop = "drop table filtermanteka ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }



                    //////////////////////////////////////////////////////////////////////////////  filtertype


                    if (dt.Rows[i][0].ToString() == "filtertype")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();



                        string querinsert55showtabledrop = "drop table filtertype ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }

                    ///////////////////////////////////////////////////////  filterprice//////////////////////



                    if (dt.Rows[i][0].ToString() == "filterprice")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();



                        string querinsert55showtabledrop = "drop table filterprice ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }


                    ///////////////////////////////////////////////
                    ///

                    ///////////////////////////////////////////////////////  filterpricelow;//////////////////////



                    if (dt.Rows[i][0].ToString() == "filterpricelow")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();


                        dbconnect.openconn();

                        string querinsert55showtabledrop = "drop table filterpricelow  ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }





                    ///////////////////////////////////////////  viewfilter  //////////////////
                    ///



                    if (dt.Rows[i][0].ToString() == "viewfilter")
                    {

                        Literal6.Text = "الجدول موجود" + dt.Rows[i][0].ToString();

                        Literal6.Text = dt.Rows.Count.ToString();



                        string querinsert55showtabledrop = "drop view viewfilter ";

                        dbconnect.selectdata(querinsert55showtabledrop);

                        dbconnect.closeconn();


                    }





                    ////////////////////////////// end viewfilter//////////////////////////








                    //////////////////////////////////////////// end filterprice ///////////////////////////////

                }


            }

            dbconnect.closeconn();



            //////////////////////////////////////////////////////////////////////////////////////////////////////




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

                        string querinsert55 = "insert into filtercountry  ( select  tutorialID  from tutorials where State='"+ txtstatetutorial.Text + "' " +
                           "and isactive='true' and country =  '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();

                    }



                    i = i + 1;

                    if (i > 1)
                    {


                        dbconnect.openconn();

                        string querinsert55 = "insert into filtercountry  ( select  tutorialID from tutorials where State='"+ txtstatetutorial.Text+"' " +
                           "and isactive='true' and country =  '"+tts+"'  )  "; 

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

                        string querinsert55 = "insert into filtercity  ( select  tutorialID  from tutorials where State='"+ txtstatetutorial.Text + "' " +
                           "and isactive='true' and city =  '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();

                    }



                    i = i + 1;

                    if (i > 1)
                    {


                        dbconnect.openconn();

                        string querinsert55 = "insert into filtercity  ( select  tutorialID  from tutorials where State='"+ txtstatetutorial.Text + "' " +
                           "and isactive='true' and city =  '" + tts + "'  )  ";

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

                        string querinsert55 = "insert into filtermanteka  ( select  tutorialID  from tutorials where State='"+ txtstatetutorial.Text + "' " +
                           "and isactive='true' and manteka = '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();

                    }



                    i = i + 1;

                    if (i > 1)
                    {


                        dbconnect.openconn();

                        string querinsert55 = "insert into filtermanteka  ( select  tutorialID  from tutorials where State='"+ txtstatetutorial.Text + "' " +
                           "and isactive='true' and manteka =  '" + tts + "'  )  ";

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

                        string querinsert55 = "insert into filtertype  ( select  tutorialID  from tutorials where State='"+ txtstatetutorial.Text + "' " +
                           
                           "and isactive='true' and tutorialType = '" + tts + "'  )  ";

                        dbconnect.selectdata(querinsert55);
                        dbconnect.closeconn();

                    }



                    i = i + 1;

                    if (i > 1)
                    {


                        dbconnect.openconn();

                        string querinsert55 = "insert into filtertype  ( select  tutorialID  from tutorials where State='"+ txtstatetutorial.Text + "'  "  +
                             
                           "and isactive='true' and tutorialType =  '" + tts + "'  )  ";

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




            if ((DropDownList5pricbetoweenvie11.Enabled == true) && (DropDownList5pricbettoweenview22.Enabled == true))
            {



                //  if ((DropDownList9price11.SelectedItem.Text != "") && (DropDownList5manysearch.SelectedItem.Text != "") && (DropDownList10price22.SelectedItem.Text != "") && (DropDownList5manysearchpow.SelectedItem.Text != ""))
                //   { 


                ttsprice1 = DropDownList9price11.SelectedItem.Text;


              string  ttmanypower1 = DropDownList5manysearch.SelectedItem.Text;

                string querpower = "select  power from  manypower  where namemany='" + ttmanypower1 + "' ";


                dbconnect.openconn();

                dt = dbconnect.selectdata(querpower);

                dbconnect.closeconn();


                int power99 = Convert.ToInt16(dt.Rows[0][0].ToString());


                double price99 = Convert.ToDouble(ttsprice1);


                double yypower = Convert.ToDouble(price99 * Math.Pow(10, power99));



                ////////////////////////////////////////////////////////////



                ttsprice2 = DropDownList10price22.SelectedItem.Text;

               string ttmanypower2 = DropDownList5manysearchpow.SelectedItem.Text;





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

                   "and isactive='true'   and pricpower >=" + yypower + " and pricpower <=" + yypower22 + "    order by price   )  ";

                dbconnect.selectdata(querinsert55);
                dbconnect.closeconn();


               

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


            if ((DropDownList5searchpriceaddmanyview.Enabled == true))
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

                   "and isactive='true'    and pricpower <=" + yypowerlow + "    order by price   )  ";

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
                 ssall = "tutorials"+" ";

                for (i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i][0].ToString() == "filtercountry")
                        
                    {
                       
                       //Coloumns[1] = new ColoumnParam("country", ColoumnType.NVarChar, dt.Rows[i][0].ToString());

                        ssall = ssall +" " +"INNER JOIN   filtercountry  on  tutorials.tutorialID=filtercountry.tutorialID";

                    }

                    if(dt.Rows[i][0].ToString() == "filtercity")
                    {


                        // Coloumns[2] = new ColoumnParam("city", ColoumnType.NVarChar, dt.Rows[i][0].ToString());


                        ssall = ssall +" " +"INNER JOIN   filtercity  on   tutorials.tutorialID=filtercity.tutorialID";



                    }


                    if (dt.Rows[i][0].ToString() == "filtermanteka")
                    {


                       // Coloumns[3] = new ColoumnParam("manteka", ColoumnType.NVarChar, dt.Rows[i][0].ToString());
                        ssall = ssall +" " +"INNER JOIN   filtermanteka  on  tutorials.tutorialID=filtermanteka.tutorialID";



                    }


                    if (dt.Rows[i][0].ToString() == "filtertype")
                    {


                        //Coloumns[4] = new ColoumnParam("type", ColoumnType.NVarChar, dt.Rows[i][0].ToString());
                        ssall = ssall +" " +"INNER JOIN   filtertype  on   tutorials.tutorialID=filtertype.tutorialID";



                    }



                    if (dt.Rows[i][0].ToString() == "filterprice")
                    {


                        // Coloumns[5] = new ColoumnParam("price", ColoumnType.NVarChar, dt.Rows[i][0].ToString());

                        ssall = ssall + "  "+" INNER JOIN filterprice  on tutorials.tutorialID=filterprice.tutorialID";


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


           // Literal6.Text = ssall;

            if ((ssall != "") && (ssall != "tutorials" + " "))
            {

                dbconnect.openconn();

                string querinsert55createview = " create view viewfilter as (select tutorials.tutorialID, tutorials.tutorialType, tutorials.price, tutorials.country," +
                    " tutorials.city, tutorials.placetutorial," +

                              "tutorials.manteka,tutorials.area,tutorials.alatlalh,tutorials.tabke,tutorials.havinge,tutorials.refernc,tutorials.room ," +

                              "tutorials.alfarch,tutorials.alkasa,tutorials.dirction , tutorials.electron ,tutorials.DateStart ,tutorials.tutorialbrowserid,tutorials.many,masad,Serviecother,dateother,namesatae,namepricestate," +

                              "   tutorials.winmany,  tutorials.manywinmany, tutorials.tutorialbrowserwinid from" +

                              "    " + ssall + "   where State='" + txtstatetutorial.Text + "' and isactive='true'  ) ";


                ///  استخدمنا  INNER JOIN  لدمج الجدوال اول تقاطع ما بين جدوال من خلال معرف


                //  اما استخدامنا where يكون مفق الربط بالمفاتح الاجبني حصرا

                dbconnect.selectdata(querinsert55createview);


                dbconnect.closeconn();






                // Literal6.Text = ssall;



                SqlDataSource22.SelectCommand = " select viewfilter.* ,browserfirstName , browserlastName,NumberPhone,NumberHome ,browsercomment  from  viewfilter , mybrowser  " +
                      "  where tutorialbrowserid=browserID    ";







                DataList2.Visible = true;





                Button2filterprice.Text = "تفعيل bettwen";

                Button1filtterpriclow.Text = "تفعيل اقل من";



                // select tutorialID from tutorials where tutorialID =?







            }
            else

                Literal6.Text = "لاتوجد نتائج للبحث ";



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






            // for (i = 0; i < 5; i++)
            //    Literal6.Text = Literal6.Text+" "+ Coloumns[i].ColoumnsData;

            //

            // Literal6.Text = ssall;

            // SqlDataSource22.SelectCommand = " select tutorials.tutorialID, tutorials.tutorialType, tutorials.price, tutorials.country," +
            //     " tutorials.city, tutorials.placetutorial," +

            //              "tutorials.manteka,tutorials.area,tutorials.alatlalh,tutorials.tabke,tutorials.havinge,tutorials.refernc,tutorials.room ," +

            //              "tutorials.alfarch,tutorials.alkasa from" +

            //            "    "+ssall+"    ";


            //////////////////////////////////////////////

            //" tutorials INNER JOIN filterprice on tutorials.tutorialID=filterprice.tutorialID  ";

            ///    





            // for (i = 0; i < j; i++)


            //  Literal6.Text = "yjuytj";


            //ssall = ssall+"  "+ "on" + "  " + ssall + "." + "state=" + ss + "." + "state";

            //  Literal6.Text = ssall;







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

                string queryselectelprice = "select distinct price   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive ='true'  " +

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

                    string queryselectmanyandpricesearchviewbetoeen = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive='true'  " +

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




                    string queryselectmanyandpricesearchviewbetoeen22 = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive ='true'  " +

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




            if (DropDownList5searchpriceaddmanyview.Enabled == true)
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

                string queryselectelprice = "select distinct price   from tutorials where  state='" + txtstatetutorial.Text + "' and isactive ='true' " +

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




                    string queryselectmanyandpricesearchview = "select distinct  price  , many from tutorials  where  State='" + txtstatetutorial.Text + "' and isactive='true'   " +

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















        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource2_Selecting1(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void CheckBoxlista1country_SelectedIndexChanged(object sender, EventArgs e)
        {



                    

                







            
        }

        protected void SqlDataSource55_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView2updatedata1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1price_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2area_TextChanged(object sender, EventArgs e)
        {

        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           


        }

    }
}