using System;

public class TreeNode
{
    public Node headNode;
    public int lengh = 0;
	public TreeNode()
	{
		
	}
	public void AddNode(Node node)
    {
        if (headNode == null)
        {
            headNode = node;
            lengh++;
        }
        else
        {
            Node tailNode = headNode;
            while (tailNode.nextNode != null)
            {
                tailNode = tailNode.nextNode;
            }
            tailNode.nextNode = node;
            lengh++;
        }

    }
   
    public Node GetNode(int number)
    {
        Node node = headNode;
        while (number>0) 
        {
            node = node.nextNode;
            number--;
        }
        return node;
    }
    //for test
    public void GetAllNode()
    {
        
        Node node = headNode;
        while(node != null)
        {
            Console.WriteLine(node.name);
            node = node.nextNode;
        }
    }
    public int Calculate(Node lastNode,TreeNode tree)
    {
        int MinDistance=0;
        
        Node firstNode = headNode;
        Node node = headNode ;
        int distance = 0;
        int nLeaf = 0;
        int repeatC = 0;
        for (int i=1;i<tree.lengh;i++)
        {
            node = tree.GetNode(i);
            repeatC = 0;
            for (int j=0;j<i;j++)
            {
                
                
                if (node.GetLeaf(j).distance==-1 || node.GetLeaf(j).calCheck == true)
                {
                    //distance = distance + node.GetLeaf(j).distance;
                    //Save(MinDistance, distance);
                    repeatC += 1;
                    
                }
                else if (node.GetLeaf(j).name == lastNode.name)
                {
                    distance = distance + node.GetLeaf(j).distance;
                    if (distance < MinDistance || MinDistance == 0)
                    {
                        MinDistance = distance;
                    }
                    node.GetLeaf(j).calCheck = true;
                    distance = 0;
                    i = i-2;
                    break;
                }
                else
                {
                    distance = distance + node.GetLeaf(j).distance;
                    //node = node.SearchNodeFromLeaf(tree,node.GetLeaf(j));
                    //node = node.nextNode;
                    //i++;
                    break;
                }

                if (repeatC == j)
                {
                    break;
                }
                
            }
            
        }
        return MinDistance;
        
    }
    static int Factorial(int number)
    {
        int fact = 1;
        for (int i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
   

}
