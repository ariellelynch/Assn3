namespace huffmantree
{
    using System.Collections.Generic;
    public class Encoder
    {
        //used for encoding text selections using huffman tree
        private string Plaintext;

        private string EncodedText;

        private Node HuffmanTree;

        private Dictionary<char, int> frequencies;


        private Dictionary<char, string> codesForChars;
        
        //note: P Q contains node/BT elements
        private PriorityQueue<Node> FrequencyQueue;

        private void FindFrequencies()
        {
            //finds frequencies of characters and stores them in frequencies dictionary
            
            //some sort of try except structure for when key hasn't been created yet/char hasn't been found yet
            foreach (char c in Plaintext)
            {
                //loops over chars and creates new dict entry if none exists already, increments if another instance of char is found
                try
                {
                    //increment frequency value of character
                    frequencies[c]++;
                }
                catch (KeyNotFoundException)
                {
                    //create new key for char
                    frequencies.Add(c, 1);
                }
            }
        }

        private void GenerateHuffmanTree()
        {
            //creates nodes for all characters and adds them into PQ, builds huffman tree
            foreach (KeyValuePair<char, int> c in frequencies)
            {
                //generate node and add to priority 
                Node newNode = new Node(c.Key, c.Value);
                FrequencyQueue.Add(newNode);
            }
            
            //now generate huffman tree
            while (FrequencyQueue.Size()!=1)
            {
                //remove two lowest frequency nodes and generate parent node as sum of child frequencies
                Node parent = new Node('*',0);
                parent.LeftNode = FrequencyQueue.Front();
                parent.Frequency += parent.LeftNode.Frequency;
                FrequencyQueue.Remove();
                parent.RightNode = FrequencyQueue.Front();
                parent.Frequency += parent.RightNode.Frequency;
                FrequencyQueue.Remove();
                //add new parent to frequency queue
                FrequencyQueue.Add(parent);
            }
            
            //assigns generated tree to HhuffmanTree attr. 
            HuffmanTree = FrequencyQueue.Front();

        }
        
        public int TraverseTree(Node p)
        {
            if (p.LeftNode!=null&&p.RightNode!=null)
            {
                p.LeftNode.Address = p.Address+"0";
                p.RightNode.Address += p.Address+"1";
                return TraverseTree(p.RightNode) + TraverseTree(p.LeftNode);
            } else if (p.LeftNode != null)
            {
                p.LeftNode.Address = p.Address + "0";
                return TraverseTree(p.LeftNode);

            } else if (p.RightNode != null)
            {
                p.RightNode.Address = p.Address + "1";
            }
            else
            {
                //base case, leaf node
                //add address to dict
                codesForChars.Add(p.Letter, p.Address);
                return 0;
            }
        }

        public Encoder()
        {
            //default ctor for encoder
            //takes input from console to initialize plaintext attr.
            
            //TODO: initialize plaintext

            EncodedText = "";
            frequencies = new Dictionary<char, int>();
            codesForChars = new Dictionary<char, string>();
            
            //don't need to initialize huffman tree because will just contain ref to node initialized later in encode method
            
        }
        
        //need to write in helper method for traversing tree recursively and creating dictionary of codes

        public string Encode()
        {
            FindFrequencies();
            GenerateHuffmanTree();
            TraverseTree(HuffmanTree);
            // this.Plaintext;
            // this.FrequencyQueue;

            // this.EncodedText += TraverseAddresses();
            // this is done after the entire tree is generated

            return this.EncodedText;
            //uses plaintext attr and returns encoded text
        }

        public string Decode(Node tree)
        {
            //decodes the encoded text in the encoder, mostly for testing
        }

        public void print()
        {
            //prints encoded text
            
            //check for null encoded val and throw exception
        }

    }
}
