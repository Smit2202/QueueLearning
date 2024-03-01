using System;
using System.Collections.Generic;
using QueueLearning;

namespace QueueLearning
{
    class QueueLearning
    {
        public static void Main(string[] args)
        {
            // create a queue
            Queue<string> fruits = new Queue<string>();
            bool task = false;

            while (!task)
            {
                Console.WriteLine($"{Environment.NewLine}Add = add, {Environment.NewLine}Displaying the Queue = show,{Environment.NewLine}Check = check, {Environment.NewLine}Quit = quit");
                Console.WriteLine();

                Console.Write("Enter What You Want to do? : ");
                string UserInputModule = Console.ReadLine();
                switch (UserInputModule)
                {
                    case "add":
                        // adds
                        Console.Write("Enter the string: ");
                        string userInputString = Console.ReadLine();
                        QueueAdd.Add(userInputString, fruits);
                        break;
                    case "show":
                        // print elements of the queue 
                        foreach (string item in fruits)
                        {
                            Console.WriteLine(item);
                        }
                        break;                    
                    case "check":
                        Console.WriteLine("Enter String");
                        string nstring = Console.ReadLine(); 
                        Console.WriteLine(fruits.Contains(nstring));
                        break;
                    case "quit":
                        task = true;
                        break;
                    default:
                        Console.WriteLine("Enter Valid Inpute");
                        break;
                }

            }

            

        }
    }
}
