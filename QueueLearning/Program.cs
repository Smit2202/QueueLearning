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
            bool Task = false;

            while (!Task)
            {
                Console.WriteLine($"{Environment.NewLine}Add = A, {Environment.NewLine}Displaying the Queue = B,{Environment.NewLine}Check = F, {Environment.NewLine}Quit = E");
                Console.WriteLine();

                Console.Write("Enter What You Want to do? : ");
                string Uinput = Console.ReadLine();
                switch (Uinput)
                {
                    case "A":
                        // adds
                        Console.Write("Enter the string: ");
                        string Uin = Console.ReadLine();
                        QueueAdd.Add(Uin, fruits);
                        break;
                    case "B":
                        // print elements of the queue 
                        foreach (string item in fruits)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "E":
                        Task = true;
                        break;
                    case "F":
                        Console.WriteLine("Enter String");
                        string nstring = Console.ReadLine(); 
                        Console.WriteLine(fruits.Contains(nstring));
                        break;
                    default:
                        Console.WriteLine("Enter Valid Inpute");
                        break;
                }

            }

            

        }
    }
}
