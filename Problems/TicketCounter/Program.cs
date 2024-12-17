using System;
using System.Collections.Generic;

class TicketCounter
{
    static void Main()
    {
        // TODO: Step 1 - Create a queue to hold customer names
        // Hint: Use Queue<string> to store the names in FIFO order.

        // Queue<string> customerQueue = new Queue<string>();

        // TODO: Step 2 - Simulate customers arriving at the ticket counter
        // Hint: Use Enqueue() to add customer names to the queue.

        // Example:
        // customerQueue.Enqueue("Customer 1");
        // customerQueue.Enqueue("Customer 2");

        Console.WriteLine("Serving customers at the ticket counter:\n");

        // TODO: Step 3 - Serve customers in the order they arrived
        // Hint: Use a while loop to check the queue count and Dequeue() to remove customers.
        // Example:
        // while (customerQueue.Count > 0)
        // {
        //     string customer = customerQueue.Dequeue();
        //     Console.WriteLine($"Serving: {customer}");
        // }

        // TODO: Step 4 - Check if the queue is empty
        // Hint: Use customerQueue.Count to confirm no customers are left in the queue.

        // Example:
        // Console.WriteLine("\nAll customers have been served. The queue is empty.");
    }
}
