<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ALATLAS.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   <header id="navbar" class="mainNav  ">
    <div class="container">
        <nav class="navbar navbar-expand-lg navbar-light bg-light p-0">
            <a class="navbar-brand" href="#">
                <img src="files\log99.jpg" alt="  الاطلس" style=" width:150px;  background-color:Background;"/>
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo02" aria-controls="navbarTogglerDemo02" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon">
                    <svg xmlns="files\log99" width="28" height="28" viewBox="0 0 28 28">
                      <g id="Group_25042" data-name="Group 25042" transform="translate(-371 -960)">
                        <g id="Rectangle_13418" data-name="Rectangle 13418" transform="translate(371 960)" fill="#fff" stroke="#707070" stroke-width="1" opacity="0">
                          <rect width="28" height="28" stroke="none"/>
                          <rect x="0.5" y="0.5" width="27" height="27" fill="none"/>
                        </g>
                        <g id="menu" transform="translate(373 964.999)">
                          <path id="Path_30682" data-name="Path 30682" d="M23,124.668H1a1,1,0,0,1,0-2H23a1,1,0,0,1,0,2Zm0,0" transform="translate(0 -115.168)" fill="#fff"/>
                          <path id="Path_30683" data-name="Path 30683" d="M23,2H1A1,1,0,0,1,1,0H23a1,1,0,1,1,0,2Zm0,0" fill="#fff"/>
                          <path id="Path_30684" data-name="Path 30684" d="M23,247.332H1a1,1,0,0,1,0-2H23a1,1,0,0,1,0,2Zm0,0" transform="translate(0 -230.332)" fill="#fff"/>
                        </g>
                      </g>
                    </svg>
                </span>
            </button>

            <div class="collapse navbar-collapse" id="navbarTogglerDemo02">

                <ul class="navbar-nav ml-auto mt-2 mt-lg-0">
                                            <li class="nav-item ">

                            <a class="nav-link" href="#"></a>
                        </li>


                        <li class="nav-item ">
                            <a class="nav-link" style=" color:blue; font-size:15px;  background-color:aliceblue;  border:dashed; " href="#"  id="solde">أضف عقارك للبيع مجانا</a>
                        </li>

                         
                         

                        <li class="nav-item ">
                            <a class="nav-link" href="#"> </a>
                        </li>
                        <li class="nav-item ">
                            <a class="nav-link" href="#"> </a>
                        </li>


                         
                           <li class="nav-item ">
                            <a class="nav-link" style="color:blue; font-size:15px;  background-color:aliceblue;  border:dashed; " href="#" id="take">أضف عقارك للايجار مجانا</a>
                             </li>


                        <li class="nav-item ">
                            <a class="nav-link" href="#"> </a>
                        </li>
                        <li class="nav-item ">
                            <a class="nav-link" href="#"> </a>
                        </li>
                        <li class="nav-item ">
                            <a class="nav-link" href="#"> </a>
                        </li>
                                      
                    <li class="nav-item ">
                        <a class="nav-link" style="color:blue; font-size:15px;  background-color:aliceblue;  border:dashed; " href="#">عن عقارالاطلس</a>
                    </li>
                    <li class="nav-item ">
                        <a class="nav-link" href="#">  </a>
                    </li>
                    <li class="nav-item ">
                        <a class="nav-link" style="color:blue; font-size:15px;  background-color:aliceblue;  border:dashed; " href="contact me.aspx">تواصل معنا</a>
                    </li>
                </ul>
                <div class="left-align" style="white-space: nowrap">
 <a href="#" class="btn light-btn" style="  background-color:aliceblue;   align-content:center;   color:hotpink;   border:dashed;  font-size:17px; "   data-toggle="modal" data-target="#modalLoginForm"> <img src="https://aqaryamasr.com/assets/front/imgs/1.svg"style=" widows:inherit;" alt="تسجيل الدخول"/>تسجيل الدخول</a>

                                    </div>
                            </div>
        </nav>

            </div>
</header>



    


    <div class="main-content" style="min-height: 100vh;">
        


            <!--ad pop up (users)-->
        <!--ad pop up end (users)-->

    <section class="search">
        <div class="container-fluid" >
            <div class=" row">
                <div class="col">
                        <div class="g" ></div>
                    <div class="search-content" >
                        <div class="container">
                            <div class="row">
                                <div class="col-12">
                                     

                                    <br />
                                    <br />
                                    <h2 class="search__text" style="color:chartreuse;">إبحث عن عقارات للبيع و للايجار  ؟
                                    <%=firstnamewelcom %> <%=lastnamewelcom %> <%=emialewelocm %>
                                    </h2>
                                    
                                    <div class=" search-box"  style="min-width:160vh  ;   background-image:url('https://localhost:44343/files/OIP.jpg') ;   min-height:75vh; margin-top:10vh;"   >
                                        <ul class="nav nav-pills mb-3" id="pills-tab" role="tablist">
                                            <li class="nav-item">
                                                <a class="nav-link active fake-contract" data-type="ابحث عن عقار للشراء"   id="pagric"  href="ricepage.aspx"    role="tab"   aria-controls="pills-home" aria-selected="true">ابحث عن عقار للشراء</a>
                                            </li>
                                            <li class="nav-item">
                                                <a class="nav-link fake-contract" data-type="ابحث عن عقار للاستاجار" id="pagtakof"  href="take of.aspx" role="tab" aria-controls="pills-profile"   aria-selected="false">ابحث عن عقار للاستاجار</a>
                                            </li>
                                        </ul>
                                    <div class="tab-content" id="pills-tabContent">
                                    <div class="tab-pane fade show active" id="cc" role="tabpanel" aria-labelledby="pills-home-tab">



          
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
                                        
          
<asp:UpdatePanel ID="UpdatePanel5" runat="server">
<ContentTemplate>
     


  <div class="form-row">
       

      
      

     <div class="form-group col-12 col-md-2">
            

                 <label id="q5" class="form-control fakeinput" >بحث حسب البلد</label>

                  <asp:CheckBoxList ID="CheckBoxlista1country" runat="server" AutoPostBack="true"  ></asp:CheckBoxList>
          </div>


      

    <div class="form-group col-12 col-md-2">
        <label id="q" class="form-control fakeinput" >بحث حسب المدينة </label>

                <asp:CheckBoxList ID="CheckBoxlist2city" runat="server" AutoPostBack="true"  ></asp:CheckBoxList>
           
        </div>

      
     <div class="form-group col-12 col-md-2">
         <label id="q2" class="form-control fakeinput" >بحث حسب المنطقة</label>
 
             <asp:CheckBoxList ID="CheckBoxList1manteka" runat="server" AutoPostBack="true"  ></asp:CheckBoxList>
   
            
        </div>
      

     <div class="form-group col-12 col-md-2">
              
        <label id="q3" class="form-control fakeinput" >بحث حسب نوع العقار</label>
    
             <asp:CheckBoxList ID="CheckBoxList1type" runat="server" AutoPostBack="true"  ></asp:CheckBoxList>
   
              
        </div>
       
        

            
   <div class="form-group col-12 col-md-2">
                         
            
        <label id="q4" class="form-control fakeinput" >بحث حسب السعر</label>

            
           <label for="price_from"> viewاقل من</label>

            <asp:DropDownList ID="DropDownList5searchpriceaddmanyview" runat="server"  AutoPostBack="true"  ForeColor="Blue"   Font-Bold="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="300px"  OnSelectedIndexChanged="DDLAccounts_SelectedIndexChanged"    >
                 

             </asp:DropDownList>
           
         <br />
       <br />
   
     <asp:Button ID="Button2filterprice" runat="server" Text="تفعيل بحث bettwen " OnClick="Button2filterprice_Click" />
           
    <div class="d-flex align-items-center justify-content-between mt-3 prices-box">
           <br />
        <br />


         &nbsp;&nbsp;&nbsp;&nbsp;

         <%//////  <label for="price_from"  >اقل من</label>  %>

            <asp:DropDownList ID="DropDownList5priclowfrom" runat="server"   Visible="false"  AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="100px" >

             </asp:DropDownList>



       &nbsp;&nbsp;&nbsp;&nbsp;
         
   <% /////// <label for="price_many">حدد العملة</label>  %>
    <asp:DropDownList ID="DropDownList5powerlowfrom" runat="server"  Visible="false"  AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"  CssClass="ArabicFont"      Width="100px" >

     </asp:DropDownList> 
        </div>
       


     
       
          
    <div class="d-flex align-items-center justify-content-between mt-3 prices-box">
            
     <div class="form-group">               

        <label for="price_from"> السعر من </label>      
          <asp:DropDownList ID="DropDownList5pricbetoweenvie11" runat="server"  AutoPostBack="true"   ForeColor="Blue" Font-Bold="true"     CssClass="ArabicFont"  OnSelectedIndexChanged="pricbetoeenview11_SelectedIndexChanged"  Width="160px" >
             </asp:DropDownList>

       



            &nbsp;&nbsp; <h4>between</h4>&nbsp;&nbsp;
         
       </div>
      </div>
 
       <label for="price_from">  السعرالي</label>
        <asp:DropDownList ID="DropDownList5pricbettoweenview22" runat="server"  AutoPostBack="true"   ForeColor="Blue"   Font-Bold="true"    CssClass="ArabicFont"     OnSelectedIndexChanged="pricbetoeenview22_SelectedIndexChanged"   Width="170px" >
           </asp:DropDownList>


          
    <div class="d-flex align-items-center justify-content-between mt-3 prices-box">
            

          <div class="form-group">               

          <%//////////  <label for="price_from">السعر من</label>  %> 

                   
                   
         <asp:DropDownList ID="DropDownList9price11" runat="server" Visible="false"  AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="100px" >

         </asp:DropDownList>
            
     <%/////////////  <label for="price_many">حدد العملة</label>  %>
    <asp:DropDownList ID="DropDownList5manysearch" runat="server"  Visible="false" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"  CssClass="ArabicFont"      Width="80px" >

     </asp:DropDownList> 
      

           <%///////////   between   %>
          
       <%//////////////  <label for="price_to">السعر الي</label>  %>

                      
         <asp:DropDownList ID="DropDownList10price22" runat="server"  Visible="false" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="80px" >

         </asp:DropDownList>

          
     <%///////  <label for="price_many">حدد العملة</label>  %>
    <asp:DropDownList ID="DropDownList5manysearchpow" runat="server"   Visible="false" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"  CssClass="ArabicFont"      Width="80px" >

     </asp:DropDownList> 
              </div>



              </div>





       
             

</div>     


        <div class="form-group col-12 col-md-2">
        
        
           
        <asp:Button ID="Button1filtterpriclow" runat="server" Text="تفعيل  بحث اقل من " OnClick="Button2filterpricelow_Click" />
     
            </div>

  
              
        
      </div>

     </ContentTemplate>
 </asp:UpdatePanel> 
          



    <div class="more-filter-inputss" >
        
          
        <div class="form-row">

              

         



            <div class="form-group col-md-2 col-6">
                <input placeholder="" name="size" type="number" class="form-control sz-input-home" min="1"/>
                </div>

            welcom to search
            <div class="form-group col-12 col-md-8">
                <input placeholder="" name="q" type="text" class="form-control sz-input-home"/>
               </div>

            </div>
        </div>
        
    <div class="form-row" id="more" runat="server" >
        <div class="form-group col-md-6 d-flex align-items-center" id="morother" runat="server" >
            <a href="javascript:void(0)" id="more-search-boxes" class="more-search-boxes" >
                
                <svg id="Group_25033" data-name="Group 25033" xmlns="http://www.w3.org/2000/svg" width="20" height="20" viewBox="0 0 20 20">
                    <g id="Rectangle_65" data-name="Rectangle 65" fill="#392694" stroke="#707070" stroke-width="1" opacity="0">
                        <rect width="20" height="20" stroke="none"/>
                        <rect x="0.5" y="0.5" width="19" height="19" fill="none"/>
                    </g>
                    <g id="Rectangle_66" data-name="Rectangle 66" transform="translate(1 1)" fill="#392694" stroke="#707070" stroke-width="1" opacity="0">
                        <rect width="18" height="18" stroke="none"/>
                        <rect x="0.5" y="0.5" width="17" height="17" fill="none"/>
                    </g>
                    <path id="right-chevron" d="M6.5,7.5,0,13.594V15L8,7.5,0,0V1.406Z" transform="translate(18 6) rotate(90)" fill="#392694" opacity="0.8"/>
                </svg>
            </a>
        </div>


       


   <div class="form-group col-md-2">
            
         <asp:Button ID="BuSearch" runat="server"  CssClass="btn btn-success"  Text="بحث"  meta:resourcekey="BuAddStudentResource1" onclick="BuSearch_Click" />



        </div>


        
   
     </div> 


                                        </div>
                                        </div>
                     
                                        <div class="background1"></div>
                                    </div>
                                       
                                    

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
       
         </div>
    </section>
        
        </div>
<%////////////////////////////////////////////////////////////////////////////// %>
                   
        <asp:Literal ID="Literal7" runat="server"></asp:Literal>


        

    


<%/////////////////////////////////////////////////////////////////////////////////////////////// %>
      
<h3><asp:Literal ID="pagename" runat="server"></asp:Literal> </h3>



    <asp:Literal ID="Literal5" runat="server" Visible="false"></asp:Literal>

    <asp:TextBox ID="pagstae0" runat="server" Visible="false"></asp:TextBox>



    <%///////////////////////////////////////////////////////////////////////////////////////// %>





  <div class="modal fade" id="modalLoginForm99" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">


            <div  id="loginForm99" >

                  <input type="hidden" name="_token999" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
                 <div class="modal-header">
                      <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalLoginFormCloseBtn99"/>
                      
                    </div>


                <div class="modal-body">
                    <img src="files\log99.jpg"/>
                    <div id="msg-result09"></div>
                    <div class="md-form">
                        <label data-error="wrong" data-success="right" for="defaultForm-tel2">رقم الهاتف</label>
                        <input type="number" id="defaultForm-tel29" class="form-control validate validate_phone_login" placeholder="01x11111xxxxxxxx" name="phone09" />
                    </div>
                    <div class="md-form">
                        <label data-error="wrong" data-success="right" for="defaultForm-passsssssss">كلمة السر</label>
                        <div class="input-group" id="show_hide_password99">
                            <input type="password" id="defaultForm-passsssssss99"  name="password09" class="form-control validate"/>
                            <div class="input-group-addon">
                                <a href="#"><i class="bi bi-eye-slash"aria-hidden="true"></i></a>
                            </div>
                        </div>
                        <p><a href="#" data-toggle="modal" data-dismiss="modal" data-target="#modalForgotForm" id="forgotPasswordBtn99">نسيت كلمة السر ؟</a></p>
                    </div>
                </div>

                

                <div class="modalfooter justify-content-center" >
                    <button type="button"  class="btn btn-primary login" id="ll99" value="rrrr"  onclick="">تسجيل دخول</button>
                    <p> <a href="#" data-toggle="modal" data-dismiss="modal" data-target="#modalRegisterForm">ليس لديك حساب ؟ تسجيل </a></p>
                </div>


            </div>


        </div>
    </div>
</div>




    
    


    <script>
  
    

        document.getElementById("ll99").addEventListener('click', function () {

           // alert("jj");






            var valpass = $('#loginForm99 input[name="password09"]').val();

            var valphone = $('#loginForm99 input[name="phone09"]').val();




            if (valpass == '') {
                $('#loginForm99 input[type="password"]').addClass('border-error');
            }
            else if (valpass != '') {
                $('#loginForm99 input[type="password"]').removeClass('border-error');
            }




            if (valphone == '') {
                $('#loginForm99 input[type="number"]').addClass('border-error');
            }
            else if (valphone != '') {
                $('#loginForm99 input[type="number"]').removeClass('border-error');
            }






            if ((valpass != '') && (valphone != '')) {

                //alert("oooo");

                var inputphon = $('#loginForm99 input[name="phone09"]').val();

                var inputpass = $('#loginForm99 input[name="password09"]').val();


                // alert(inputphon);
                // alert(inputpass);

                $.ajax({
                    type: "POST",
                    url: 'index.aspx/ee',
                    data: "{ 'name' :'" + inputphon + "', 'pass' : '" + inputpass + "'}",
                    contentType: "application/json;charest=utf-8",
                    dataType: "json",


                    success: function (msg) {

                       // alert(msg.d);
                        if ((msg.d != "") && (msg.d != "not-active") && (msg.d != "error") && (msg.d != "private")) {

                            //  alert(msg.d);

                            window.location.href = "index.aspx?tutorialbrowserid=" + msg.d + " " + "&admintype=" + "publice" + "&state=" + '<%=pagstae0.Text%>';




                        }



                        else if (msg.d == "private") {

                            window.location.href = "myDashoard.aspx?admintype=" + msg.d;




                        }

                        else if (msg.d == "not-active") {

                            alert("not-active");


                            $('#modalLoginFormCloseBtn99').trigger('click');   //// اغلاق فورم تسجيل الدخول







                            var modalforgotpassForm = new bootstrap.Modal(document.getElementById('modalForgotForm'));  //// فورم نسيت كلمة السر




                            modalforgotpassForm.show();

                        }


                        else if (msg.d == 'error') {
                            alert("errorjjjjj");
                            $('#loginForm99').find('input[name="phone09"]').addClass('border-error').removeClass('border-success-a');
                            //$('.po').remove();
                            $('#loginForm99').find('input[name="phone09"]').after('<span class="error-msg po">' + "رقم الهاتف او كلمة السر غير صحيحة" + '</span>');

                        }
                    }



                });//// json



            }  /// else



        });
    </script>
      







   
    <%//////////////////////////////////////////////////////////////////////////////////////////////// %>
   

 <div class="container" dir= "rtl" >
  
  <div class="panel-group">
    

    <div class=" panel-primary class">

      <div class="panel-heading" style="text-align:center ">    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="20" 
                       Text=""></asp:Label> </div>

       

        <div class="container">
            <div class="row">
                  
                   


<asp:DataList ID="DataList3" runat="server" DataKeyField="tutorialID"  
    DataSourceID="SqlDataSource22" >

     <ItemTemplate>
         




      <div class="item box_featured" style="width:920px">
       
         

        <a href="#"   onclick="ff()"  title='<%# Eval("tutorialType") %>' >
           
            



            <div class="background-img" style="background: transparent url('  '); ">

                               

                <span><h4><%=stateview %></h4></span>

                <div class="col-sm-12 text-left" style="top: -45pt">
                     <div class="heartStyle">
                        <p href="javascript:void(0)" data-url="" class="clickFavourite"   style="cursor: auto;" disabled ="">
                            <svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" viewBox="0 0 32 32">
                                <g id="Group_24958k" data-name="Group 24958" transform="translate(-814.759 -1257.759)">
                                    <g id="Rectangle_13409k" data-name="Rectangle 13409" transform="translate(814.759 1257.759)" fill="#eae6ff" stroke="#707070" stroke-width="1" opacity="0">
                                        <rect width="32" height="32" stroke="none"/>
                                        <rect x="0.5" y="0.5" width="31" height="31" fill="none"/>
                                    </g>
                                    <path id="heartk" d="M19.837,22.543a7.923,7.923,0,0,0-3.709.911A8.241,8.241,0,0,0,14,25.06a8.241,8.241,0,0,0-2.129-1.606,7.923,7.923,0,0,0-3.709-.911A8.271,8.271,0,0,0,0,30.9c0,3.264,1.684,6.73,5,10.3a48.6,48.6,0,0,0,8.526,7.03l.47.311.47-.311A48.6,48.6,0,0,0,23,41.2c3.32-3.573,5-7.039,5-10.3A8.271,8.271,0,0,0,19.837,22.543Z" transform="translate(816.759 1238.216)" fill="#eae6ff"/>
                                </g>
                            </svg>
                        </p>

                </div>
            </div>
         </div>





            <div class="content-featured">

                <h3><asp:Label ID="Label151" runat="server" Font-Bold="true"  Font-Size="20px"    Text='<%# Eval("tutorialType") %>' ></asp:Label></h3>
               

                    <div class="felex">
                    <div class="div-felex">
                        <h4>الموقع</h4>
                        <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/locat.png?var=10"/> 
                         <asp:Label ID="Label11" runat="server"  Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("country") %>'  ></asp:Label>
                          <asp:Label ID="Label24" runat="server"  Font-Bold="true"    Font-Size="20px" Text= '<%# Eval("city") %>' ></asp:Label></p>

                       </div>
                       
                       <div class="div-felex">
                       <h4>المساحة</h4>
                       <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" alt="المساحة" title="المساحة"/>
                       <asp:Label ID="Label34" runat="server" Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("area") %>' ></asp:Label></p>

                        </div>

                           <div class="div-felex">
                            <h4>عدد الغرف</h4>
                            <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/rooms_number_mob.png?v=10" alt="عدد الغرف" title="عدد الغرف"/>
                           <asp:Label ID="Label42" runat="server"  Font-Bold="true" Font-Size="20px"   Text='<%# Eval("room") %>' ></asp:Label></p>
                           </div>

                        
                          <div class="div-felex">
                            <h4>الاطلالة</h4>
                            <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/bathrooms_number_mob.png?v=10" alt="عدد الحمامات" title="الاطلالة"/>
                          <asp:Label ID="Label32" runat="server"  Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("alatlalh") %>'></asp:Label></p>

                            
                        </div>

                       </div>

                <div class="price">
                    <p><asp:Label ID="Label13" runat="server" Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("price") %>' ></asp:Label>
     
                      <asp:Label ID="Label70" runat="server" Font-Bold="true" Font-Size="20px"  Text='<%# Eval("many") %>' ></asp:Label></p>

               

            </div>
        </a>
    </div>

      
</ItemTemplate>
    

    </asp:DataList>






                    </div>
                        </div>
                            </div>
        
                                 </div>
                                   </div>





    <script>


        function ff() {



            if ('<%=javaid%>' != "") {


                if ('<%=pagstae0.Text%>' == "rice")

                    window.location.href = "rice.aspx";


                else if ('<%=pagstae0.Text%>' == "take of")

                    window.location.href = "take of.aspx";


            }


            if ('<%=javaid%>' == "") {



                var modalforgotpassForm = new bootstrap.Modal(document.getElementById('modalLoginForm99'));  //// فورم نسيت كلمة السر




                modalforgotpassForm.show();

            }
        }

    </script>











      <div class="container" dir= "rtl" >

<div class="panel-group">
  

  <div class=" panel-primary class">
    <div class="panel-heading" style="text-align:center ">    <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="20" 
                     Text=""></asp:Label> </div>

     

      <div class="container">
          <div class="row">
           


 <asp:DataList ID="DataList2" runat="server" DataKeyField="tutorialID"  
     DataSourceID="SqlDataSource22">


     <ItemTemplate> 
     
          <br />
         <br />
         <br />

          <br />
 <br />

         
 <div class="item box_featured" style="width:800px;    " >
 <a href="#" title=" " >
                        

                       
     
            <div class="background-img " style=" background-image:  url('  '); ">
                

                <span><h4><%=stateview %></h4> </span>


                <div class="col-sm-12 text-left" style="top: -45pt">
                     <div class="heartStyle">
                        <p href="javascript:void(0)" data-url="" class="clickFavourite"   style="cursor: auto;" disabled ="">
                            <svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" viewBox="0 0 32 32">
                                <g id="Group_24958k" data-name="Group 24958" transform="translate(-814.759 -1257.759)">
                                    <g id="Rectangle_13409k" data-name="Rectangle 13409" transform="translate(814.759 1257.759)" fill="#eae6ff" stroke="#707070" stroke-width="1" opacity="0">
                                        <rect width="32" height="32" stroke="none"/>
                                        <rect x="0.5" y="0.5" width="31" height="31" fill="none"/>
                                    </g>
                                    <path id="heartk" d="M19.837,22.543a7.923,7.923,0,0,0-3.709.911A8.241,8.241,0,0,0,14,25.06a8.241,8.241,0,0,0-2.129-1.606,7.923,7.923,0,0,0-3.709-.911A8.271,8.271,0,0,0,0,30.9c0,3.264,1.684,6.73,5,10.3a48.6,48.6,0,0,0,8.526,7.03l.47.311.47-.311A48.6,48.6,0,0,0,23,41.2c3.32-3.573,5-7.039,5-10.3A8.271,8.271,0,0,0,19.837,22.543Z" transform="translate(816.759 1238.216)" fill="#eae6ff"/>
                                </g>
                            </svg>


                           
                    <img src="files\log99.jpg" style=" width:130px;"/>


     

                                   <asp:Label ID="Label2" runat="server" 
                                        meta:resourcekey="LaStudentNameResource1" 
                                        Text="id" Font-Bold="True" Visible="false"></asp:Label>
                             
                                    <asp:Label ID="Label8filterid" runat="server" Visible="false" Text='<%# Eval("tutorialID") %>' 
                                        Font-Bold="True"></asp:Label>
                               
                                   <asp:Label ID="Labelbrowserwinid" runat="server" Visible="false" Text='<%# Eval("tutorialbrowserwinid") %>' 
                                       Font-Bold="True"></asp:Label>
                                 
                           
     
                       
            <span> <asp:Label ID="Labelstate" runat="server" Visible="true" Text=''></asp:Label></span>
        


     
                                           <asp:GridView ID="GridView1messge" runat="server" AutoGenerateColumns="False" 
                                        CellPadding="4" DataKeyNames="browsercommentwin " 
                                        DataSourceID="SqlDataSource2messege" ForeColor="#333333" GridLines="None" AlternatingRowStyle-BorderStyle="Dashed" AlternatingRowStyle-HorizontalAlign="Center" AlternatingRowStyle-VerticalAlign="Middle"  BorderStyle="Dashed" HorizontalAlign="Center">
                                        
                                        <AlternatingRowStyle BackColor="White" />
                                       <Columns>
                                            
                                           
                     

                                          
                                             <asp:TemplateField HeaderText="ملاحظات للزبون">
                                                     <ItemTemplate>

                                           
                                                 :
                                              <asp:Label ID="Label59" runat="server" 
                                              Text='<%# Eval("browsercommentwin") %>' ></asp:Label>
 
                                             </ItemTemplate>
                                               </asp:TemplateField>


                                        </Columns>
                                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                        <SortedDescendingHeaderStyle BackColor="#820000" />
                                    </asp:GridView>

                                        
                                                   <asp:SqlDataSource ID="SqlDataSource2messege" runat="server" ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
                                       SelectCommand=" SELECT distinct browsercommentwin from requeststate   WHERE Reqtutorialid = ?

                                                       and Reqbowserid =? and reqState=?"
                                               

                                  ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                 <SelectParameters>
            <asp:ControlParameter ControlID="Label8filterid" PropertyName="Text" DefaultValue="" Name="tutorialid" />

               <asp:ControlParameter ControlID="Labelbrowserwinid" PropertyName="Text" DefaultValue="" Name="browserid" />
    
                <asp:ControlParameter ControlID="Labelstate" PropertyName="Text" DefaultValue="" Name="state" />
    
    
</SelectParameters>



</asp:SqlDataSource> 






        






     
    <div  id="Featured-owl" class="owl-carousel owl-theme" >

                           
        <asp:Repeater ID="GridView52" runat="server"  DataSourceID="SqlDataSource43">
                   
                            
                                 <ItemTemplate> 
                                     
                 
         
                         
                                     <asp:Image ID="Image1" runat="server" Width="50%" Height="50%" ImageUrl='<%# Eval("Tutoriallinke") %>' />       
  
                                  
               
                                </ItemTemplate>
                              </asp:Repeater>
                      





                  <asp:SqlDataSource ID="SqlDataSource43" runat="server" ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
                                       SelectCommand="SELECT tutorialslinkid, Tutoriallinke FROM linkimage WHERE (tutorialslinkid =?) "
                                       ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                 <SelectParameters>
       <asp:ControlParameter ControlID="Label8filterid" PropertyName="Text" DefaultValue="" Name="TutorialID" />
    
</SelectParameters>
</asp:SqlDataSource> 


                          
                    

        
        


        </div>




               </p>

       </div>
   </div>
</div>





     <br />
     <br />

          
    
  <div class="content-featured" >
  
     
        <div class="felex">

             <div class="div-felex"  >
                 <h4>الموقع</h4>
                 <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/> 
               <asp:Label ID="Label11" runat="server"  Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("country") %>'  ></asp:Label>
               <asp:Label ID="Label24" runat="server"  Font-Bold="true"    Font-Size="20px" Text= '<%# Eval("city") %>' ></asp:Label>
             <asp:Label ID="Label35" runat="server"  Font-Bold="true"    Font-Size="20px" Text= '<%# Eval("manteka") %>' ></asp:Label>


                 </p>
               </div>
           </div>


                 <div class="felex">       
                    <div class="div-felex">
                        <h4> نوع العقار</h4>    
                        <p><asp:Label ID="Label151" runat="server" Font-Bold="true"  Font-Size="20px"    Text='<%# Eval("tutorialType") %>' ></asp:Label></p>
                      </div>



              
                             
    
                            <div class="div-felex">
   
                                 <h4>غرف العقار</h4>  
                                 <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/rooms_number_mob.png?v=10" />

                                  <asp:Label ID="Label42" runat="server"  Font-Bold="true" Font-Size="20px"   Text='<%# Eval("room") %>' ></asp:Label></p>
            
                                </div>

                          

                                         
                                <div class="div-felex">
                                 
                                     <h4>اطلالة العقار</h4>     
                                      <p> <asp:Label ID="Label32" runat="server"  Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("alatlalh") %>'></asp:Label></p>
                                      
                                    </div>
                             
                     </div>
                            
                      <div class="felex">

                         <div class="div-felex">
                               
                              <h4> مساحة العقار</h4>  
                              
                                 <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
                                 <asp:Label ID="Label34" runat="server" Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("area") %>' ></asp:Label></p>
                             </div>

                       
    


                          <div class="div-felex">
                               
                               <h4> ملكية العقار</h4>  
                              

                                <p>  <asp:Label ID="Label36" runat="server"  Font-Bold="true" Font-Size="20px"   Text ='<%# Eval("havinge") %>' ></asp:Label></p>  
                             </div>
                              




                           
                                <div class="div-felex">
                               
                                     <h4> كسوة العقار</h4>    
                                      <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
                                      <asp:Label ID="Label456" runat="server" Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("alkasa") %>' ></asp:Label></p>              
                                   </div>

                          </div>
                            
                           
                          <div class="felex">
                              <div class="div-felex">
                                  <h4> اشارات العقار</h4>  
                                   <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/>

                                    <asp:Label ID="Label38" runat="server" Font-Bold="true"  Font-Size="20px"   Text='<%# Eval("refernc") %>' ></asp:Label></p>        
                                 </div>



                                  <div class="div-felex">
                                      
                                      <h4> طابق العقار</h4>  
                                        <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/rooms_number_mob.png?v=10" />

                         
                                        <asp:Label ID="Label40" runat="server"  Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("tabke") %>' ></asp:Label></p>
                                      
                                        </div>
                                       
      
                                </div>

         
      
        
  <div class="felex">


     <div class="div-felex">
  
       <h4> اتجاه العقار</h4>  
        <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/>

         <asp:Label ID="Label52" runat="server"  Font-Bold="true" Font-Size="20px"   Text='<%# Eval("dirction") %>' ></asp:Label></p>
   
      </div>




                           
   <div class="div-felex">                                 
       
      <h4> كهرباء العقار</h4>  

      <p> <asp:Label ID="Label74" runat="server" Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("electron") %>'></asp:Label></p>
     </div>

      
</div>




        
  <div class="felex">


     <div class="div-felex">
  
       <h4> مصعد العقار</h4>  
        <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/>

         <asp:Label ID="Label31" runat="server"  Font-Bold="true" Font-Size="20px"   Text='<%# Eval("masad") %>' ></asp:Label></p>
   
      </div>


            
   <div class="div-felex">                                 
       
      <h4> خدمات بناء العقار</h4>  

      <p> <asp:Label ID="Label33" runat="server" Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("Serviecother") %>'></asp:Label></p>
     </div>

      
</div>










        
  <div class="felex">


     <div class="div-felex">
                                   
        <h4> سعر العقار</h4>  

             <asp:Label ID="Label13" runat="server" Font-Bold="true"  Font-Size="20px"  Text='<%# Eval("price") %>' ></asp:Label>
     
                  <asp:Label ID="Label70" runat="server" Font-Bold="true" Font-Size="20px"  Text='<%# Eval("many") %>' ></asp:Label>

         </div>
         
     
      
  


           
     <asp:GridView ID="GridView2win" runat="server" AutoGenerateColumns="False"
         CellPadding="4" DataKeyNames="TutorialID" OnRowCommand="GridView2win_RowCommand"
         DataSourceID="SqlDataSource1win" ForeColor="#333333" GridLines="None"  AlternatingRowStyle-HorizontalAlign="Center"    HorizontalAlign="Center" >
                           
<AlternatingRowStyle BackColor="White" />
         <Columns>
                               
                            


          
                                          
            <asp:TemplateField HeaderText="">
                   <ItemTemplate>

                    
        <asp:Label ID="Label59id" runat="server"   ForeColor="Red"
     Text='<%# Eval("tutorialID") %>' Font-Bold="True" Visible="false"></asp:Label>
 
        </ItemTemplate>
       </asp:TemplateField>

             

             
             
           
   <asp:TemplateField HeaderText="" >
        <ItemTemplate>

           
       <asp:LinkButton ID="LinkButton3win"   runat="server" PostBackUrl='<%# "index.aspx?tutorialID=" + Eval("tutorialID")+"&statetutorial=" +txtstatetutorial.Text +"&tutorialbrowserid=" +tutorialbrowserid.Text +"&messg=ok"  %>'
           Text='<%# Eval("namebutton") %>'  CommandName="wintutorial"   >
       </asp:LinkButton>


       </ItemTemplate>

   </asp:TemplateField>


             

       

                              
                           </Columns>

                         

                       </asp:GridView>


         

  
           
        <asp:SqlDataSource ID="SqlDataSource1win" runat="server"
            ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
            SelectCommand="select tutorialID,  namebutton from  tutorials where  tutorialID=?  "
                      
            ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">

            
       <SelectParameters>
       <asp:ControlParameter ControlID="Label8filterid" PropertyName="Text" DefaultValue="" Name="tutorialid" />
    
    

         </SelectParameters>
                      
        </asp:SqlDataSource>

      
      

 </div>

    

      




 </div>
 
       


  </a>
     </div>



        </ItemTemplate>
    </asp:DataList>

          
   
    


    </div>
       </div>
          </div>


    </div>
          </div>
             

               

     <asp:SqlDataSource ID="SqlDataSource22" runat="server"
                        ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"

     SelectCommand= ""
    providerName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>" >





                  
 </asp:SqlDataSource>
         
         
    


    


    
    












    

    

    <div class="container" dir= "rtl" >
  
  <div class="panel-group">
    

    <div class=" panel-primary class">
      <div class="panel-heading" style="text-align:center ">    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="20" 
                       Text=""></asp:Label> </div>
      <div class="container"> 
          <br />
          <div class="row">



    <br />

              
           
    
     
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
<ContentTemplate>

    
   <asp:Button ID="Button1view" runat="server"      onclick="BuviewData_Click" Text="  عرض عقارات الزبون "  />
          
            <asp:Button ID="Button2add" runat="server"  onclick="addtutorial_Click" Text="  اضافة عقار جديد الزبون " Width="200px" BackColor="Red"  />


    <div class="ItemNewsConatin" > 
        <asp:Panel ID="Panel1solde" runat="server" CssClass="pnl2"  >   

            
            




            <p class="MsoNormal" dir="auto">
            <asp:Label ID="Label10" runat="server" Text="يرجى اضافة البيانات الصحيحة"></asp:Label></p>

            <br />

              
              <asp:TextBox ID="placee" runat="server" placeholder="placee" Visible="false"></asp:TextBox>

            



              
                                       <div class="alert alert-danger" id="Div1" runat="server">
                                              <asp:Literal ID="Literal3" Text="<strong>Warning!</strong>  يرجى اضافة معلومات حول العقار." runat="server"></asp:Literal>  
                                          </div>
                             

  





                
                    <br />
                    <br />
             

                         <asp:TextBox ID="TextBox4" runat="server"  Font-Size="X-Large" ForeColor="Red"  Enabled="false"    ></asp:TextBox>
            
                      <asp:TextBox ID="placetutorialee" runat="server"  Font-Size="X-Large" ForeColor="Red"  Enabled="false" ></asp:TextBox>
                    

              <table class="nav-justified" dir="rtl">
                  <tr>
        
                      
                        <td>
                            
                            
                            
                            
                            <h1>موقع العقار</h1>
                            <asp:Literal ID="Literal4" runat="server"></asp:Literal>
                        </td>

                    

                 <td><asp:Label ID="Label7" runat="server"  Text="حدد بلد العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
                  
                      <asp:DropDownList ID="DropDownList1" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"    Width="150px" OnSelectedIndexChanged="selectcountry"  >
    
                         
                      </asp:DropDownList>

                     <asp:TextBox ID="TextBox2countryonly" runat="server" Visible="false"></asp:TextBox>
                                      
    
 <asp:Literal ID="Literal11" runat="server" Text=" اساسي"></asp:Literal>

                       
                     </td>



           

                  <td><asp:Label ID="Label2w" runat="server"  Text="حدد مدينة العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
                  
                   <asp:DropDownList ID="DropDownList3" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  OnSelectedIndexChanged="selectcity"  >
                          
                      


                   </asp:DropDownList>
                                       
               
 <asp:Literal ID="Literal12" runat="server" Text=" اساسي"></asp:Literal>

                       
                     </td>
                     



                
                <td><asp:Label ID="Label3" runat="server"  Text="حدد منطقة العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
                  
                         <asp:DropDownList ID="DropDownList4" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  OnSelectedIndexChanged="almanteka_SelectedIndexChanged" >
                              
                             
                         </asp:DropDownList>
                       
                
 <asp:Literal ID="Literal9" runat="server" Text=" اساسي"></asp:Literal>




                        <asp:Label ID="Label91" runat="server"  Text="حدد منطقة الفرعية للعقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
   
     <asp:DropDownList ID="DropDownList1mantekanode" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  >
          
     </asp:DropDownList>
     
<asp:Literal ID="Literal23" runat="server" Text=" اساسي"></asp:Literal>









                       
                     </td>




                     <td>   <asp:Label ID="Label4" runat="server"  Text="حدد اسم الشارع" Font-Bold="True" Font-Size="12pt"></asp:Label>
           <asp:TextBox ID="txtstreatname" runat="server" Font-Bold="true" BackColor="YellowGreen" ></asp:TextBox>

  <br />
  <br />
           <asp:Label ID="Label5" runat="server" Text="حدد رقم البناء"></asp:Label>

           <asp:TextBox ID="txtnumberbuild" runat="server" Font-Bold="true" BackColor="YellowGreen"></asp:TextBox>

</td>
               

                  </tr>
                  </table>





            
                   <asp:Label ID="Label6" runat="server"  Text="حدد نوع العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>
                   <asp:DropDownList ID="DropDownList2" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  >

                   </asp:DropDownList>
                                      <td>
    
 <asp:Literal ID="Literal10" runat="server" Text=" اساسي"></asp:Literal>
</td>
             
              <br />
                      <br />




                 <br />

     <br />
   
      <asp:Label ID="Label9" runat="server"  Text="  حدد رقم الطابق " Font-Bold="True" Font-Size="12pt"></asp:Label>

     <asp:DropDownList ID="DropDownList5tabke" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>

     <br />
      <br />
     
      <asp:Label ID="Label14" runat="server"  Text="  حدد عدد الغرف " Font-Bold="True" Font-Size="12pt"></asp:Label>

        
     <asp:DropDownList ID="DropDownList6room" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>

     <br />
      <br />
      <asp:Label ID="Label15" runat="server"  Text="  حددحالة الفرش " Font-Bold="True" Font-Size="12pt"></asp:Label>

             
       

     <asp:DropDownList ID="DropDown7alfarch" runat="server"  AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" CssClass="ArabicFont"   Width="150px"></asp:DropDownList>

     <br />

      <br />



      <asp:Label ID="Label16" runat="server"  Text="  حددحالة الكسوة " Font-Bold="True" Font-Size="12pt"></asp:Label>

  


     <asp:DropDownList ID="DropDownList8alkasa" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px" ></asp:DropDownList>


     
     <br />
      <br />

    

     
      <asp:Label ID="Label17" runat="server"  Text="  حددحالة الاتجاه " Font-Bold="True" Font-Size="12pt"></asp:Label>

     <asp:DropDownList ID="DropDownList5dirction" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>

     
     
     <br />
         <br />
     
      <asp:Label ID="Label18" runat="server"  Text="  حددحالة الملكية " Font-Bold="True" Font-Size="12pt"></asp:Label>
     <asp:DropDownList ID="DropDownList5havinge" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>

     
     <br />
         <br />
     
      <asp:Label ID="Label19" runat="server"  Text="  حددحالة الاشارات " Font-Bold="True" Font-Size="12pt"></asp:Label>

     <asp:DropDownList ID="DropDownList5refernc" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>

      <br />
     <br />

     
      <asp:Label ID="Label20" runat="server"  Text="  حددحالة الكهرباء " Font-Bold="True" Font-Size="12pt"></asp:Label>

     <asp:DropDownList ID="DropDownList5electron" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>
     
     <br />
         <br />



              
             
      <asp:Label ID="Label29" runat="server"  Text="  حددحالة المصعد " Font-Bold="True" Font-Size="12pt"></asp:Label>

     <asp:DropDownList ID="DropDownList5masad" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>
     
     <br />
         <br />



             
      <asp:Label ID="Label30" runat="server"  Text="  حددحالة خدمات البناء " Font-Bold="True" Font-Size="12pt"></asp:Label>

     <asp:DropDownList ID="DropDownList5service" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>
     
     <br />
         <br />


















            
          <table class="nav-justified" dir="rtl"  border="1" style="-moz-box-align:center ; width:100vh;" >
               <tr>
                <td>

                 <asp:Label ID="Label8" runat="server"   Text="ادخل ثمن العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
                      
              <asp:TextBox ID="price" runat="server"   MaxLength="100"  placeholder="السعر"  onkeypress="return isokmaxlength(event,this,2000);" class="form-control "   meta:resourcekey="txtStudentNameResource1" Width="90%"></asp:TextBox>
     </td>

                    <td>
    
 <asp:Literal ID="Literal21" runat="server" Text=" اساسي"></asp:Literal>
</td>


       <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage=" يجب ان يكون المدخل ارقام فقط" ControlToValidate="price" ForeColor="Red"  Operator="DataTypeCheck" Type="Double"></asp:CompareValidator>


  
  

<td>  <asp:Label ID="Label69" runat="server"  Text="حدد عملة  سعرالعقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
      

        <asp:DropDownList ID="DropDownList5many" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  >
    
        </asp:DropDownList>

               
         </td>

                    <td>
    
 <asp:Literal ID="Literal8" runat="server" Text=" اساسي"></asp:Literal>
</td>






                   </tr>
              </table>

     
           <br />
                    
                     <asp:Label ID="Label21" runat="server"  Text="  حددالاطالة " Font-Bold="True" Font-Size="12pt"></asp:Label>

                      <asp:TextBox ID="TextBox2alatlalh" runat="server"  MaxLength="20"  placeholder="الاطلالة" BackColor="YellowGreen"  class="form-control " onkeypress="return isokmaxlength(event,this,200);"  meta:resourcekey="txtStudentNameResource1" Width="30%"></asp:TextBox>
                       
                    
                    
                    <br />

                    <br />
                     <asp:Label ID="Label22" runat="server"  Text="  حدد المساحة " Font-Bold="True" Font-Size="12pt"></asp:Label>

                    
                      <asp:TextBox ID="TextBox2area" runat="server"  MaxLength="20" BackColor="YellowGreen"  placeholder="area"  class="form-control " onkeypress="return isokmaxlength(event,this,200);"     Width="30%"></asp:TextBox>
                       
                    <br />
                 
                    <br />





               <asp:Label ID="LaStudentName10" runat="server"   Text="تفاصيل اضافية حول العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>

          <asp:TextBox ID="txtdeatials" runat="server"  BackColor="YellowGreen"  MaxLength="100"   placeholder="  Nots"  class="form-control input-lg" onkeypress="return isokmaxlength(event,this,400);" Height="100px" TextMode="MultiLine"></asp:TextBox>
       
          
            
 <table class="nav-justified" dir="rtl">
            <tr>


        
               
<td>

   <asp:Button ID="BuAddDatabrowser" runat="server"   ClientIDMode="Static"   onclick="BuAddData_Click" Text="اضافة طلب الان"   />
    </td>

            <td>
              <asp:Button ID="Button2_updatehaveperson" runat="server" Text="تعديل عقار الزبون"  ClientIDMode="Static"    onclick="BuUPDATE_Datahave_Click"   />
               </td>

           



</tr>
</table>
           


    
              



</asp:Panel>
        </div>


    
    
     </ContentTemplate>
 </asp:UpdatePanel>



                   

    </div>
          </div>
              </div>
                 </div>
                   </div>



    


   
    
<asp:UpdatePanel ID="UpdatePanel4" runat="server">
<ContentTemplate>
 

          <section class="properties">
      <div class="container-fluid">
          <div class=" row">
              <div class="col">
                 
              </div>
          </div>
      </div>


      <div class="container">
          <div class="row">
<div class="col-sm-4 pad-top-30">    

      



 
    <div dir="rtl" class="ItemNewsBackgruound">  
    <p>

                    

        


                        
    <table>
       <tr>
           <td>
                <asp:DataList ID="DataList1" runat="server" DataKeyField="tutorialID" Visible="false"  BorderColor="Red"
                    DataSourceID="SqlDataSource1" Width="100%" >
                    <ItemTemplate> 
                       
                            <div class="ItemNews img-rounded">
                                   
                                    
                                          <div class="ItemNewsConatin" > 

                                            <br />
                                              <br />
                                              <br />

 <div class="item box_featured" style="width:820px; border:dashed;">
 <a href="#" title="" >
                        
     

                  
      <asp:Panel ID="Panel77" runat="server" CssClass="pnl2"  border="0" style="-moz-box-align:center">
      
 

          
    <div  id="Featured-owl" class="owl-carousel owl-theme">   
                               
                                    <asp:Label ID="Label8tutorialid" runat="server" Text='<%# Eval("tutorialID") %>' 
                                        Font-Bold="True" Visible="false"></asp:Label>
                                
                               
    
       
        

        <asp:Repeater ID="GridView52image" runat="server"  DataSourceID="SqlDataSource43" OnItemCommand="repat1deletimag_RowCommand"  >
                   



                                    
        <ItemTemplate>


                                           <asp:Label ID="Label78imagid" runat="server" Text='<%# Eval("id") %>' 
                                              Font-Bold="True"  Width="100px" Font-Size="15px" Visible="false"></asp:Label>
       
                                         
                                          

                                       <asp:Image ID="Image2" runat="server" Height="150px"  
                                              ImageUrl='<%# Eval("Tutoriallinke") %>' Width="200px"   />

             


                      



       <asp:LinkButton ID="LinkButton3deleteimag"  Width="50px" runat="server" PostBackUrl='<%# "index.aspx?id=" + Eval("id")+"&statetutorial=" +txtstatetutorial.Text +"&tutorialbrowserid=" +  tutorialbrowserid.Text %>'
           Text="حذف  صورةالعقار" CommandName="deleteimage"   >
       </asp:LinkButton>
         

                


             </ItemTemplate>

</asp:Repeater>

    








                  <asp:SqlDataSource ID="SqlDataSource43" runat="server" ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
                                       SelectCommand="SELECT id,tutorialslinkid, Tutoriallinke FROM linkimage WHERE (tutorialslinkid =?) "
                                       ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                 <SelectParameters>
       <asp:ControlParameter ControlID="Label8tutorialid" PropertyName="Text" DefaultValue="" Name="TutorialID" />
    
</SelectParameters>




</asp:SqlDataSource> 
        </div>
    
           

                
                

                                

     <br />
     <br />

         
  <div class="content-featured">
    
     

        <div class="felex">

             <div class="div-felex">
                 <h4>الموقع</h4>
                 <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/> 
               <asp:Label ID="Label11" runat="server"   Text='<%# Eval("country") %>'  Font-Bold="true"  Font-Size="15px" ></asp:Label>
               <asp:Label ID="Label24" runat="server"   Text= '<%# Eval("city") %>'  Font-Bold="true"  Font-Size="15px"></asp:Label>

                 </p>
               </div>


      <div class="div-felex">
     <h4>العنوان التفصيلي</h4>
     <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/> 
   <asp:Label ID="Label61" runat="server"   Text='<%# Eval("manteka") %>' Font-Bold="true" Font-Size="15px"  ></asp:Label>
   <asp:Label ID="Label62" runat="server"   Text= '<%# Eval("placetutorial") %>' Font-Bold="true" Font-Size="15px" ></asp:Label>

     </p>
   </div>
           
            

</div>
            
        <div class="felex">

            <div class="div-felex">
             <h4> تاريخ بدء العقار</h4>    
             <p><asp:Label ID="Label63" runat="server"   Text='<%# Eval("DateStart") %>'  Font-Bold="true" Font-Size="15px"></asp:Label></p>
             </div>



            
            <div class="div-felex">
             <h4> تاريخ احدث تعديل للعقار</h4>    
             <p><asp:Label ID="Label64" runat="server"   Text='<%# Eval("Dateupdat") %>' Font-Bold="true" Font-Size="15px" ></asp:Label></p>
             </div>

     </div>


        <div class="felex">          
                    <div class="div-felex">
                        <h4> نوع العقار</h4> 
                          <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
                        <asp:Label ID="Label28" runat="server"   Text='<%# Eval("tutorialType") %>' Font-Bold="true"  Font-Size="15px"></asp:Label></p>
                      </div>



              
                             
    
                            <div class="div-felex">
   
                                 <h4>غرف العقار</h4>  
                                 <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/rooms_number_mob.png?v=10" />

                                  <asp:Label ID="Label43" runat="server" Font-Bold="true"  Font-Size="15px"   Text='<%# Eval("room") %>' ></asp:Label></p>
            
                                </div>

                          

                                         
                                <div class="div-felex">
                                 
                                     <h4>اطلالة العقار</h4>  
                                      <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
                                       <asp:Label ID="Label45" runat="server" Font-Bold="true"  Font-Size="15px" Text='<%# Eval("alatlalh") %>'></asp:Label></p>
                                      
                                    </div>
                             

                         </div>   
            
        <div class="felex">

                         <div class="div-felex">
                               
                              <h4> مساحة العقار</h4>  
                              
                                 <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
                                 <asp:Label ID="Label46" runat="server"  Font-Bold="true"  Font-Size="15px" Text='<%# Eval("area") %>' ></asp:Label></p>
                             </div>

                        
    

                   

                          <div class="div-felex">
                               
                               <h4> ملكية العقار</h4>  
                              
                               <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
                                 <asp:Label ID="Label50" runat="server" Font-Bold="true"  Font-Size="15px" Text='<%# Eval("havinge") %>' ></asp:Label></p>  
                             </div>
                              




                           
                                <div class="div-felex">
                               
                                     <h4> كسوة العقار</h4>    
                                      <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
                                      <asp:Label ID="Label55" runat="server" Font-Bold="true"  Font-Size="15px" Text='<%# Eval("alkasa") %>' ></asp:Label></p>              
                                   </div>


                        </div>    
                   
                     <div class="felex">        
                              <div class="div-felex">
                                  <h4> اشارات العقار</h4>  
                                   <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/>

                                    <asp:Label ID="Label56" runat="server" Font-Bold="true"  Font-Size="15px"  Text='<%# Eval("refernc") %>' ></asp:Label></p>        
                                 </div>



                                  <div class="div-felex">
                                      
                                      <h4> طابق العقار</h4>  
                                        <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/rooms_number_mob.png?v=10" />

                         
                                        <asp:Label ID="Label57" runat="server"  Font-Bold="true"  Font-Size="15px" Text='<%# Eval("tabke") %>' ></asp:Label></p>
                                      
                                        </div>
                                       
      
      
       
                        <div class="div-felex">
  
                         <h4> اتجاه العقار</h4>  
                             <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/>

                         <asp:Label ID="Label58" runat="server" Font-Bold="true"  Font-Size="15px"  Text='<%# Eval("dirction") %>' ></asp:Label></p>
   
                   </div>

             </div>

 <div class="felex">
                           
   <div class="div-felex">                                 
       
      <h4> كهرباء العقار</h4>  
         <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
          <asp:Label ID="Label74" runat="server" Font-Bold="true"  Font-Size="15px" Text='<%# Eval("electron") %>'></asp:Label></p>
     </div>


       <div class="div-felex">                                 
     
         <h4> مصعد العقار</h4>  
          <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
          <asp:Label ID="Label315" runat="server" Font-Bold="true"  Font-Size="15px" Text='<%# Eval("masad") %>'></asp:Label></p>
     </div>
      


     <div class="div-felex">                                 
  
      <h4> خدمات بناء العقار</h4>  
        <p><img src="https://aqaryamasr.com/frontend/imgs/property_featured/size_mob.png?v=10" />
        <asp:Label ID="Label338" runat="server" Font-Bold="true"  Font-Size="15px" Text='<%# Eval("Serviecother") %>'></asp:Label></p>
     </div>




     </div>


  <div class="felex">

     <div class="div-felex">
                                   
        <h4> سعر العقار</h4>  

             <asp:Label ID="Label60" Font-Bold="true"  Font-Size="15px" runat="server" Text='<%# Eval("price") %>' ></asp:Label>
     
                  <asp:Label ID="Label70" Font-Bold="true"  Font-Size="15px" runat="server" Text='<%# Eval("many") %>' ></asp:Label>

         </div>
         
     
    <div class="div-felex">
                          
    <h4> ملاحظات عن العقار</h4>  

    <asp:Label ID="Label65" runat="server" Font-Bold="true"  Font-Size="15px" Text='<%# Eval("tutorialDeatils") %>' ></asp:Label>
 

</div>
     

</div>     


      <br />
      <br />
      

 <div class="felex">


     <asp:GridView ID="GridView2updatedata1" runat="server" AutoGenerateColumns="False"
         CellPadding="4" DataKeyNames="TutorialID" OnRowCommand="GridView2updatedata1_RowCommand"
         DataSourceID="SqlDataSource1updatedat" ForeColor="#333333" GridLines="None"  AlternatingRowStyle-HorizontalAlign="Center" AlternatingRowStyle-VerticalAlign="Middle" BackColor="#ffffff"  HorizontalAlign="Center" >
                           
<AlternatingRowStyle BackColor="White" />
         <Columns>
                               
                            
             
   <asp:TemplateField HeaderText="..">
       <ItemTemplate>
           <asp:Label ID="Labeltutorialupdatedeleteid" runat="server" Visible="false" Text='<%# Eval("tutorialID") %>' ></asp:Label>

            
           
       </ItemTemplate>

   </asp:TemplateField>


          
             
   <asp:TemplateField HeaderText="..">
       <ItemTemplate>

       <asp:LinkButton ID="LinkButton1"  Width="250px" runat="server" PostBackUrl='<%#  "index.aspx?id=" + Eval("tutorialID") + "&statetutorial=" +txtstatetutorial.Text +"&tutorialbrowserid=" +  tutorialbrowserid.Text   %>'
           Text="اضغط لتحميل صورة " CommandName="inserteimage"  >
       </asp:LinkButton>
           
      

       </ItemTemplate>

   </asp:TemplateField>

             
           
   <asp:TemplateField HeaderText=".">
        <ItemTemplate>
       <asp:LinkButton ID="LinkButton2updatetutorial"  Width="200px" runat="server" PostBackUrl='<%# "index.aspx?id=" + Eval("tutorialID") +"&statetutorial=" +txtstatetutorial.Text +"&tutorialbrowserid=" +  tutorialbrowserid.Text   %>'
           Text="تعديل العقار" CommandName="updatetutorial" >
       </asp:LinkButton>

   
       </ItemTemplate>

   </asp:TemplateField>


            
             


    <asp:TemplateField HeaderText="..........">
      <ItemTemplate>
     <asp:LinkButton ID="LinkButton2addtutorial"  Width="200px" runat="server" PostBackUrl='<%# "index.aspx?tutorialbrowserid=" +tutorialbrowserid.Text+"&statetutorial=" +txtstatetutorial.Text   %>'
         Text="اضافة عقار جديد" CommandName="addtutorial">
     </asp:LinkButton>

 
     </ItemTemplate>

 </asp:TemplateField>





           
   <asp:TemplateField HeaderText="..........">
        <ItemTemplate>

           
       <asp:LinkButton ID="LinkButton3deletetutorial"  Width="200px" runat="server" PostBackUrl='<%# "index.aspx?id=" + Eval("tutorialID")+"&statetutorial=" +txtstatetutorial.Text +"&tutorialbrowserid=" +  tutorialbrowserid.Text %>'
           Text="حذف العقار" CommandName="deletetutorial"  >
       </asp:LinkButton>


       </ItemTemplate>

   </asp:TemplateField>



       

                              
                           </Columns>
                          
                       </asp:GridView>


      </div>
  


</div>

        <asp:SqlDataSource ID="SqlDataSource1updatedat" runat="server"
            ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
            SelectCommand="select tutorialID from tutorials where  tutorialID=? "
                      
            ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">


                   <SelectParameters>
<asp:ControlParameter ControlID="Label8tutorialid" Name="tutorialID" 
          PropertyName="Text" />
         </SelectParameters>
                      
        </asp:SqlDataSource>

         
          
     
</asp:Panel>



           </a>
          </div>



                        </div>
                            </div>
                    </ItemTemplate>
                </asp:DataList>
               
                        </td>
        </tr>
        <tr>

            



            <td>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                                            ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
                                            SelectCommand=""
                                            ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                                
                                            </asp:SqlDataSource>
           
            </td>
            
        </tr>
       
    </table>
    
         </div>





    </div>
</div>
</div>
</section>
  


  
     </ContentTemplate>
 </asp:UpdatePanel>

  
    <%/////////////////////////////////////////////////////////////////////////////////    slid %>


    
    <%///////////////////////////////////////////////////////////////////////////////////////////////////  slid %>

    
        <section class="Governorate">
        <div class="container-fluid">
            <div class=" row">
                <div class="col">
                    <h2 class="Featured-title">تصفح عقارات للبيع او اجار ضمن المحافظات</h2>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div id="Governorate-slid"class="owl-carousel owl-theme">


                                            <a href="#" class="item" style="width:100%">
                                               
 <div class="background-img" style="background: transparent url('https://aqaryamasr.com/storage/realestates/pNCc7PyzDtQoUdeiZZxgqXY7MgstZ3bm8iWCeo5e.jpg');">
     <span>للبيع</span>

  
     
  <img src=" files\log99.jpg"/>
    </div>
</a>


                                            <a href="https://aqaryamasr.com/realestate_filter/%D8%A7%D9%84%D8%AC%D9%8A%D8%B2%D8%A9/0/0/0/%D9%84%D9%84%D8%A8%D9%8A%D8%B9" class="item" style="width:100%">
   <div class="background-img" style="background: transparent url('#');">
     <span>للإيجار</span>
             
    </div>
</a>


                                            <a href="#" class="item" style="width:100%">
     <div class="background-img" style="background: transparent url('https://aqaryamasr.com/storage/realestates/g8jCiz3YwKufLvYuiASTPPrsm2WIYhv9CgPQWXzg.jpg');">
     <span>للبيع</span>
             
    </div>
</a>


                                            <a href="#" class="item" style="width:100%">
    <div class="background-img" style="background: transparent url('https://aqaryamasr.com/storage/realestates/OerXpWJ3uNohYazADM7BV60wWiIagFdkK9NkjKgZ.jpg');">
     <span>للبيع</span>
              
    </div>
</a>


                                            <a href="#" class="item" style="width:100%">
    <div class="background-img" style="background: transparent url('https://aqaryamasr.com/storage/realestates/Wxao1QYFRkxXWTJ85hgr0lRl2NqKplUAZDW0iWIq.png');">
     <span>للإيجار</span>
            
    </div>
</a>


                                            <a href="#" class="item" style="width:100%">
    <div class="background-img" style="background: transparent url('https://aqaryamasr.com/storage/realestates/wE3kH2RTITkVVkTA4p2pr4tkgBtY9qRVGA1sGKbm.jpg');">
     <span>للبيع</span>
             
    </div>
</a>


                                            <a href="#" class="item" style="width:100%">
     <div class="background-img" style="background: transparent url('https://aqaryamasr.com/storage/realestates/ug8BZhNbMenR4OV5p7d7qm37EtBG0bdsEC6JX5hz.jpg');">
      <span>للبيع</span>
            
    </div>
</a>


                                            <a href="#" class="item" style="width:100%">
    <div class="background-img" style="background: transparent url('https://aqaryamasr.com/storage/realestates/xxRhs1JulQAL949iborRxdnl6KaIYriqvxLs6J9A.jpg');">
     <span>للإيجار</span>
            
    </div>
</a>


             </div>


            </div>
        </div>
    </section>
    

    



 <%   /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// %>

    
    
    <script src="https://aqaryamasr.com/assets/front/js/bootstrap.min.js" rel="preload"></script>


    <script src="https://aqaryamasr.com/assets/front/js/owlcarousel/owl.carousel.min.js" rel="preload"></script>


    
     <script>

         // document.getElementById("BuSearch").addEventListener('click', function () {

         //  $('.owl-carousel').owlCarousel();          
         $('.owl-carousel').owlCarousel({



             rtl: true,
             loop: ($('#Featured-owl.items').length > 2 && window.innerWidth >= 768),
             nav: true,
             items: 1,
             autoplay: true,
             autoplayTimeout: 4000,
             autoplayHoverPause: true,
             dots: true,
             responsive: {
                 0: {
                     items: 1,
                     // dotsEach: 8
                 },
                 // breakpoint from 768 up
                 768: {
                     items: 2,
                     // dotsEach: 8
                 }
             }
         });





         $('#Governorate-slid').owlCarousel({
             rtl: true,
             items: 4,
             loop: true,
             nav: true,
             autoplay: true,
             autoplayTimeout: 6000,
             autoplayHoverPause: true,
             dots: true,
             responsive: {
                 0: {
                     items: 1,
                     // dotsEach: 8
                 },
                 // breakpoint from 768 up
                 768: {
                     items: 4,
                 }
             }
         });
        




     </script>




    

<%///////////////////////////////////////////////////////////////////////////     طلب شراء او استاجار عقار   ارسال%>

    
    
<div class="modal fade" id="modalmessgbox" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">

            <div id="messgid">
             <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
             <div class="modal-header">
     <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgCloseBtn"/>
        <span aria-hidden="true">&times;</span>  
   </div>


            
                <div class="modal-body">
                    <img src="files\log99.jpg"/>
                    <div id="msg-result"></div>
                    <div class="md-form">
               <label data-error="wrong"  data-success="right" title="" for="defaultForm-tel2">showmessg</label>
                <input type="hidden" id="defaultForm-tel2"  class="form-control validate validate_phone_login" placeholder="" name="messg" />

                    </div>

                    
                  <button type="button"  id="ok1" class="btn btn-success" onclick="" >موافق</button>
                        
                    
                  <button type="button"  id="ok2" class="btn btn-success" onclick="" >غير موافق</button>
                        
                 


    




            </div>
 

                </div>


       </div>
    </div>
</div>





    





    
  <script>

      // $(window).on('load', function () {

      function showmessok() {


          $('#modalmessgbox').modal('show');


          if ('<%=txtstatetutorial.Text%>' == "solde") {

              // $('#messgid input[name="messg"]').val( "هل انت تريد شراء العقار");

              $('#messgid').find('input[name="messg"]').after('<span class="error-msg po">' + "هل تريد شراء هذا العقار" + '</span>');

          }
          else if ('<%=txtstatetutorial.Text%>' == "take") {

              // $('#messgid input[name="messg"]').val( "هل انت تريد شراء العقار");

              $('#messgid').find('input[name="messg"]').after('<span class="error-msg po">' + "هل تريد استاجار هذا العقار" + '</span>');
          }










          document.getElementById("ok2").addEventListener('click', function () {
              // document.getElementById("ok2").addEventListener('click', function () {

            //  alert("nnnnnO");

             


              $('#modalmessgCloseBtn').trigger('click');





          });
              





          document.getElementById("ok1").addEventListener('click', function () {
           


              $('#sendrequset').trigger('click');






          });


      }



  </script>



    

   <%  //  //////////////////////////////////////////////////////////////  اضافة  عقار جديد %>



    
    
    
<div class="modal fade" id="modalmessgaddbox" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">
        

         <div id="messgadd">
          <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
          <div class="modal-header">


  <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgaddCloseBtn"/>

     <span aria-hidden="true">&times;</span> 
              




</div>


         
             <div class="modal-body">
                 <img src="files\log99.jpg"/>
                 <div id="msg-result0"></div>
                 <div class="md-form">
            <label data-error="wrong"  id="mesg" data-success="right" title="" for="defaultForm-tel2"></label>
             <input type="hidden" id="defaultForm-tel0"  class="form-control validate validate_phone_login" placeholder="" name="messgadd" />

                 </div>

                 
               <button type="button"  id="okadd" class="btn btn-success" onclick="" >موافق غلى اضافة العقار</button>
                     
                 
               <button type="button"  id="noadd" class="btn btn-success" onclick="" > غير موافق</button>
                     
              

                 </div>

             
    
            <asp:TextBox ID="TextBox1" runat="server" Text="welcom" ClientIDMode="Static" ></asp:TextBox>
            <img id="imagload" src="aa"  />
            

         </div>
 
</div>
</div>
    </div>




    <script>



        function addprice() {
            alert("يرجى اضافة السعر  والعملةاولا");

        }

        function addcountry() {
            alert("يرجى تحديد بلد العقار");

        }

        function addcity() {
            alert("يرجى تحديد المدينة العقار");

        }

        function addplace() {
            alert("يرجى تحديد منطقة العقار");

        }

        function addtype() {
            alert("يرجى تحديد نوع العقار");

        }






        function addtutoroial() {



            $('#modalmessgaddbox').modal('show');

            $('#messgadd').find('input[name="messgadd"]').after('<span class="error-msg po">' + "سوف يتم اضافة هذا العقار في قائمة العقارات للشرء" + '</span>');


            // document.getElementById("mesg").title = "سوف يتم اضافة هذا العقار في قائمة العقارات للشرء";





            document.getElementById("okadd").addEventListener('click', function () {


                document.getElementById("TextBox1").value = "ok";


                document.getElementById("imagload").namespaceURI = "/image2/load.gif";

                // document.getElementById("BuAddDatabrowser").trigger('click');



                $('#BuAddDatabrowser').trigger('click');

            });



            document.getElementById("noadd").addEventListener('click', function () {



                $('#modalmessgaddCloseBtn').trigger('click');



            });

        }





   <%  //  //////////////////////////////////////////////////////////////  تعديل  العقار %>




        function updatetutoroial() {



            $('#modalmessgaddbox').modal('show');

            $('#messgadd').find('input[name="messgadd"]').after('<span class="error-msg po">' + "سوف يتم تعديل هذا العقار  حسب البيانات المدخلة الان" + '</span>');


            document.getElementById("okadd").addEventListener('click', function () {


                document.getElementById("TextBox1").value = "ok";


                // document.getElementById("BuAddDatabrowser").trigger('click');



                $('#Button2_updatehaveperson').trigger('click');






            });





            document.getElementById("noadd").addEventListener('click', function () {




                $('#modalmessgaddCloseBtn').trigger('click');





            });



        }



        function noadd() {

            alert("لم تتم الاضافة");

        }





    </script>





       





    

   <%  //  //////////////////////////////////////////////////////////////  اضافة صور للعقار %>

    

<div class="modal fade" id="modalmessgaddimagebox" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">
        

         <div id="messgaddimage">
          <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
          <div class="modal-header">


  <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgaddimageCloseBtn"/>

     <span aria-hidden="true">&times;</span> 
         
</div>

             <div class="modal-body">
                 <img src="files\log99.jpg"/>
                
               <asp:Label ID="Label99" runat="server"   Text="اختر  صور للعقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
   
                     <asp:FileUpload ID="FileUpload1" runat="server"          class="btn btn-success" />
                    <asp:TextBox ID="tutoriallink" runat="server"  Text="jkkjk" Width="50%" Visible="true"></asp:TextBox>
   
       
                 </div>

                   <button type="button"  id="okaddimage" class="btn btn-success" onclick="" >موافق غلى اضافة الصورة</button>
        
    
                   <button type="button"  id="noaddimage" class="btn btn-success" onclick="" > غير موافق</button>
                
             

             
             
   <asp:Button ID="addimagebutton" ClientIDMode="Static"   BackColor="White"    OnClick="onload_file" runat="server" Text="" />




         </div>
 
</div>
</div>
    </div>



    




    <script>


        function imageadd() {



           // $('#FileUpload1').trigger('click');

            $('#modalmessgaddimagebox').modal('show');








            document.getElementById("okaddimage").addEventListener('click', function () {



               


                $('#addimagebutton').trigger('click');

              //  alert('<%=tutoriallink.Text%>')


            });





            document.getElementById("noaddimage").addEventListener('click', function () {



                $('#modalmessgaddimageCloseBtn').trigger('click');

            });


        }




        function notaddimag() {


            alert("عذرا لم يتم اختيار صورة يرجى اعادة المحاولة لاختيار صورة لتحميلها");
            $('#modalmessgaddimagebox').modal('show');



            document.getElementById("okaddimage").addEventListener('click', function () {

                $('#addimagebutton').trigger('click');


            });




            document.getElementById("noaddimage").addEventListener('click', function () {

                $('#modalmessgaddimageCloseBtn').trigger('click');

            });







        }



    </script>




    

   <%  //  //////////////////////////////////////////////////////////////  حذف صور للعقار %>



    

<div class="modal fade" id="modalmessgdeletimagebox" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">
        

         <div id="messgdeletimage">
          <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
          <div class="modal-header">


  <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgdeletimageCloseBtn"/>

     <span aria-hidden="true">&times;</span> 
         

</div>

             
         
             <div class="modal-body">
                 <img src="files\log99.jpg"/>
                 <div id="msg-result0d"></div>
                 <div class="md-form">
             <input type="hidden" id="tel0d"  class="form-control validate validate_phone_login" placeholder="" name="messgadd" />

                 </div>


                   <button type="button"  id="okdeletimage" class="btn btn-success" onclick="" >موافق غلى حذف الصورة</button>
        
    
                   <button type="button"  id="nodeletimage" class="btn btn-success" onclick="" > غير موافق</button>
                

                 </div>


             


         </div>
 
</div>
</div>
    </div>



   




    

    <script>


        function imagdelet() {


            <%%>

            $('#modalmessgdeletimagebox').modal('show');

            $('#messgadd').find('input[name="messgadd"]').after('<span class="error-msg po">' + "هل انت متاكد من حذف هذه الصورة" + '</span>');


            document.getElementById("okdeletimage").addEventListener('click', function () {



                // document.getElementById("BuAddDatabrowser").trigger('click');



                $('#deletimagebutton').trigger('click');






            });





            document.getElementById("nodeletimage").addEventListener('click', function () {




                $('#modalmessgdeletimageCloseBtn').trigger('click');





            });





        }


    </script>



    
    

   <%  //  //////////////////////////////////////////////////////////////  حذف  عقار  %>



    
    

<div class="modal fade" id="modalmessgdelettutorials" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">
        

         <div id="messgdelettutorial">
          <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
          <div class="modal-header">


  <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgdelettutorialCloseBtn"/>

     <span aria-hidden="true">&times;</span> 
         

</div>

             <div class="modal-body">
                 <img src="files\log99.jpg"/>
                 <div id="msg-result0dt"></div>
                 <div class="md-form">
             <input type="hidden" id="tel0dt"  class="form-control validate validate_phone_login" placeholder="" name="messgadd" />

                 </div>


                   <button type="button"  id="okdelettutorial" class="btn btn-success" onclick="" >موافق غلى حذف العقار</button>
        
    
                   <button type="button"  id="nodelettutorial" class="btn btn-success" onclick="" > غير موافق</button>
                

                 </div>

             





         </div>
 
</div>
</div>
    </div>



    



    

    <script>


        function tutorialdelet() {


            $('#modalmessgdelettutorials').modal('show');

            $('#messgdelettutorial').find('input[name="messgadd"]').after('<span class="error-msg po">' + "هل انت متاكد من حذف هذه العقار" + '</span>');


            document.getElementById("okdelettutorial").addEventListener('click', function () {



                // document.getElementById("BuAddDatabrowser").trigger('click');



                $('#delettuorialbutton').trigger('click');



            });





            document.getElementById("nodelettutorial").addEventListener('click', function () {




                $('#modalmessgdelettutorialCloseBtn').trigger('click');

               // alert('<%=javaid%>');



            });





        }


    </script>











    

   <%  //  //////////////////////////////////////////////////////////////  end    %>

    


         
    <%/////////////////////////////////////////////////////////////////////////////// %>
   
    
    
          <script type="text/javascript">






              function ShowModalSucces() {

                  $("#DivMessagePanelsuccess").addClass('alert alert-success');
                  $('#ModalMessage').modal('show');
                  window.setTimeout(HideModal, 1000);


                  

              }

              function ShowModalError() {

                  $("#DivMessagePaneldanger").addClass('alert alert-danger');
                  $('#ModalMessagerror').modal('show');
                  window.setTimeout(HideModal, 1000);
              }

              function HideModal() {
                  $('#ModalMessage').modal('hide');
              }
          </script>  
    



<div id="ModalMessagerror" class="modal fade" role="dialog">
<div class="modal-dialog">
  
       <div class="alert alert-danger" id="DivMessagePaneldanger" runat="server">

         <asp:Literal ID="LiMessage" Text="<strong>Warning!</strong> يرجى اضافة اسم وكنية الزبون." runat="server" ></asp:Literal>  
             <a href="#" class="close" data-dismiss="modal" aria-label="close">&times;</a>
      </div>
                                  
     

  </div>
    </div>











    
          <div class="alert alert-success"   id="DivMessag">

       <asp:Literal ID="Literal2" Text="تم تسجيل طلبك بنجاح سوف يتم معالجة الطلب واعلامك  عزيزي الزبون." runat="server" Visible="false"></asp:Literal>
</div>



      <script type="text/javascript">
          function ShowModalSucces() {




              $("#DivMessagePanelsuccess").addClass('alert alert-success');
              $('#ModalMessage').modal('show');
              window.setTimeout(HideModal, 1000);

          }

      </script>





    
            <asp:Label ID="Label78" runat="server" Text="state" Visible="false"></asp:Label>
            <asp:TextBox ID="txtstatetutorial" runat="server" Visible="false"></asp:TextBox>



    
            <br />
            <br />

      <asp:Label ID="Label75" runat="server" Text="tutorialid" Visible="false"></asp:Label>
       <asp:TextBox ID="tutorialid" runat="server" Visible="false"></asp:TextBox>

     <br />
     <br />

    
      <asp:Label ID="Label23" runat="server" Text="browserid" Visible="false"></asp:Label>
      <asp:TextBox ID="tutorialbrowserid" placeholder="tutorialbrowserid" runat="server" Visible="false"></asp:TextBox>





        <br />
    <asp:TextBox ID="messegbox" runat="server"></asp:TextBox>
       <br />






       



    
    <asp:TextBox ID="TextBox5" runat="server" Font-Size="X-Large" ForeColor="Red"  Enabled="false"      ></asp:TextBox>




<div id="ModalMessage" class="modal fade" role="dialog">
<div class="modal-dialog">

     
          <div class="alert alert-success"   id="DivMessagePanelsuccess">
              <asp:Literal ID="Literal1" runat="server"></asp:Literal>
              <a href="#" class="close" data-dismiss="modal" aria-label="close">&times;</a>
          </div>

    
  </div>
    </div>














<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>


    <asp:Panel ID="Panelfilter" runat="server">

<table class="TabelStyles" style="width: 100%" dir="rtl">
                  <tr>
         

            <td> <h3>حدد خيارات البحث</h3></td>


           <asp:Literal ID="Literal6" runat="server" Text="" Visible="false"></asp:Literal>
            



    
     <td style="text-align: right;" colspan="2">
         </td>



         <td style="width: 10%">
         <asp:Label ID="Label27" runat="server" Text="البحث حسب البلد"></asp:Label>
             <asp:CheckBoxList ID="CheckBoxlista1country0" AutoPostBack="true" runat="server" ></asp:CheckBoxList>
                      
                   </td>
             
                  

    
<td style="text-align: right;" colspan="3">
      </td>
 <td style="width: 10%">
     <asp:Label ID="Label26" runat="server" Text="البحث حسب المدينة" ></asp:Label>
     <asp:CheckBoxList ID="CheckBoxlist2city0" runat="server" AutoPostBack="true"  ></asp:CheckBoxList>
   

                      </td>
           

    
     <td style="text-align: right;" colspan="3">
         </td>

     <td style="width: 10%">

         <asp:Label ID="Label47" runat="server" Text="البحث حسب المنطقة"></asp:Label>

         <asp:CheckBoxList ID="CheckBoxList1manteka0" runat="server" AutoPostBack="true"></asp:CheckBoxList>
          
                   
              </td>
    


   
         <td style="text-align: right;" colspan="3">

         </td>

 <td style="width: 15%">
     <asp:Label ID="Label48" runat="server" Text="البحث حسب نوع العقار"></asp:Label>
     <asp:CheckBoxList ID="CheckBoxList1type0" runat="server" AutoPostBack="true"></asp:CheckBoxList>
           

                    </td>

                
 
    
    
     <td style="text-align: right;" colspan="3">
         </td>


     <td style="width: 20%">
         
         <asp:CheckBox ID="CheckBox1pricfilter0" runat="server" Visible="true"  ForeColor="Red"/>
         <asp:Button ID="Button2filterprice0" runat="server" Text="اضغط هنا لتفعيل البحث حسب السعر" OnClick="Button2filterprice0_Click" />
         <br />
         <br />
          <asp:Literal ID="Literal9filterprice" runat="server"></asp:Literal>
         <br />
         <br />
         <asp:Label ID="Label72" runat="server" Text="القيمة الاصغر"></asp:Label>
    
         <asp:DropDownList ID="DropDownList9price110" runat="server"  AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="120px" >

         </asp:DropDownList>

         
         <h3>between</h3>

        

    <asp:Label ID="Label73" runat="server" Text="القيمة الاكبر"></asp:Label>
    
    <asp:DropDownList ID="DropDownList10price220" runat="server" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"      CssClass="ArabicFont"   Width="120px">

 </asp:DropDownList>



   
                  </td>
    
              <td>      
    <asp:DropDownList ID="DropDownList5manysearch0" runat="server"  AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="100px" >

</asp:DropDownList>
                  </td>



                



     <td style="text-align: right;" colspan="3">
         &nbsp;</td>
     <td style="width: 10%">                    
                
   

            
   <asp:Button ID="BuSearch0" runat="server"  CssClass="ButtonSearch"  Text="بحث" Height="30px"  meta:resourcekey="BuAddStudentResource1" onclick="BuSearch0_Click" />
          


         </td>
            
        </tr>


</table>

   
    </asp:Panel>
    



    </ContentTemplate>
    </asp:UpdatePanel>



    

    
    
<asp:UpdatePanel ID="UpdatePanel2filter" runat="server">
<ContentTemplate>






 
    <div dir="rtl" class="ItemNewsBackgruound">  
    <p>

                    <asp:Label ID="Label51" runat="server" Font-Bold="True" Font-Size="19" ForeColor="Red" 
                        Text=""></asp:Label>
                  </p>
     
    
         </div>



    

   <%  //  //////////////////////////////////////////////////////////////    footer %>



    <footer class="mt-5">
    <div class="container">
        <div class="row">
            <div class="col-sm-3">
                <img src="files\log99.jpg" alt="عقارات الاطلس"/>
            </div>
            <div class="col-sm-6">
                <h3>خريطة الموقع</h3>
                <ul class="footer-menu">
                    <li class="foot-item">
                        <a class="foot-link" href="#">عقارات <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="foot-item">
                        <a class="foot-link" href="javascript:void(0)"  data-toggle="modal" data-target="#modalLoginForm" >أضف عقارك مجانا</a>
                    </li>
                    <li class="foot-item">
                        <a class="foot-link" href="#"></a>
                    </li>
                    <li class="foot-item">
                        <a class="foot-link" href="#"> </a>
                    </li>
                    <li class="foot-item">
                        <a class="foot-link" href="#" target="_blank"> </a>
                    </li>
                    <li class="foot-item">
                        <a class="foot-link" href="#">عن عقار  الاطلس</a>
                    </li>
                    <li class="foot-item">
                        <a class="foot-link" href="#"></a>
                    </li>
                    <li class="foot-item">
                        <a class="foot-link" href="contact me.aspx">تواصل معنا</a>
                    </li>
                    <li class="foot-item">
                        <a class="foot-link" href="#"> </a>
                    </li>
                </ul>
            </div>
                        <div class="col-sm-3">
                <h3>تواصل معنا عبر</h3>
                <p>البريد الالكترونى : <a href="mailto:real@reeal.kassarint.com" style="color: inherit">real@reeal.kassarint.com</a></p>
                <p>مواقع التواصل الاجتماعى</p>
                <ul class="media">
                    <li><a target="_blank" href="https://www.facebook.com/"><img src="https://aqaryamasr.com/assets/front/imgs/f.png" width="32" height="32" alt="حساب الفيسبوك"/></a></li>                    <li><a target="_blank" href="#"><img src="https://aqaryamasr.com/assets/front/imgs/i.png" width="32" height="32" alt="حساب انستجرام"/></a></li>              <li><a target="_blank" href="https://www.youtube.com/channel/UCJBXpc6Ujv0sKV07X7eQZjQ"><img src="https://aqaryamasr.com/assets/front/imgs/y.png" width="32" height="32" alt="حساب يوتيوب"/></a></li>                </ul>
            </div>
            



        </div>
    </div>
</footer>



    

 <%//////////////////////////////////////////////////////////////////////////////////////////////////// %>

    

    
   <asp:Button ID="delettuorialbutton" ClientIDMode="Static"      OnClick="delet_tutorial" runat="server" Text="" />

   <asp:Button ID="deletimagebutton" ClientIDMode="Static"      OnClick="delet_image" runat="server" Text="" />

   <asp:Button ID="sendrequset" ClientIDMode="Static"      OnClick="send_request" runat="server" Text="" />


    








     </ContentTemplate>
  
 </asp:UpdatePanel>                




    <%//////////////////////////////////////////////////////////////////////////// %>



    




     <script type="text/javascript">



         document.getElementById("solde").addEventListener('click', function () {

             //  alert("eeee");

             if ('<%=javaid%>' != '') {

                 window.location.href = "soldepage.aspx";
             }
             else {


                 var modalLoginForm = new bootstrap.Modal(document.getElementById('modalLoginForm'));  //// فورم  تسجيل الدخول

                 modalLoginForm.show();
             }

         });







         document.getElementById("take").addEventListener('click', function () {

             //  alert("eeee");

             if ('<%=javaid%>' != '') {

                 window.location.href = "takepage.aspx";
             }
             else {


                 var modalLoginForm = new bootstrap.Modal(document.getElementById('modalLoginForm'));  //// فورم  تسجيل الدخول

                 modalLoginForm.show();
             }

         });








     </script>







    


    
    
     <script>
         window.onscroll = function () { myFunction() };

         var header = document.getElementById("navbar");
         var sticky = header.offsetTop;

         function myFunction() {
             if (window.pageYOffsett > sticky) {
                 header.classList.add("sticky");
             } else {
                 header.classList.remove("sticky");
             }
         }
     </script>








    
                    
     <script type="text/javascript">



         document.getElementById("pagric").addEventListener('click', function () {


           //  if ('<%=javaid%>' != '') {

             //     window.location.href = "ricepage.aspx";


             // }
           //  else  if ('<%=javaid%>' != '') {



                // var modalLoginForm = new bootstrap.Modal(document.getElementById('modalLoginForm'));  //// فورم  تسجيل الدخول

               //  modalLoginForm.show();
           //  }

         });






         document.getElementById("pagtakof").addEventListener('click', function () {

           //  alert("eeee");

            // if ('<%=javaid%>' != '') {

             //  window.location.href = "take of.aspx";
             //  }
             //  else {


             //  var modalLoginForm = new bootstrap.Modal(document.getElementById('modalLoginForm'));  //// فورم  تسجيل الدخول

             //  modalLoginForm.show();
             //  }

         });




     </script>        





    
    














</asp:Content>
