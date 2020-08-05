using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;
using LinkedList;

namespace LinkedList
{
    public class GenericStack<T>
    {

        //Instantiate the instance of Generic class backed by Linked List

        readonly DLinkedList<T> owner = new DLinkedList<T>();


        // Returns if the list is empty or Not

        public bool isempty()
        {
            bool result = (owner.count == 0) ? true : false;
            return result;
        }

        //Push a value to the top of the stack


        public void Push(T value)
        {
            owner.AddHead(value);
        }

        //Removes a value from the top of the stack


        public void Pop()
        {
            owner.RemoveHead();
        }


        // Returns the value at the top of the Stack
        public void Peek()
        {
            owner.GetHead();
        }

        // Returns the size of the stack


        public int Size()
        {
            return owner.count;
        }


        // Print all the nodes in the list
        public void Print()
        {
            owner.Print();
        }
    }
}
