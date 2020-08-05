using System;
using System.Threading.Channels;
using LinkedList;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            bool session = true;
            while (session == true)
            {
                //Session Started

                Console.WriteLine(@"What Would You Like To Do?
              +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
              DOUBLY LINKED LIST ==> PRESS 1     STACK ==> PRESS 2    QUEUE ==> Press 3   EXIT ==> PRESS 4
              +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        ");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


                int response = Convert.ToInt32(Console.ReadLine());
                if (response == 1)
                {
                    DLinkedList<string> populate = new DLinkedList<string>();
                    bool linklistsession = true;
                    while (linklistsession == true)
                    {
                        
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
                                                        Index of Value ==> PRESS 12
                                                             Pint     ==> PRESS 13
                                                           Main Menu   ==> 14");



                        int linkListResponse = Convert.ToInt32(Console.ReadLine());

                        // Add a value to the Head of the Linked List


                        if (linkListResponse == 1)
                        {
                            Console.WriteLine("Enter the value to Add to the head: ");
                            string value = Console.ReadLine();
                            populate.AddHead(value);
                        }

                        // Add a value to the Tail of the List

                        else if (linkListResponse == 2)
                        {
                            Console.WriteLine("Enter the value to Add to the tail: ");
                            string value = Console.ReadLine();
                            populate.AddTails(value);
                        }

                        //Returns the Head node Of the Linked List

                        else if (linkListResponse == 3)
                        {
                            Console.WriteLine($"The Head Node is {populate.head.Value}");
                        }

                        //Return the  Tail node of the Linked List
                        else if (linkListResponse == 4)
                        {
                            Console.WriteLine($"The tail Node is {populate.tail.Value}");
                        }

                        //Return The head node of the Linked list


                        else if (linkListResponse == 5)
                        {

                            populate.RemoveHead();
                            Console.Write($"Remaing Node: ");
                            populate.Print();
                        }

                        // Remove the Tail node of the Linked List

                        else if (linkListResponse == 6)
                        {
                            populate.RemoveTail();
                            Console.Write($"Remaining Node: ");
                            populate.Print();
                        }

                        //Remove a value From the linked List

                        else if (linkListResponse == 7)
                        {
                            string value = Console.ReadLine();
                            populate.Remove(value);
                            Console.WriteLine("The Remaining Node: ");
                            populate.Print();
                        }

                        //Returns the size of the Linked list

                        else if (linkListResponse == 8)
                        {
                            Console.Write("The size of the Linked List is: ");
                            populate.Size();
                        }


                        // Checks if the link list is empty or contain nodes


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

                        //Check for a value in the linked list

                        else if (linkListResponse == 10)
                        {
                            Console.WriteLine("Enter the value to Check: ");
                            string value = Console.ReadLine();
                            bool answer = populate.Check(value);
                            string report = (answer == true) ? "FOUND" : "NOT FOUND";
                            Console.WriteLine(report);

                        }

                        //Search for  a value in the Linked list

                        else if (linkListResponse == 11)
                        {
                            string value = Console.ReadLine();
                            populate.Search(value);
                        }

                        //Return the index of a Node int the Liked List


                        else if (linkListResponse == 12)
                        {
                            string value = Console.ReadLine();
                            Console.WriteLine($"The index of {value} is {populate.Index(value)}");

                        }

                        //Print the linked list

                        else if (linkListResponse == 13)
                        {
                            populate.Print();
                        }

                        //Close Linked list session

                        else if (linkListResponse == 14)
                        {
                            linklistsession = false;
                        }
                        // Ask the user again if the input was not valid
                        else
                        {
                            Console.WriteLine(" PLEASE ENTER A VALID NUMBER!!!!!!!!!!!!!!!!");
                        }
                    }
                }

                //Generic Stack


                else if (response == 2)
                {

                    //Instance of a new stack

                    GenericStack<string> own = new GenericStack<string>();


                    //Generic stack sessio
                    bool stackSession = true;
                    while (stackSession == true)
                    {

                        //Options


                        Console.WriteLine(@"Options:         
                                                Push ==> PRESS 1
                                                Pop ==>  PRESS 2
                                                Peek ==> PRESS 3
                                                Size ==> PRESS 4
                                         Check Empty ==> PRESS 5
                                                Print ==> PRESS 6
                                            Main Menu ==> PRESS 7");
                        int stackResponse = Convert.ToInt32(Console.ReadLine());
                        
                        //Push a Node to top of the stack

                        if (stackResponse == 1)
                        {
                            string value = Console.ReadLine();
                            own.Push(value);
                            Console.Write("The Stack is now: ");
                            own.Print();


                        }

                        // Removes a node from the top of the stack

                        else if (stackResponse == 2)
                        {
                            own.Pop();
                            Console.Write("The Stack is now: ");
                            own.Print();
                        }

                        //Returns the node at the top of the stack


                        else if (stackResponse == 3)
                        {
                            Console.WriteLine($"The node at the top of the Stack is: ");
                            own.Peek();
                        }

                        //Returns the size of the stack

                        else if (stackResponse == 4)
                        {
                            Console.WriteLine($"The Size of the Stack is {own.Size()}");
                        }

                        //Returns if the stack is empty or Not

                        else if (stackResponse == 5)
                        {

                            var result = (own.Size() == 0) ? true : false;
                            if (result == true)
                            {
                                Console.WriteLine("The Stack is Empty: ");
                            }
                            else
                            {
                                Console.WriteLine("The Stack is Not Empty: ");
                            }
                        }

                        //Print all the nodes in the stack

                        else if (stackResponse == 6)
                        {
                            Console.WriteLine("All Nodes in the Stack: ");
                            own.Print();
                        }

                        //Ends Stack Session

                        else if (stackResponse == 7)
                        {
                            stackSession = false;
                        }

                        //Ask the user again if the value was invalid

                        else
                        {
                            Console.WriteLine("PLEASE ENTER A VALID NUMBER!!!!!!!!!!!!!!!!!!");
                        }

                    }

                }
                else if (response == 3)
                {

                    // Stack session started


                    //An instance of Queue is created
                    GenericQueue<string> bam = new GenericQueue<string>();

                    bool queueSession = true;
                    while (queueSession == true)
                    {

                        //Options


                        Console.WriteLine(@"OPTIONS
                                                        Enqueue ==> PRESS 1
                                                        Dequeue ==> PRESS 2
                                                        Size ==> PRESS 3
                                                        Check Empty ==> PRESS 4
                                                        Print ==> PRESS 5");
                        int queueResponse = Convert.ToInt32(Console.ReadLine());

                        if (queueResponse == 1)
                        {

                            //Add a node to the tail of the queue


                            string value = Console.ReadLine();
                            bam.Enqueue(value);
                            Console.Write($"The Queue is now: ");
                            bam.Print();
                        }

                        //Removes a node from the head of the Queue


                        else if (queueResponse == 2)
                        {
                            bam.Dequeue();
                            Console.WriteLine("The is Queue is now: ");
                            bam.Print();
                        }

                        //Find the size of the QUeue

                        else if (queueResponse == 3)
                        {
                            Console.WriteLine($"The Size of the Queue is {bam.Size()}");
                        }

                        //Returns Empty or Not


                        else if (queueResponse == 4)
                        {
                            bool result = (bam.Size() == 0) ? true : false;
                            if (result == true)
                            {
                                Console.WriteLine($"The Queue is Empty");
                            }
                            else
                            {
                                Console.WriteLine("The Queue is Not Empty");
                            }
                        }

                        //Returns all the node in the queue

                        else if (queueResponse == 5)
                        {
                            Console.WriteLine("The Item on the Queue: ");
                            bam.Print();
                        }
                        else
                        {

                            // ends the queue session


                            queueSession = false;
                        }
                    }

                }
                else
                {

                    //ends all session

                    session = false;
                }


            }



        }
    }
}
