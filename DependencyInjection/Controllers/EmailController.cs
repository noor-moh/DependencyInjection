using DependencyInjection.EmailService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    [Route("api/email")]
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;

        }
        [HttpPost("send")]
        public void Send(string message, string receiver)
        {
            Client cA = new Client(_emailService);
            cA.SendEmail(message, receiver);

            /// ====> using new 
            /// 
            PostmarkService r1 = new PostmarkService();
            Client cA1 = new Client(r1);
            cA1.SendEmail(message, receiver);

            PostmarkService r2 = new PostmarkService();
            Client cA2 = new Client();
            cA2.AssignEmailService(r2);
            cA2.SendEmail(message, receiver);
        }
    }
}
