using System;

public class OrderProcessor
{
    // Delegate
    public delegate void OrderPlacedHandler(Orders order);

    // Event
    public event OrderPlacedHandler OnOrderPlaced;

    // Process Order
    public void ProcessOrder(Orders order)
    {
        Console.WriteLine($"Order Placed: {order.OrderId}");

        // Null-safe event invocation
        OnOrderPlaced?.Invoke(order);
    }
}