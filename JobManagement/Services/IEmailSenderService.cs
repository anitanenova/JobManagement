namespace JobManagement.Services
{
    using System.Threading.Tasks;
    using BusinessManagement.Services.Model;

    public interface IEmailSenderService
    {
        Task SendAsync(Email emailToSend);
        string GetEmailBody(string link, string msg, string subHeader, string header);
    }
}