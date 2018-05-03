using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace DataStructures.Stack
{
    public class Stack<T>
    {
        private Node _head;

        public Stack(T t)
        {
            _head = new Node(t);
        }

        public void Push(T t)
        {
            var temp = new Node(t) {Next = _head};
            _head = temp;
        }

        public T Pop()
        {
            try
            {
                var temp = _head;
                _head = _head.Next;
                return temp.Data;
            }
            catch
            {
                throw new Exception("Stack is empty");
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