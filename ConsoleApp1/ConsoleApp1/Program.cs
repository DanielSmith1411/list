using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        class LinkedList
        {
            public class Node
            {
                public object Contents; //The variable stored in the node. Change the 'object' to a different data type.
                public Node Next; //Reference to the next node
            }

            private Node head; //Points to the start of the list

            public LinkedList()
            {
                head = null; //For the first node, the head will be null. The heads of the next node will reference the node before it.
            }

            void InsertBeginning(object Contents)
            {
                Node newNode = new Node();
                newNode.Contents = Contents;
                if (head == null)

                {
                    newNode.Next = null;
                }
                else
                {
                    newNode.Next = head;
                }
                head = newNode;
            }

            void InsertAfter(object Contents)
            {

            }

            void RemoveBeginning(LinkedList Node)
            {

            }

            void RemoveAfter(LinkedList Node)
            {

            }

            public int Length(LinkedList Node) //If the function doesn't work, it will be because of this line. Internet search was very unhelpful.
            {
                if (Node == null)
                {
                    return 0;
                }
                return 0;
            }
        }

        static public string input;
    

        

        static void Main(string[] args) //This is where all functions should be called from. There shouldn't be any inputs above here.
        {
            //Variable storage
            string input = Program.input;
            bool isRunning = true;


            Console.WriteLine("Welcome to the program."); //To Do: Find a better way of printing to multiple lines.
            Console.WriteLine("");

            while (isRunning == true)
            {
                Console.WriteLine("temporary text xxxxxxxxxxxx"); //This is where the functions will be listed.
                input = Console.ReadLine();
                if (input == "test")
                {
                    Console.WriteLine("The test is successful"); //Replace this line with a function call once a function has been written.
                }
                else if (input == "length")
                {
                    LinkedList.Length(Node);
                }
                else if (input == "quit") //Simple quitting.
                {
                    Console.WriteLine("Press Enter to quit or type BACK to return.");
                    input = Console.ReadLine();
                    if (input != "BACK")
                    {
                        isRunning = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }
    }
}
