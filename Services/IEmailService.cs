using Azure.Messaging.ServiceBus;
using EmailProviderOntraix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProviderOntraix.Services;

public interface IEmailService
{
    bool SendEmail(EmailRequest emailRequest);
    EmailRequest UnpackEmailRequest(ServiceBusReceivedMessage message);
}

