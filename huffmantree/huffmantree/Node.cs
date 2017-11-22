using System;

namespace huffmantree
{
    public class Node : IComparable 
    {
        //node class for binary tree, also serves as binary tree class (includes getters/setters for child values)
        public char Letter;

        public int Frequency;

        public Node RightNode;

        public Node LeftNode;

        public string Address { get; set; }

        //getters and setters

        public Node()
        {
            //parameterless ctor
            
            RightNode = null;
            LeftNode = null;
            Address = "";

        }

        public Node(char Letter, int Frequency)
        {
            //ctor for childless node
            this.Letter = Letter;
            this.Frequency = Frequency;
            this.RightNode = null;
            this.LeftNode = null;
        }

        public Node(char Letter, int Frequency,Node RightNode, Node LeftNode)
        {
            //ctor for node with children
            this.Letter = Letter;
            this.Frequency = Frequency;
            this.RightNode = RightNode;
            this.LeftNode = LeftNode;
        }

        public int CompareTo(object obj)
        {
            int res = 0;
            //cast input to node type
            Node c = (Node) obj;
            if (c.Frequency<this.Frequency)
            {
                res = -1;
            } else if (c.Frequency == this.Frequency)
            {
                res = 0;
            } else if (c.Frequency > this.Frequency)
            {
                res = 1;
            }

            return res;
        }

        public void TraverseTree()
        {
            LeftNode.Address += "0";
            RightNode.Address += "1";
        }
    }
}
