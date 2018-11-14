using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace barcobus
{
    public class EmailException
    {




        public EmailException(logItem e) {
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("barcobus.noreply@gmail.com");
                msg.To.Add("joaquin@peraza.uy");
                msg.To.Add("pedetchem@gmail.com");
                msg.Subject = "El encargado "+e.Encargado.Nombre+" ha intentado violar el sistema";
                msg.Body = "Se adjunta la informacion de la excepcion: \n"+e.ToString();

                //msg.Attachments.Add(new Attachment(attachedFile)); 

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "barcobus.noreply@gmail.com";
                ntcd.Password = "BarcoBus123";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                //MessageBox.Show("Your Mail is sended");  

            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);  
            }  
        }
    }
}