#region Includes 
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Text;
using System;
using System.Runtime.InteropServices;
using Desafio.TecnicoLLip.Application.Utils;
#endregion

namespace Desafio.TecnicoLLip.Application.Services
{
    public class EmailAppService : IDisposable, IEmailAppService
    {
        #region Properties dispose
        private bool isDisposed { get; set; }
        private IntPtr nativeResource = Marshal.AllocHGlobal(100);
        #endregion

        private SmtpMail SmtpMail { get; set; }
        public IConfiguration Configuration { get; set; }
        public EmailAppService(IConfiguration configuration)
        {
            SmtpMail = new SmtpMail();
            Configuration = configuration;

            new ConfigureFromConfigurationOptions<SmtpMail>(
                Configuration.GetSection("SmtpMailConfiguraions")
            )
            .Configure(SmtpMail);
        }

        #region IDisposable Support
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
               //((IDisposable)SmtpMail)?.Dispose();
            }

            if (nativeResource != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativeResource);
                nativeResource = IntPtr.Zero;
            }

            isDisposed = true;
        }

        ~EmailAppService()
        {
            Dispose(false);
        }
        #endregion

        public void SendEmail(Logger logger)
        {
            using SmtpClient client = new SmtpClient(SmtpMail.Provider, SmtpMail.Port);
            MailMessage mailMessage = Constructor.Create<MailMessage>
            (x => {
                x.From = new MailAddress(SmtpMail.From, SmtpMail.Alias);
                x.BodyEncoding = Encoding.UTF8;
                x.Body = logger.Mesage;
                x.Subject = SmtpMail.Subject;
                x.IsBodyHtml = SmtpMail.IsBodyHtml;
                x.To.Add(SmtpMail.To);
            }); 
            client.Send(mailMessage);
        }
    }
}
