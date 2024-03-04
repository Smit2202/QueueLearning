using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLearning
{
    public class UserInput
    {
        public string Input()
        {
            // Take Inpute string from user
            Console.WriteLine($"{Environment.NewLine}Add Element = add, {Environment.NewLine}Displaying all the Element of the Queue = show,{Environment.NewLine}Check that Queue Contain's Element?  = check, {Environment.NewLine}Remove Element = remove, {Environment.NewLine}Return Element = return, {Environment.NewLine}Quit = quit,");
            Console.WriteLine();
            Console.Write("Enter What You Want to do? : ");
            string? UserInput = Console.ReadLine();

            // Return Value of UserInpute.
            return UserInput;
        }
    }
}
