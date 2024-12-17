using System;
using System.Collections.Generic;

class TicketCounter
{
    static void Main()
    {
        // Create a queue to hold customer names
        Queue<string> customerQueue = new Queue<string>();

        // Simulate customers arriving at the ticket counter
        customerQueue.Enqueue("Customer 1");
        customerQueue.Enqueue("Customer 2");
        customerQueue.Enqueue("Customer 3");
        customerQueue.Enqueue("Customer 4");

        Console.WriteLine("Serving customers at the ticket counter:\n");

        // Serve customers in the order they arrived
        while (customerQueue.Count > 0)
        {
            string customer = customerQueue.Dequeue();
            Console.WriteLine($"Serving: {customer}");
        }

        // Check if the queue is empty
        Console.WriteLine("\nAll customers have been served. The queue is empty.");
    }
}
