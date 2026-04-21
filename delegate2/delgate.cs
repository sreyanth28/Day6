using System;

    delegate int Notify(string message);
    public class Notification
    {
        public static int SendEmail(string message)
        {
        Console.WriteLine("Email sent: " + message);
        return 1; 
    }
        public static int SendSms(string message)
        {
        Console.WriteLine("SMS sent: " + message);
        return 2; 
    }
    }

