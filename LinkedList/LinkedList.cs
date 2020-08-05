using System;
using System.Collections;
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

    public class DLinkedList<T> : ICollection<T>
    {
        //public DLinkedList(T head,T tail)
        //{
        //    this.Head = head;
        //    this.Tail = tail;

        //}
        public int count = 0;
        public LinkedListNode<T> head { get; private set; }
        public LinkedListNode<T> tail { get; private set; }
        public int index { get; private set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

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
            Console.WriteLine($"The Size is: {count}");
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
                Console.WriteLine($"The Size is: {count}");

            }
            
        }
        public LinkedListNode<T> Search(T value)
        {
            LinkedListNode<T> Current = head;
            index = -1;
            while(Current != null)
            {
                index++;
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

        public void Insert(T value, int index)
        {
            LinkedListNode<T> adding = new LinkedListNode<T>(value);


        }
        public bool RemoveHead()
        {
            //LinkedListNode<T> previous = head.Previous;
            LinkedListNode<T> next = head.Next;
            if (head == null)
            {
                return false;
            }
            else
            {
                next.Previous = null;
                head = next;
                count--;
                return true;
                
            }
        }
           
        public bool RemoveTail()
        {
            
            LinkedListNode<T> previous = tail.Previous;
            if (tail == null)
            {
                return false;
            }
            else
            {
                previous.Next = null;
                tail = previous;
                count--;
                return true;
            }
            
        }
        public LinkedListNode<T> GetHead()
        {
            return head;
        }
        public LinkedListNode<T> GetTail()
        {
            return tail;
        }
        public void Print()
        {
            LinkedListNode<T> firstNode = head;
            //LinkedListNode<T> next = T
            if (firstNode == null)
            {
                Console.WriteLine("There is nothing in me!!!");
            }
            else 
            {
                string result = "";
                while (firstNode != null)
                {
                    result += $"{firstNode.Value}, ";
                    firstNode = firstNode.Next;
                }
                string finalResult = result.Substring(0, result.Length - 2);
                Console.WriteLine($"{{{finalResult}}}");
            }
           
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
        public int Index(T value)
        {
            
            Search(value);
            return index;
        }

        public void Add(T item)
        {
            //throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
