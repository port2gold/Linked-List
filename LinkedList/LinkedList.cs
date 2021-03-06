﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace LinkedList
{
    public class LinkedListNode<T>
    {
        //Link List Node Constructor

        public LinkedListNode(T value, LinkedListNode<T> previous = null, LinkedListNode<T> next = null)
        {
            this.Value = value;
            this.Previous = previous;
            this.Next = next;
        }
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Previous { get; set; }
    }

    // Linked List Class
    public class DLinkedList<T> : ICollection<T>
    {
        //Property Fields 

        public int count = 0;
        public LinkedListNode<T> head { get; private set; }
        public LinkedListNode<T> tail { get; private set; }
        public int index { get; private set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        // Add head Method

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

        //Add Tail method

        public void AddTails(T value)
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

        // Search value Method

        public LinkedListNode<T> Search(T value)
        {
            LinkedListNode<T> Current = head;
            index = -1;
            while (Current != null)
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

        //Check Value method 

        public bool Check(T value)
        {
            //Search for value and if found return true else false
            return Search(value) != null;

        }

        //Check if the Link list is empty

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

        // Find the size of the Linked List


        public int Size()
        {
            return count;
        }

        public void Insert(T value, int index)
        {
            LinkedListNode<T> adding = new LinkedListNode<T>(value);


        }

        // Remove the head Node of the Linked list 


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


        // Remove the Tail node of the Linked List

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

        // Returns  the Head Node of the Linked list
        public LinkedListNode<T> GetHead()
        {
            return head;
        }

        // Returns the  Tail Node of the Linked lIst 

        public LinkedListNode<T> GetTail()
        {
            return tail;
        }

        // Print the all the nodes in the linked list 


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


        //Remove the value that was passed into the function

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


        // Find the index of the value passed


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
