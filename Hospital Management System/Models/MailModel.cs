namespace Hospital_Management_System.Models
{
    public class MailModel
    {

        public MailModel(string From, string To, string Subject, string Body)
        {
            this.From = From;
            this.To = To;
            this.Subject = Subject;
            this.Body = Body;
        }

        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
