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

        private Dictionary<string, char> charsForCodes;
        
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
                FrequencyQueue.Remove();
                parent.RightNode = FrequencyQueue.Front();
                FrequencyQueue.Remove();
                //add new parent to frequency queue
                FrequencyQueue.Add(parent);
            }
            
            //assigns generated tree to HhuffmanTree attr. 
            HuffmanTree = FrequencyQueue.Front();

        }

        public Encoder()
        {
            //default ctor for encoder
            //takes input from console to initialize plaintext attr.
            
            //TODO: initialize plaintext

            EncodedText = "";
            frequencies = new Dictionary<char, int>();
            codesForChars = new Dictionary<char, string>();
            charsForCodes = new Dictionary<string, char>();
            
            //don't need to initialize huffman tree because will just contain ref to node initialized later in encode method
            
        }
        
        //need to write in helper method for traversing tree recursively and creating dictionary of codes

        public string Encode()
        {
            //uses plaintext attr and returns encoded text
            FindFrequencies();
            
        }

        public string Decode()
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