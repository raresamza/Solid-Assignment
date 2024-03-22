using ConsoleApp1;

var user1 = new User("Alice", "alice@example.com", "+123456789");
var user2 = new User("Bob", "bob@example.com", "+987654321");

var notificationService = new NotificationService();

Console.WriteLine("Choose a notification channel (Email, SMS, Push):");
string channelStr = Console.ReadLine();
if (Enum.TryParse(channelStr, true, out NotificationChannel channel))
{
    Console.WriteLine("Enter your message:");
    string message = Console.ReadLine();

    user1.SendNotification(user2, notificationService, channel, message);
}
else
{
    Console.WriteLine("Invalid notification channel.");
}
