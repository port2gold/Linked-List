using System;
using System.Collections.Generic;
using System.Text;
using LinkedList;

namespace LinkedList
{
    public class GenericQueue<T>
    {
        //Create an Object of lInked list

        DLinkedList<T> ow = new DLinkedList<T>();

        //Checks if the Queue is empty 


        public bool isEmpty()
        {
            bool result = (ow.count == 0) ? true : false;
            return result;
        }

        // Adds an item to the tail of the queue

        public void Enqueue(T value)
        {
            ow.AddTails(value);
        }


        //Removes an item from the head of the queue


        public void Dequeue()
        {
            ow.RemoveHead();
        }
        


        //Returns the Size of the Queue


        public int Size()
        {
            return ow.count;
        }


        //Print out all the nodes in  the Queue



        public void Print()
        {
            ow.Print();
        }
    }
}
