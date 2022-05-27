using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS
{
    internal class emailClass
    {
        public void sendEmail(String to,String subjecet, String body)
        {
            String from = "shenalakalanka513@gmail.com";
            String psw = "Diologb@34";  
            MailMessage msg = new MailMessage();
            msg.To.Add(to);
            msg.From = new MailAddress(from);
            msg.Body = "From : " + "<br>Message: " + body;
            msg.Subject = subjecet;
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, psw);

            try
            {
                smtp.Send(msg);
                DialogResult code = MessageBox.Show("Email sent successfully", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (code == DialogResult.OK)
                {

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
