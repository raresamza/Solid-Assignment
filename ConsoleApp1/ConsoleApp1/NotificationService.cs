using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NotificationService
    {
        private readonly Dictionary<NotificationChannel, INotification> _channels;

        public NotificationService()
        {
            _channels = new Dictionary<NotificationChannel, INotification>
        {
            { NotificationChannel.Email, new EmailNotification() },
            { NotificationChannel.SMS, new SMSNotification() },
            { NotificationChannel.Push, new PushNotification() }
        };
        }

        public void SendNotification(User recipient, NotificationChannel channel, string message)
        {
            if (_channels.TryGetValue(channel, out INotification notificationChannel))
            {
                notificationChannel.SendNotification(recipient, message);
            }
            else
            {
                Console.WriteLine("Invalid notification channel.");
            }
        }
    }
}
