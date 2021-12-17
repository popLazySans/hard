using System;

public class Node
{
	public string name;
	public Node nextNode;
    public LeafNode head;
    public int leafLengh = 0;
	public Node(string nameValue)
	{
		name = nameValue;
		nextNode = null;
	}
	public void AddLeaf(LeafNode node)
	{
        if (head == null)
        {
            head = node;
            leafLengh++;
        }
        else
        {
            LeafNode tail = head;
            while (tail.nextLeafNode != null)
            {
                tail = tail.nextLeafNode;
            }
            tail.nextLeafNode = node;
            leafLengh++;
        }
    }
    public LeafNode GetLeaf(int number)
    {
        LeafNode node = head;
        while (number > 0)
        {
            node = node.nextLeafNode;
            number--;
        }
        return node;
    }
    public Node SearchNodeFromLeaf(TreeNode tree,LeafNode leaf)
    {
        Node node = tree.headNode;
        for (int i = 0; i < tree.lengh; i++)
        {
            if (leaf.name == node.name)
            {
                break;
            }
            else
            {
                node = node.nextNode;
            }
            
        }
        return node;
    }
    //for test
    public void GetAllLeaf()
    {
        LeafNode node = head;
        while (node != null)
        {
            Console.Write(node.name);
            Console.Write(node.distance);
            Console.WriteLine("");
            node = node.nextLeafNode;
        }
    }
}
