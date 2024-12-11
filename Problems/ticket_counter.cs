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