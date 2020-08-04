using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;
using LinkedList;

namespace LinkedList
{
    class GenericStack<T>
    {
        readonly DLinkedList<T> owner = new DLinkedList<T>();
        public bool IsEmpty()
        {

        }
        public void Push(T value)
        {
            owner.AddHead(value);
        }
        public void Pop()
        {
            owner.RemoveHead();
        }
        public void Peek()
        {

        }
        public int Size()
        {

        }
        public void Print()
        {

        }
    }
}
