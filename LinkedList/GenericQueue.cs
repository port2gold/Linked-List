using System;
using System.Collections.Generic;
using System.Text;
using LinkedList;

namespace LinkedList
{
    class GenericQueue<T>
    {
        DLinkedList<T> owner = new DLinkedList<T>();
        public bool isEmpty()
        {

        }
        public void Enqueue(T value)
        {
            owner.AddTails(value);
        }
        public void Dequeue()
        {
            owner.RemoveHead();
        }
        public void Peek()
        {
            GetHead()
        }
        public int Size()
        {

        }
        public void Print()
        {

        }
    }
}
