using System;

namespace Odev09_EmailDraft.Models
{
    public class EmailDraft
    {

        public String To { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }
        public bool IsSent { get; private set; }

        public EmailDraft(string to, string subject, string body, bool isSent = false)
        {
            To = to;
            Subject = subject;
            Body = body;
            IsSent = isSent;
        }
        public void UpdateBody(string newBody)
        {
            if (!IsSent)
            {
                Body = newBody;
            }
            else
            {
                Console.WriteLine("Email zaten gönderildiği için içeriği güncelleyemezsiniz.");
            }
        }

        public void Send()
        {
            if (!string.IsNullOrEmpty(To) && !string.IsNullOrEmpty(Subject))
            {
                IsSent = true;
                Console.WriteLine("Email başarıyla  gönderildi.");
            }
            else
            {
                Console.WriteLine("Email gönderilemedi. Alıcı ve Konu alanları boş olamaz.");
            }
        }

    }
}