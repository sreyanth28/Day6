
using System;
Notify n=Notification.SendEmail;
int res=n("Hello World");
Console.WriteLine("email sent:"+res);
n=Notification.SendSms;
int res1=n("Hello World");
Console.WriteLine("sms sent:"+res1);
