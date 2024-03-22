using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PushNotification : INotification
    {
        public void SendNotification(User recipient, string message)
        {
            Console.WriteLine($"Sending push notification to {recipient.Username}: {message}");
        }
    }
}
