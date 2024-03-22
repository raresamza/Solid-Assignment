using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string Username { get; }
        public string Email { get; }
        public string PhoneNumber { get; }

        public User(string username, string email, string phoneNumber)
        {
            Username = username;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void SendNotification(User recipient, NotificationService notificationService, NotificationChannel channel, string message)
        {
            notificationService.SendNotification(recipient, channel, message);
        }
    }
}
