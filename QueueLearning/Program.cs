using System;
using System.Collections.Generic;
using QueueLearning;

namespace QueueLearning
{
    class QueueLearning
    {
        public static void Main(string[] args)
        {
            // Create a Queue
            Queue<string> fruitsQueue = new Queue<string>();

            // Loop for take inpute from user.
            bool quit = false;
            while (!quit)
            {
                // Taking inpute from user for which task Perform.
                string UserInputModule = UserInput.Input();

                switch (UserInputModule)
                {
                    // Add Element in Queue.
                    case "add":                        
                        QueueAdd.Add(fruitsQueue);
                        break;
                    // Show Queue.
                    case "show":                        
                        QueueShow.Show(fruitsQueue);
                        break;
                    // Check the Element is in Queue or not .
                    case "check":
                        QueueCheck.Check(fruitsQueue);
                        break;
                    case "remove":
                        RemoveElement.Remove(fruitsQueue);
                        break;
                    case "return":
                        ReturnElement.ReturnElementFromQueue(fruitsQueue);
                        break;
                    // Quit the Application.
                    case "quit":
                        quit = true;
                        break;
                    // Invalid Inpute.
                    default:
                        Console.WriteLine("Enter Valid Inpute");
                        break;
                }
            }           
        }
    }
}
