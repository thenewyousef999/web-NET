<%@ Page Title="" Language="C#" MasterPageFile="~/mydashoard.master" AutoEventWireup="true" CodeBehind="myDashoard.aspx.cs" Inherits="ALATLAS.myDashoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ClientsMainContent" runat="server">

    
         <style type="text/css">
        .style1
        {
            height: 21px;
        }
      
    </style>




       <script>
          
           // stop typing word after max number
           function isokmaxlength(e, val, maxlengt) {
               var charCode = (typeof e.which == "number") ? e.which : e.keyCode
               //  alert('hi');
               if (!(charCode == 44 || charCode == 46 || charCode == 0 || charCode == 8 || (val.value.length < maxlengt))) {
                   return false;
               }
           }
           </script>






    <asp:Literal ID="Literal26" runat="server" Visible="false"></asp:Literal>

    <asp:Literal ID="Literal14" runat="server"></asp:Literal>

    <asp:TextBox ID="TextBox7" runat="server" Visible="false"></asp:TextBox>


    <asp:Literal ID="Literal4" runat="server" Visible="true" Text=""></asp:Literal>



    <asp:Literal ID="Literal5" runat="server"></asp:Literal>




    <asp:TextBox ID="idbro" runat="server" TextMode="Number" Visible="false"></asp:TextBox>


    <asp:TextBox ID="TextBox1" runat="server" Visible="false"></asp:TextBox>
   <br />

   
    <br />


<br />

   
    


    
    
            <asp:Label ID="Label78" runat="server" Text="state" Visible="false"></asp:Label>
            <asp:TextBox ID="txtstatetutorial" runat="server" Visible="false"></asp:TextBox>


    
    
      
            <h3><asp:Literal ID="pagename" runat="server"></asp:Literal> </h3>
    
    
          
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>

            



    <div class="ItemNewsConatin" > 
        <asp:Panel ID="Panel1" runat="server" CssClass="pnl2"  >

      
     
    <asp:Label ID="Label24" runat="server" Text="tutorialid" Visible="false"></asp:Label>
    <asp:TextBox ID="tutorialidimagetxt" Text="" runat="server" Visible="false"></asp:TextBox>



      <asp:Label ID="Label23" runat="server" Text="browserid" Visible="false"></asp:Label>
       <asp:TextBox ID="browserid" runat="server" Visible="false"></asp:TextBox>

            <br />
            <br />

      <asp:Label ID="Label75" runat="server" Text="tutorialid" Visible="false"></asp:Label>
       <asp:TextBox ID="tutorialid" runat="server" Visible="false"></asp:TextBox>

            
    

               <table class="nav-justified" dir="rtl">

            <tr>

                <td>

                    
<asp:Button ID="Button4new" runat="server"  class="btn btn-success"    onclick="Buddnew_Click" Text="جديد  " Height="37px" Width="70px" />
 

                </td>
                

                   
              
                 <td><asp:Label ID="Label28" runat="server"  Text="اسم الاول" Font-Bold="True" Font-Size="10pt" Width="50px" ></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"   Text="" class="form-control"    placeholder=" First Name"  Width="200px"   ></asp:TextBox>
                    
                 </td>

               
                  
                    
                   
                    <td><asp:Label ID="Label45v" runat="server"  Text="اسم العائلة" Font-Bold="True" Font-Size="10pt" Width="50px" ></asp:Label>
                  
       <asp:TextBox ID="TextBox3" runat="server"  Text="" class="form-control "     placeholder=" Family Name"  Width="200px"   ></asp:TextBox>

           </td>

 
     </tr>


    



<tr>


    <td>
       
        <br />
        <br />

        <br />


        
    </td>


     <td> <asp:Button ID="Button1" runat="server"  class="btn btn-success"    onclick="BuddSearchbrowser_Click" Text="البحث عن زبون أو اضافة زبون جديد  " Height="37px" Width="200px" />
 

</td>  
    

    <td> 
        
        <asp:Button ID="Button22" runat="server" Text=" الذين لديهم عقارات لدى المكتب" class="btn btn-success" onclick="BuAddSearch_All_Click"  Height="37px" Width="220px" />

       

       </td>

          
    <td>

         <asp:Literal ID="Literal24searchall" runat="server"></asp:Literal>
        <asp:CheckBoxList ID="CheckBoxList1searchbrowserstate" runat="server"></asp:CheckBoxList>

        
       &nbsp;&nbsp;&nbsp;&nbsp;
        
     <asp:Literal ID="countsold" runat="server"></asp:Literal>

    </td>

    <asp:Literal ID="Literal27_click" runat="server" Visible="false"></asp:Literal>


          
        <td>
            
       
            <asp:Button ID="Button5" runat="server" Text=" عرض الزبائن ليس لهم عقارات " class="btn btn-success" onclick="BuAddSearch_null_Click"  Height="37px" Width="200px" />
            <br />
            <br />

       </td>







     </tr>


    
</table>


     <table class="nav-justified" dir="rtl">



   <tr>


     <td>
    <br />
    <br />


  </td>



    <td dir="rtl" style="text-align: right;" colspan="3">

                  <br />
                   <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            CellPadding="4" DataKeyNames="browserID" DataSourceID="SqlDataSource55"
            EmptyDataText="" ForeColor="#333333" BorderWidth="1px" HorizontalAlign="Center"
            GridLines="None" OnRowCommand="GridView1_RowCommand" Visible="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="True">
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField HeaderText="id" DataField="browserID" Visible="false"  />

             



                
                
                <asp:TemplateField HeaderText="............">
                    <ItemTemplate>
                        <asp:Label ID="Label415l" runat="server" Text=" ---------"></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>




                <asp:TemplateField HeaderText="الاسم الاول">
                    <ItemTemplate>
                        <asp:Label ID="Label41" runat="server" Text='<%# Eval("browserfirstName") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>




                
                <asp:TemplateField HeaderText="............">
                    <ItemTemplate>
                        <asp:Label ID="Label422" runat="server" Text="-----------"></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>







                  <asp:TemplateField HeaderText="الاسم الثاني">
                  <ItemTemplate>
                  <asp:Label ID="Label42" runat="server" Text='<%# Eval("browserlastName") %>'></asp:Label>
                 </ItemTemplate>

                 </asp:TemplateField>





                
                
                <asp:TemplateField HeaderText="............">
                    <ItemTemplate>
                        <asp:Label ID="Label41b" runat="server" Text="---------"></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>






                 <asp:TemplateField HeaderText="رقم الموبايل">
                <ItemTemplate>
                 <asp:Label ID="Label43" runat="server" Text='<%# Eval("NumberPhone") %>'></asp:Label>
                </ItemTemplate>

                </asp:TemplateField>





                
                
                <asp:TemplateField HeaderText="............">
                    <ItemTemplate>
                        <asp:Label ID="Label415lm" runat="server" Text=" ---------"></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>





                 <asp:TemplateField HeaderText="رقم التلفون" >
                  <ItemTemplate>
                  <asp:Label ID="Label44" runat="server" Text='<%# Eval("NumberHome") %>'></asp:Label>
                   </ItemTemplate>

                   </asp:TemplateField>



                
                





                

                <asp:ButtonField CommandName="MyCommand"  
                    HeaderText="  " />

                <asp:ButtonField ButtonType="Button" CommandName="addNEW" 
                    HeaderText=""  
                    Text="اضافة عقار جديد" ValidationGroup="SendMEssage" />



                    
                <asp:TemplateField HeaderText="............">
                    <ItemTemplate>
                        <asp:Label ID="Label415l" runat="server" Text=" ---------"></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>

                
                <asp:ButtonField CommandName="MyCommand"  
                    HeaderText="  " />

                <asp:ButtonField ButtonType="Button" CommandName="view" 
                    HeaderText=""  
                    Text=" عرض عقارات" ValidationGroup="SendMEssage" />



                   
                <asp:TemplateField HeaderText="............">
                    <ItemTemplate>
                        <asp:Label ID="Label415l" runat="server" Text=" ---------"></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>





                  <asp:ButtonField CommandName="MyCommand"  
                    HeaderText="  " />

                      <asp:ButtonField ButtonType="Button" CommandName="updatebrowser" 
                        HeaderText=" "  
                       Text=" تعديل بيانات الزبون " ValidationGroup="SendMEssage" />



                
                <asp:TemplateField HeaderText="............">
                    <ItemTemplate>
                        <asp:Label ID="Label415l" runat="server" Text=" ---------"></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>


                    

                   <asp:ButtonField CommandName="MyCommand"  
                      HeaderText="  " />

                         <asp:ButtonField ButtonType="Button" CommandName="deletebrowser" 
                            HeaderText=" "  
                          Text=" حذف  الزبون " ValidationGroup="SendMEssage" />






                 <asp:TemplateField HeaderText="ملاحظات للزبون" >
                 <ItemTemplate>
                 <asp:Label ID="Label45" runat="server" Text='<%# Eval("browsercomment") %>'></asp:Label>
                   </ItemTemplate>

                      </asp:TemplateField>

          




            </Columns>
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>

     
        </td>

             

      
    

        <asp:SqlDataSource ID="SqlDataSource55" runat="server" ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
            SelectCommand=""
            ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>" OnSelecting="SqlDataSource55_Selecting">

                </asp:SqlDataSource>

       
    
      


             <td style="width: 10%">
                 &nbsp;</td>
         </tr>

                  </table>
<br />

     

        

        
    
</asp:Panel>

        </div>
      


   <%  //  /////////////////////////////////////////////  %>

            
     


    
   


   
    <div class="container" dir="rtl" >
    
    <div class="container" dir="rtl" >
  
  <div class="panel-group">
    

    <div class=" panel-primary class" >

          <div class="panel-heading" style="text-align:center "> <asp:Label ID="Label2m" runat="server" Font-Bold="True" Font-Size="20"  ></asp:Label>
                      

           </div>



      <div class="container"> 
              <br />
      <div class="row"  dir="rtl">
    

          
<asp:UpdatePanel ID="UpdatePanel3" runat="server">
<ContentTemplate>

    <div class="ItemNewsConatin" > 
        <asp:Panel ID="Panel11" runat="server" CssClass="pnl2"  >


            <p class="MsoNormal" dir="auto">
            <asp:Label ID="Label1" runat="server" Text=" اضافة بيانات زبون جديد"></asp:Label></p>

            <br />


            <asp:Literal ID="Literal11" runat="server"></asp:Literal>

          <table class="nav-justified" dir="rtl">
               <tr>

                   
       


                 <td>  <asp:Label ID="Label3" runat="server"  Text="اسم الاول" Font-Bold="True" Font-Size="12pt"></asp:Label>
                    <asp:TextBox ID="txtFirstNam" runat="server" Text="" MaxLength="60"  Width="70%"  class="form-control " onkeypress="return isokmaxlength(event,this,100);"  placeholder=" First Nname"   ReadOnly="False "  AutoCompleteType="HomeFax"
                            ></asp:TextBox>
             

                     </td>

                  

                <td> <asp:Label ID="LaStudentName15" runat="server"  Text="اسم العائلة" Font-Bold="True" Font-Size="12pt"></asp:Label>
                  
       <asp:TextBox ID="txtMiddleName" runat="server" MaxLength="60" Text="" class="form-control "  onkeypress="return isokmaxlength(event,this,100);"   placeholder=" Family Name"  Width="70%" >

      </asp:TextBox>

           </td>

                   </tr>

              <tr>


         <td> <asp:Label ID="Label7" runat="server"   Text=" رقم الموبايل" Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:TextBox ID="textphone" runat="server" class="form-control " MaxLength="50" Text=""  placeholder=" رقم الموبايل" onkeypress="return isokmaxlength(event,this,20);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="50%"></asp:TextBox>
         
             <br />
                 
             </td>

              
        <td>   <asp:Label ID="Label8" runat="server"   Text="  رقم التلفون" Font-Bold="True" Font-Size="12pt"></asp:Label>
           <asp:TextBox ID="textphonhome" runat="server" class="form-control " MaxLength="50" Text=""  placeholder=" رقم التلفون" onkeypress="return isokmaxlength(event,this,20);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="50%"></asp:TextBox>
         <br />
                       
          
        </td>

        </tr>
              
     <tr>

      




         <td>


  <asp:Label ID="Label65" runat="server"   Text=" ملاحظات حول  الزبون" Font-Bold="True" Font-Size="12pt"></asp:Label>

<asp:TextBox ID="TextBox6browsercommint" runat="server"  MaxLength="300" onkeypress="return isokmaxlength(event,this,500);"    placeholder="  Nots"  class="form-control "  TextMode="MultiLine" Height="150px" ></asp:TextBox>

             

         </td>


                          




         </tr>

              <tr>

                



   
         <td>
         <asp:Button ID="Button1_person" runat="server"  class="btn btn-success"     onclick="BuAddData_Click" Text="اضافة زبون جديد" Height="37px" Width="98px" />

             <asp:Button ID="Button2_person_update" runat="server"  class="btn btn-success"  Visible="false"    onclick="updateDatae_Click" Text="تعديل بيانات الزبون " Height="37px" Width="98px" />






            <asp:Literal ID="Literal1" runat="server"></asp:Literal>

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


</div>




    <asp:TextBox ID="TextBox5" runat="server" Font-Size="X-Large" ForeColor="Red"  Enabled="false"      ></asp:TextBox>






    




    <div class="container" dir="rtl" >
    
    <div class="container" dir="rtl" >
  
  <div class="panel-group">
    

    <div class=" panel-primary class" >

          <div class="panel-heading" style="text-align:center "> <asp:Label ID="Label46v" runat="server" Font-Bold="True" Font-Size="20"  ></asp:Label>
                      

           </div>

      <div class="container"> 
              <br />
      <div class="row"  dir="rtl">


          
          
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
 

      <div class="ItemNewsConatin" > 
          <asp:Panel ID="Panel2" runat="server" CssClass="pnl2">



   

              <table class="nav-justified" dir="rtl">
                  <tr>
         

                     <td>
                          <h1>عنوان  العقار </h1>

                
       
                            
       <asp:TextBox ID="placetutorialee" runat="server"  Font-Size="X-Large" ForeColor="Red"  Enabled="false" ></asp:TextBox>



         <asp:TextBox ID="textplcae" runat="server" Visible="false"></asp:TextBox>
                         
               
                <asp:Label ID="Label10" runat="server"  Text="حدد بلد العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
                    

                      <asp:DropDownList ID="DropDownList1" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px" OnSelectedIndexChanged="selectcountry"  >
    
                      </asp:DropDownList>
                        
                    <asp:Literal ID="Literal18" runat="server" Text=" اساسي"  ></asp:Literal>

                 <asp:Label ID="Label11" runat="server"  Text="حدد مدينة العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
                 
                     <asp:DropDownList ID="DropDownList3" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px" OnSelectedIndexChanged="selectcity"  >
                          
                            </asp:DropDownList>
                         
                         
                    <asp:Literal ID="Literal17" runat="server" Text=" اساسي"></asp:Literal>

                         </td>

                      </tr>




                  <tr>
                      <td>
                          
                  <br />
                  <br />
                    
    &nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;    &nbsp;&nbsp;&nbsp;&nbsp;    &nbsp;&nbsp;&nbsp;&nbsp;    &nbsp;&nbsp;&nbsp;&nbsp;    &nbsp;&nbsp;&nbsp;&nbsp;    &nbsp;&nbsp;&nbsp;&nbsp;   
      
                         
                         
       

                <asp:Label ID="Label12" runat="server"  Text="حدد منطقة العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
                       
                         <asp:DropDownList ID="DropDownList4" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  OnSelectedIndexChanged="almanteka_SelectedIndexChanged" >
                              
                         </asp:DropDownList>
                         
                    <asp:Literal ID="Literal16" runat="server" Text=" اساسي"></asp:Literal>
                         

          <asp:Label ID="Label91" runat="server"  Text="حدد منطقة الفرعية للعقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
         
           <asp:DropDownList ID="DropDownList1mantekanode" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  >
                
           </asp:DropDownList>
           
      <asp:Literal ID="Literal23" runat="server" Text=" اساسي"></asp:Literal>

   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;     &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; 
    
         <asp:Literal ID="Literal24allmanteka" runat="server"    Text=" "></asp:Literal>

                          </td>

                      </tr>

                 


                  <tr>
                   <td>

                        <br />
                         <br />
                                           
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;
                         
    <asp:Label ID="Label92" runat="server"  Text="حدد حالة العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>
   
     <asp:DropDownList ID="DropDownList5statetutorial" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  >
          
     </asp:DropDownList>
     
<asp:Literal ID="Literal25" runat="server" Text=" اساسي"></asp:Literal>



    <asp:Label ID="Label96" runat="server" Text="اضافة تاريخ"></asp:Label>

     <asp:TextBox ID="TextBox8dateother"  placeholder="mm-dd-yyyy"   Text=""  TextMode="DateTime"  Width="150px"   runat="server"></asp:TextBox>
                       <asp:Literal ID="Literal27" runat="server"></asp:Literal>
                       



                   </td>
                      </tr>

                         

                  <tr>
                      <td>
                           <br />
                               <br />

                         <asp:TextBox ID="TextBox4" runat="server"  Font-Size="X-Large" ForeColor="Red"  Enabled="false"    ></asp:TextBox>



                <asp:Label ID="Label4" runat="server"  Text="حدد اسم الشارع" Font-Bold="True" Font-Size="12pt"></asp:Label>
                         <asp:TextBox ID="txtstreatname" runat="server"></asp:TextBox>


                         <asp:Label ID="Label5" runat="server" Text="حدد رقم البناء"></asp:Label>

                         <asp:TextBox ID="txtnumberbuild" Width="90px" runat="server"></asp:TextBox>



                           

                          </td>
                </tr>



     </table>

      
   </asp:Panel>
 </div>



 
                  <br />
                  <br />


      <%    /////////////////////////   //////// %>

     
      


            <div class="ItemNewsConatin" > 
      <asp:Panel ID="Panel3" runat="server" CssClass="pnl2">



              <table class="nav-justified" dir="rtl">
                  <tr>

               


                       
                <td>  <asp:Label ID="Label9" runat="server"  Text="حدد نوع العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>

             
             
             

                   <asp:DropDownList ID="DropDownList2" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  >
                   </asp:DropDownList>
                  
                     
                    <asp:Literal ID="Literal10" runat="server" Text=" اساسي"></asp:Literal>
               
                    <br />

                    <br />

                    
                     <asp:Label ID="Label6" runat="server"  Text="  حدد رقم الطابق " Font-Bold="True" Font-Size="12pt"></asp:Label>

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

                    </td>
                      
                    
               <td>


               </td>
                        
               <td>


               </td> 

                    
                   <td>  <asp:Label ID="Label17" runat="server"  Text="  حددحالة الاتجاه " Font-Bold="True" Font-Size="12pt"></asp:Label>

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



        <asp:Label ID="Label72" runat="server"  Text="  حددحالة المصعد " Font-Bold="True" Font-Size="12pt"></asp:Label>

            <asp:DropDownList ID="DropDownList5masad" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>

                                        

<br />
    <br />



           <asp:Label ID="Label73" runat="server"  Text="  حددحالة خدمات البناء " Font-Bold="True" Font-Size="12pt"></asp:Label>

            <asp:DropDownList ID="DropDownList5service" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>

                                        

<br />
    <br />
     






                      </td>
                  </tr>
                    </table>


         </asp:Panel>

   
 </div>

      

    
    
     </ContentTemplate>
 </asp:UpdatePanel>


      

          
<asp:UpdatePanel ID="UpdatePanel5" runat="server">
<ContentTemplate>
 



     <% ////     /////////////////// %>
          
      <div class="ItemNewsConatin" > 
          <asp:Panel ID="Panel4" runat="server" CssClass="pnl2">


  
                    
                     <asp:Label ID="Label21" runat="server"  Text="  حددالاطالة " Font-Bold="True" Font-Size="12pt"></asp:Label>

                      <asp:TextBox ID="TextBox2alatlalh" runat="server"   placeholder="الاطلالة"  class="form-control " onkeypress="return isokmaxlength(event,this,200);"  meta:resourcekey="txtStudentNameResource1" Width="30%"></asp:TextBox>
                       
                    
                    
                    <br />

                    <br />
                     <asp:Label ID="Label22" runat="server"  Text="  حدد المساحة " Font-Bold="True" Font-Size="12pt"></asp:Label>

                    
              <asp:TextBox ID="TextBox2area" runat="server"  placeholder="area" class="form-control " onkeypress="return isokmaxlength(event,this,200);" meta:resourcekey="txtStudentNameResource1" Width="30%" OnTextChanged="TextBox2area_TextChanged"></asp:TextBox>
                       
                    <br />
                 
                    <br />
              
    
          <table class="nav-justified" dir="rtl"  border="0" style="-moz-box-align:center" >
               <tr>
                <td>

                 <asp:Label ID="Label13" runat="server"   Text="ادخل ثمن العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>

                  <asp:TextBox ID="price" runat="server"  MaxLength="30"  placeholder="السعر"  class="form-control " Text=""  onkeypress="return isokmaxlength(event,this,300);"   Height="30px"   meta:resourcekey="txtStudentNameResource1" Width="50%"></asp:TextBox>
                    

                     <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage=" يجب ان يكون المدخل ارقام فقط" ControlToValidate="price" ForeColor="Red"  Operator="DataTypeCheck" Type="Double"></asp:CompareValidator>

                 

                    <asp:Literal ID="Literal15" runat="server" Text=" اساسي"></asp:Literal>
                
                </td>
              
              <td>  <asp:Label ID="Label69" runat="server"  Text="حدد عملة  سعرالعقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
                    

                      <asp:DropDownList ID="DropDownList5many" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  >
    
                      </asp:DropDownList>
              
                  
                    <asp:Literal ID="Literal8" runat="server" Text=" اساسي"></asp:Literal>


                  </td>
                   </tr>
              

     
           <br />

                    <br />
             
                    <br />
              
         
    
              <tr>
                  <td>
       
              
                   <asp:Label ID="LaStudentName10" runat="server"   Text="تفاصيل اضافية حول العقار الزبون" Font-Bold="True" Font-Size="12pt"></asp:Label>

<asp:TextBox ID="txtdeatials" runat="server"   MaxLength="500"  onkeypress="return isokmaxlength(event,this,500);"     placeholder="  Nots"  class="form-control input-lg"  Width="500px" Height="150px" TextMode="MultiLine"></asp:TextBox>
       
              </td>


                  <td>

           <div  style="color:red; width:350px; ">
              
    <asp:Label ID="Label98" runat="server" Text="تفعيل التذكرة" Font-Bold="true" Font-Size="20px" ></asp:Label>


               <asp:CheckBox ID="CheckBox1remmber" runat="server" AutoPostBack="true" />
         &nbsp;&nbsp;&nbsp;&nbsp; 
         &nbsp;&nbsp;&nbsp;&nbsp;
               
              



               </div>
                      </td>
                       </tr>
                         </table>



    <br />
    <br />
                

               
   

 <table class="nav-justified" dir="rtl">
            <tr>


        
               
<td>

    <asp:Button ID="Button2_addhaveperson" runat="server"  class="btn btn-success"  ClientIDMode="Static"    onclick="BuAddDatahave_Click" Text="اضافة عقار جديد للزبون " Height="37px" Width="350px" />

     </td>

                <td>
              <asp:Button ID="Button2_updatehaveperson" runat="server" Text="تعديل عقار الزبون" class="btn btn-success"  ClientIDMode="Static"    onclick="BuUPDATE_Datahave_Click" Height="37px" Width="150px"  />
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


</div>  

   
      




          
      <div class="ItemNewsConatin" > 
          <asp:Panel ID="Panel55" runat="server" CssClass="pnl2">


              <asp:Label ID="iamgviewtut" runat="server" Text=""></asp:Label>



              <asp:Label ID="imagbrowser" runat="server" Text=""></asp:Label>



               <asp:Label ID="Label99" runat="server"   Text="اختر  صور للعقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
   
       <asp:FileUpload ID="FileUpload1" runat="server" class="btn btn-success" />
 
     <br />
               <br />


                  <asp:Button ID="upload" runat="server"   class="btn btn-success" 
                 meta:resourcekey="BuAddStudentResource1" onclick="upload_Click"       Text="اضغط لتحميل الصورة المختارة"   />
                      
               <br />
                 
                    <asp:TextBox ID="tutoriallink" runat="server" Visible="false"  Text="" Width="30%" placeholder="رابط التحميل" ReadOnly="true"></asp:TextBox>



              <asp:Literal ID="Literal9" runat="server"></asp:Literal>
                              </asp:Panel>

</div>

            <%  // ///////////////////////////  %>




    

<asp:UpdatePanel ID="UpdatePanel6" runat="server">
<ContentTemplate>
 






    <div class="ItemNewsConatin" > 
        <asp:Panel ID="Panel6" runat="server" CssClass="pnl2"  >



            <asp:DataList ID="DataList53" runat="server" DataKeyField="" Visible="true" 
                DataSourceID="SqlDataSource43" Width="100%" OnSelectedIndexChanged="DataList53_SelectedIndexChanged">
                <ItemTemplate> 
                   
                   
                    

            <p class="MsoNormal" dir="auto">
            <asp:Label ID="Label1" runat="server" Text="صور لعقار الزبون"></asp:Label></p>

            <br />

            

          <table class="nav-justified" dir="rtl"  border="0" style="-moz-box-align:center" >
               <tr>

                  


                     <asp:Image ID="Image2" runat="server" Height="50px" 
                        ImageUrl='<%# Eval("Tutoriallinke") %>' Width="50px" />
             
            
                       
                   </tr>
              </table>
           

                    </ItemTemplate>
                    </asp:DataList>

     

                          <asp:SqlDataSource ID="SqlDataSource43" runat="server" ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
                  SelectCommand="SELECT tutorialslinkid, browserlinkid, Tutoriallinke FROM odb99.linkimage WHERE (tutorialslinkid = ?)"
                  ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>" OnSelecting="SqlDataSource43_Selecting">

                    <SelectParameters>
        <asp:ControlParameter ControlID="iamgviewtut" Name="tutorialid" PropertyName="Text" />
   
</SelectParameters>
     </asp:SqlDataSource>
              




         </asp:Panel>   
          


</div>
          
    
  
    
     </ContentTemplate>
 </asp:UpdatePanel>

  






   <%  //  ////////////////////////////////////////////////////////////// %>

    <asp:Label ID="Label51" runat="server" Visible="true" Text=""></asp:Label>

    <asp:Label ID="remmbertext" runat="server" Text="Label" Visible="false"></asp:Label>
    
   
    
<asp:UpdatePanel ID="UpdatePanel4" runat="server">
<ContentTemplate>
             
                 
    
     <style type="text/css">
    .style1
    {
        height: 21px;
    }
</style>
 
 
<div dir="rtl" class="ItemNewsBackgruound">  



                    
<table   style="width: 100%">
    <tr>
        <td class="style1">
            </td>
        <td class="style1" 
            >
            </td>
    </tr>
    <tr>
        <td colspan="5">

           <div  style="color:red; width:350px; font-size:20px;">
              <h4>  <%=remmber %>    </h4>
              </div>


                <asp:DataList ID="DataList1" runat="server" DataKeyField="tutorialID" Visible="false"    BorderColor="Red"
                    DataSourceID="SqlDataSource1"  OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
                    <ItemTemplate> 
                       

                                <div class="ItemNews img-rounded">
               
                
                      <div class="ItemNewsConatin" > 
<asp:Panel ID="Panel1" runat="server" CssClass="pnl2">
    
<div style="width: 100%">



<table class="style1" style="width: 100%">
        <tr>
            

                                <td>
                                 <asp:Label ID="Label201" runat="server" 
                                      
                                        Text="id" Font-Bold="True" Visible="false"></asp:Label>:
                                
                                    <asp:Label ID="Label8tutorialid" runat="server" Text='<%# Eval("tutorialID") %>' 
                                        Font-Bold="True" Visible="false"></asp:Label>
                               
                             




                              <asp:Label ID="Label95" runat="server" Text='<%# Eval("state") %>' 
                              Font-Bold="True" Visible="false" Width="90px"  Font-Size="15px"></asp:Label>
                
                           </td>
         
                         </tr>




    </table>

    

        </div>
    </asp:Panel>
                        
</div>
      </div>
               

<table class="style1" style="width: 100%;  border:double;  border-color:red; ">

    

     <tr>
         <td style="color:red;">
     
          <asp:Label ID="Label94u"     runat="server" Text='<%# Eval("namesatae") %>' 
              Font-Bold="True" Visible="true"    Font-Size="55px"></asp:Label>
 
          </td>

         </tr>
    <tr>
        <td>

            

       <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False"  OnRowCommand="GridView4remmberdelete_RowCommand"
         CellPadding="4" DataSourceID="SqlDataSource4"  
         ForeColor="#333333" GridLines="None"     >
         <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <Columns>





             
   <asp:TemplateField HeaderText="">
        <ItemTemplate>
       <asp:LinkButton ID="LinkButton22"  Width="120px" runat="server" PostBackUrl='<%# "myDashoard.aspx?id=" + Eval("tutorialID") +"&statetutorial=" +txtstatetutorial.Text   %>'
           Text="اضغط لازالةالتذكرة" CommandName="remmber" class="btn btn-success" >
       </asp:LinkButton>

   
       </ItemTemplate>

   </asp:TemplateField>





             
   </Columns>
   
</asp:GridView>




       <asp:SqlDataSource ID="SqlDataSource4" runat="server"
                              ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
         SelectCommand="select tutorialID  from tutorials where  remmber='remmber'  and  tutorialID=? " 
                          
                              ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                    
                           <SelectParameters>
                           <asp:ControlParameter ControlID="Label8tutorialid" Name="tutorialID" 
                              PropertyName="Text" />
                           </SelectParameters>
                     
                                    </asp:SqlDataSource>

        </td>

    </tr>



<tr>
    <td>
       
       
<table class="style1" style="width: 100%;  border:double;  border-color:red; ">

    

     <tr>
            
                      
        <asp:Repeater ID="repeaterimage" runat="server"  DataSourceID="SqlDataSource430"     OnItemCommand="repatedeimage_command" >                 
        <ItemTemplate >
           <td>
            
              <h4>صور العقار</h4>

             <asp:Label ID="Label78imagid" runat="server" Text='<%# Eval("id") %>' 
                                              Font-Bold="True"  Width="100px" Font-Size="15px" Visible="false"></asp:Label>
       
                                            <asp:Image ID="Image2" runat="server" Height="150px"  
                                              ImageUrl='<%# Eval("Tutoriallinke") %>' Width="150px"   />
                                       
             
          
       <asp:LinkButton ID="LinkButton3deleteimag"  Width="150px" runat="server" PostBackUrl='<%# "myDashoard.aspx?id=" + Eval("id")+"&statetutorial=" +txtstatetutorial.Text+ "&pagename="+pagename.Text  %>'
           Text="حذف  صورةالعقار" CommandName="deleteimage"  class="btn btn-success" >
       </asp:LinkButton>
              </td>
    
                         
       </ItemTemplate>
            
            </asp:Repeater>


                  <asp:SqlDataSource ID="SqlDataSource430" runat="server" ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
                                       SelectCommand="SELECT id,tutorialslinkid, Tutoriallinke FROM linkimage WHERE (tutorialslinkid =?) "
                                       ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                 <SelectParameters>
       <asp:ControlParameter ControlID="Label8tutorialid" PropertyName="Text" DefaultValue="" Name="TutorialID" />
    
</SelectParameters>

</asp:SqlDataSource> 
   

            
         </tr>
    </table>




        </td>
          </tr>

        <tr>
                <td  dir="rtl" colspan="2" >


           
                 <h4>الموقع</h4>
                 <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/> 
               <asp:Label ID="Label11u" runat="server"   Text='<%# Eval("country") %>'     Font-Bold="true" Font-Size="20px" ></asp:Label>
               <asp:Label ID="Label24u" runat="server"   Text= '<%# Eval("city") %>' Font-Bold="true" Font-Size="20px"></asp:Label>
               </p>

           
     <h4>العنوان التفصيلي</h4>
     <p><img src="https://aqaryamasr.com/frontend/imgs/property/locat.png?var=2"/> 
   <asp:Label ID="Label61" runat="server"   Text='<%# Eval("manteka") %>' Font-Bold="true"   Font-Size="20px"></asp:Label>
         
   <asp:Label ID="Label62" runat="server"   Text= '<%# Eval("placetutorial") %>' Font-Bold="true"  Font-Size="20px" ></asp:Label>

     </p>
  

            
        </td>   

     </tr>


    <tr>
        
        <td>

        

       <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
         CellPadding="4" DataSourceID="SqlDataSource6" 
         ForeColor="#333333" GridLines="None"    >
         <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <Columns>

      
      
                <asp:TemplateField HeaderText="-----" ControlStyle-BorderStyle="Dashed"  ItemStyle-HorizontalAlign="Center"  ControlStyle-Font-Bold="true">
                    <ItemTemplate>

                               
                         <asp:Label ID="Label100" runat="server" Text="تاريخ بدء العقار"  BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>

  
                        <asp:Label ID="Label63" runat="server"  Width="220px" Font-Bold="true"  Text='<%# Eval("DateStart") %>' ></asp:Label>
     
                        </ItemTemplate>
                    </asp:TemplateField>


                <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Dashed">
                    <ItemTemplate>

                            
                         <asp:Label ID="Label100" runat="server" Text="تاريخ احدث تعديل للعقار"  BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>

                               
                           <asp:Label ID="Label64" runat="server"  Width="220px" Font-Bold="true"  Text='<%# Eval("Dateupdat") %>' ></asp:Label>
                
                        </ItemTemplate>
                        </asp:TemplateField>

           
      
                <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center"   HeaderStyle-HorizontalAlign="Center"   ControlStyle-BorderStyle="Dashed">
                    <ItemTemplate>

                        
                         <asp:Label ID="Label100" runat="server" Text="تاريخ اضافة العقار يدويا"  BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>

                               
                
                       <asp:Label ID="Label51" runat="server" BackColor="YellowGreen"  Width="220px" Font-Bold="true"  Text='<%# Eval("dateother") %>'  ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
             

             
                                    </Columns>
   
</asp:GridView>




       <asp:SqlDataSource ID="SqlDataSource6" runat="server"
                              ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
         SelectCommand="select tutorialID,DateStart,Dateupdat,dateother  from tutorials where  isactive <>'false' and isactive<>'win'  and  tutorialID=? " 
                          
                              ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                    
                           <SelectParameters>
                           <asp:ControlParameter ControlID="Label8tutorialid" Name="tutorialID" 
                              PropertyName="Text" />
                           </SelectParameters>
                     
                                    </asp:SqlDataSource>


</td>

    </tr>

<br />

     <tr>
         <td >

     <br />
<br />
<br />

       <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
         CellPadding="4" DataSourceID="SqlDataSource2"  BorderStyle="Dashed"  BorderColor="Black" 
         ForeColor="#333333" GridLines="None" Width="100%"   HorizontalAlign="Center"   >
         <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <Columns>
                   
      

            
                 <asp:TemplateField HeaderText="-----" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
                     <ItemTemplate>

                         <asp:Label ID="Label100" runat="server" Text="نوع العقار" BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"    ></asp:Label>
                   <asp:Label ID="Label28b" runat="server" Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow"   Text='<%# Eval("tutorialType") %>' Font-Size="17px"></asp:Label>
                                 </ItemTemplate>
                                </asp:TemplateField>
                          

             

                              
              <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
                  <ItemTemplate>
                          
                              
                         <asp:Label ID="Label100" runat="server" Text="غرف العقار"  BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>

                   <asp:Label ID="Label43" runat="server"  Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow"   Text='<%# Eval("room") %>' ></asp:Label>
                                </ItemTemplate>
                                </asp:TemplateField>
                                


                 <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
                     <ItemTemplate>

                         
                         <asp:Label ID="Label100" runat="server" Text="مصعد العقار"   BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"   ></asp:Label>

                  <asp:Label ID="Label85" runat="server" Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow"  Text='<%# Eval("masad") %>'></asp:Label>
                              </ItemTemplate>
                            </asp:TemplateField>
                                  




             <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
                <ItemTemplate>

                    
                         <asp:Label ID="Label100" runat="server" Text="خدمات بناء العقار"   BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>

                        <asp:Label ID="Label86" runat="server" Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow"  Text='<%# Eval("Serviecother") %>' ></asp:Label>
                    </ItemTemplate>
                       </asp:TemplateField>



                                
                           
               <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
                   <ItemTemplate>

                       
                         <asp:Label ID="Label100" runat="server" Text="كسوة العقار"  BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>

                         <asp:Label ID="Label55" runat="server" Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow"  Text='<%# Eval("alkasa") %>' ></asp:Label>             
                      </ItemTemplate>
                        </asp:TemplateField>


             
                            
            <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
              <ItemTemplate>              
                  
                  
                       
                       <asp:Label ID="Label100" runat="server" Text="طابق العقار" BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>

                       <asp:Label ID="Label57" runat="server" Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow"  Text='<%# Eval("tabke") %>' ></asp:Label>
               </ItemTemplate>
                    </asp:TemplateField>
                                     
             

                                    </Columns>
    <RowStyle BackColor="" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <HeaderStyle BackColor="" Font-Bold="True" ForeColor="White"  />
    <AlternatingRowStyle BackColor="White" />
</asp:GridView>




       <asp:SqlDataSource ID="SqlDataSource2" runat="server"
                              ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
         SelectCommand="select tutorialID,tutorialType,tabke,room ,alkasa ,masad,Serviecother  from tutorials where  isactive <>'false' and isactive<>'win'  and  tutorialID=? " 
                          
                              ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                    
                           <SelectParameters>
                           <asp:ControlParameter ControlID="Label8tutorialid" Name="tutorialID" 
                              PropertyName="Text" />
                           </SelectParameters>
                      
        
                                    </asp:SqlDataSource>


           
                                   
             </td>
         </tr>




      <tr>
     <td >

  <br />
<br />
<br />

   <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
     CellPadding="4" DataSourceID="SqlDataSource3"  BorderStyle="Dashed"  BorderColor="Black"
     ForeColor="#333333" GridLines="None" Width="100%"  HorizontalAlign="Center"   >
     <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
     <Columns>
              
         
         
      

                                 
            <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
              <ItemTemplate>              
        
        
     <asp:Label ID="Label100" runat="server" Text="اشارات العقار" BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>


       <asp:Label ID="Label56" runat="server"  Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow" Text='<%# Eval("refernc") %>' ></asp:Label>        
                </ItemTemplate>
                    </asp:TemplateField>


         

         
            <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
              <ItemTemplate>              

                      
          <asp:Label ID="Label100" runat="server" Text="اطلالة العقار" BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>


              <asp:Label ID="Label45b" runat="server"  Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow" Text='<%# Eval("alatlalh") %>'></asp:Label>
                   </ItemTemplate>
                  </asp:TemplateField>
    

       
                     
         
            <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
              <ItemTemplate>              
        
        <asp:Label ID="Label100" runat="server" Text="اتجاه العقار" BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>


         <asp:Label ID="Label58" runat="server" Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow"  Text='<%# Eval("dirction") %>' ></asp:Label>
       </ItemTemplate>
         </asp:TemplateField>
                 

         
            <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
              <ItemTemplate>              
        
                 <asp:Label ID="Label100" runat="server" Text="كهرباء العقار" BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>


                   <asp:Label ID="Label74" runat="server" Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow" Text='<%# Eval("electron") %>'></asp:Label>
  </ItemTemplate>
      </asp:TemplateField>


       
         
         <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
          <ItemTemplate>              
           
          <asp:Label ID="Label100" runat="server" Text="ملكية العقار" BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>

          <asp:Label ID="Label50" runat="server" Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow" Text='<%# Eval("havinge") %>' ></asp:Label> 
       </ItemTemplate>
      </asp:TemplateField>
    

        
         
       <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
              <ItemTemplate>              


            <asp:Label ID="Label100" runat="server" Text="مساحة العقار" BorderColor="Pink"   Width="200px" Font-Bold="true"  Font-Size="17px"  ></asp:Label>
          
            <asp:Label ID="Label46" runat="server" Width="200px" Font-Bold="true" ForeColor="Black"  BackColor="Yellow"  Text='<%# Eval("area") %>' ></asp:Label>
        </ItemTemplate>
      </asp:TemplateField>


    
             
  </Columns>
    <RowStyle BackColor="" ForeColor="" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <PagerStyle BackColor="" ForeColor=""  />
    <HeaderStyle BackColor="" Font-Bold="True" ForeColor="White" />
    <AlternatingRowStyle BackColor="White" />
</asp:GridView>

          


       <asp:SqlDataSource ID="SqlDataSource3" runat="server"
                   ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
    SelectCommand="select tutorialID,area,alatlalh,havinge,refernc,dirction,electron  from tutorials where  isactive <>'false' and isactive<>'win'  and tutorialID= ? " 
                      
                              ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                  
                            <SelectParameters>
                             <asp:ControlParameter ControlID="Label8tutorialid" Name="tutorialID" 
                                PropertyName="Text" />
                             </SelectParameters>
             
                              </asp:SqlDataSource>



   </td>
</tr>

   <tr>
  <td >

      <br />
      <br />
      <br />



     <tr>
     <td>


 <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
  CellPadding="4" DataSourceID="SqlDataSource5"   BorderStyle="Dashed"  BorderColor="Black"
  ForeColor="#333333" GridLines="None" Width="100%" HorizontalAlign="Center"   >
  <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
  <Columns>
            
      


      
     <asp:TemplateField HeaderText="-----" ItemStyle-HorizontalAlign="Center" ControlStyle-BorderStyle="Double">
      <ItemTemplate>

              
            <asp:Label ID="Label100" runat="server" Text="ملاحظات عن العقار" BorderColor="Pink"  Width="100%"   Font-Bold="true"  Font-Size="17px"  ></asp:Label>
          

             <asp:Label ID="Label65b" runat="server" Width="100%"  Height="50px" Font-Size="15px"   Font-Bold="true" ForeColor="Black"  BackColor="pink" Text='<%# Eval("tutorialDeatils") %>' ></asp:Label>
        </ItemTemplate>
      </asp:TemplateField>






   </Columns>
     
</asp:GridView>

          
       

       <asp:SqlDataSource ID="SqlDataSource5" runat="server"
              ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
               SelectCommand="select tutorialID, tutorialDeatils from tutorials where  isactive <>'false' and isactive<>'win'  and tutorialID= ? " 

                              ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                    
                                <SelectParameters>
                               <asp:ControlParameter ControlID="Label8tutorialid" Name="tutorialID" 
                                PropertyName="Text" />
                              </SelectParameters>
             
                              </asp:SqlDataSource>


 </td>

        </tr>
      <br />
      <br />



     <tr>
         

         <td style="color:orangered;">

              &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
             <asp:Label ID="nameprice" runat="server" Text='<%# Eval("namepricestate") %>'   Font-Bold="true"  Font-Size="22px" ></asp:Label>

             <asp:Label ID="Label60" runat="server" Text='<%# Eval("price") %>'   Font-Bold="true"  Font-Size="22px" ></asp:Label>
     
                  <asp:Label ID="Label70" runat="server" Font-Bold="true" Font-Size="22px" Text='<%# Eval("many") %>' ></asp:Label>


         </td>
     </tr>




     <tr>
         <td>

             


<br />
 <br />

           
     <asp:GridView ID="GridView2updatedata1" runat="server" AutoGenerateColumns="False"
         CellPadding="4" DataKeyNames="TutorialID" OnRowCommand="GridView2updatedata1_RowCommand"
         DataSourceID="SqlDataSource1updatedat" ForeColor="#333333" GridLines="None" AlternatingRowStyle-BorderStyle="Dashed" AlternatingRowStyle-HorizontalAlign="Center" AlternatingRowStyle-VerticalAlign="Middle" BackColor="#FF0066" BorderStyle="Dashed" HorizontalAlign="Center" OnSelectedIndexChanged="GridView2updatedata1_SelectedIndexChanged">
                           
<AlternatingRowStyle BackColor="White" />
         <Columns>
                               
                            
             
   <asp:TemplateField HeaderText=".......">
       <ItemTemplate>
           <asp:Label ID="Labeltutorialupdatedeleteid" runat="server" Visible="false" Text='<%# Eval("tutorialID") %>' ></asp:Label>

            
           
       </ItemTemplate>

   </asp:TemplateField>


          
             
   <asp:TemplateField HeaderText="........">
       <ItemTemplate>

       <asp:LinkButton ID="LinkButton1"  Width="250px" runat="server" PostBackUrl='<%# "myDashoard.aspx?id=" + Eval("tutorialID") + "&statetutorial=" +txtstatetutorial.Text+ "&pagename="+pagename.Text %>'
           Text="اضغط لتحميل الصورة المختارة" CommandName="inserteimage"  class="btn btn-success">
       </asp:LinkButton>
           
      

       </ItemTemplate>

   </asp:TemplateField>

             
           
   <asp:TemplateField HeaderText="........">
        <ItemTemplate>
       <asp:LinkButton ID="LinkButton2"  Width="250px" runat="server" PostBackUrl='<%# "myDashoard.aspx?id=" + Eval("tutorialID") +"&statetutorial=" +txtstatetutorial.Text +"&pagename="+pagename.Text   %>'
           Text="تعديل  العقار" CommandName="updatetutorial" class="btn btn-success" >
       </asp:LinkButton>

   
       </ItemTemplate>

   </asp:TemplateField>



             
           
   <asp:TemplateField HeaderText="..........">
        <ItemTemplate>

           
       <asp:LinkButton ID="LinkButton3"  Width="250px" runat="server" PostBackUrl='<%# "myDashoard.aspx?id=" + Eval("tutorialID")+"&statetutorial=" +txtstatetutorial.Text+"&pagename="+pagename.Text  %>'
           Text="حذف العقار" CommandName="deletetutorial"  class="btn btn-success" >
       </asp:LinkButton>


       </ItemTemplate>

   </asp:TemplateField>



             
           
   <asp:TemplateField HeaderText="..........">
        <ItemTemplate>

           
       <asp:LinkButton ID="LinkButton3cc"  Width="250px" runat="server" PostBackUrl='<%# "myDashoard.aspx?id=" + Eval("tutorialID")+"&statetutorial=" +txtstatetutorial.Text+"&pagename="+pagename.Text  %>'
           Text="اضافة نسخة عن العقار " CommandName="copyother"  class="btn btn-success" >
       </asp:LinkButton>


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


  


        <asp:SqlDataSource ID="SqlDataSource1updatedat" runat="server"
            ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
            SelectCommand="select tutorialID from tutorials where  tutorialID=? "
                      
            ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">


                   <SelectParameters>
<asp:ControlParameter ControlID="Label8tutorialid" Name="tutorialID" 
          PropertyName="Text" />
         </SelectParameters>
                      
        </asp:SqlDataSource>

        



   



         </td>
     </tr>





    </table>




                        
      </ItemTemplate>
      </asp:DataList>


                        
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                                            ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
                                            SelectCommand=""
                                            ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                                  <SelectParameters>
                                           <asp:ControlParameter ControlID="browserid" Name="id" 
                                                     PropertyName="Text" />
                                                    </SelectParameters>
                      
                                            </asp:SqlDataSource>
           





      
            </td>
        </tr>
    </table>
    </div>




  
     </ContentTemplate>
 </asp:UpdatePanel>

     
           
    


     
    <%//  ////////////////////////////////////////////////////////////////////////////////////////filter %>



       
    

<asp:UpdatePanel ID="UpdatePanel22" runat="server">
<ContentTemplate>


    
    <asp:Panel ID="Panel5datewin" runat="server">
          <table class="nav-justified">

        <tr>

            
        
        
         <td>
        <asp:Label ID="Label79old" runat="server" Text="تاريخ  الاقدم "></asp:Label>
   
        <asp:DropDownList ID="DropDownList5winoldedate" runat="server"  AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="170px" >

        </asp:DropDownList>
           
             </td>

                </tr>
        <tr>
            <td>
            
        <h3>between</h3>
           </td>
            </tr>
        <tr>


            <td>
   <asp:Label ID="Label81new" runat="server" Text="تاريخ الاحدث"></asp:Label>
   
   <asp:DropDownList ID="DropDownList6winneewdate" runat="server" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"      CssClass="ArabicFont"   Width="170px">

</asp:DropDownList>

                </td>
           
        <td>
  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;           
   <asp:Button ID="Button4datwin1" runat="server"  CssClass="btn btn-success"  Text="بحث" Height="30px"  meta:resourcekey="BuAddStudentResource1" onclick="budatewin_Click" />
          



            </td>



                        <td>
                             &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            <asp:Label ID="Label79countwin" runat="server" Text="مجموع الربح" ></asp:Label>
            <asp:TextBox ID="Textcountwin" runat="server" Width="250px"></asp:TextBox>
          </td>


            <td>
                

   
   <asp:DropDownList ID="DropDownList5manyreferens"  Visible="false"  runat="server" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"      CssClass="ArabicFont"   Width="120px">

       
</asp:DropDownList>

            </td>

               <td>
<br />

<br />
   </td> 


            </tr>

              

              <tr>

                <td>
             <br />

             <br />
                </td> 


                  <td>


                  </td>

            <td>

                
 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;                
   <asp:Button ID="Button4winsold" runat="server"  CssClass="btn btn-success"  Text="ربح المكتب من شراء العقارات" Height="30px"  meta:resourcekey="BuAddStudentResource1" onclick="budatewinsold_Click" />
          

            </td>




                     <td>
 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
             
<asp:Button ID="Button4wintake" runat="server"  CssClass="btn btn-success"  Text="ربح المكتب من استاجار العقارات" Height="30px"  meta:resourcekey="BuAddStudentResource1" onclick="budatewintake_Click" />
       

         </td>

            

             <td>
 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;


   <asp:Button ID="Button4allwin" runat="server"  CssClass="btn btn-success"  Text=" ربح المكتب شراء+استاجار" Height="30px"  meta:resourcekey="BuAddStudentResource1" onclick="budateallwin_Click" />
          


             </td>

          

        </tr>
              

    </table>

        <br />
        <br />
        <br />


       <h4> <asp:Literal ID="Literal10win" runat="server"  ></asp:Literal></h4>

        </asp:Panel>


        
    </ContentTemplate>
    </asp:UpdatePanel>


        
    

<asp:UpdatePanel ID="UpdatePanel7" runat="server">
<ContentTemplate>





  

    <asp:Panel ID="Panelfilter" runat="server">

<table class="TabelStyles" style="width: 100%" dir="rtl">
      
    


            <tr>
         

            <td> <h4>حدد خيارات البحث</h4></td>


           <asp:Literal ID="Literal6" runat="server" Text="" Visible="false"></asp:Literal>
            



    
     <td style="text-align: right;" colspan="2">
         </td>



         <td style="width: 10%">
         <asp:Label ID="Label27" runat="server" Text="البحث حسب البلد"></asp:Label>
             <asp:CheckBoxList ID="CheckBoxlista1country" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CheckBoxlista1country_SelectedIndexChanged"></asp:CheckBoxList>
                      
                   </td>
             
                  

    
<td style="text-align: right;" colspan="3">
      </td>
 <td style="width: 10%">
     <asp:Label ID="Label26" runat="server" Text="البحث حسب المدينة" ></asp:Label>
     <asp:CheckBoxList ID="CheckBoxlist2city" runat="server" AutoPostBack="true"  ></asp:CheckBoxList>
   

                      </td>
           

    
     <td style="text-align: right;" colspan="3">
         </td>

     <td style="width: 10%">

         <asp:Label ID="Label47" runat="server" Text="البحث حسب المنطقة"></asp:Label>

         <asp:CheckBoxList ID="CheckBoxList1manteka" runat="server" AutoPostBack="true"></asp:CheckBoxList>
          
                   
              </td>
    


   
         <td style="text-align: right;" colspan="3">

         </td>

 <td style="width: 15%">
     <asp:Label ID="Label48" runat="server" Text="البحث حسب نوع العقار"></asp:Label>
     <asp:CheckBoxList ID="CheckBoxList1type" runat="server" AutoPostBack="true"></asp:CheckBoxList>
           

                    </td>

                
 
    
    
     <td style="text-align: right;" colspan="3">
         </td>


     <td style="width: 40%">

         
         <br />
           <asp:Button ID="Button1filtterpriclow" runat="server" Text="تفعيل  بحث اقل من " OnClick="Button2filterpricelow_Click" />

         <br />
         <br />

    <%////////////////////////////////////////////////////////اقل من %>
                
            
        <label id="q4" class="form-control fakeinput" >بحث حسب السعر</label>


                 <label for="price_from"> اقل من</label>

              <asp:DropDownList ID="DropDownList5searchpriceaddmanyview" runat="server"  AutoPostBack="true"  ForeColor="Blue"   Font-Bold="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="300px"  OnSelectedIndexChanged="DDLAccounts_SelectedIndexChanged"    >
              

          </asp:DropDownList>
        
          <br />
     
        
       <div class="d-flex align-items-center justify-content-between mt-3 prices-box">
        

        &nbsp;&nbsp;&nbsp;&nbsp;

        <%//////  <label for="price_from"  >اقل من</label>  %>

         <asp:DropDownList ID="DropDownList5priclowfrom" runat="server"   Visible="false"  AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="100px" >

          </asp:DropDownList>



       &nbsp;&nbsp;&nbsp;&nbsp;
      
      <% /////// <label for="price_many">حدد العملة</label>  %>
      <asp:DropDownList ID="DropDownList5powerlowfrom" runat="server"  Visible="false"  AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"  CssClass="ArabicFont"      Width="100px" >

     </asp:DropDownList> 
       </div>
    

         <br />

      <asp:Button ID="Button2filterprice" runat="server" Text="تفعيل بحث bettewn" OnClick="Button2filterprice_Click" />

         <br />


 <%////////////////////////////////////////////// end low %>
<%///////////////////////////////////////////////////////////////////between   ///////////////////////////////                  %>

      <div class="d-flex align-items-center justify-content-between mt-3 prices-box">
         
         <div class="form-group">               

         <label for="price_from"> السعر من </label>      
       <asp:DropDownList ID="DropDownList5pricbetoweenvie11" runat="server"   AutoPostBack="true"   ForeColor="Blue" Font-Bold="true"     CssClass="ArabicFont"  OnSelectedIndexChanged="pricbetoeenview11_SelectedIndexChanged"  Width="160px" >
          </asp:DropDownList>

    



         &nbsp;&nbsp; <h4>between</h4>&nbsp;&nbsp;
      
       </div>
       </div>
 
       <label for="price_from">  السعرالي</label>
     <asp:DropDownList ID="DropDownList5pricbettoweenview22" runat="server"   AutoPostBack="true"   ForeColor="Blue"   Font-Bold="true"    CssClass="ArabicFont"     OnSelectedIndexChanged="pricbetoeenview22_SelectedIndexChanged"   Width="170px" >
        </asp:DropDownList>


       
      <div class="d-flex align-items-center justify-content-between mt-3 prices-box">
         

       <div class="form-group">               

       <%//////////  <label for="price_from">السعر من</label>  %> 
         <%/////   <asp:Label ID="Label72" runat="server" Text="القيمة الاصغر"></asp:Label>   %>
    
         
      
         <asp:DropDownList ID="DropDownList9price11" runat="server"  AutoPostBack="true" Visible="false"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="120px" >

            </asp:DropDownList>

  
                
           <asp:DropDownList ID="DropDownList5manysearch" runat="server" Visible="false"  AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"   CssClass="ArabicFont"   Width="100px" >

           </asp:DropDownList>
         


                  <%/////// <h3>between</h3>  %>

       

  <%////////// <asp:Label ID="Label73" runat="server" Text="القيمة الاكبر"></asp:Label>  %>
           <% %>
   
   <asp:DropDownList ID="DropDownList10price22" runat="server" AutoPostBack="true" Visible="false" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"      CssClass="ArabicFont"   Width="120px">

</asp:DropDownList>

       
      <%///////  <label for="price_many">حدد العملة</label>  %>
     <asp:DropDownList ID="DropDownList5manysearchpow" runat="server"    Visible="false" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"  CssClass="ArabicFont"      Width="80px" >

       </asp:DropDownList> 
           </div>



           </div>





<%///////////////////////////////////////////////////////////////////////////end between///////////////////////////////////// %>
          

   
             </td>



                



     <td style="text-align: right;" colspan="3">
         &nbsp;</td>
     <td style="width: 10%">                    
                
   

            
   <asp:Button ID="BuSearch" runat="server"  CssClass="ButtonSearch"  Text="بحث" Height="30px"  meta:resourcekey="BuAddStudentResource1" onclick="BuSearch_Click" />
          


         </td>
            
        </tr>


</table>

   
    </asp:Panel>
    



    </ContentTemplate>
    </asp:UpdatePanel>







    

    
    
<asp:UpdatePanel ID="UpdatePanel2filter" runat="server">
<ContentTemplate>






 
    <div dir="rtl" class="ItemNewsBackgruound">  
  


    
    
                        
    <table   style="width: 100%">
        <tr>
            <td class="style1">
                </td>
            <td class="style1" 
                >
                </td>
        </tr>
        <tr>





            <td colspan="2">
               
     


                <asp:DataList ID="DataList2" runat="server" DataKeyField="tutorialID" 
                    DataSourceID="SqlDataSource22" Width="100%">
                    <ItemTemplate> 
                       
                            <div class="ItemNews img-rounded">
                                   
                                    
                                          <div class="ItemNewsConatin" > 
                  
      <asp:Panel ID="Panel77" runat="server" CssClass="pnl2" Visible="true">
      
  <div style="width: 100%">
                    <table class="style1" style="width: 100%">
                            <tr>

                                

                                    <td>
     <asp:Label ID="Label50" runat="server" 
meta:resourcekey="LaStudentNameResource1" 
       Text=" ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////" Font-Bold="True"></asp:Label>

        </td>

                                
             <div  id="Featured-owl" class="owl-carousel owl-theme">   

                                <td width="10px">
                                   <asp:Label ID="Label2" runat="server" 
                                        meta:resourcekey="LaStudentNameResource1" 
                                        Text="id" Font-Bold="True" Visible="false"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label8filterid" runat="server" Visible="false" Text='<%# Eval("tutorialID") %>' 
                                        Font-Bold="True"></asp:Label>
                                </td>
                               
                            </tr>
                            </table>
                  

      </div>
</asp:Panel>

                        <table class="style1" style="width: 100%;">
                           
                            <tr>


                                <td>


                                   <asp:Label ID="Label30" runat="server" 
                                      meta:resourcekey="LaStudentNameResource1" 
                                   Text ="عنوان العقار " Font-Bold="True" ></asp:Label>:
       
                                     
                                    <asp:Label ID="Label6" runat="server" Font-Size="14pt" 
                                        Text='<%# Eval("country") %>' Font-Bold="True"  ></asp:Label>
                                    &nbsp;
                                    <asp:Label ID="Label23" runat="server" Font-Size="14pt" 
                                           text='<%# Eval("city") %>' Font-Bold="True"></asp:Label>
                                   &nbsp;
                                     <asp:Label ID="Label29" runat="server" Font-Size="14pt" 
                                           text='<%# Eval("manteka") %>' Font-Bold="True"></asp:Label>
                                      
                                            &nbsp;&nbsp;&nbsp;
                                      <asp:Label ID="Label5" runat="server" Font-Size="14pt" 
                                       Text='<%# Eval("placetutorial") %>' Font-Bold="True"></asp:Label>

                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        
                                                  

                   
         <asp:Label ID="Label67" runat="server" 
                   meta:resourcekey="LaStudentNameResource1" 
      Text="تاريخ طلب العقار" Font-Bold="True" Width="100px" Font-Size="14px" ></asp:Label>
         
       : 
          

  <asp:Label ID="Label68" runat="server" Font-Size="14pt" 
    Text='<%# Eval("DateStart") %>' Font-Bold="True" Width="250px" ></asp:Label>
         
<br />
         <br />
      
</td>


<td>

    
         <asp:Label ID="Label93" runat="server" 
                   meta:resourcekey="LaStudentNameResource1" 
      Text="تاريخ اضافة يدوي" Font-Bold="True" Width="100px" Font-Size="14px" ></asp:Label>
         
       : 
          

  <asp:Label ID="Label94" runat="server" Font-Size="14pt" 
    Text='<%# Eval("dateother") %>' Font-Bold="True" Width="250px" ></asp:Label>
         

</td>


                             
    </tr>



                                        <tr>


                                   <td dir="rtl">
                                    <asp:Label ID="Label60" runat="server" 
                                        meta:resourcekey="LaStudentNameResource1" 
                                       
                                        Text="اسم مالك العقار" Font-Bold="True"></asp:Label>
                                           : 
                                      <asp:Label ID="Label55" runat="server" Font-Size="14pt" 
                                       Text='<%# Eval("browserfirstName") %>' Font-Bold="True"></asp:Label>
                                        
                                   

                                     <asp:Label ID="Label56" runat="server" Font-Size="14pt" 
                                      text='<%# Eval("browserlastName") %>' Font-Bold="True"></asp:Label>
                                         </td>



                                          <td dir="rtl">
                                           
                                          <asp:Label ID="Label62" runat="server" Font-Size="14pt" 
                                              text="  موبايل مالك العقار" Font-Bold="True"></asp:Label>
                                               :
                                              <asp:Label ID="Label57" runat="server" Font-Size="14pt" 
                                                 text='<%# Eval("NumberPhone") %>' Font-Bold="True" ></asp:Label>
                                          
                                              
                                           <asp:Label ID="Label63" runat="server" Font-Size="14pt" 
                                              text=" تليفون مالك العقار" Font-Bold="True"></asp:Label>
                                              :
                                          <asp:Label ID="Label58" runat="server" Font-Size="14pt" 
                                                Text='<%# Eval("NumberHome") %>' Font-Bold="True" ></asp:Label>
                                              
                                 <br />
                                <br />
                                           </td>


                                          
                                            </tr>
                                      
                                   <tr>
                                             <td dir="rtl">
                                           <asp:Label ID="Label64" runat="server" 
                                                 meta:resourcekey="LaStudentNameResource1" 
                                              Text=" ملاحظات مالك العقار" Font-Bold="True"></asp:Label>
                                
                                                 :
                                            <asp:Label ID="Label59" runat="server" Font-Size="14pt" 
                                          Text='<%# Eval("browsercomment") %>' Font-Bold="True" Width="400px"></asp:Label>
 
 
                                 <br />
                                <br />

                                             </td>


                                                </tr>
   






                                  <tr>

                           
                                     
                                     <td> 
                                         
                                        
                                         
                          
           <asp:Label ID="Label97" runat="server" Font-Size="14pt" 
        Text='<%# Eval("namesatae") %>' Font-Bold="True" Width="400px"></asp:Label>
                
                                                          
                                 
                           
        <asp:Repeater ID="GridView52" runat="server"  DataSourceID="SqlDataSource43">
                   
                            
                                 <ItemTemplate> 
                                         
                                         
                                        
                     

                                            <asp:Image ID="Image2" runat="server" Height="150px"  
                                  ImageUrl='<%# Eval("Tutoriallinke") %>' Width="150px"  />
                                     
                                     

                                        
          
                                             </ItemTemplate>
                                              </asp:Repeater>
                 </div>
                                         


                  <asp:SqlDataSource ID="SqlDataSource43" runat="server" ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
                                       SelectCommand="SELECT tutorialslinkid, Tutoriallinke FROM linkimage WHERE (tutorialslinkid =?) "
                                       ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                 <SelectParameters>
       <asp:ControlParameter ControlID="Label8filterid" PropertyName="Text" DefaultValue="" Name="TutorialID" />
    
</SelectParameters>



</asp:SqlDataSource> 




                                 <br />
                                <br />
                                         

                                     </td>

                                      
                         
                               </tr>

                
                            <tr>
                           
                             <td dir="rtl">
                            <asp:Label ID="Label510" runat="server" 
                                  meta:resourcekey="LaStudentNameResource1" 
                                     Text="نوع العقار" Font-Bold="True" Width="60px" Font-Size="15px"></asp:Label>
                                       :
                                        <asp:Label ID="Label151" runat="server" Text='<%# Eval("tutorialType") %>' 
                                             Font-Bold="True" Width="100px"  Font-Size="15px" ></asp:Label>
                                                </td>


                                               <td dir="rtl">
                                                 
                                           <asp:Label ID="Label12" runat="server" 
                                         meta:resourcekey="LaStudentNameResource1" 
                                       Text="سعر العقار" Font-Bold="True" Width="70px" Font-Size="15px"></asp:Label> 
                                       
                                       :
                                      <asp:Label ID="Label13" runat="server" Text='<%# Eval("price") %>' 
                                          Font-Bold="True"  Font-Size="15px"></asp:Label>
                                    
                                      <asp:Label ID="Label70" runat="server" Text='<%# Eval("many") %>' 
                                          Font-Bold="True" Width="100px" Font-Size="15px"></asp:Label>

                                       
                                                    

                                 <br />
                                <br />

                                        </td>

                                             
                                </tr>





                            <tr>



                                <td dir="rtl">
                                    
                                <asp:Label ID="Label545" runat="server" 
                                    meta:resourcekey="LaStudentNameResource1" 
                                  text="كسوة العقار" Font-Bold="True" Width="70px" Font-Size="15px"></asp:Label>
                                   :
                                      <asp:Label ID="Label456" runat="server" Width="100px" Font-Size="15px" Text='<%# Eval("alkasa") %>' 
                                       Font-Bold="True"></asp:Label>
                                </td>

                                  <td dir="rtl">
                                     
                                 <asp:Label ID="Label31" runat="server" 
                                       meta:resourcekey="LaStudentNameResource1" 
                                           text="اطلالة العقار" Font-Bold="True" Width="70px" Font-Size="15px"></asp:Label>
                                       :
                                   <asp:Label ID="Label32" runat="server" Width="100px" Font-Size="15px" Text='<%# Eval("alatlalh") %>' 
                                    Font-Bold="True"></asp:Label>
                                      
                                 <br />
                                <br />
                                    
                                          </td>



                              

                                                     </tr>

                           <tr>



                                 <td dir="rtl">
                                  
                             <asp:Label ID="Label33" runat="server" 
                                     meta:resourcekey="LaStudentNameResource1" 
                         text="مساحة العقار" Font-Bold="True" Width="70px" Font-Size="15px"></asp:Label>
                         :
                    <asp:Label ID="Label34" runat="server" Width="100px" Font-Size="15px" Text='<%# Eval("area") %>' 
                         Font-Bold="True"></asp:Label>

                                    
                              </td>
                  



                                <td dir="rtl">
                               
                                 <asp:Label ID="Label35" runat="server" 
                                 meta:resourcekey="LaStudentNameResource1" 
                               text="ملكية العقار" Font-Bold="True" Width="70px" Font-Size="15px"></asp:Label>
                               :
                        <asp:Label ID="Label36" runat="server" Width="100px" Text='<%# Eval("havinge") %>' 
                        Font-Bold="True" Font-Size="15px"></asp:Label>
                              
                                   
                                 <br />
                                <br />

                           </td>

                              

                                                         </tr>







                            
                            <tr>
                                     <td dir="rtl">
                                      
                                 <asp:Label ID="Label37" runat="server" 
                                meta:resourcekey="LaStudentNameResource1" 
                                 text="اشارات العقار" Font-Bold="True" Width="70px" Font-Size="15px"></asp:Label>
                                 
                                :
                            <asp:Label ID="Label38" runat="server" Width="100px" Text='<%# Eval("refernc") %>' 
                                   Font-Bold="True" Font-Size="15px"></asp:Label>
                                        </td>


                                  
                                       <td dir="rtl">
                                        
                                         <asp:Label ID="Label39" runat="server" 
                                             meta:resourcekey="LaStudentNameResource1" 
                                         text="طابق العقار" Font-Bold="True" Width="60px" Font-Size="15px"></asp:Label>
                                        :

                         
                                     <asp:Label ID="Label40" runat="server" Width="100px" Text='<%# Eval("tabke") %>' 
                                              Font-Bold="True" Font-Size="15px"></asp:Label>
                                       
                                           
                                 <br />
                                <br />
                                              </td>

                                        </tr>

                                              


          <tr>

    <td dir="rtl">
               
 <asp:Label ID="Label41" runat="server" 
      meta:resourcekey="LaStudentNameResource1" 
     text="غرف العقار" Font-Bold="True" Width="60px" Font-Size="15px"></asp:Label>
   
    :
   <asp:Label ID="Label42" runat="server" Width="100px" Font-Size="15px"  Text='<%# Eval("room") %>' 
   Font-Bold="True"></asp:Label>
             </td>





         
    <td dir="rtl">
               
 <asp:Label ID="Label453" runat="server" 
       meta:resourcekey="LaStudentNameResource1" 
  text="كسوة العقار" Font-Bold="True" Width="60px" Font-Size="15px"></asp:Label>
:
<asp:Label ID="Label44" runat="server" Width="100px" Font-Size="15px" Text='<%# Eval("alkasa") %>' 
    Font-Bold="True"></asp:Label>
        
          <br />
         <br />
    </td>



          
                 </tr>

                       



                       <tr>   
                           
                  
   <td dir="rtl">
              
  <asp:Label ID="Label49" runat="server" 
        meta:resourcekey="LaStudentNameResource1" 
      text="اتجاه العقار" Font-Bold="True" Width="60px" Font-Size="15px"></asp:Label>
   :
<asp:Label ID="Label52" runat="server" Width="100px" Font-Size="15px" Text='<%# Eval("dirction") %>' 
       Font-Bold="True"></asp:Label>
    </td>
 




                           
                                        
        <td dir="rtl" >
            <asp:Label ID="Label61" runat="server" Text="وضغ الكهرباء" Font-Bold="True" Width="70px" Font-Size="15px"
                 meta:resourcekey="LaStudentNameResource1" >
                 </asp:Label> 
            :
            <asp:Label ID="Label74" runat="server" Text='<%# Eval("electron") %>'  Width="100px" Font-Size="15px"  Font-Bold="True"></asp:Label>


        </td>
              


           </tr>



 

            <tr>   
                           
                  
   <td dir="rtl">
              
  <asp:Label ID="Label87" runat="server" 
        meta:resourcekey="LaStudentNameResource1" 
      text="مصعد العقار" Font-Bold="True" Width="60px" Font-Size="15px"></asp:Label>
   :
<asp:Label ID="Label88" runat="server" Width="100px" Font-Size="15px" Text='<%# Eval("masad") %>' 
       Font-Bold="True"></asp:Label>
    </td>
 




      <td dir="rtl" >
     <asp:Label ID="Label89" runat="server" Text="خدمات بناء العقار" Font-Bold="True" Width="70px" Font-Size="15px"
          meta:resourcekey="LaStudentNameResource1" >
          </asp:Label> 
     :
     <asp:Label ID="Label90" runat="server" Text='<%# Eval("Serviecother") %>'  Width="100px" Font-Size="15px"  Font-Bold="True"></asp:Label>


 </td>
       


    </tr>







                            <tr>



                                
           
       <td dir="ltr">


           
     <asp:GridView ID="GridView2win" runat="server" AutoGenerateColumns="False"
         CellPadding="4" DataKeyNames="TutorialID" OnRowCommand="GridView2win_RowCommand"
         DataSourceID="SqlDataSource1win" ForeColor="#333333" GridLines="None" AlternatingRowStyle-BorderStyle="Dashed" AlternatingRowStyle-HorizontalAlign="Center" AlternatingRowStyle-VerticalAlign="Middle" BackColor="#FF0066" BorderStyle="Dashed" HorizontalAlign="Center" OnSelectedIndexChanged="GridView2updatedata1_SelectedIndexChanged">
                           
<AlternatingRowStyle BackColor="White" />
         <Columns>
                               
                            
             
   <asp:TemplateField HeaderText="..........">
       <ItemTemplate>
           <asp:Label ID="Labeltutorialwinid" runat="server" Visible="true" Text='<%# Eval("tutorialID") %>' ></asp:Label>

            
           
       </ItemTemplate>

   </asp:TemplateField>


          
             

             
             
           
   <asp:TemplateField HeaderText="" >
        <ItemTemplate>

           
       <asp:LinkButton ID="LinkButton3win"  Width="250px" runat="server" PostBackUrl='<%# "myDashoard.aspx?id=" + Eval("tutorialID")+"&statetutorial=" +txtstatetutorial.Text %>'
           Text= '<%# Eval("namebutton") %>'  CommandName="wintutorial"  class="btn btn-success" >
       </asp:LinkButton>


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


  
           
        <asp:SqlDataSource ID="SqlDataSource1win" runat="server"
            ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
            SelectCommand="select tutorialID ,namebutton from  tutorials where tutorialID=? "
                      
            ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">

            
                                    <SelectParameters>
<asp:ControlParameter ControlID="Label8filterid" Name="tutorialID" 
          PropertyName="Text" />
         </SelectParameters>
                      
        </asp:SqlDataSource>

           
    

         

    </td>

</tr>

                                           <tr>
                                
                                               <td dir="rtl">
                                                 
                                           <asp:Label ID="Label79manywin" runat="server" 
                                         meta:resourcekey="LaStudentNameResource1" 
                                       Text="عمولة المكتب" Font-Bold="True" Width="70px" Font-Size="15px"></asp:Label> 
                                       
                                       :
                                      <asp:Label ID="Label81manywin" runat="server" Text='<%# Eval("winmany") %>' 
                                          Font-Bold="True"  Font-Size="15px"></asp:Label>
                                    
                                      <asp:Label ID="Label82manywin" runat="server" Text='<%# Eval("manywinmany") %>' 
                                          Font-Bold="True" Width="100px" Font-Size="15px"></asp:Label>

                                               

                                 <br />
                                <br />

                                        </td>


                                <td>
                                     <asp:Label ID="Labelbrowserwinid" runat="server" Text='<%# Eval("tutorialbrowserwinid") %>' 
                                           Font-Bold  ="True" Width="100px" Font-Size="15px" Visible="true"></asp:Label>


                                </td>


                            </tr>






                 
                        
                                  

        </table>


                           
                                    
                                      <asp:GridView ID="GridView1requestbrowserwin" runat="server" AutoGenerateColumns="False" 
                                        CellPadding="4" DataKeyNames="browserid " 
                                        DataSourceID="SqlDataSource2reqbrowser" ForeColor="#333333" GridLines="None" AlternatingRowStyle-BorderStyle="Dashed" AlternatingRowStyle-HorizontalAlign="Center" AlternatingRowStyle-VerticalAlign="Middle" BackColor="#FF0066" BorderStyle="Dashed" HorizontalAlign="Center">
                                        
                                        <AlternatingRowStyle BackColor="White" />
                                       <Columns>
                                            
                                           
                     

                                          
                                             <asp:TemplateField HeaderText="اسم زبون العقار">
                                                     <ItemTemplate>

                                           
                                                 :

                                              <asp:Label ID="Label59firstname" runat="server" Font-Size="14pt"  ForeColor="Red"
                                              Text='<%# Eval("browserfirstName") %>' Font-Bold="True" Width="200px"></asp:Label>
 
                                              </ItemTemplate>
                                             </asp:TemplateField>
                                          
                                           


                                           

                                           
                                             <asp:TemplateField HeaderText="////////">
                                                     <ItemTemplate>

                    
                                                 :
                                              <asp:Label ID="Label59phonek2" runat="server" Font-Size="14pt"  ForeColor="Red"
                                              Text='///////////'  Font-Bold="True" Width="50px"></asp:Label>

                                             </ItemTemplate>
                                             </asp:TemplateField>





                                             <asp:TemplateField HeaderText="الكنية">
                                                 <ItemTemplate>
                                                 :
                                              <asp:Label ID="Label59lastname" runat="server" Font-Size="14pt"  ForeColor="Red"
                                              Text='<%# Eval("browserlastName") %>'  Font-Bold="True" Width="200px"></asp:Label>
 
                                             </ItemTemplate>
                                             </asp:TemplateField>

                                          

                                           
                                             <asp:TemplateField HeaderText="////////">
                                                     <ItemTemplate>

                    
                                                 :
                                              <asp:Label ID="Label59phonek2" runat="server" Font-Size="14pt"  ForeColor="Red"
                                              Text='///////////'  Font-Bold="True" Width="50px"></asp:Label>

                                             </ItemTemplate>
                                             </asp:TemplateField>



                                           
                                             <asp:TemplateField HeaderText="رقم موبايل الزبون">
                                                     <ItemTemplate>

                    
                                                 :
                                              <asp:Label ID="Label59phone" runat="server" Font-Size="14pt"  ForeColor="Red"
                                              Text='<%# Eval("NumberPhone") %>'  Font-Bold="True" Width="150px"></asp:Label>

                                             </ItemTemplate>
                                             </asp:TemplateField>





                                           
                                             <asp:TemplateField HeaderText="////////">
                                                     <ItemTemplate>

                    
                                                 :
                                              <asp:Label ID="Label59p4" runat="server" Font-Size="14pt"  ForeColor="Red"
                                              Text='///////////'  Font-Bold="True" Width="50px"></asp:Label>

                                             </ItemTemplate>
                                             </asp:TemplateField>




                                           
                                             <asp:TemplateField HeaderText="ارقام تليفون الزبون">
                                                     <ItemTemplate>

                                           
                                               <asp:Label ID="Label11phome" runat="server" Font-Size="14pt"  ForeColor="Red"
                                               Text='<%# Eval("NumberHome") %>' Font-Bold="True" Width="150px"></asp:Label>

 
                                             </ItemTemplate>
                                             </asp:TemplateField>





                                           
                                           
                                             <asp:TemplateField HeaderText="////////">
                                                     <ItemTemplate>

                    
                                                 :
                                              <asp:Label ID="Label59lp4" runat="server" Font-Size="14pt"  ForeColor="Red"
                                              Text='///////////'  Font-Bold="True" Width="50px"></asp:Label>

                                             </ItemTemplate>
                                             </asp:TemplateField>




                                           
                                           
                                             <asp:TemplateField HeaderText="ايميل">
                                                     <ItemTemplate>

                    
                                                 :
                                              <asp:Label ID="Labelemile" runat="server" Font-Size="14pt"  ForeColor="Red"
                                              Text='<%# Eval("browseremile") %>'  Font-Bold="True" Width="200px"></asp:Label>

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

                                        
                             <asp:SqlDataSource ID="SqlDataSource2reqbrowser" runat="server" ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"
                                       SelectCommand=" SELECT distinct browserID, browserfirstName,browserlastName,browseremile,NumberPhone,NumberHome from mybrowser 
                                                          WHERE browserID = 0 " 
                                 
                                               

                                  ProviderName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>">
                                 <SelectParameters>
          

               <asp:ControlParameter ControlID="Labelbrowserwinid" PropertyName="Text" DefaultValue="" Name="browserid" />
    
              
    
    
</SelectParameters>



</asp:SqlDataSource> 

                               










           

                        <br />
                        </div>
                            </div>
                    </ItemTemplate>
                </asp:DataList>
    
               
          </td>
        </tr>

        <tr>
            <td>
               

     <asp:SqlDataSource ID="SqlDataSource22" runat="server"
                        ConnectionString="<%$ ConnectionStrings:odb99ConnectionString %>"

     SelectCommand= ""
    providerName="<%$ ConnectionStrings:odb99ConnectionString.ProviderName %>" OnSelecting="SqlDataSource2_Selecting1">


          <SelectParameters>
     <asp:SessionParameter Name="adminID" SessionField="adminID" />
     <asp:Parameter DefaultValue="1" Name="start" Type="Int32" />
     <asp:Parameter DefaultValue="10" Name="end" Type="Int32" />
 </SelectParameters>



                  
 </asp:SqlDataSource>
         
               
            </td>
            <td>
                &nbsp;</td>
        </tr>
       
        

        <tr>


            <td>
                 <ul class="pager">
                     
  <li><a  ><asp:Button ID="Button2" runat="server" Text="Next" OnClick="Button1_Click" Visible="false" /></a></li>
  <li><a  ><asp:Button ID="Button3" runat="server" Text="Previous" OnClick="Button2_Click" Visible="False" /></a></li>
</ul>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>

        <tr>
            <td>
                <asp:HiddenField ID="HFMax" runat="server" />
                <asp:HiddenField ID="HFIndex" runat="server" Value="10" />
            </td>
            <td>
                &nbsp;</td>
        </tr>


        

    </table>

       
    
         </div>





     </ContentTemplate>
  
 </asp:UpdatePanel>                


    


    <%/////////////////////////////////////////////////////////   fun java %>


    

 <%   /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// %>

     


    <asp:Literal ID="Literal3" runat="server"></asp:Literal>
          <asp:Literal ID="Literal7" runat="server"></asp:Literal>


              <asp:TextBox ID="typetutor" runat="server" Visible="false"></asp:TextBox>
           



    
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


              function ShowModalErrortdate() {

                  $("#DivMessagePaneldanger").addClass('alert alert-danger');
                  $('#ShowModalErrortype').modal('show');
                  window.setTimeout(HideModal, 1000);
              }





              function HideModal() {
                  $('#ModalMessage').modal('hide');
              }
       </script>  
    
<div id="ModalMessage" class="modal fade" role="dialog">
<div class="modal-dialog">

     
          <div class="alert alert-success"   id="DivMessagePanelsuccess">

           <asp:Literal ID="Literal2" Text="<strong>Success!</strong> Data is added successfully." runat="server"></asp:Literal>
              <a href="#" class="close" data-dismiss="modal" aria-label="close">&times;</a>
          </div>

    
  </div>
    </div>


<div id="ModalMessagerror" class="modal fade" role="dialog">
<div class="modal-dialog">
  
       <div class="alert alert-danger" id="DivMessagePaneldanger" runat="server">

         <asp:Literal ID="LiMessage" Text="<strong>Warning!</strong> يرجى اضافة اسم وكنية الزبون." runat="server" ></asp:Literal>  
             <a href="#" class="close" data-dismiss="modal" aria-label="close">&times;</a>
      </div>
                                  
     

  </div>
    </div>




<div id="ShowModalErrortype" class="modal fade" role="dialog">
<div class="modal-dialog" style="color:red;">
  
       <div class="alert alert-danger"   id="Div1" runat="server">

         <asp:Literal ID="Literal24" Text="<strong>Warning!</strong>  يرجى التقييد بالنموذج التاريخ  ." runat="server" ></asp:Literal>  
             <a href="#" class="close" data-dismiss="modal" aria-label="close">&times;</a>
      </div>
                                  
     

  </div>
    </div>










<%///////////////////////////////////////////////////////////////////////////////////  java %>  

       


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




    </script>






       <%//////////////////////////////////////////////////    صفحة ربح المكتب عرض بيانات زبون العقار الذي اشتراه او استاجره %>
    
<div class="modal fade" id="modalmessgboxwin" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">

            <div id="messgidreswin">
             <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
             <div class="modal-header">
     <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgCloseBtnwin"/>
        <span aria-hidden="true">&times;</span>  
   </div>


            
                <div class="modal-body">
                    <img src="files\log99.jpg"/>
                    <div id="msg-resultrwin"></div>
                    <div class="md-form">
                <input type="hidden" id="defaultForm-tel2rwin"  class="form-control validate validate_phone_login" placeholder="" name="messg" />



                                      <div class="md-form">
               
    
                   <label data-error="wrong"   data-success="right" title="" for="defaultForm-tel2"> عمولة المكتب</label>

                    <asp:TextBox ID="TextBox8manywin" Enabled="false" runat="server"></asp:TextBox>
        
                        
      <div class="md-form">


          
    <div class="ItemNewsConatin" > 
        <asp:Panel ID="Panel7" runat="server" CssClass="pnl2"  >


            <p class="MsoNormal" dir="auto">


                <input id="Hidden1" type="hidden" name="viw"   />
            
            <asp:Label ID="Label77" runat="server" Text="عرض بيانات الزبون"></asp:Label></p>

         


            <asp:Literal ID="Literal13" runat="server"></asp:Literal>

          <table class="nav-justified" dir="rtl">
               <tr>

                   
       


                 <td>  <asp:Label ID="Label80" runat="server"  Text="اسم الاول" Font-Bold="True" Font-Size="12pt"></asp:Label>
                    <asp:TextBox ID="TextBox9name1view" Enabled="false" runat="server" Text="" MaxLength="60"  Width="70%"  class="form-control " onkeypress="return isokmaxlength(event,this,70);"  placeholder=" First Nname"   ReadOnly="False "  AutoCompleteType="HomeFax"></asp:TextBox>
             
                     

                     </td>

                  

                <td> <asp:Label ID="Label81" runat="server"  Text="اسم العائلة" Font-Bold="True" Font-Size="12pt"></asp:Label>
                  
       <asp:TextBox ID="TextBox10name2view" runat="server" Enabled="false" MaxLength="25" Text="" class="form-control "  onkeypress="return isokmaxlength(event,this,70);"   placeholder=" Family Name"  Width="70%" ></asp:TextBox>

                    

           </td>

                   </tr>

              <tr>


         <td> <asp:Label ID="Label82" runat="server"   Text=" رقم الموبايل" Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:TextBox ID="TextBox11phonview" Enabled="false" runat="server" class="form-control " MaxLength="50" Text=""  placeholder=" رقم الموبايل" onkeypress="return isokmaxlength(event,this,15);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="50%"></asp:TextBox>
         
             <br />
                 
             </td>

              
        <td>   <asp:Label ID="Label83" runat="server"   Text="  رقم التلفون" Font-Bold="True" Font-Size="12pt"></asp:Label>
           <asp:TextBox ID="TextBox12homeview" Enabled="false" runat="server" class="form-control " MaxLength="50" Text=""  placeholder=" رقم التلفون" onkeypress="return isokmaxlength(event,this,15);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="50%"></asp:TextBox>
         <br />
                       
          
        </td>



 
      
        </tr>
              
     <tr>

         <td>


  <asp:Label ID="Label84" runat="server"   Text=" ملاحظات حول  الزبون" Font-Bold="True" Font-Size="12pt"></asp:Label>

<asp:TextBox ID="TextBox13notview" runat="server"  Enabled="false"  MaxLength="25"   placeholder="  Nots"  class="form-control " onkeypress="return isokmaxlength(event,this,255);" TextMode="MultiLine" Height="171px" ></asp:TextBox>

             

         </td>

         <td>


             <asp:Button ID="Button4deletwin" runat="server" Text="حذف العقار" class="btn btn-success" OnClick="deletwintutor"    />
         </td>


         </tr>

             
</table>

 

      
 </asp:Panel>
  </div>
     
     
          </div>



               </div>


                    </div>



    


            </div>
 

                </div>


       </div>
    </div>
</div>





     <script>

         // $(window).on('load', function () {

         function showmessokviewwin() {


             $('#modalmessgboxwin').modal('show');




         }

     </script>













    

<%///////////////////////////////////////////////////////////////////////////      شراء او استاجار عقار %>

    
    
<div class="modal fade" id="modalmessgbox" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">

            <div id="messgidres">
             <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
             <div class="modal-header">
     <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgCloseBtn"/>
        <span aria-hidden="true">&times;</span>  
   </div>


            
                <div class="modal-body">
                    <img src="files\log99.jpg"/>
                    <div id="msg-resultr"></div>
                    <div class="md-form">
                <input type="hidden" id="defaultForm-tel2r"  class="form-control validate validate_phone_login" placeholder="" name="messg" />



                                      <div class="md-form">
               
    
                   <label data-error="wrong"   data-success="right" title="" for="defaultForm-tel2">ادخل عمولة المكتب</label>

                    <asp:TextBox ID="TextBox99manywin" runat="server"></asp:TextBox>
                                          
                    <asp:Literal ID="Literal19" runat="server" Text=" اساسي"></asp:Literal>
        
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage=" يجب ان يكون المدخل ارقام فقط" ControlToValidate="TextBox99manywin" ForeColor="Red"  Operator="DataTypeCheck" Type="Double"></asp:CompareValidator>



<asp:UpdatePanel ID="UpdatePanel8" runat="server">
<ContentTemplate>


                     <label data-error="wrong"  data-success="right" title="" for="defaultForm-tel2">حدد العملة</label>

  
                     <asp:DropDownList ID="DropDownList99manywin" runat="server" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"      CssClass="ArabicFont"   Width="120px">

       
                     </asp:DropDownList>

                     
                    <asp:Literal ID="Literal20" runat="server" Text=" اساسي"></asp:Literal>

      <div class="md-form">


          
    <div class="ItemNewsConatin" > 
        <asp:Panel ID="Panel5" runat="server" CssClass="pnl2"  >


            <p class="MsoNormal" dir="auto">
            <asp:Label ID="Label25" runat="server" Text="اضافة بيانات الزبون"></asp:Label></p>

           

            <asp:Literal ID="Literal12" runat="server"></asp:Literal>

          <table class="nav-justified" dir="rtl">
               <tr>

            
                 <td>  
                     

                     <asp:Label ID="Label53" runat="server"  Text="اسم الاول" Font-Bold="True" Font-Size="12pt"></asp:Label>
                    <asp:TextBox ID="Textname1form" runat="server" Text="" MaxLength="60"  Width="70%"  class="form-control " onkeypress="return isokmaxlength(event,this,70);"  placeholder=" First Nname"   ReadOnly="False "  AutoCompleteType="HomeFax"></asp:TextBox>
             
                     
                     </td>
                   <td>
                       
                    <asp:Literal ID="Literal21" runat="server" Text=" اساسي"></asp:Literal>
                   </td>

                  

                <td>
                    </tr>
                    <tr>
                   
                   <td> <asp:Label ID="Label54" runat="server"  Text="اسم العائلة" Font-Bold="True" Font-Size="12pt"></asp:Label>
                  
       <asp:TextBox ID="Textname2form" runat="server" MaxLength="25" Text="" class="form-control "  onkeypress="return isokmaxlength(event,this,70);"   placeholder=" Family Name"  Width="70%" ></asp:TextBox>

                   
           </td>

                   

                   <td>
    
 <asp:Literal ID="Literal22" runat="server" Text=" اساسي"></asp:Literal>
</td>


                   </tr>

              <tr>


         <td> <asp:Label ID="Label66" runat="server"   Text=" رقم الموبايل" Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:TextBox ID="Textnumphform" runat="server" class="form-control " MaxLength="50" Text=""  placeholder=" رقم الموبايل" onkeypress="return isokmaxlength(event,this,15);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="50%"></asp:TextBox>
         
                 
             </td>

              
        <td>   <asp:Label ID="Label71" runat="server"   Text="  رقم التلفون" Font-Bold="True" Font-Size="12pt"></asp:Label>
           <asp:TextBox ID="Textnummopform" runat="server" class="form-control " MaxLength="50" Text=""  placeholder=" رقم التلفون" onkeypress="return isokmaxlength(event,this,15);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="50%"></asp:TextBox>
        
                       
          
        </td>

      
        </tr>
              
     <tr>

         <td>


  <asp:Label ID="Label76" runat="server"   Text=" ملاحظات حول  الزبون" Font-Bold="True" Font-Size="12pt"></asp:Label>

<asp:TextBox ID="Textnotform" runat="server"   MaxLength="25"   placeholder="  Nots"  class="form-control " onkeypress="return isokmaxlength(event,this,255);" TextMode="MultiLine" Height="130px" ></asp:TextBox>

             

         </td>

         </tr>

             
</table>

 

      
 </asp:Panel>
  </div>
     
     
          </div>




   </ContentTemplate>
    </asp:UpdatePanel>


               </div>





                    </div>

                    
                  <button type="button"  id="ok1" class="btn btn-success" onclick="" >موافق</button>
                        
                    
                  <button type="button"  id="ok2" class="btn btn-success" onclick="" >غير موافق</button>
                        
                 


    


            </div>
 

                </div>


       </div>
    </div>
</div>


    
   <asp:Button ID="sendrequset" ClientIDMode="Static"      OnClick="sold99takee99" runat="server" Text="sendrequjest" />







    
  <script>

      // $(window).on('load', function () {

      function showmessok() {


          $('#modalmessgbox').modal('show');


          if ('<%=txtstatetutorial.Text%>' == "solde") {

              // $('#messgid input[name="messg"]').val( "هل انت تريد شراء العقار");

              $('#messgidres').find('input[name="messg"]').after('<span class="error-msg po">' + "هل تريد شراء هذا العقار" + '</span>');

          }
          else if ('<%=txtstatetutorial.Text%>' == "take") {

              // $('#messgid input[name="messg"]').val( "هل انت تريد شراء العقار");

              $('#messgidres').find('input[name="messg"]').after('<span class="error-msg po">' + " هل   تريد  استاجار هذا العقار" + '</span>');
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









      function notsold99tak99many() {


          alert("عذرا لم يتم ادخال  عمولة للمكتب او بيانات زبون العقار يرجى اعادة المحاولة   ");

          $('#ShowModalError').modal('show');

          $('#modalmessgbox').modal('show');







          if ('<%=txtstatetutorial.Text%>' == "solde") {

              // $('#messgid input[name="messg"]').val( "هل انت تريد شراء العقار");

              $('#messgidres').find('input[name="messg"]').after('<span class="error-msg po">' + "هل تريد شراء هذا العقار" + '</span>');

          }
          else if ('<%=txtstatetutorial.Text%>' == "take") {

              // $('#messgid input[name="messg"]').val( "هل انت تريد شراء العقار");

              $('#messgidres').find('input[name="messg"]').after('<span class="error-msg po">' + "هل تريد استاجار هذا العقار" + '</span>');
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

                 
               <button type="button"  id="okadd" class="btn btn-success" onclick="" >موافق غلى اضافةاو تعديل العقار</button>
                     
                 
               <button type="button"  id="noadd" class="btn btn-success" onclick="" > غير موافق</button>
                     
              

                 </div>


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



        function addstate() {
            alert("يرجى تحديد حالة العقار");

        }




        function addtutoroial() {

           // alert("jj");

            $('#modalmessgaddbox').modal('show');

            $('#messgadd').find('input[name="messgadd"]').after('<span class="error-msg po">' + "سوف يتم اضافة هذا العقار في قائمة العقارات للشرء" + '</span>');


            // document.getElementById("mesg").title = "سوف يتم اضافة هذا العقار في قائمة العقارات للشرء";





            document.getElementById("okadd").addEventListener('click', function () {


                document.getElementById("TextBox6").value = "ok";


                ///  document.getElementById("imagload").namespaceURI = "/image2/load.gif";

                // document.getElementById("BuAddDatabrowser").trigger('click');



                $('#Button2_addhaveperson').trigger('click');

               
                    $('#modalmessgaddCloseBtn').trigger('click');
               

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


                document.getElementById("TextBox6").value = "ok";


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









        function notupdatesold() {
            alert("عذرا لايمكن تعديل هذا العقار لان موجود ضمن قائمة (طالبات شراء العقارات )او ضمن قائمة (ربح المكتب من شراء العقارات ))يرجى التحقق من قائمة طلباتك لمعالجة الطلب اولا");

            window.location.href = "MYDashoard.aspx?updateimage=" + "updateimage" + "&browseridview=" + '<%=browserid.Text%>' + "&tutorialid=" + '<%=tutorialid.Text%>' + "&statetutorial=" +'<%=txtstatetutorial.Text%>';



        }

        function notupdatetak() {
            alert("عذرا لايمكن تعديل هذا العقار لان موجود ضمن قائمة (طالبات استاجار العقارات او ضمن قائمة(ربح المكتب من استاجارات العقارات) )يرجى التحقق من قائمة طلباتك لمعالجة الطلب اولا");

            window.location.href = "MYDashoard.aspx?updateimage=" + "updateimage" + "&browseridview=" + '<%=browserid.Text%>' + "&tutorialid=" + '<%=tutorialid.Text%>' + "&statetutorial=" + '<%=txtstatetutorial.Text%>';


        }










    </script>





       






    
            <asp:TextBox ID="TextBox6" runat="server" Text="welcom" Enabled="false" Visible="true" ClientIDMode="Static" ></asp:TextBox>
           


   <%  //  //////////////////////////////////////////////////////////////  اضافة صور للعقار %>

    
    
<div class="modal fade" id="modalmessgaddimagebox1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">
        

         <div id="messgaddimage1">
          <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
          <div class="modal-header">


  <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgaddimageCloseBtn1"/>

     <span aria-hidden="true">&times;</span> 
         
</div>

             <div class="modal-body">
                 <img src="files\log99.jpg"/>
                
               <asp:Label ID="Label79" runat="server"   Text="اختر  صور للعقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
   

     <asp:FileUpload ID="FileUpload3" runat="server"    class="btn btn-success"     />
        <asp:TextBox ID="TextBoxlinkimag" runat="server"  Text="kkkkk" Width="50%" Visible="false"></asp:TextBox>
   
       
                 </div>

                   <button type="button"  id="okaddimage1" class="btn btn-success" onclick="" >موافق غلى اضافة الصورة</button>
        
    
                   <button type="button"  id="noaddimage1" class="btn btn-success" onclick="" > غير موافق</button>
                
             

         </div>
 
</div>
</div>
    </div>


    

   <asp:Button ID="addimagebutton1" ClientIDMode="Static"      OnClick="onload_file" runat="server" Text="addimag" />

    


    <script>


        function imageadd() {


          //  alert("hhh");
            

            // $('#FileUpload1').trigger('click');

            $('#modalmessgaddimagebox1').modal('show');




           // alert('<%=browserid.Text%>');
      

            


            document.getElementById("okaddimage1").addEventListener('click', function () {



               // alert('<%=browserid.Text%>');


                $('#addimagebutton1').trigger('click');


            });





            document.getElementById("noaddimage1").addEventListener('click', function () {



                $('#modalmessgaddimageCloseBtn1').trigger('click');

            });


        }




        function notaddimag() {


            alert("عذرا لم يتم اختيار صورة يرجى اعادة المحاولة لاختيار صورة لتحميلها");


            $('#ShowModalError').modal('show');


            $('#modalmessgaddimagebox1').modal('show');



            document.getElementById("okaddimage1").addEventListener('click', function () {

                $('#addimagebutton1').trigger('click');


            });




            document.getElementById("noaddimage1").addEventListener('click', function () {

                $('#modalmessgaddimageCloseBtn1').trigger('click');

            });







        }










    </script>






  <%//////////////////////////////////////////////////////////////////////////   معالجة طالبات بيع او تاجير العقارات   %> 




   


    

    
<div class="modal fade" id="modalrequestsendbox" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">

            <div id="messgid">
             <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
             <div class="modal-header">
     <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgrequestCloseBtn"/>
     <span aria-hidden="true">&times;</span>  
   </div>


            
                <div class="modal-body">
                    <img src="files\log99.jpg"/>
                    <div id="msg-result"></div>
                    <div class="md-form">
               <label data-error="wrong"  data-success="right" title="" for="defaultForm-tel2"></label>
                <input type="hidden" id="defaultForm-tel2"  class="form-control validate validate_phone_login" placeholder="" name="messg" />

                    </div>


                  <button type="button"  id="okyes" class="btn btn-primary login" onclick="" >موافق على الطلب</button>
                  <button type="button"  id="okno" class="btn btn-primary login" onclick="" > غير موافق </button>
                  <button type="button"  id="okdel" class="btn btn-primary login" onclick="" >حذف الطلب</button>


            </div>

              

                </div>


       </div>
    </div>
</div>


    



    


   <asp:Button ID="yessrequestsolde"  ClientIDMode="Static" OnClick="yessrequestsoldetakebutton" runat="server" Text="yesqeruestsold" />

   <asp:Button ID="deletrequsetsolde"  ClientIDMode="Static" OnClick="deletrequsetsoldetakebutton" runat="server" Text="deletrequestsold" />






    
    
  <script>




      // $(window).on('load', function () {

      



      function requestsendsoltake() {


          if (('<%=txtstatetutorial.Text%>' == "requset_solde") || ('<%=txtstatetutorial.Text%>' == "requset_take")) {




              $('#modalrequestsendbox').modal('show');


              if ('<%=txtstatetutorial.Text%>' == "requset_solde") {

                  // $('#messgid input[name="messg"]').val( "هل انت تريد شراء العقار");

                  $('#messgid').find('input[name="messg"]').after('<span class="error-msg po">' + "هل انت موافق على طلب بيع هذا العقار" + '</span>');

              }
              else if ('<%=txtstatetutorial.Text%>' == "requset_take") {

                  // $('#messgid input[name="messg"]').val( "هل انت تريد شراء العقار");

                  $('#messgid').find('input[name="messg"]').after('<span class="error-msg po">' + "هل انت  موافق على طلب تاجير هذا العقار" + '</span>');
              }

          }



              document.getElementById("okyes").addEventListener('click', function () {


                  $('#yessrequestsolde').trigger('click');





              });






              document.getElementById("okno").addEventListener('click', function () {
                  // document.getElementById("ok2").addEventListener('click', function () {


                //  alert("gggg");

                  $('#modalmessgrequestCloseBtn').trigger('click');




              });







              document.getElementById("okdel").addEventListener('click', function () {




                 // alert('<%=tutorialid.Text%>')  //// delete

                  $('#deletrequsetsolde').trigger('click');





              });


          


          
      }


  </script>





    
    
    
  <%//////////////////////////////////////////////////////////////////////////   معالجة طالبات شراء او استاجار العقارات   %> 



    

    
<div class="modal fade" id="modalrequestsenmanydbox" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">

         <div id="messgidmany">
             <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
               <div class="modal-header">
                  <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalsendrequestmanyCloseBtn"/>
                  <span aria-hidden="true">&times;</span>
                </div>
                



             





        <div class="modal-body">
                  <img src="files\log99.jpg"/>
                    <div id="msg-resultm"></div>
                 <div class="md-form">
               


                   <input type="hidden" id="defaultForm-tel2m"  class="form-control validate validate_phone_login" placeholder="" name="messg" />

                   </div>

            
           
              <div class="md-form">
               
    
                   <label data-error="wrong"  data-success="right" title="" for="defaultForm-tel2">ادخل عمولة المكتب</label>

                    <asp:TextBox ID="TextBox6manywin" runat="server"></asp:TextBox>
        
   
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
<ContentTemplate>


                     <label data-error="wrong"  data-success="right" title="" for="defaultForm-tel2">حدد العملة</label>

  
                     <asp:DropDownList ID="DropDownList5manywin" runat="server" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown"      CssClass="ArabicFont"   Width="120px">

       
                     </asp:DropDownList>

   </ContentTemplate>
    </asp:UpdatePanel>


               </div>
            
       </div>


           

                  <button type="button"  id="okyesmany" class="btn btn-primary login" onclick="" >موافق على الطلب</button>
                  <button type="button"  id="oknomany" class="btn btn-primary login" onclick="" > غير موافق على الطلب </button>
                  <button type="button"  id="okdelmany" class="btn btn-primary login" onclick="" >حذف الطلب</button>


            </div>

           

       </div>
    </div>
</div>

    
    

   <asp:Button ID="yessrequestrice" ClientIDMode="Static" OnClick="yessrequestricetakeofbutton" runat="server" Text="yesricrequest" />


   <asp:Button ID="deletrequsetrice" ClientIDMode="Static" OnClick="deletrequsetricetakeofbutton" runat="server" Text="deletricrequest" />


    

    
  <script>




      function requestsendrictakeof11() {



              $('#modalrequestsenmanydbox').modal('show');


              if ('<%=txtstatetutorial.Text%>' == "requset_rice") {


                  $('#messgidmany').find('input[name="messg"]').after('<span class="error-msg po">' + "هل انت موافق على طلب شراء هذا العقار" + '</span>');

              }


               else if ('<%=txtstatetutorial.Text%>' == "requset_take_of") {

                      // $('#messgid input[name="messg"]').val( "هل انت تريد شراء العقار");

                      $('#messgidmany').find('input[name="messg"]').after('<span class="error-msg po">' + "هل انت  موافق على طلب استاجار هذا العقار" + '</span>');
                }



          document.getElementById("okyesmany").addEventListener('click', function () {


              $('#yessrequestrice').trigger('click');





          });






          document.getElementById("oknomany").addEventListener('click', function () {
              // document.getElementById("ok2").addEventListener('click', function () {




              $('#modalsendrequestmanyCloseBtn').trigger('click');




          });







          document.getElementById("okdelmany").addEventListener('click', function () {


            //  alert('<%=tutorialid.Text%>')  //// update from teswin to true

              $('#deletrequsetrice').trigger('click');





          });


      }





      
        function notsendrequestmany() {


            alert("عذرا لم يتم ادخال  عمولة للمكتب يرجى اعادة المحاولة   ");

            $('#ShowModalError').modal('show');

            
              $('#modalrequestsenmanydbox').modal('show');




              
          document.getElementById("okyesmany").addEventListener('click', function () {


              $('#yessrequestrice').trigger('click');





          });






          document.getElementById("oknomany").addEventListener('click', function () {
              // document.getElementById("ok2").addEventListener('click', function () {




              $('#modalsendrequestmanyCloseBtn').trigger('click');




          });







          document.getElementById("okdelmany").addEventListener('click', function () {


            //  alert('<%=tutorialid.Text%>')  //// update from teswin to true

              $('#deletrequsetrice').trigger('click');





          });









        }





  </script>




   <%////////////////////////////////////////////////////////////////////////////////////////////////  حذف العقار %>   



    
    

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


    
   <asp:Button ID="delettuorialbutton" ClientIDMode="Static"      OnClick="delet_tutorial" runat="server" Text="deletetutorial" />

    



    

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

               


            });





        }







        function notdeletetutorialsold() {
            alert("عذرا لايمكن حذف هذا العقار لان موجود ضمن قائمة (طالبات شراء العقارات )يرجى التحقق من قائمة طلباتك لمعالجة الطلب اولا");

            window.location.href = "MYDashoard.aspx?updateimage=" + "updateimage" + "&browseridview=" + '<%=browserid.Text%>' + "&tutorialid=" + '<%=tutorialid.Text%>' + "&statetutorial=" +'<%=txtstatetutorial.Text%>';



        }

        function notdeletetutorialtake() {
            alert("عذرا لايمكن حذف هذا العقار لان موجود ضمن قائمة (طالبات استاجار العقارات )يرجى التحقق من قائمة طلباتك لمعالجة الطلب اولا");

            window.location.href = "MYDashoard.aspx?updateimage=" + "updateimage" + "&browseridview=" + '<%=browserid.Text%>' + "&tutorialid=" + '<%=tutorialid.Text%>' + "&statetutorial=" + '<%=txtstatetutorial.Text%>';


        }




        </script>








    

   <%////////////////////////////////////////////////////////////////////////////////////////////////  حذف الزبون %>   



    
    

<div class="modal fade" id="modalmessgdeletebrowser" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"  aria-hidden="true">
    <div class="modal-dialog rounded modal-dialog-centered" role="document">
        <div class="modal-content">
        

         <div id="messgdeletbrowser">
          <input type="hidden" name="_token" value="MRMONKwsIK0eMCs7RMh09dNqxNKwAMuAfpwOLPYW"/>  
          <div class="modal-header">


  <button type="button" class="close" data-dismiss="modal" aria-label="Close" id="modalmessgdeletbrowserCloseBtn"/>

     <span aria-hidden="true">&times;</span> 
         

</div>

             <div class="modal-body">
                 <img src="files\log99.jpg"/>
                 <div id="msg-result0dtd"></div>
                 <div class="md-form">
             <input type="hidden" id="tel0dtd"  class="form-control validate validate_phone_login" placeholder="" name="messgdelet" />

                 </div>


                   <button type="button"  id="okdeletbrowser" class="btn btn-success" onclick="" >موافق غلى حذف الزبون</button>
        
    
                   <button type="button"  id="nodeletbrowser" class="btn btn-success" onclick="" > غير موافق</button>
                

                 </div>

             



         </div>
 
</div>
</div>
    </div>


    
   <asp:Button ID="deletebrowser" ClientIDMode="Static"      OnClick="delet_browser" runat="server" Text="deletebrowser" />

    



    

    <script>


        function browserdelet() {


            $('#modalmessgdeletebrowser').modal('show');

            $('#messgdeletbrowser').find('input[name="messgdelet"]').after('<span class="error-msg po">' + "هل انت متاكد من حذف  الزبون" + '</span>');


            document.getElementById("okdeletbrowser").addEventListener('click', function () {



                // document.getElementById("BuAddDatabrowser").trigger('click');



                $('#deletebrowser').trigger('click');



            });





            document.getElementById("nodeletbrowser").addEventListener('click', function () {




                $('#modalmessgdeletbrowserCloseBtn').trigger('click');




            });





        }







        function notdeletebrowsersold() {
            alert("عذرا لايمكن حذف هذا الزبون لان لديه عقارات  موجود ضمن قائمة (طالبات شراء العقارات )يرجى التحقق من قائمة طلباتك لمعالجة الطلب اولا");

          


        }





        function notdeletebrowsertake() {
            alert("عذرا لايمكن حذف هذا الزبون لان لديه عقارات  موجود ضمن قائمة (طالبات استاجار العقارات )يرجى التحقق من قائمة طلباتك لمعالجة الطلب اولا");

          

        }





    </script>









</asp:Content>