using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.EmailService
{

    public class Client
    {
        private IEmailService _service;

        public IEmailService Service
        {
            set
            {
                _service = value;
            }
        }

        public Client(IEmailService service)
        {
            _service = service;
        }
        public Client()
        {
        }
        public void AssignEmailService(IEmailService service)
        {
            _service = service;
        }

        public void SendEmail(string message, string receiver)
        {
            _service.SendEmail(message, receiver);
        }
    }
}
