using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLearning
{
    public class RemoveElement
    {
        public void Remove(Queue<string> queueName)
        {
            if(QueueNull.CheckNull(queueName))
            {
                // Return value and remove from the Queue. 
                var removedElement = queueName.Dequeue();
                Console.WriteLine($"Remove element {removedElement} from {queueName}.");
            }
        }
    }
}
