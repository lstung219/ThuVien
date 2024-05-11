using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3Layer.BUS.Helper
{
    public class MailHelper
    {
        private readonly SmtpClient _smtp;
        private const string SMTP_USER = "squirrel.io.vn@gmail.com";
        private const string SMTP_PASSWORD = "cshs wjoy sqev npwy";

        public MailHelper()
        {
            _smtp = new SmtpClient()
            {

                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(SMTP_USER, SMTP_PASSWORD),
                DeliveryMethod = SmtpDeliveryMethod.Network,
            };
        }

        /// <summary>
        /// Send mail
        /// </summary>
        /// <param name="message">message</param>
        /// <returns></returns>
        public bool SendMail(MailMessage message)
        {
            try
            {
                _smtp.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi gửi mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
