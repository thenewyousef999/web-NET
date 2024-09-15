using DBManager;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Services;
using ALATLAS.classes;

namespace ALATLAS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        ///////////////////////////////////////////////
        ///

        [WebMethod(MessageName = "OpenAccount", Description = "This method create new account  in the database")]
        [System.Xml.Serialization.XmlInclude(typeof(ReturnError))]
        public ReturnError openAccount(string FullName, string UserName, String Password, Boolean AccountType, string EmailAdrress)
        {
            ReturnError error = new ReturnError();

            //  dataTable = DBop.NewConectionDLL.SelectDataSet("Admins", " * " ).Tables[0];
            /////send email to new account=========================================================
            // System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            // mail.To.Add(EmailAdrress);
            // mail.From = new MailAddress( "webmaster@alrubaye.com" , "Email head", System.Text.Encoding.UTF8);
            // mail.Subject = "Complete your final steps with  my phone locations";
            //mail.SubjectEncoding = System.Text.Encoding.UTF8;
            //  for (int i = 0; i < dataTable.Rows.Count; i++) { 

            string smtpAddress = "mail.alrubaye.com";
                int portNumber = 25;
                bool enableSSL = false;

                string emailFrom = "webmaster@alrubaye.com";
                string password = "abc3551356";
                string emailTo = "lonasamerekal199@gmail.com";
                string subject = "Welcome in my phone location system";
                string body = "Thank you for using my phone locations system \n" + "  \n Your account  now ready to be used.  please setup this app from google play on your phone \n" + "https://play.google.com/store/apps/details?id=phonelocation.example.asuss550c.phonelocation" + "\nThen from setting login with your user name and password." + "And enjoy." + "Best regards,";

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

            return error;


        }

    }
}
