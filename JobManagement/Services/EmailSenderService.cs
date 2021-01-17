namespace JobManagement.Services
{
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using System.Threading.Tasks;
    using BusinessManagement.Services.Model;
    using Microsoft.Extensions.Options;
    using Models.Settings;

    public class EmailSenderService : IEmailSenderService
    {
        private readonly EmailServerSettings _emailServerSettings;
        public EmailSenderService(IOptions<EmailServerSettings> emailServerSettings)
        {
            _emailServerSettings = emailServerSettings.Value;
        }

        public string GetEmailBody(string link, string msg, string subHeader, string header)
        {
            var builder = new StringBuilder();
            string openTags = "<div>" +
                                "<table>" +
                                "<tbody>";
            string closeTags = "</tbody>" +
                                "</table>" +
                                "</div>";
            string body1 = "<tr>" +
                                    @"<td style=""padding:0; font-family:'Segoe UI Semibold','Segoe UI Bold','Segoe UI','Helvetica Neue Medium',Arial,sans-serif; font-size:17px; color:#707070"">"+ header + "</td>" +
                                "</tr>";
            string body2 = "<tr>" +
                                    @"<td style=""padding:0;font-family:'Segoe UI Light','Segoe UI','Helvetica Neue Medium',Arial,sans-serif;font-size:41px;color:#2672ec"">"+subHeader+"</td>" +
                                "</tr>";
            string body3 = "<tr>" +
                                    @"<td style=""padding:0; padding-top:25px; font-family:'Segoe UI',Tahoma,Verdana,Arial,sans-serif; font-size:14px; color:#2a2a2a"">" +
                                    $"{msg} <a href='{link}'>{link}</a></td>" +
                                "</tr>";
            string body4 = "<tr>" +
                                    @"<td style=""padding:0; padding-top:25px; font-family:'Segoe UI',Tahoma,Verdana,Arial,sans-serif; font-size:14px; color:#2a2a2a"">Thanks,</td>" +
                                "</tr>";
            string body5 = "<tr>" +
                                    @"<td style=""padding:0; font-family:'Segoe UI',Tahoma,Verdana,Arial,sans-serif; font-size:14px; color:#2a2a2a"">Hydra Corp team</td>" +
                                "</tr>";

            builder.Append(openTags);
            builder.Append(body1);
            builder.Append(body2);
            builder.Append(body3);
            builder.Append(body4);
            builder.Append(body5);
            builder.Append(closeTags);

            return builder.ToString();
        }

        public async Task SendAsync(Email emailToSend)
        {
            if (string.IsNullOrEmpty(emailToSend.SenderName))
            {
                emailToSend.SenderName = _emailServerSettings.SenderName;
            }

            if (string.IsNullOrEmpty(emailToSend.SenderEmail))
            {
                emailToSend.SenderEmail = _emailServerSettings.SenderEmail;
            }

            var fromAddress = new MailAddress(emailToSend.SenderEmail, emailToSend.SenderName);
            var toAddress = new MailAddress(emailToSend.RecipientEmail, emailToSend.RecipientName);

            var client = new SmtpClient
            {
                Host = _emailServerSettings.Host,
                Port = _emailServerSettings.Port,
                EnableSsl = _emailServerSettings.EnableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = _emailServerSettings.UseDefaultCredentials,
                Credentials = new NetworkCredential(
                    _emailServerSettings.SMTPUserName,
                    _emailServerSettings.SMTPPassword),
                Timeout = _emailServerSettings.Timeout,
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = emailToSend.Subject,
                SubjectEncoding = Encoding.GetEncoding(65000),
                Body = emailToSend.Body,
                IsBodyHtml = emailToSend.IsBodyHTML,
            })
            {
                await client.SendMailAsync(message);
            }
        }
    }
}