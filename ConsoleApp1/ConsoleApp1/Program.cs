using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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

            private Node head;

            public LinkedList()
            {
                head = null;
            }
        }

        static public string input;

        void InsertAfter()
        {

        }

        void RemoveBeginning()
        {

        }

        void RemoveAfter()
        {

        }

        void Length() //Whatever you do, don't use an incremental counter. That is cheating.
        {

        }

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
