<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login out.aspx.cs" Inherits="ALATLAS.login_out" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
        <script>
            $(document).Ready(function () {
                $(".nav-tabs a").Click(function () {
                    $(this).tab('show');
                });
            });
            // stop typing word after max number
            function isokmaxlength(e, val, maxlengt) {
                var charCode = (typeof e.which == "number") ? e.which : e.keyCode
                //  alert('hi');
                if (!(charCode == 44 || charCode == 46 || charCode == 0 || charCode == 8 || (val.value.length < maxlengt))) {
                    return false;
                }
            }

            function isokpass(e, val, pval)
            {
                var charCode = (typeof e.which == "number") ? e.which : e.keyCode
                if (val.value != pval.value)
                    return alert("كلمة المرور غير مطابقة لحقل التاكيد ");

            }



            function BuAddData_Click() {

                alert("welcom ");

            }

          



        </script>












    

    <div class="container" dir=   "rtl" >
  
  <div class="panel-group">
    

    <div class=" panel-primary class">
      <div class="panel-heading" style="text-align:center ">    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="20" 
                       Text="يرجى اضافة البيانات الصحيحة "></asp:Label> </div>
      <div class="container"> 
          <br />
          <div class="row"  dir="rtl"  >

             
    


          
              
                                       <div class="alert alert-danger" id="theDiv" runat="server">
                                              <asp:Literal ID="LiMessage" Text="<strong>Warning!</strong> يرجى اضافة الحقول جميعا." runat="server"></asp:Literal>  
                                          </div>
                                  


                   <asp:Label ID="Label3" runat="server"  Text="اسم الاول" Font-Bold="True" Font-Size="12pt"></asp:Label>
                    <asp:TextBox ID="txtFirstNam" runat="server" Text="" MaxLength="60"  Width="30%"  class="form-control " onkeypress="return isokmaxlength(event,this,70);"  placeholder=" First Nname"   ReadOnly="False "  AutoCompleteType="HomeFax"></asp:TextBox>
             
                      <% //  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFirstNam" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator> %>
     


             <br />


                   <asp:Label ID="LaStudentName15" runat="server"  Text="اسم العائلة" Font-Bold="True" Font-Size="12pt"></asp:Label>
                  
       <asp:TextBox ID="txtMiddleName" runat="server" MaxLength="25" Text="" class="form-control "  placeholder=" Family Name"  Width="30%" onkeypress="return isokmaxlength(event,this,70);" ></asp:TextBox>
                                         <% //  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMiddleName" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator>  %>

              
              
               
                

                  <br />
             

               <br />
  <asp:Label ID="Label5" runat="server"   Text="ايميل" Font-Bold="True" Font-Size="12pt"></asp:Label>
                       <asp:TextBox ID="txtEmail" runat="server"  MaxLength="50"  placeholder="outlook.com/gmail.com@ "  class="form-control " onkeypress="return isokmaxlength(event,this,100);"  meta:resourcekey="txtStudentNameResource1" Width="50%"></asp:TextBox>
                                         <% //  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator> %>
                        
           <br />

                     <br />
              
              



               <br />

               <asp:Label ID="Label2" runat="server"   Text="كلمة المرور" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="browserpass" runat="server"  MaxLength="50" Text=""  placeholder=" Password" class="form-control " onkeypress=" return isokmaxlength(event,this,30);"  meta:resourcekey="txtStudentNameResource1"  TextMode="Password" Width="30%"></asp:TextBox>
                                               <%   // <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="browserpass" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator> %>

 <br />

<br />

                            <asp:Label ID="Label4" runat="server"   Text="تاكيد كلمة المرور" Font-Bold="True" Font-Size="12pt"></asp:Label>
   <asp:TextBox ID="suchpass" runat="server" class="form-control " MaxLength="50" Text=""  placeholder=" Password" onkeypress=" return isokmaxlength(event,this,30);"  meta:resourcekey="txtStudentNameResource1" TextMode="Password" Width="30%"></asp:TextBox>
              <br />
              <br />


               <div class="alert alert-danger" id="Div2" runat="server">
                 <asp:Literal ID="Literal3"  Text="<strong>Warning!</strong> كلمة المرور غير مطابقة لحقل التاكيد." runat="server" ></asp:Literal>  
              
             </div>
      <br />        
                            <asp:Label ID="Label6" runat="server"   Text=" رقم الموبايل" Font-Bold="True" Font-Size="12pt"></asp:Label>
   <asp:TextBox ID="phone" runat="server" class="form-control " MaxLength="50" Text=""  placeholder=" رقم الموبايل" onkeypress="return isokmaxlength(event,this,15);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="30%"></asp:TextBox>
                                              <% //    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="suchpass" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator> %>
         
<br />
<br />
              
                            <asp:Label ID="Label7" runat="server"   Text="  رقم التلفون" Font-Bold="True" Font-Size="12pt"></asp:Label>
   <asp:TextBox ID="phonehome" runat="server" class="form-control " MaxLength="50" Text=""  placeholder=" رقم التلفون" onkeypress="return isokmaxlength(event,this,15);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="30%"></asp:TextBox>
                                              <% //    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="suchpass" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator> %>
         
<br />
              





              <br />
                    <asp:Button ID="BuAddDatabrowser" runat="server"  class="btn btn-success"  Visible="false"   onclick="  BuAddData_Click" Text="سجل الان" Height="37px" Width="98px" />

                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" />
           <br />

 &nbsp;&nbsp;
 &nbsp;&nbsp;

              <br />
              <br />


               &nbsp;&nbsp;    
    <br />


           
              

              





    
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

         <asp:Literal ID="Literal1" Text="<strong>Warning!</strong> يرجى اضافة الحقول جميعا." runat="server" ></asp:Literal>  
             <a href="#" class="close" data-dismiss="modal" aria-label="close">&times;</a>
      </div>
                                  
     

  </div>
    </div>


              
            


              



               



    </div>
          </div>
              </div>
                 </div>
                   </div>











</asp:Content>
