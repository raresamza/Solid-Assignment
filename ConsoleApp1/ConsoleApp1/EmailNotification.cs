using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmailNotification : INotification
    {
        public void SendNotification(User recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient.Email}: {message}");
        }
    }
}
