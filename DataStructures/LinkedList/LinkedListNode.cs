namespace DataStructures.LinkedList
{
    public class LinkedListNode
    {
        internal object Content { get; }
        internal LinkedListNode NodeNext { get; set; }

        public LinkedListNode()
        {
            Content = null;
            NodeNext = null;
        }

        public LinkedListNode(object input)
        {
            Content = input;
        }
    }
}