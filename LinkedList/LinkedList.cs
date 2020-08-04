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
        public LinkedListNode<T> head { get; private set; }
        public LinkedListNode<T> tail { get; private set; }
        public void AddHead(T value)
        {
            LinkedListNode<T> adding = new LinkedListNode<T>(value, null, head);
            if (head != null)
            {
                head.Previous = adding;
            }
            head = adding;
            if (tail == null)
            {
                tail = head;
            }
            count++;
        }
        public  void AddTails(T value)
        {
            //Add value to the tail
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
                //
                if (Current.Value.Equals(value))
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return null;
        }
        public bool Check(T value)
        {
            //Search for value and if found return true else false
            return Search(value) != null; 
            
        }
        public bool isEmpty()
        {
            //checks if the count is zero return true else return false
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            return count;
        }

        public void Insert()
        {

        }
        public void RemoveHead()
        {
            LinkedListNode<T> previous = head.Previous;
            LinkedListNode<T> next = head.Next;
            if (previous == null)
            {
                next.Previous = null;
            }
        }
        public void RemoveTail()
        {
            LinkedListNode<T> previous = tail.Previous;
            LinkedListNode<T> next = tail.Next;
            if (next == null)
            {
                previous.Next = null;
            }
        }
        public  LinkedListNode<T> GetHead()
        {
            LinkedListNode<T> previous = head.Previous;
            if (previous == null)
            {
                return head.Value;
            }
        }
        public void Print()
        {
            s
        }
        public bool Remove(T value)
        {
            // calls search function on the value

            LinkedListNode<T> param = Search(value);
            // if it was not found, then nothing to remove

            if (param == null)
            {
                return false;
            }
            LinkedListNode<T> previous = param.Previous;
            LinkedListNode<T> next = param.Next;
            // the value is the head
            if (previous == null)
            {
                head = next;
                if (head != null)
                {
                    head.Previous = null;
                }
            }
            else
            {
                previous.Next = next;
            }
            //the value is the tail   
            if (next == null)
            {
                tail = previous;
                if (tail != null)
                {
                    tail.Next = null;
                }
            }
            else
            {
                next.Previous = previous;
            }
            count--;
            return true;
        }
        public void Index(T value)
        {
            int position = 0;
            LinkedListNode<T> Current = head;
            while(Current != null)
            {
                if (Current.Value.Equals(value))
                {
                    position++;
                }
            }
        }

    }
}
