using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LinkedList
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value, LinkedListNode<T>previous= null, LinkedListNode<T>next=null)
        {
            this.Value = value;
            this.Previous = previous;
            this.Next = next; 
        }
        public T Value { get; set; }
        public LinkedListNode<T>Next { get; set; }
        public LinkedListNode<T>Previous { get; set; }
    }

    public class DLinkedList<T> //: ICollection<T>
    {
        //public DLinkedList(T head,T tail)
        //{
        //    this.Head = head;
        //    this.Tail = tail;

        //}
        public int count = 0;
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }
        public void AddHead(T value)
        {
            LinkedListNode<T> adding = new LinkedListNode<T>(value, null, head);
            if (head != null)
            {
                head.Previous = adding;
            }
            head = adding;
            if (Tail == null)
            {
                tail = head;
            }
            count++;
        }
        public  void AddTaila(T value)
        {
            if (tail == null)
            {
                AddHead(value);
            }
            else
            {
                LinkedListNode<T> adding = new LinkedListNode<T>(value, tail);
                tail.Next = adding;
                tail = adding;
                count++;
            }
            
        }
        public LinkedListNode<T> Search(T value)
        {
            LinkedListNode<T> Current = head;
            while(Current != null)
            {
                if (Current.Value.Equals(value))
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return null;
        }

    }
}
