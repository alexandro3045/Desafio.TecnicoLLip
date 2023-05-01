namespace Desafio.TecnicoLLip.Domain.Models.Utility
{
    public class SmtpMail
    {
        public string Subject { get; set; } = "Integração LLip";
        public bool IsBodyHtml { get; set; } = true;
        public string Provider { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
        public string From { get; set; }
        public string Alias { get; set; }
        public string To { get; set; }
    }
}
