ADD RECURSION EXPLANATION!!!

# Tree Tutorial

## Welcome to the Tree Module

Welcome to the third module of the Data Structure Tutorial! In this module, we will explore **trees**, one of the most versatile and widely used data structures in computer science. Trees are essential for organizing data in a **hierarchical** structure.

### What is a Tree?

A **tree** is a hierarchical data structure consisting of nodes. It starts with a single node called the **root**, and each node may have zero or more child nodes. Nodes without children are called **leaf nodes**. The structure forms a tree-like shape, hence the name.

### Key Terms
THANK YOU CHAT FOR THIS RIGHT HERE!
- **Root**: The topmost node in the tree.
- **Child**: A node directly connected to another node when moving away from the root.
- **Parent**: A node directly connected to another node when moving toward the root.
- **Leaf**: A node with no children.
- **Subtree**: A tree consisting of a node and its descendants.
- **Height**: The length of the longest path from the root to a leaf.
- **Depth**: The length of the path from the root to a node.

### Purpose of a Tree

Trees are used in scenarios where hierarchical or relational data needs to be represented, such as:

- Representing file systems.
- Organizing data for quick search (e.g., binary search trees).
- Modeling hierarchical relationships (e.g., family trees).
- Parsing expressions in compilers.

### Performance of a Tree

| Operation               | Time Complexity (Binary Search Tree) |
|-------------------------|---------------------------------------|
| Search                  | O(h) (h = height of the tree)        |
| Insert                  | O(h)                                |
| Delete                  | O(h)                                |

For balanced trees, `h` is approximately `log(n)`, making these operations efficient.

### Tree in C#

C# does not have a built-in tree data structure, but we can easily implement one using classes. Below is an example of a binary tree implementation.

# Tree Tutorial

## Welcome to the Tree Module

Welcome to the third module of the Data Structure Tutorial! In this module, we will explore **trees**, one of the most versatile and widely used data structures in computer science. Trees are essential for organizing data in a hierarchical structure.

### What is a Tree?

A **tree** is a hierarchical data structure consisting of nodes. It starts with a single node called the **root**, and each node may have zero or more child nodes. Nodes without children are called **leaf nodes**. The structure forms a tree-like shape, hence the name.

### Key Terms

- **Root**: The topmost node in the tree.
- **Child**: A node directly connected to another node when moving away from the root.
- **Parent**: A node directly connected to another node when moving toward the root.
- **Leaf**: A node with no children.
- **Subtree**: A tree consisting of a node and its descendants.
- **Height**: The length of the longest path from the root to a leaf.
- **Depth**: The length of the path from the root to a node.

### Purpose of a Tree

Trees are used in scenarios where hierarchical or relational data needs to be represented, such as:

- Representing file systems.
- Organizing data for quick search (e.g., binary search trees).
- Modeling hierarchical relationships (e.g., family trees).
- Parsing expressions in compilers.

### Performance of a Tree

| Operation               | Time Complexity (Binary Search Tree) |
|-------------------------|---------------------------------------|
| Search                  | O(h) (h = height of the tree)        |
| Insert                  | O(h)                                |
| Delete                  | O(h)                                |

For balanced trees, `h` is approximately `log(n)`, making these operations efficient.

### Tree in C#

C# does not have a built-in tree data structure, but we can easily implement one using classes. Below is an example of a binary tree implementation.

#### Example Code: Basic Tree Implementation

```csharp
using System;

// Represents a single node in the binary tree
class TreeNode
{
    public int Value;  // Value of the node
    public TreeNode Left;  // Pointer to the left child
    public TreeNode Right; // Pointer to the right child

    // Constructor to initialize the node with a value
    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

// Represents the binary tree
class BinaryTree
{
    public TreeNode Root;  // Root node of the tree

    // Inserts a value into the binary tree
    public void Insert(int value)
    {
        if (Root == null)
        {
            // If the tree is empty, set the root to the new node
            Root = new TreeNode(value);
        }
        else
        {
            // Recursively find the correct position for the new node
            InsertRec(Root, value);
        }
    }

    // Helper method for inserting a value into the tree
    private void InsertRec(TreeNode node, int value)
    {
        if (value < node.Value)
        {
            // Go to the left subtree if the value is smaller
            if (node.Left == null)
                node.Left = new TreeNode(value);
            else
                InsertRec(node.Left, value);
        }
        else
        {
            // Go to the right subtree if the value is larger or equal
            if (node.Right == null)
                node.Right = new TreeNode(value);
            else
                InsertRec(node.Right, value);
        }
    }

    // Performs an in-order traversal of the tree (left, root, right)
    public void InOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            // Visit the left subtree
            InOrderTraversal(node.Left);
            
            // Visit the root node
            Console.WriteLine(node.Value);
            
            // Visit the right subtree
            InOrderTraversal(node.Right);
        }
    }
}

// Main program to demonstrate the binary tree
class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();

        // Insert values into the tree
        tree.Insert(51);
        tree.Insert(35);
        tree.Insert(78);
        tree.Insert(25);
        tree.Insert(48);
        tree.Insert(64);
        tree.Insert(80);

        // Perform in-order traversal and display the tree's elements
        Console.WriteLine("In-Order Traversal:");
        tree.InOrderTraversal(tree.Root);
    }
}
```

### Solving a Problem with a Tree

#### Problem Statement
You are tasked with building a program that stores employee IDs in a hierarchical structure. Implement a binary tree to add employee IDs and perform an in-order traversal to display the IDs in sorted order.

#### Solution
```csharp
// Use the BinaryTree class from the example code.
```

#### Explanation
- The `Insert` method ensures the IDs are stored in sorted order.
- The `InOrderTraversal` method retrieves the IDs in ascending order.

### Exercise for the Student

#### Problem Statement
Write a program to create a binary tree that stores integers. Implement methods to:

1. Search for a specific value in the tree.
2. Delete a node with a given value.

#### Hint
Use recursion to implement both search and delete operations. For deletion, consider the following cases:
- Node to be deleted is a leaf.
- Node to be deleted has one child.
- Node to be deleted has two children (replace it with the in-order successor).

[Solution Link](solutions/tree_operations_solution.cs)

### Common Errors

- **Infinite Recursion**: Ensure base cases are defined in recursive functions.
- **Null Reference Exception**: Always check if a node is null before accessing its properties.
- **Unbalanced Trees**: Insertions in sorted order can lead to unbalanced trees, reducing performance. Consider using a self-balancing tree for such cases.

### Summary
- Trees organize data hierarchically.
- Binary trees are a simple yet powerful type of tree.
- C# allows easy implementation of trees using classes and recursion.

[Back to Welcome Page](welcome.md)