using System;
//Complete all the todo statements 


// Represents a single node in the binary tree
class TreeNode
{
    public int Value;      // Value of the node
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
            Root = new TreeNode(value);
        }
        else
        {
            InsertRec(Root, value);
        }
    }

    // TODO: Complete the InsertRec method to insert values recursively
    private void InsertRec(TreeNode node, int value)
    {
        // If the value is smaller, go to the left child
        // If the value is larger, go to the right child
        // Create a new node if the child node is null
    }

    // TODO: Implement a method to search for a value in the binary tree
    public bool Search(int value)
    {
        // Return true if the value is found, false otherwise
        return false; // Placeholder
    }

    // TODO: Implement a method to delete a node with a specific value
    public void Delete(int value)
    {
        // Implement deletion logic with three cases:
        // 1. Node to be deleted is a leaf.
        // 2. Node to be deleted has one child.
        // 3. Node to be deleted has two children (replace with in-order successor).
    }

    // Performs an in-order traversal of the tree (left, root, right)
    public void InOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.WriteLine(node.Value);
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

        // Example Insertions (Already provided)
        tree.Insert(51);
        tree.Insert(35);
        tree.Insert(78);
        tree.Insert(25);
        tree.Insert(48);
        tree.Insert(64);
        tree.Insert(80);

        Console.WriteLine("In-Order Traversal of the Tree:");
        tree.InOrderTraversal(tree.Root);

        // TODO: Allow the user to implement and test:
        // 1. Searching for a value
        Console.WriteLine("\nTODO: Search for a value in the tree.");

        // 2. Deleting a node
        Console.WriteLine("\nTODO: Delete a node from the tree.");

        // 3. Perform InOrderTraversal again to verify changes
        Console.WriteLine("\nTODO: Display the updated tree after deletion.");
    }
}
