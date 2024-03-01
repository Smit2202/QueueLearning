using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLearning
{
    public class QueueShow
    {
        public static void Show(Queue<string> queueName)
        {
            // Print all elements of the Queue.
            foreach (string item in queueName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
