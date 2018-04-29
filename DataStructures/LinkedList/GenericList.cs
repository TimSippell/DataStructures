using System.Collections.Generic;

namespace DataStructures.LinkedList
{
    public class GenericList<T>
    {
        private Node _head;

        public GenericList()
        {
            _head = null;
        }

        public void AddHead(T t)
        {
            var n = new Node(t) {Next = _head};
            _head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        private class Node
        {
            public Node Next { get; set; }
            public T Data { get; private set; }

            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }
    }
}