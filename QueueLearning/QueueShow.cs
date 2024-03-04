using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLearning
{
    public class QueueShow
    {
        public void Show(Queue<string> queueName)
        {
            if(QueueNull.CheckNull(queueName)) // Check that Queue Is Empty or not ?
            {
                // Print all elements of the Queue.
                foreach (string item in queueName)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
