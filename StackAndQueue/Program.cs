namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Stack And Queue Program");
            //UC_1
            Stack stack = new Stack();
            stack.Display();
            //UC_2
            StackPeakPop obj = new StackPeakPop();
            obj.Display();
            //UC_3
            Queue queue = new Queue();
            queue.Display();
        }
    }
}