
public delegate int Emails(string emailAddress);
class Email
{
    public static int SendEmail(string emailAddress)
    {
        Console.WriteLine($"Sending email to {emailAddress}");
        return 0;
    }
}