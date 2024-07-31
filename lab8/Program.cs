using System;
// Define a delegate for the event
delegate void SimpleEventHandler(string message);
class Publisher
{
    // Declare an event using the delegate; it can be null
    public event SimpleEventHandler? SimpleEvent;

    // Method to trigger the event
    public void RaiseEvent(string message)
    {
        // Safely invoke the event if it has subscribers
        SimpleEvent?.Invoke(message);
    }
}
class Program
{
    static void Main()
    {
        // Create an instance of Publisher
        Publisher publisher = new Publisher();
        // Subscribe to the event with a lambda expression
        publisher.SimpleEvent += message => Console.WriteLine("Event received: " + message);
        // Trigger the event
        publisher.RaiseEvent("Hello, world!");
    }
}
