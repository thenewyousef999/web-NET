using ALATLAS.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBManager;


namespace ALATLAS
{
    public partial class homee : System.Web.UI.Page
    {


        Cdbconnect dbconnect = new Cdbconnect();


        tutorials tutor = new tutorials();


        DataTable dt = new DataTable();




        protected void Page_Load(object sender, EventArgs e)
        {


            
          


           // int yy99 = Convert.ToInt32(txtpow.Text);


         // Literal3.Text=   Math.Pow(10,yy99).ToString();

            // string queryselectcountry = "select country   from tutorialspublic where country is not null ";



            // dbconnect.openconn();
            // dt.Clear();


            // dt = dbconnect.selectdata(queryselectcountry);


            //  Literal1.Text = dt.Rows.Count.ToString();

            // Literal1.Text = Convert.ToString(dt.Rows[0][1]);






            if (!Page.IsPostBack)
            {




                string queryselectmany = "select distinct many   from tutorialspublic where many is not null ";



                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselectmany);



                dbconnect.closeconn();



                //  Literal1.Text = dt.Rows.Count.ToString();


                if (dt.Rows.Count > 0)
                {
                    Literal1.Text = Convert.ToString(dt.Rows[0][0]);
                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList1many.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }






                ////////////////////////////////////  بلد

                string queryselectcountry = "select distinct country   from tutorialspublic where country is not null ";



                dbconnect.openconn();
                dt.Clear();


                dt = dbconnect.selectdata(queryselectcountry);



                dbconnect.closeconn();



                DropDownList1country.Items.Add(new ListItem("حدد بلد", "0" ));
                //  Literal1.Text = dt.Rows.Count.ToString();


                if (dt.Rows.Count > 0)
                {
                   // Literal1.Text = Convert.ToString(dt.Rows[0][0]);
                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList1country.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));
                }







                //////////////////////////////city  مدينة

                // string queryselecity = "select distinct city  from tutorialspublic where city is not null";
                
                    string queryselecity = "select distinct namecitynode   from countrypublic where    namrcountry='" + DropDownList1country.SelectedItem.Text + "'     and  namrcountry  is not null";



                    dbconnect.openconn();

                    dt.Clear();

                    dt = dbconnect.selectdata(queryselecity);



                    dbconnect.closeconn();


                DropDownList3city.Items.Add(new ListItem("حدد مدينة", "0"));
                if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)

                            DropDownList3city.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));

                    }

                


                ///////////////////////////////////////////  منطقة
                ///  اضافة المنطقة

                // string queryselealmanteka = "select distinct manteka   from tutorialspublic where manteka is not null";

            
                    string queryselealmanteka = "select distinct namemantekanode    from citypublic where  namecity  ='" + DropDownList3city.SelectedItem.Text + "'   and namecity  is not null";



                    dbconnect.openconn();

                    dt.Clear();

                    dt = dbconnect.selectdata(queryselealmanteka);



                    dbconnect.closeconn();


                almanteka.Items.Add(new ListItem("حدد منطقة ", "0"));

                if (dt.Rows.Count > 0)
                    {

                        for (int i = 0; i < dt.Rows.Count; i++)


                            almanteka.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                    }

                //////////////////////////////////////////////////////////////////////////
                ///    تفرعات من المنطقة





                string queryselealmanteka00 = "select distinct namemantekanodenode     from mantekapublic where  namemanteka ='" + almanteka.SelectedItem.Text + "'   and namemanteka  is not null";



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

                    for (int i = 0; i < dt.Rows.Count; i++)


                       DropDownList2tutorialType.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }





                /////////////////////////////////////////////////////////////
                ///   طابق العقار اضافة 




                string queryselecttabke = "select distinct tabke     from tutorialspublic where tabke is not null";


                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselecttabke);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                      for (int i = 0; i < dt.Rows.Count; i++)

                      DropDList1tabkk55.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }




                /////////////////////////////////////////////////////////////
                ///   طابق العقار اضافة 




                string queryselectroom = "select distinct room      from tutorialspublic where room is not null";


                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselectroom);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                     for (int i = 0; i < dt.Rows.Count; i++)


                       DropDownList2room.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }




                /////////////////////////////////////////////////////////////
                ///   فرش العقار اضافة 




                string queryselectalfarch = "select distinct alfarch       from tutorialspublic where alfarch is not null";


                dbconnect.openconn();

                dt.Clear();
                dt = dbconnect.selectdata(queryselectalfarch);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                      for (int i = 0; i < dt.Rows.Count; i++)


                       DropDownList2alfarch.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }




                /////////////////////////////////////////////////////////////
                ///   كسوة العقار اضافة 




                string queryselectalkasa = "select distinct alkasa        from tutorialspublic where alkasa is not null";

                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselectalkasa);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                       for (int i = 0; i < dt.Rows.Count; i++)


                       DropDownList1alkasa.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }




                /////////////////////////////////////////////////////////////
                ///   الاتجاهات العقار اضافة 




                string queryselectdirction = "select distinct dirction         from tutorialspublic where dirction is not null";


                dbconnect.openconn();

                dt.Clear();
                dt = dbconnect.selectdata(queryselectdirction);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                     for (int i = 0; i < dt.Rows.Count; i++)


                       DropDownList1dirction34.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }



                /////////////////////////////////////////////////////////////
                ///   الملكية العقار اضافة 




                string queryselecthavinge = "select  distinct havinge            from tutorialspublic  where havinge is not null";


                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselecthavinge);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                     for (int i = 0; i < dt.Rows.Count; i++)


                       DropDownList1havinge.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }


                /////////////////////////////////////////////////////////////
                ///   الاشارات العقار اضافة 




                string queryselectrefernc = "select  distinct refernc             from tutorialspublic where refernc is not null";


                dbconnect.openconn();

                dt.Clear();
                dt = dbconnect.selectdata(queryselectrefernc);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                      for (int i = 0; i < dt.Rows.Count; i++)


                       DropDownList1refernc.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }



                /////////////////////////////////////////////////////////////
                ///   الكهرباء العقار اضافة 




                string queryselectelectron = "select distinct electron               from tutorialspublic where electron is not null";


                dbconnect.openconn();

                dt.Clear();
                dt = dbconnect.selectdata(queryselectelectron);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                     for (int i = 0; i < dt.Rows.Count; i++)


                       DropDownList1electron.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }


                ///////////////////////////////////////////////////////    مصعد كهربائي




                string queryselectmasad = "select distinct masad    from tutorialspublic where masad is not null";


                dbconnect.openconn();

                dt.Clear();
                dt = dbconnect.selectdata(queryselectmasad);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList1masad.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }





                ///////////////////////////////////////////////////////     خدمات البناء




                string queryselecservice = "select distinct serviecother    from tutorialspublic where serviecother is not null";


                dbconnect.openconn();

                dt.Clear();
                dt = dbconnect.selectdata(queryselecservice);



                dbconnect.closeconn();

                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)


                        DropDownList1service.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
                }



            }

        }





        protected void addbuttonmany(object sender, EventArgs e)   /////   اضافة عملة جديدة
        {






            if ((txtmany.Text != "") && (txtmany.Text != null))  /////  عملة العقار
            {

                string queryinsertmany = " insert into tutorialspublic(many )values('" + txtmany.Text + "')  ";




                dbconnect.openconn();

                dbconnect.insertdata(queryinsertmany);

               

                dbconnect.closeconn();


            }





            ///////////////////////////////  قوة عملة العقار

            if ((txtpow.Text != "") && (txtmany.Text != "") && (txtpow.Text != null) && (txtmany.Text != null))  /////  عملة العقار قوى
            {

                string queryinsertmanypow = " insert into manypower(namemany ,power )values( '" + txtmany.Text + "'  ,'" + txtpow.Text + "')  ";



                dbconnect.openconn();


                dbconnect.insertdata(queryinsertmanypow);

                txtpow.Text = "";

                txtmany.Text = "";

                dbconnect.closeconn();


            }





            Response.Redirect("homee.aspx");






        }


        /// <summary>
        /// /////////////////////////////////////////////////////////



        protected void refersh(object sender, EventArgs e)   /////   اضافة منطقة جديد
        {

            Response.Redirect("homee.aspx");





        }





        protected void buttaddcounty(object sender, EventArgs e)   /////   اضافة بلد جديد
        {






            if ((txtcountry.Text != "") && (txtcountry.Text != null))
            {

                string queryinsertcountry = " insert into tutorialspublic(country )values('" + txtcountry.Text + "')  ";



                dbconnect.openconn();


                dbconnect.insertdata(queryinsertcountry);

                

                dbconnect.closeconn();



                DropDownList1country.SelectedItem.Text = txtcountry.Text;


                txtcountry.Text = "";

                // Response.Redirect("homee.aspx");

                DropDownList3city.SelectedItem.Text = "";


            }



        }



        protected void buttaddcity(object sender, EventArgs e)   /////   اضافة مدينة جديدة
        {




            ////////txtcity ////////////////////////////////////////////
            ///
            if ((txtcity.Text != "")&& (DropDownList1country.SelectedItem.Text != ""))
            {

                string queryinsertcity = " insert into tutorialspublic(city )values('" + txtcity.Text + "')  ";


                dbconnect.openconn();


                dbconnect.insertdata(queryinsertcity);
                dbconnect.closeconn();


          
                string queryinsertcitypub = " insert into  countrypublic( namrcountry ,namecitynode ) values('"+ DropDownList1country.SelectedItem.Text+"' ,'"+txtcity.Text+"') ";


                dbconnect.openconn();


                dbconnect.insertdata(queryinsertcitypub);
                dbconnect.closeconn();


                DropDownList3city.SelectedItem.Text = txtcity.Text;


                txtcity.Text = "";

                almanteka.SelectedItem.Text = "";
              // Response.Redirect("homee.aspx");


            }


        }


        protected void buttaddmanteka(object sender, EventArgs e)   /////   اضافة منطقة جديد
        {




            ///////////////txtalmanteka

            if( (txtalmanteka.Text != "")&&(DropDownList3city.SelectedItem.Text!=""))
            {

                string queryinsertmanteka = " insert into tutorialspublic(manteka )values('" + txtalmanteka.Text + "')  ";
                dbconnect.openconn();



                dbconnect.insertdata(queryinsertmanteka);
                dbconnect.closeconn();



         

                string queryinsertmanteka99 = " insert into  citypublic(namecity ,namemantekanode ) values('"+ DropDownList3city.SelectedItem.Text+ "',  '" + txtalmanteka.Text + "' )  ";
                dbconnect.openconn();



                dbconnect.insertdata(queryinsertmanteka99);
                dbconnect.closeconn();


                almanteka.SelectedItem.Text = txtalmanteka.Text;


                txtalmanteka.Text = "";
                //Response.Redirect("homee.aspx");

                DropDownList1mantekanode.SelectedItem.Text = "";


            }




        }





        protected void addbuttonlocale(object sender, EventArgs e)   /////   للمنطقة اضافة تفرعات  جديدة
        {





            if (txtnamenode.Text != "")
            {

                string queryinsertmanteka = "  insert into  mantekapublic(namemanteka  , namemantekanodenode )  values('" + almanteka.SelectedItem.Text + "' , '"+ txtnamenode.Text+"')  ";
                dbconnect.openconn();



                dbconnect.insertdata(queryinsertmanteka);
                dbconnect.closeconn();

              //  DropDownList1mantekanode.SelectedItem.Text = txtnamenode.Text;

                // Response.Redirect("homee.aspx");

                txtnamenode.Text = "";


            }


          

        }



        protected void addtutorialspublic_Click(object sender, EventArgs e)   ////  اضافة مواصافات جديدية للعقار
        {






            ///////////////txtetypetutorial  

            if (txtetypetutorial.Text !="")
            {

                string queryinserttutorialType = " insert into tutorialspublic(tutorialType )values('" + txtetypetutorial.Text + "')  ";


                dbconnect.openconn();


                dbconnect.insertdata(queryinserttutorialType);
                dbconnect.closeconn();



            }


            ///////////////TextBox1tabke  

            if (TextBox1tabke.Text !="")
            {

                string queryinserttutoritabke = " insert into tutorialspublic(tabke  )values('" + TextBox1tabke.Text + "')  ";



                dbconnect.openconn();

                dbconnect.insertdata(queryinserttutoritabke);

                dbconnect.closeconn();


            }


            ///////////////TextBox1room  

            if (TextBox1room.Text != "")
            {

                string queryinserttroom = " insert into tutorialspublic(room  )values('" + TextBox1room.Text + "')  ";




                dbconnect.openconn();
                dbconnect.insertdata(queryinserttroom);
                dbconnect.closeconn();



            }



            ///////////////TextBox1alfarch   الفرش

            if (TextBox1alfarch.Text !="")
            {

                string queryinsertalalfarch = " insert into tutorialspublic(alfarch )values('" + TextBox1alfarch.Text + "')  ";


                dbconnect.openconn();


                dbconnect.insertdata(queryinsertalalfarch);
                dbconnect.closeconn();



            }




            ///////////////TextBox1alkasa   كسوة

            if (TextBox1alkasa.Text !="")
            {

                string queryinsertalalalkasa = " insert into tutorialspublic(alkasa  )values('" + TextBox1alkasa.Text + "')  ";


                dbconnect.openconn();

                dbconnect.insertdata(queryinsertalalalkasa);
                dbconnect.closeconn();



            }





            ///////////////TextBox1dirction    اتجاه

            if (TextBox1dirction.Text !="")
            {

                string queryinsertaldirction = " insert into tutorialspublic(dirction )values('" + TextBox1dirction.Text + "')  ";


                dbconnect.openconn();


                dbconnect.insertdata(queryinsertaldirction);

                dbconnect.closeconn();


            }




            ///////////////TextBox1havinge    ملكية

            if (TextBox1havinge.Text !="")
            {

                string queryinsertalhavinge = " insert into tutorialspublic(havinge )values('" + TextBox1havinge.Text + "')  ";




                dbconnect.openconn();

                dbconnect.insertdata(queryinsertalhavinge);

                dbconnect.closeconn();


            }



            ///////////////TextBox1refernc   اشارات

            if (TextBox1refernc.Text != "")
            {

                string queryinsertalrefernc = " insert into tutorialspublic(refernc )values('" + TextBox1refernc.Text + "')  ";



                dbconnect.openconn();


                dbconnect.insertdata(queryinsertalrefernc);

                dbconnect.closeconn();


            }





            ///////////////TextBox1electron   كهرباء

            if (TextBox1electron.Text !="")
            {

                string queryinsertalelectron = " insert into tutorialspublic(electron )values('" + TextBox1electron.Text + "')  ";


                dbconnect.openconn();


                dbconnect.insertdata(queryinsertalelectron);



                dbconnect.closeconn();

            }


            /////////////////////////////////////////   masd
             /////  مصعد


            if (TextBox1masad.Text != "")
            {

                string queryinsertalmasad = " insert into tutorialspublic(masad )values('" + TextBox1masad.Text + "')  ";


                dbconnect.openconn();


                dbconnect.insertdata(queryinsertalmasad);



                dbconnect.closeconn();

            }


            ///////////////////////////////////////////////
              //////   خدمات بناء

            if (TextBox2server.Text != "")
            {

                string queryinsertalservic = " insert into tutorialspublic(serviecother )values('" + TextBox2server.Text + "')  ";


                dbconnect.openconn();


                dbconnect.insertdata(queryinsertalservic);



                dbconnect.closeconn();

            }



            Response.Redirect("homee.aspx");

        }



        protected void almanteka_SelectedIndexChanged(object sender, EventArgs e)
        {

            string queryselealmanteka = "select distinct namemantekanodenode      from mantekapublic where  namemanteka ='" + almanteka.SelectedItem.Text + "'   and namemanteka  is not null";



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


            string queryselealmanteka = "select distinct namemantekanode    from citypublic where  namecity='" + DropDownList3city.SelectedItem.Text + "'   and namecity  is not null";



            dbconnect.openconn();

            dt.Clear();

            dt = dbconnect.selectdata(queryselealmanteka);



            dbconnect.closeconn();

            almanteka.Items.Clear();


            almanteka.Items.Add(new ListItem("حدد منطقة ", "0"));

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    almanteka.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i+1)));
            }






            string queryselealmanteka11 = "select distinct namemantekanodenode      from mantekapublic where  namemanteka ='" + almanteka.SelectedItem.Text + "'   and namemanteka  is not null";



            dbconnect.openconn();

            dt.Clear();

            dt = dbconnect.selectdata(queryselealmanteka11);



            dbconnect.closeconn();

            DropDownList1mantekanode.Items.Clear();

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    DropDownList1mantekanode.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i)));
            }










        }




        protected void selectcountry(object sender, EventArgs e)
        {




            //////////////////////////////city
            if (DropDownList1country.SelectedItem.Text != "")
            {

                // string queryselecity = "select distinct city  from tutorialspublic where city is not null";

                string queryselecity = "select distinct namecitynode   from countrypublic where    namrcountry='" + DropDownList1country.SelectedItem.Text + "'     and  namrcountry  is not null";



                dbconnect.openconn();

                dt.Clear();

                dt = dbconnect.selectdata(queryselecity);



                dbconnect.closeconn();
                DropDownList3city.Items.Clear();





                DropDownList3city.Items.Add(new ListItem("حدد مدينة", "0"));


                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)

                        DropDownList3city.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));

                }

            }
            //////////////////////////////////////////////////////////   manteka by city
            ///



                string queryselealmanteka = "select distinct namemantekanode    from citypublic where  namecity='" + DropDownList3city.SelectedItem.Text + "'   and namecity  is not null";



            dbconnect.openconn();

            dt.Clear();

            dt = dbconnect.selectdata(queryselealmanteka);



            dbconnect.closeconn();

            almanteka.Items.Clear();


            almanteka.Items.Add(new ListItem("حددمنطقة", "0"));

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)


                    almanteka.Items.Add(new ListItem(Convert.ToString(dt.Rows[i][0]), Convert.ToString(i + 1)));


            }




            //Response.Redirect("homee.aspx");


        }










    }
}