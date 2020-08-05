using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
          
            bool session = true;
            while (session == true)
            {
                Console.WriteLine(@"What Would You Like To Do?
              +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
              DOUBLY LINKED LIST ==> PRESS 1              STACK ==> PRESS 2         QUEUE ==> Press 3
              ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        ");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


                int response = Convert.ToInt32(Console.ReadLine());
                if (response == 1)
                {
                    bool linklistsession = true;
                    while (linklistsession == true)
                    {
                        DLinkedList<string> populate= new DLinkedList<string>();
                        Console.WriteLine(@"OPTIONS:
                                                        Add Head ==> PRESS 1
                                                        Add Tail ==> PRESS 2
                                                        Get Head ==> PRESS 3
                                                        Get Tail ==> PRESS 4
                                                        Remove Head ==> PRESS 5
                                                        Remove Tail ==> PRESS 6
                                                        Remove value ==> PRESS 7
                                                        Check Size ==> PRESS 8
                                                        Check IF Empty ==> PRESS 9
                                                        Check Value ==> PRESS 10
                                                        Search ==> PRESS 11
                                                        Index of Value ==> PRESS 12");
                        int linkListResponse = Convert.ToInt32(Console.ReadLine());
                        if (linkListResponse == 1)
                        {
                            Console.WriteLine("Enter the value to Add to the head: ");
                            string value = Console.ReadLine();
                            populate.AddHead(value);
                        }
                        else if (linkListResponse == 2)
                        {
                            Console.WriteLine("Enter the value to Add to the tail: ");
                            string value = Console.ReadLine();
                            populate.AddTails(value);
                        }
                        else if (linkListResponse == 3)
                        {
                            Console.WriteLine($"The Head Node is {populate.head}");
                        }
                        else if (linkListResponse == 4)
                        {
                            Console.WriteLine($"The tail Node is {populate.tail}");
                        }
                        else if (linkListResponse == 5)
                        {

                            populate.RemoveHead();
                            Console.Write($"Remaing Node: ");
                            populate.Print();
                        }
                        else if (linkListResponse == 6)
                        {
                            populate.RemoveTail();
                            Console.Write($"Remaining Node: ");
                            populate.Print();
                        }
                        else if (linkListResponse == 7)
                        {
                            string value = Console.ReadLine();
                            populate.Remove(value);
                            Console.WriteLine("The Remaining Node: ");
                            populate.Print();
                        }
                        else if (linkListResponse == 8)
                        {
                            Console.Write("The size of the Linked List is: ");
                            populate.Size();
                        }
                        else if (linkListResponse == 9)
                        {
                            bool answer = populate.isEmpty();
                            if (answer == true)
                            {
                                Console.WriteLine("The Array is EMPTY!!!");
                            }
                            else
                            {
                                Console.WriteLine("The Array is NOT EMPTY!!!");
                            }
                        }
                        else if (linkListResponse == 10)
                        {
                            Console.WriteLine("Enter the value to Check: ");
                            string value = Console.ReadLine();
                            bool answer = populate.Check(value);
                            string report = (answer == true) ? "FOUND" : "NOT FOUND";
                            Console.WriteLine(report);

                        }
                        else if (linkListResponse == 11)
                        {
                            string value = Console.ReadLine();
                            populate.Search(value);
                        }
                        else if (linkListResponse == 12)
                        {
                            string value = Console.ReadLine();
                            Console.WriteLine( $"The index of {value} is {populate.Index(value)}"); 

                        }
                        else if (linkListResponse == 13)
                        {
                            linklistsession = false;
                        }
                    }
                }
                else if (response ==2)
                {

                }
                else if(response == 3)
                {

                }
                else
                {
                    session = false;
                }
               

            }



        }
    }
}
