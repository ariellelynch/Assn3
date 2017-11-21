namespace huffmantree
{
    public class Encoder
    {
        //used for encoding text selections using huffman tree
        private string Plaintext;

        private string EncodedText;

        private Node HuffmanTree;
        
        //TODO: need two dictionaries, one for finding frequency and another for holding the character codes, maybe another one with key & val reversed for decoding method
        
        //note: P Q contains node/BT elements
        private PriorityQueue<Node> FrequencyQueue;

        public Encoder()
        {
            //default ctor for encoder
            //takes input from console to initialize plaintext attr.
        }
        
        //need to write in helper method for traversing tree recursively and creating dictionary of codes

        public string Encode()
        {
            //uses plaintext attr and returns encoded text
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