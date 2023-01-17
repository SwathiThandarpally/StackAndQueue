using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public  class QueueDequeue
    {
        public void Display()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(56);
            queue.Enqueue(36);
            queue.Enqueue(70);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            Console.WriteLine("After dequeue");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            Console.WriteLine("After dequeue");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            Console.WriteLine("After dequeue");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Queue Is Empty");
        }
    }
}
