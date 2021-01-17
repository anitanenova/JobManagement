namespace JobManagement.Models.Settings
{
    public class EmailServerSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string SMTPUserName { get; set; }
        public string SMTPPassword { get; set; }
        public bool EnableSsl { get; set; }
        public bool UseDefaultCredentials { get; set; }
        public int Timeout { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
    }
}