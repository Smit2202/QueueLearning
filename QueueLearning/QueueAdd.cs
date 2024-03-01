using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLearning
{
    public class QueueAdd
    {
        public static void Add(Queue<string> queueName)
        {
            // Take Inpute string from user.
            Console.Write("Enter the string: ");
            string userInputString = Console.ReadLine();

            // Add UserInpute in Queue.
            queueName.Enqueue(userInputString);
        }
    }
}
