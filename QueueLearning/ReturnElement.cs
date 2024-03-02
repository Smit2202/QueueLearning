using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLearning
{
    public class ReturnElement
    {
        public void ReturnElementFromQueue(Queue<string> queueName)
        {
            // Return value without removing from the Queue. 
            var peekElement = queueName.Peek();
            Console.WriteLine($"Peek element {peekElement} from {queueName}.");
        }
    }
}
