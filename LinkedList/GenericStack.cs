using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;
using LinkedList;

namespace LinkedList
{
    public class GenericStack<T>
    {
        readonly DLinkedList<T> owner = new DLinkedList<T>();
        public bool isempty()
        {
            bool result = (owner.count == 0) ? true : false;
            return result;
        }
        public void Push(T value)
        {
            owner.AddTails(value);
        }
        public void Pop()
        {
            owner.RemoveHead();
        }
        public void Peek()
        {
            owner.GetTail();
        }
        public int Size()
        {
            return owner.count;
        }
        public void Print()
        {
            owner.Print();
        }
    }
}
