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
            //QueueNull.CheckNull(queueName);

            if (QueueNull.CheckNull(queueName))
            {
                bool check = false;

                while (!check)
                {
                    // Take Inpute string from user.
                    Console.Write("Enter String: ");
                    string? nstring = Console.ReadLine();

                    if (string.IsNullOrEmpty(nstring) || string.IsNullOrWhiteSpace(nstring))
                    {
                        Console.WriteLine("You Enter Nothing Please Enter. ");
                        Console.WriteLine("");
                    }
                    else if (queueName.Contains(nstring))
                    {
                        Console.WriteLine($"The String {nstring} is in Queue.");
                        Console.WriteLine("");
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine($"Queue don't Conatin {nstring}.");
                        Console.WriteLine("");
                        check = true;
                    }
                }
            }
        }
    } 
}
