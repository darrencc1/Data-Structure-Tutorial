# Set Tutorial

## Welcome to the Set Module

In this module, we will explore **sets**. Sets are particularly useful for storing **unique** elements and performing mathematical set operations efficiently.

### What is a Set?

A **set** is a collection of unique elements, meaning no duplicates are allowed. Unlike lists or arrays, the order of elements in a set is not guaranteed.

### Purpose of a Set

Sets are used in scenarios where:

- Ensuring uniqueness is important (e.g., storing unique IDs).
- Efficient membership testing is needed (e.g., checking if an element exists).
- Performing set operations like union, intersection, and difference.

### Performance of a Set

| Operation      | Time Complexity |
|----------------|-----------------|
| Add (Insert)   | O(1)            |
| Remove         | O(1)            |
| Contains       | O(1)            |
| Union          | O(n)            |
| Intersection   | O(n)            |
| Difference     | O(n)            |

### Set in C#

C# provides a `HashSet<T>` class in the `System.Collections.Generic` namespace for working with sets. Here's how you can use it:

#### Example Code: Basic Set Operations
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a set of integers
        HashSet<int> set = new HashSet<int>();

        // Add elements to the set
        set.Add(1);
        set.Add(2);
        set.Add(3);

        // Attempt to add a duplicate
        bool added = set.Add(3);
        Console.WriteLine("Was the number 3 added again? " + added);

        // Check if an element exists
        Console.WriteLine("Does the set contain 2? " + set.Contains(2));

        // Remove an element
        set.Remove(2);
        Console.WriteLine("Does the set contain 2 after removal? " + set.Contains(2));

        // Display all elements in the set
        Console.WriteLine("Elements in the set:");
        foreach (int element in set)
        {
            Console.WriteLine(element);
        }
    }
}
```

### Solving a Problem with a Set

#### Problem Statement
You are designing a system to store a list of attendees for a conference. Attendees should only be added to the list once, even if they register multiple times. Use a set to manage the attendee list.  

#### Solution
```csharp
using System;
using System.Collections.Generic;

class ConferenceAttendees
{
    static void Main()
    {
        HashSet<string> attendees = new HashSet<string>();

        // Add attendees
        attendees.Add("Alice");
        attendees.Add("Bob");
        attendees.Add("Charlie");

        // Attempt to add a duplicate
        attendees.Add("Alice");

        Console.WriteLine("Unique attendees:");
        foreach (string attendee in attendees)
        {
            Console.WriteLine(attendee);
        }
    }
}
```

#### Explanation
- The `HashSet` ensures that each attendee is stored only once.
- Adding the same attendee multiple times does not change the set.

### Exercise for the Student

#### Problem Statement
Write a program to simulate a library system that tracks books currently borrowed. Ensure no duplicate book titles can be added to the borrowed list. Your program should:

1. Add book titles to the set as they are borrowed.
2. Remove book titles when they are returned.
3. Display the current list of borrowed books.

#### Hint
Use the `HashSet<T>` class for storing book titles and use methods like `Add`, `Remove`, and iteration to manage and display the set.

[Solution Link](solutions/library_system_solution.cs)

### Common Errors

- **Assuming order in a set**: Sets do not maintain order. If order is important, consider using another data structure.
- **Attempting to add duplicates**: While duplicates are ignored, it's good practice to verify whether an item already exists.
- **Confusing `HashSet<T>` with other collections**: Unlike lists, `HashSet` does not allow indexing or duplicates.

### Summary
- A set is a collection of unique elements.
- C# provides the `HashSet<T>` class for set implementation.
- Sets are ideal for scenarios where uniqueness and efficient membership testing are critical.

[Back to Welcome Page](welcome.md)