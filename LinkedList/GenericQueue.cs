using System;
using System.Collections.Generic;
using System.Text;
using LinkedList;

namespace LinkedList
{
    public class GenericQueue<T>
    {
        DLinkedList<T> ow = new DLinkedList<T>();
        public bool isEmpty()
        {
            bool result = (ow.count == 0) ? true : false;
            return result;
        }
        public void Enqueue(T value)
        {
            ow.AddTails(value);
        }
        public void Dequeue()
        {
            ow.RemoveHead();
        }
        //public void Peek()
        //{
        //    return tail
        //}
        public int Size()
        {
            return ow.count;
        }
        public void Print()
        {
            ow.Print();
        }
    }
}
