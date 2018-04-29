using System;
using System.Collections;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        private LinkedListNode Head { get; set; }
        private LinkedListNode Tail { get; set; }

        public LinkedList()
        {
            Tail = Head = new LinkedListNode();
        }

        public LinkedList(IEnumerable input)
        {
            foreach (var node in input)
            {
                if (Head == null)
                {
                    Tail = Head = new LinkedListNode(node);
                }
                else
                {
                    Tail.NodeNext = new LinkedListNode(node);
                    Tail = Tail.NodeNext;
                }
            }
        }

        public void AddNode(object input)
        {
            Tail.NodeNext = new LinkedListNode(input);
            Tail = Tail.NodeNext;
        }

        public void PrependNode(object input)
        {
            var temp = new LinkedListNode {NodeNext = Head};
            Head = temp;
        }

        public object GetNode(object input)
        {
            var node = Head;
            while (node.NodeNext != null)
            {
                if (node.Content == input)
                    return node;
                node = node.NodeNext;
            }

            return null;
        }

        public void DeleteNode(object input)
        {
            var node = Head;
            while (node.NodeNext != null)
            {
                var nodeLast = node;
                if (node.Content == input)
                {
                    nodeLast.NodeNext = node.NodeNext ?? null;
                }
            }
        }

        public void WriteList()
        {
            var node = Head;
            while (node.NodeNext != null)
            {
                Console.WriteLine(node);
                node = node.NodeNext;
            }
        }
    }
}