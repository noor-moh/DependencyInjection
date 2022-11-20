using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.EmailService
{
    public interface IEmailService
    {
        void SendEmail(string message, string receiver);
    }
}
