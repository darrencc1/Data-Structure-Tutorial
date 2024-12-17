using System;

// Represents a single node in the binary tree
class TreeNode
{
    public int Value;       // Value of the node
    public TreeNode Left;   // Pointer to the left child
    public TreeNode Right;  // Pointer to the right child

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
    public TreeNode Root;

    // Inserts a value into the binary tree
    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private TreeNode InsertRec(TreeNode node, int value)
    {
        if (node == null)
            return new TreeNode(value);

        if (value < node.Value)
            node.Left = InsertRec(node.Left, value);
        else
            node.Right = InsertRec(node.Right, value);

        return node;
    }

    // Searches for a specific value in the tree
    public bool Search(int value)
    {
        return SearchRec(Root, value);
    }

    private bool SearchRec(TreeNode node, int value)
    {
        if (node == null)
            return false;

        if (node.Value == value)
            return true;

        if (value < node.Value)
            return SearchRec(node.Left, value);
        else
            return SearchRec(node.Right, value);
    }

    // Deletes a node with a specific value
    public void Delete(int value)
    {
        Root = DeleteRec(Root, value);
    }

    private TreeNode DeleteRec(TreeNode node, int value)
    {
        if (node == null)
            return null;

        // Find the node to delete
        if (value < node.Value)
            node.Left = DeleteRec(node.Left, value);
        else if (value > node.Value)
            node.Right = DeleteRec(node.Right, value);
        else
        {
            // Case 1: Node has no children
            if (node.Left == null && node.Right == null)
                return null;

            // Case 2: Node has one child
            if (node.Left == null)
                return node.Right;
            if (node.Right == null)
                return node.Left;

            // Case 3: Node has two children - Find in-order successor
            TreeNode successor = FindMin(node.Right);
            node.Value = successor.Value;
            node.Right = DeleteRec(node.Right, successor.Value);
        }

        return node;
    }

    private TreeNode FindMin(TreeNode node)
    {
        while (node.Left != null)
            node = node.Left;
        return node;
    }

    // In-order traversal to display the tree in sorted order
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

// Main program to test the binary tree implementation
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

        Console.WriteLine("In-Order Traversal of the Tree:");
        tree.InOrderTraversal(tree.Root);

        // Search for a value
        Console.WriteLine("\nSearch for value 64:");
        Console.WriteLine(tree.Search(64) ? "Value found!" : "Value not found!");

        Console.WriteLine("\nSearch for value 100:");
        Console.WriteLine(tree.Search(100) ? "Value found!" : "Value not found!");

        // Delete a node
        Console.WriteLine("\nDelete value 78:");
        tree.Delete(78);

        Console.WriteLine("In-Order Traversal after Deletion:");
        tree.InOrderTraversal(tree.Root);
    }
}
