using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSATrees
{
    public class ConversationTree
    {
        public ConversationNode root;

        public ConversationNode InsertAfter(string phrase, string NextPhrase)
        {
            ConversationNode found = Find(root, phrase);
            if (found!= null)
            {
                ConversationNode newNode = new ConversationNode(NextPhrase, null);
                found.children.Add(newNode);
                return newNode;
            }
            return null;
        }

        public ConversationNode Find(ConversationNode current, string Phrase)
        {
            if (current != null)
            {
                if (current.phrase == Phrase)
                {
                    return current;
                }
                else if (current.children.Count() > 0)
                    foreach (ConversationNode node in current.children)
                        if (node.phrase != Phrase)
                            current = Find(node, Phrase);
                        else return node;
            }
            return null;
        }

        public void TraverseAcrossTree(ConversationNode node)
        {
            Console.WriteLine("Parent Node phrase {0}",node.phrase);

            if (node.children != null)
            {
                foreach (var item in node.children)
                {
                    Console.WriteLine(item.phrase);
                }
                foreach (var item in node.children)
                {
                    TraverseAcrossTree(item);
                }

            }
            
        }

        public void TraverseDownTree(ConversationNode node)
        {
            Console.WriteLine("Parent Node phrase {0}", node.phrase);
            if (node.children != null)
                foreach (var item in node.children)
                    TraverseDownTree(item);
 
        }
    }
    
    public class ConversationNode
    {
        public List<ConversationNode> children = new List<ConversationNode>();

            
        public string phrase;

        
        public ConversationNode(string Phrase,
                        List<string> childPhrases)
        {
            phrase = Phrase;
            if (childPhrases != null)
            {
                foreach (var p in childPhrases)
                {
                    children.Add(new ConversationNode(p, null));
                }
            }
        }

        
    }
}
