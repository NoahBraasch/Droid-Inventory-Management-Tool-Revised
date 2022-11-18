using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Inventory_Management_Tool_Revised
{
    public class GenericStack<T> : IGenericStack<T>
    {
        /// <summary>
        /// Internal subclass node acts a a safe way for us to implement a pointer for our linked list
        /// </summary>
        protected class Node
        { 
            public T Data { get; set; }
            // This confused me for quite a while. But its clear now that this 
            // Instance of a node in itself is just the way that we point
            // to the next node. By declaring a property of type node.
            public Node Next { get; set; }
        }
        /// <summary>
        /// Declares variables for head tail and _size
        /// </summary>
        protected Node _head;

        //Only reason we need tail is to verify that the stack has a size
        //protected Node _tail;
        protected int _size;

        /// <summary>
        /// Property that returns null if the stack has no value
        /// </summary>
        public bool IsEmpty
        {
            get { return _head == null; }
        }
        public int Size
        {
            get { return _size; }
        }

        public void Push(T Data)
        {
            Node oldHead = _head;
            _head = new Node();
            _head.Data = Data;
            _head.Next = oldHead;
            _size++;
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("List is empty");
            T returnData = _head.Data;
            _head = _head.Next;
            _size--;

            return returnData;
        }

        public void Display()
        {
            Console.WriteLine("THe list is:");
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
