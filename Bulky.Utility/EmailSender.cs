
using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Utility {
    public class EmailSender : IEmailSender
    {

        public Task SendEmailAsync(string email, string subject, string htmlMessage) {
            //logic to send email



            var from = new EmailAddress("hello@dNTT.com", "Product buy");
            var to = new EmailAddress(email);
            var message = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);

            return Task.CompletedTask;


        }
    }

    public interface IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage);
        
        }
}

