# Queue Tutorial

## Welcome to the Queue Module

Welcome to the first module of the Data Structure Tutorial! In this module, we will dive into the concept of **queues**. Queues are an essential tool for solving various problems efficiently.

### What is a Queue?

A **queue** is a linear data structure that follows the **First-In-First-Out (FIFO)** principle. This means that the first element added to the queue is the first one to be removed. Think of it as a real-life queue, like waiting in line for a movie ticket: the first person in line is served first.

### Purpose of a Queue

Queues are used to manage data in scenarios where order matters. Common use cases include:

- Scheduling tasks (e.g., printer queue).
- Managing requests in web servers.
- Breadth-first search in graph algorithms.

### Performance of a Queue

| Operation      | Time Complexity |
|----------------|-----------------|
| Enqueue (add)  | O(1)            |
| Dequeue (remove) | O(1)          |
| Peek (front)   | O(1)            |
| IsEmpty        | O(1)            |

#### Example Code: Basic Queue Operations


```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a queue of strings
        Queue<string> queue = new Queue<string>();

        // Enqueue elements
        queue.Enqueue("Alice");
        queue.Enqueue("Bob");
        queue.Enqueue("Charlie");

        Console.WriteLine("Front of the queue: " + queue.Peek());

        // Dequeue elements
        while (queue.Count > 0)
        {
            Console.WriteLine("Dequeued: " + queue.Dequeue());
        }

        // Check if the queue is empty
        Console.WriteLine("Is the queue empty? " + (queue.Count == 0));
    }
}
```

### Solving a Problem with a Queue

#### Problem Statement
A customer service center needs to process customer calls in the order they were received. Write a program that simulates this scenario using a queue.

#### Solution
```csharp
using System;
using System.Collections.Generic;

class CustomerService
{
    static void Main()
    {
        Queue<string> callQueue = new Queue<string>();

        // Add calls to the queue
        callQueue.Enqueue("Call from Customer 1");
        callQueue.Enqueue("Call from Customer 2");
        callQueue.Enqueue("Call from Customer 3");

        Console.WriteLine("Processing calls in order:");

        while (callQueue.Count > 0)
        {
            Console.WriteLine(callQueue.Dequeue());
        }
    }
}
```

#### Explanation
- Calls are added to the queue in the order they arrive.
- The program processes each call by dequeuing it, ensuring that calls are handled in the correct order.

### Exercise for Queue

#### Problem Statement
Write a program to simulate a ticket counter. Customers arrive and are served in the order they enter the queue. Your program should:

1. Enqueue customer names as they arrive.
2. Dequeue and display the name of the customer being served.
3. Stop serving when the queue is empty.

#### Hint
Use the `Queue<T>` class and the methods `Enqueue`, `Dequeue`, and `Count` to manage the queue.

[Solution Link](solutions/ticket_counter_solution.cs)

### Common Errors

- **Dequeuing from an empty queue**: This will throw an `InvalidOperationException`. Always check if the queue is empty before dequeuing.

### Summary
- A queue is a FIFO data structure.
- C# provides a built-in `Queue<T>` class for easy implementation.
- Queues are efficient for scenarios where order of processing is critical.

[Back to Welcome Page](welcome.md)
