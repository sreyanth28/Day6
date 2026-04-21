using System;

// Step 1: Publisher
public class NewsAgency
{
    // Event (delegate)
    public event Action<string, string> NewsPublished;

    // Step 3: Subscribe
    public void Subscribe(Action<string, string> subscriber)
    {
        NewsPublished += subscriber;
    }

    // Optional: Unsubscribe
    public void Unsubscribe(Action<string, string> subscriber)
    {
        NewsPublished -= subscriber;
    }

    // Step 4: Publish
    public void Publish(string topic, string news)
    {
        Console.WriteLine($"\n[Agency] Publishing {topic} news...");
        NewsPublished?.Invoke(topic, news);
    }
}

// Step 2: Subscriber
public class Reader
{
    public string Name { get; set; }
    public string InterestedTopic { get; set; }

    public Reader(string name, string topic)
    {
        Name = name;
        InterestedTopic = topic;
    }

    // Method to receive notification
    public void ReceiveNews(string topic, string news)
    {
        if (topic == InterestedTopic)
        {
            Console.WriteLine($"{Name} received {topic} news: {news}");
        }
    }
}

// Step 5: Main
class Program
{
    static void Main()
    {
        NewsAgency agency = new NewsAgency();

        Reader r1 = new Reader("Alice", "Sports");
        Reader r2 = new Reader("Bob", "Politics");
        Reader r3 = new Reader("Charlie", "Entertainment");

        // Subscribe
        agency.Subscribe(r1.ReceiveNews);
        agency.Subscribe(r2.ReceiveNews);
        agency.Subscribe(r3.ReceiveNews);

        // Publish news
        agency.Publish("Sports", "India won the match!");
        agency.Publish("Politics", "New policy announced.");
        agency.Publish("Entertainment", "New movie released.");
    }
}