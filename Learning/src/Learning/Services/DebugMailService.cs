using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Learning.Services
{
    public class DebugMailService : IMailService
    {
        public bool SendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending mail: To: {to}, Subject: {subject}");
            return true;
            //throw new NotImplementedException();
        }
    }
}
