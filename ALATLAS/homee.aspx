<%@ Page Title="" Language="C#" MasterPageFile="~/mydashoard.master" AutoEventWireup="true" CodeBehind="homee.aspx.cs" Inherits="ALATLAS.homee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ClientsMainContent" runat="server">

    
    
               <asp:Literal ID="Literal1" runat="server"></asp:Literal>

    <asp:Literal ID="Literal2" runat="server"></asp:Literal>




    
    
    <div class="container" dir="rtl" >
  
  <div class="panel-group">
    

    <div class=" panel-primary class" >

          <div class="panel-heading" style="text-align:center ">
              <asp:Label ID="Label18" runat="server" Font-Bold="True" Visible="false" Font-Size="20"  ></asp:Label>
                      

           </div>

      <div class="container"> 
              <br />
      <div class="row"  dir="rtl">






              <table class="nav-justified" dir="rtl" border="1" style="-moz-box-align:center">
                  <tr>
                      <td>
                 <p class="MsoNormal" dir="auto">
                     <asp:Label ID="Label32" runat="server" Text="اضافة عملات جديدة للعقار"></asp:Label></p>

                      </td>

                  </tr>


                  <tr>
                     <td> 

         <asp:Label ID="Label19" runat="server"  Text="ضف عملة جديدة"  Font-Bold="True" Font-Size="12pt"></asp:Label>
                    <asp:TextBox ID="txtmany" placeholder="مثلا : الف" runat="server"></asp:TextBox>


            
         <asp:Label ID="Label26" runat="server"  Text="ع(عدد اصفار العملة)حدد قوى العملة" Font-Bold="True"     Font-Size="12pt"></asp:Label>
                    <asp:TextBox ID="txtpow" runat="server"  placeholder=" مثلا:3" TextMode="Number"  ></asp:TextBox>


            <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                &nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;
      
           <asp:Button ID="Buttaddmony" runat="server" Text="اضافة عملة جديدة"   OnClick="addbuttonmany" />


 &nbsp;&nbsp;&nbsp;&nbsp;
 &nbsp;&nbsp;&nbsp;&nbsp;
          <asp:DropDownList ID="DropDownList1many" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>


                     </td>
                       </tr>            
              </table>

                 <br />
              <br />     
          

 <div class="container"> 
         <br />
 <div class="row"  dir="rtl">
    


    <div class="ItemNewsConatin" > 

        <table class="nav-justified" dir="rtl" border="1" style="-moz-box-align:center ; ">

            <tr>
                <td>
                
                   
                      
               <asp:Label ID="Label1" runat="server"  Text="ضف بلد جديد" Font-Bold="True" Font-Size="10pt"></asp:Label>
                <asp:TextBox ID="txtcountry" runat="server" Width="90px"  ></asp:TextBox>


                    <asp:Button ID="Buttaddcountry" runat="server" Text="اضافة بلد جديد"  OnClick="buttaddcounty" />
                      &nbsp;&nbsp;&nbsp;&nbsp;
                      &nbsp;&nbsp;&nbsp;&nbsp;
                   

              <asp:Label ID="Label2" runat="server"  Text="ضف مدينة جديدة" Font-Bold="True" Font-Size="10pt"></asp:Label>
                <asp:TextBox ID="txtcity" runat="server"   Width="90px" ></asp:TextBox>
                    
                    <asp:Button ID="Buttaddcity" runat="server" Text="اضافة مدينة جديد"  OnClick="buttaddcity" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;
                       
                <asp:Label ID="Label3" runat="server"  Text="ضف منطقة جديدة" Font-Bold="True" Font-Size="10pt"></asp:Label>
                    <asp:TextBox ID="txtalmanteka" runat="server" Width="90px"  ></asp:TextBox>
  
                        
                    <asp:Button ID="Buttaddmanteka" runat="server" Text="اضافة منطقة جديد"  OnClick="buttaddmanteka" />

                    <asp:Button ID="Button1refresh" runat="server" Text="تحديث"  OnClick="refersh" />

                 <br />
              <br />     
          





                </td>
            </tr>


            <tr>
                <td>
                 <p class="MsoNormal" dir="auto">
                      <asp:Label ID="Label33" runat="server" Text="حدد مسار الاضافات الفرعية "></asp:Label></p>

                </td>
            </tr>



            <tr>
                <td>

          <asp:Label ID="Label10" runat="server"  Text="حدد بلد العقار" Font-Bold="True" Font-Size="10pt"></asp:Label>
       
                 <asp:DropDownList ID="DropDownList1country" AutoPostBack="true" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px" OnSelectedIndexChanged="selectcountry"></asp:DropDownList>

              

            
           
                    
       &nbsp;&nbsp;&nbsp;&nbsp;
       &nbsp;&nbsp;&nbsp;&nbsp;         
       &nbsp;&nbsp;&nbsp;&nbsp;
       &nbsp;&nbsp;&nbsp;&nbsp;    
                    
       &nbsp;&nbsp;&nbsp;&nbsp;
       &nbsp;&nbsp;&nbsp;&nbsp;

                    <asp:Literal ID="Literal4" runat="server"></asp:Literal>
        <asp:Label ID="Label11" runat="server"  Text="حدد مدينة العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
       
            <asp:DropDownList ID="DropDownList3city" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"  OnSelectedIndexChanged="selectcity"></asp:DropDownList>
       
               

                </td>
                </tr>


            <tr>
           <td>

                <br />
                  <br />     
          
      <asp:Label ID="Label12" runat="server"  Text="حدد منطقة العقار" Font-Bold="True" Font-Size="12pt"></asp:Label>
      
               <asp:DropDownList ID="almanteka" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server" CssClass="ArabicFont" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="almanteka_SelectedIndexChanged"></asp:DropDownList>
  


                &nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;
       
               

          
           <asp:Label ID="Label31" runat="server"  Text="   ضف تفرعات للمنطقة في حال وجودها" Font-Bold="True" Font-Size="12pt"></asp:Label>
             <asp:TextBox ID="txtnamenode" runat="server" Width="20%"></asp:TextBox>


              

             

            <asp:Button ID="Buttonaddlocale" runat="server" Text="اضافة تفرعات جديدة للمنطقة "   OnClick="addbuttonlocale" />
               
                &nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;

                 <asp:DropDownList ID="DropDownList1mantekanode" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server" CssClass="ArabicFont" Width="150px" AutoPostBack="True"></asp:DropDownList>
  



                    </td>
                     </tr>

                </table>
        </div>

     </div>
     </div>



              <br />
              <br />
              <br />




            
        <table class="nav-justified" dir="rtl" border="0" style="-moz-box-align:center">

             <tr>
               <td>
               
                <p>  <asp:Label ID="Label34" runat="server" Text="اضافة مواصفات جديدة للعقار"></asp:Label></p>
                   </td>
                    </tr>



            

                  <tr>
                      <td>


             <asp:Label ID="Label4" runat="server"  Text="ضف نوع عقار  " Font-Bold="True" Font-Size="12pt"></asp:Label>

                   <asp:TextBox ID="txtetypetutorial" runat="server"></asp:TextBox>
                          
                       &nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;    
                    
                          &nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;
         

               
           <asp:Label ID="Label5" runat="server"  Text="ضف  طابق للعقار " Font-Bold="True" Font-Size="12pt"></asp:Label>

               <asp:TextBox ID="TextBox1tabke" runat="server"></asp:TextBox>
                 
                      &nbsp;&nbsp;&nbsp;&nbsp;
                       &nbsp;&nbsp;&nbsp;&nbsp;    
                    
                      &nbsp;&nbsp;&nbsp;&nbsp;
                           &nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="Label6" runat="server"  Text="ضف غرف للعقار   " Font-Bold="True" Font-Size="12pt"></asp:Label>

                     <asp:TextBox ID="TextBox1room" runat="server"></asp:TextBox>
                    
                         &nbsp;&nbsp;&nbsp;&nbsp;
                           &nbsp;&nbsp;&nbsp;&nbsp;    
               
                             &nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;
    
                          <br />
                                  <br />
               

                    </td>
                     </tr>



                      <tr>
                         <td>
                               
          <asp:Label ID="Label7" runat="server"  Text="ضف فرش  للعقار " Font-Bold="True" Font-Size="12pt"></asp:Label>

               <asp:TextBox ID="TextBox1alfarch" runat="server"></asp:TextBox>

                  
                       &nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;    
                    
                         &nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;    

                              
         <asp:Label ID="Label8" runat="server"  Text=" ضف كسوة للعقار " Font-Bold="True" Font-Size="12pt"></asp:Label>

               <asp:TextBox ID="TextBox1alkasa" runat="server"></asp:TextBox>
                 
                        &nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;    
                    
                              &nbsp;&nbsp;&nbsp;&nbsp;
                                 &nbsp;&nbsp;&nbsp;&nbsp;    

                             
              <asp:Label ID="Label13" runat="server"  Text="ضف  الاتجاهات  للعقار  " Font-Bold="True" Font-Size="12pt"></asp:Label>

               <asp:TextBox ID="TextBox1dirction" runat="server"></asp:TextBox>
                       
                  
                             </td>
                                 </tr>





                                <tr>
                                 <td>
                                  <br />
                                       <br /> 

                                     

          <asp:Label ID="Label14" runat="server"  Text="ضف  الملكية للعقار  " Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:TextBox ID="TextBox1havinge" runat="server"></asp:TextBox>

                          &nbsp;&nbsp;&nbsp;&nbsp;
                           &nbsp;&nbsp;&nbsp;&nbsp;    
               
                            &nbsp;&nbsp;&nbsp;&nbsp;
                               &nbsp;&nbsp;&nbsp;&nbsp;
                      
           


       <asp:Label ID="Label15" runat="server"  Text=" ضف اشارات للعقار " Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:TextBox ID="TextBox1refernc" runat="server"></asp:TextBox>

                       &nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;    
                    
                         &nbsp;&nbsp;&nbsp;&nbsp;
                          &nbsp;&nbsp;&nbsp;&nbsp;
                           
                           
      <asp:Label ID="Label16" runat="server"  Text="ضف  حالة الكهرباء  " Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:TextBox ID="TextBox1electron" runat="server"></asp:TextBox>
                           
                         <br />
                            <br />

                            </td>
                              </tr>
                                      



            <tr>
                <td>
                    

            <asp:Label ID="Label27" runat="server"  Text="مصعد كهربا للعقار  " Font-Bold="True" Font-Size="12pt"></asp:Label>
                   <asp:TextBox ID="TextBox1masad" runat="server"></asp:TextBox>

                    
                        &nbsp;&nbsp;&nbsp;&nbsp;
                         &nbsp;&nbsp;&nbsp;&nbsp;    
                    
                            &nbsp;&nbsp;&nbsp;&nbsp;
                               &nbsp;&nbsp;&nbsp;&nbsp;  
                 
                          
              <asp:Label ID="Label28" runat="server"  Text=" خدمات  بناء للعقار  " Font-Bold="True" Font-Size="12pt"></asp:Label>
                            <asp:TextBox ID="TextBox2server" runat="server"></asp:TextBox>

                           

                             
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;  
             
                    &nbsp;&nbsp;&nbsp;&nbsp;
                     &nbsp;&nbsp;&nbsp;&nbsp;  
                    
     
            
      <asp:Button ID="addcountry" runat="server" Text="اضافة مواصفات جديدة" OnClick="addtutorialspublic_Click" />  

                 </td>
                </tr>
      


       </table>              

              
       
/////////////////////

              <br />
              <br />
              <br />


                


              <table class="nav-justified" dir="rtl">
                  
                    <tr>  

                     <td>
                 
         
               
                 
             
              <asp:Label ID="Label9" runat="server"  Text="حدد نوع العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>

             
               <asp:DropDownList ID="DropDownList2tutorialType" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px" ></asp:DropDownList>
              

                                 
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;  
             
                   

       <asp:Label ID="Label17" runat="server"  Text="حدد طابق العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>

          <asp:DropDownList ID="DropDList1tabkk55" AutoPostBack="true"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>
                            
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;  
             
                   

        <asp:Label ID="Label185" runat="server"  Text="حدد غرف العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:DropDownList ID="DropDownList2room"  class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>
                               
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;  
             
                  
                    
       <asp:Label ID="Label195" runat="server"  Text="حدد فرش العقار   " Font-Bold="True" Font-Size="12pt"></asp:Label>

               <asp:DropDownList ID="DropDownList2alfarch" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>
                              
                 
                            
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;  
             
                      <br />
                     <br />


              <asp:Label ID="Label21" runat="server"  Text="حدد اتجاهات العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:DropDownList ID="DropDownList1dirction34" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>
               
                        
                         

                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp; 

              <asp:Label ID="Label22" runat="server"  Text="حدد ملكية العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:DropDownList ID="DropDownList1havinge" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>


             
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp; 
              <asp:Label ID="Label23" runat="server"  Text="حدد اشارات العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>

               <asp:DropDownList ID="DropDownList1refernc" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>


                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Label ID="Label24" runat="server"  Text="حدد حالة كهرباء العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>
               <asp:DropDownList ID="DropDownList1electron" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>


                           

    <br />
   <br />
 <asp:Label ID="Label29" runat="server"  Text="المصعد اللكهربائي " Font-Bold="True" Font-Size="12pt"></asp:Label>
<asp:DropDownList ID="DropDownList1masad" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>
      
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp; 



 <asp:Label ID="Label30" runat="server"  Text="خدمات بناء  " Font-Bold="True" Font-Size="12pt"></asp:Label>
<asp:DropDownList ID="DropDownList1service" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>



         &nbsp;&nbsp;&nbsp;&nbsp;
          &nbsp;&nbsp;&nbsp;&nbsp;  
   
        
          
<asp:Label ID="Label20" runat="server"  Text=" كسوة العقار " Font-Bold="True" Font-Size="12pt"></asp:Label>

     <asp:DropDownList ID="DropDownList1alkasa" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" runat="server"  CssClass="ArabicFont"   Width="150px"></asp:DropDownList>




  </td>
  </tr>
</table>
          


    

     
</div>


 </div>

  

   </div>

   </div>

   </div>
    
  


    
</asp:Content>





