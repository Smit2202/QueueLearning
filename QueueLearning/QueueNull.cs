using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLearning
{
    public class QueueNull
    {
        public static bool CheckNull(Queue<string> queueName)
        {
            if (queueName.Count == 0)
            {
                // Print that  Queue is Empty.
                Console.WriteLine("The queue is empty.");
                return false;
            }
            return true;
        }
    }
}
