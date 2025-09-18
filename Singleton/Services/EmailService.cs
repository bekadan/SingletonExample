using System;

namespace ComplexSingletonExample.Services
{
    public class EmailService
    {
        public void PrintSmtpServer()
        {
            var smtp = ConfigManager.Instance.GetSetting("SmtpServer");
            Console.WriteLine($"[EmailService] Sending emails through: {smtp}");
        }
    }
}
