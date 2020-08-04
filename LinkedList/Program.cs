using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLinkedList<int> myList = new DLinkedList<int>();
            myList.AddHead(1);
            myList.AddHead(2);
            myList.AddHead(3);
            myList.AddHead(4);

            Console.WriteLine(myList.Index(3));
        }
    }
}
