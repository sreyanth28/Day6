using System;

class Program
{
    static void Main(string[] args)
    {
        // Create processor
        OrderProcessor processor = new OrderProcessor();

        // Create services
        EmailService emailService = new EmailService();
        SMSService smsService = new SMSService();
        LoggerService loggerService = new LoggerService();

        // Subscribe to event (Multicast delegate)
        processor.OnOrderPlaced += emailService.SendEmail;
        processor.OnOrderPlaced += smsService.SendSMS;
        processor.OnOrderPlaced += loggerService.LogOrder;

        // Create order
        Orders order = new Orders
        {
            OrderId = 101,
            CustomerName = "John",
            Amount = 5000
        };

        // Process order
        processor.ProcessOrder(order);

        // BONUS: Unsubscribe example
        Console.WriteLine("\n--- After Unsubscribing SMS ---");
        processor.OnOrderPlaced -= smsService.SendSMS;

        processor.ProcessOrder(order);

        Console.ReadLine();
    }
}