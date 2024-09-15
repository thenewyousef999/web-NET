<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminloign.aspx.cs" Inherits="ALATLAS.adminloign" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
 <script type="text/javascript">

     function adminaccount() {





     }





     function ShowModalError() {

         $("#DivMessagePaneldanger").addClass('alert alert-danger');
         $('#ModalMessagerror').modal('show');
         window.setTimeout(HideModal, 1000);

         alert("الايميل او كلمة المرور غير صحيحة");
     }





 </script>



    

           <asp:Label ID="Label3" runat="server"  Text="اسم الاول" Font-Bold="True" Font-Size="12pt" Visible="false"></asp:Label>
       <asp:TextBox ID="txtFirstNam" runat="server" Text="" MaxLength="60"  Width="30%" Visible="false"  class="form-control " onkeypress="return isokmaxlength(event,this,70);"  placeholder=" First Nname"   ReadOnly="False "  AutoCompleteType="HomeFax"></asp:TextBox>
             
                      <% //  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFirstNam" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator> %>
     


             <br />


      <asp:Label ID="LaStudentName15" runat="server"  Text="اسم العائلة" Font-Bold="True" Font-Size="12pt" Visible="false"></asp:Label>
                  
       <asp:TextBox ID="txtMiddleName" runat="server" MaxLength="25" Text="" class="form-control " Visible="false"  placeholder=" Family Name"  Width="30%" onkeypress="return isokmaxlength(event,this,70);" ></asp:TextBox>
                                         <% //  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMiddleName" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator>  %>

              


    
   <asp:Label ID="Label6" runat="server"   Text=" رقم الموبايل" Font-Bold="True" Font-Size="12pt" Visible="false"></asp:Label>
   <asp:TextBox ID="phone" runat="server" class="form-control " MaxLength="50" Text="" Visible="false"  placeholder=" رقم الموبايل" onkeypress="return isokmaxlength(event,this,15);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="30%"></asp:TextBox>
                                              <% //    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="suchpass" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator> %>
         
<br />
<br />
              
   <asp:Label ID="Label76" runat="server"   Text="  رقم التلفون" Font-Bold="True" Font-Size="12pt" Visible="false"></asp:Label>
   <asp:TextBox ID="phonehome"  runat="server" class="form-control " MaxLength="50" Text="" Visible="false"  placeholder=" رقم التلفون" onkeypress="return isokmaxlength(event,this,15);"  meta:resourcekey="txtStudentNameResource1" TextMode="Number" Width="30%"></asp:TextBox>
                                              <% //    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="suchpass" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator> %>
















    <asp:Label ID="Label1" runat="server" Text="browserid" Visible="false"></asp:Label>

    <asp:TextBox ID="browserid" runat="server" Visible="false" ></asp:TextBox>
   
   <div class="container">
 
       <br />
  <div class="row">
       <div class="col-md-3">
           <h1> </h1>      
    <p> </p>  
           </div>
    <div class="col-md-3">
  
                 
                     <div class="panel panel-default" style="Width:499px">
      <div class="panel-heading">Admin and client Login</div>
      <div class="panel-body">
          <p>This Page is only for authorized who attend the tutorial they could see their solde and rice and take.</p>  
                    <div id="LoginAdmin">


                        <table class="auto-style6">
                            <tr>
                                <td class="auto-style7">
                               
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style7" colspan="2">



                                       <div class="alert alert-danger" id="theDiv" runat="server">
                                              <asp:Literal ID="LiMessage" Text="<strong>Warning!</strong> Indicates a warning that might need attention." runat="server"></asp:Literal>  
                                          </div>
                                  




                             <div style="text-align:center ">
                                 


                                 



    

                             </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">
                                    <asp:Label ID="LaStudentName0" runat="server" CssClass="bold" Font-Size="18pt" meta:resourcekey="LaStudentNameResource1" Text="User Email"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style7">
                                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                    <asp:TextBox ID="txtUserName" runat="server" placeholder="Enter Your Email or phone"  onkeypress="return isokmaxlength(event,this,100);"  class="form-control input-lg" MaxLength="50" meta:resourcekey="txtStudentNameResource1" Width="400px" TextMode="Email" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>

                                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserName" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator>
     <asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" 
      ControlToValidate="txtUserName" Display="Dynamic" 
      ErrorMessage="Email isnot vaild" ForeColor="Red" 
    ValidationExpression ="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"></asp:RegularExpressionValidator>
           </td>
                                
                                </tr>

                            <tr>
                                <td>
                                    <asp:Literal ID="Literal4" runat="server"></asp:Literal>
                                     <asp:TextBox ID="Textusernameupdate" runat="server" placeholder="Enter Your Email or phone"  onkeypress="return isokmaxlength(event,this,100);"  class="form-control input-lg" MaxLength="50" meta:resourcekey="txtStudentNameResource1" Width="400px" TextMode="Email" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>

                                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textusernameupdate" ErrorMessage="User name is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator>

    
 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
   ControlToValidate="Textusernameupdate" Display="Dynamic" 
   ErrorMessage="Email isnot vaild" ForeColor="Red" 
 ValidationExpression ="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"></asp:RegularExpressionValidator>
        </td>
          
                            </tr>

                            <tr>
                                <td class="auto-style7">
                                    <asp:Label ID="LaStudentName1" runat="server" CssClass="bold" Font-Size="18pt" meta:resourcekey="LaStudentNameResource1" Text="Password"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style7">
                                    <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                                    <asp:TextBox ID="txtPassword" runat="server" class="form-control input-lg" placeholder="Enter your password now" onkeypress=" return isokmaxlength(event,this,30);"  MaxLength="50" meta:resourcekey="txtStudentNameResource1" TextMode="Password" Width="400px" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>

                                   
                                </td>

                                </tr>
                            <tr>

                                <td>
                                    <asp:Literal ID="Literal5" runat="server"></asp:Literal>
                               <asp:TextBox ID="Textpassupdate" runat="server" class="form-control input-lg" placeholder="Enter your password new" onkeypress=" return isokmaxlength(event,this,30);"  MaxLength="50" meta:resourcekey="txtStudentNameResource1" TextMode="Password" Width="400px" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
                                    
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Textpassupdate" ErrorMessage="password is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator>

                                   </td>
                                </tr>
                            <tr>
                                  <td>
                                <asp:Literal ID="Literal6" runat="server"></asp:Literal>
                                <asp:TextBox ID="TextBox1suchpass" runat="server" class="form-control input-lg" placeholder="Enter your password new" onkeypress=" return isokmaxlength(event,this,30);"  MaxLength="50" meta:resourcekey="txtStudentNameResource1" TextMode="Password" Width="400px" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
                                      <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="كلمة المرور اغير مطابقة" ControlToValidate="TextBox1suchpass" ForeColor="Red" ControlToCompare="Textpassupdate" Operator="Equal"></asp:CompareValidator>

                                         
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox1suchpass" ErrorMessage="password is required field" ForeColor="#FF0066" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator>


                                  </td>

                                </tr>
                            <tr>
                                <td>

                                <br />
                                    

                             <div class="alert alert-danger" id="Div2" runat="server" >
                                <asp:Literal ID="Literal3"  Text=" <strong>warning</strong>th email or password is not correct " runat="server"  ></asp:Literal>  
              
                                 </div>


                                </td>
                            </tr>
                            <tr>
                                
                                <td style="text-align:right ">
                                    <br />
    <a href="adminloign.aspx?chang=update"> change my ACCount </a> 
<br />

                                </td>
                               
                            </tr>





                            
                            <tr>
                                <td class="auto-style7">
                                    <asp:Button ID="BuAddData" runat="server" class="btn btn-success"     Height="39px" ToolTip="Click to login"     Text="login" Width="111px" OnClick="BuAddData_Click1" />
                                    
                                    <asp:Button ID="Button1update" runat="server" class="btn btn-success"     Height="39px" ToolTip="Click to update"     Text="update" Width="111px" OnClick="updateData_Click1" />
                                   
                                </td>

                   
                                </tr>
                           
                              
                     <tr>
                         <td>
<a href="adminloign.aspx"><span class="glyphicon glyphicon-log-in"></span> صفحة تسجيل الدخول</a>

                             </td>
                         </tr>


                           

                          

                                                        <tr>

                                 <td>&nbsp; &nbsp;  <br /><br /></td>


 


             <td class="auto-style7">
<asp:Button ID="Button1" runat="server" class="btn btn-success"     Height="39px" ToolTip="الذهاب للحساب العام"     Text="الذهاب  للحساب العام" Width="200px" OnClick="toindex_Click1" />
</td>
                             

                            </tr>




                            <tr>
                                    <td>
                
                                    </td>
                                </tr>
                     
                        </table>

                        <asp:TextBox ID="mastrid9" runat="server" Visible="false"></asp:TextBox>
  
                    </div>
               </div>
    </div>
        <asp:HiddenField ID="HFMAC" runat="server" />
        </div>
           </div>
             </div>



</asp:Content>
