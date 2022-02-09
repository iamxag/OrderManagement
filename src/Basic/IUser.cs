using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password);
    }
    interface LoggingService
    {
        void LogError(string message);
    }
    interface EmailService
    {
        bool SendEmail(string email);
    }
}
