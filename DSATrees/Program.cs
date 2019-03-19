using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;

namespace DSATrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            int[] arr = new int[] { 2, 3, 4, 1 };
            foreach (var item in arr)
                tree.insert(tree.root,item);

           tree.treePrint(tree.root);

           int toFind = 4;
           TreeNode found = tree.Find(tree.root, toFind);

            if (found != null)
               Console.WriteLine("Found {0}", found.Val);
           else Console.WriteLine("{0} not found", toFind);

            ConversationTree conversataion = new ConversationTree();

            conversataion.root =  new ConversationNode("What is your Name",
                                    new List<string>() 
                                                {"None of your Business",
                                                    "My Name is Bill",
                                                    "I've lost my memory"});

            //ConversationNode phrase = conversataion.Find(conversataion.root, "None of your Business");
            conversataion.InsertAfter("None of your Business", "How rude");

            Console.WriteLine("{0}", conversataion.root.phrase);

            int i = 1;
            foreach (ConversationNode answer in conversataion.root.children)
            {
                Console.WriteLine("Your Choices {0} {1}",i++, answer.phrase);
            }


            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Your chose {0} ", conversataion.root.children[choice].phrase);

            Console.WriteLine("Iterate over parent");
            conversataion.TraverseAcrossTree(conversataion.root);
            Console.ReadKey();
        }
    }
}
