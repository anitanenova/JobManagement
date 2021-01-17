namespace BusinessManagement.Services.Model
{
    public class Email
    {
        public string SenderEmail { get; set; }
        public string RecipientEmail { get; set; }
        public string SenderName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string RecipientName { get; set; }
        public bool IsBodyHTML { get; set; }
    }
}
