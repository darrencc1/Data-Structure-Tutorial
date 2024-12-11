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