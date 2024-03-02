using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLearning
{
    public class QueueCheck
    {
        public void Check(Queue<string> queueName)
        {
            // Take Inpute string from user.
            Console.WriteLine("Enter String");
            string nstring = Console.ReadLine();

            // Return the value 
            // If Contain => True 
            if (queueName.Contains(nstring))
            {
                Console.WriteLine($"The String {nstring} is in Queue.");
            }
            else
            {
                Console.WriteLine($"Queue don't Conatin {nstring}.");
            }
        }
    } 
}
