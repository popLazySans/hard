using System;

namespace miniBoss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = n;
            TreeNode tree = new TreeNode();
            while (n>0)
            {
                string nameNode = Console.ReadLine();
                Node newNode = new Node(nameNode);
                tree.AddNode(newNode);
                n--;
            }
            for (int i = 0;i<number;i++)
            {
                
                for (int j = 0;j<i;j++)
                {
                    int distance = int.Parse(Console.ReadLine());
                    LeafNode newLeaf = new LeafNode(tree.GetNode(j).name,distance);
                    tree.GetNode(i).AddLeaf(newLeaf);
                   //tree.GetNode(i).GetAllLeaf();
                }
       
            }

            //Console.WriteLine(tree.GetNode(2).name);
            //tree.GetAllNode();
            string last_word = Console.ReadLine();
            for (int j =0;j<tree.lengh;j++)
            {
                if (tree.GetNode(j).name == last_word)
                {
                    Console.WriteLine( tree.Calculate(tree.GetNode(j),tree));
                }
            }
           
        }

      
    }
     
}
