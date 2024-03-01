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
        public static void Add(string item, Queue<string> QNAme)
        {
            QNAme.Enqueue(item);
        }
    }
}
