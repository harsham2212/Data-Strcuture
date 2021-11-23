using System;

namespace DataStructure
{
    class Program
    {
        private static int position;

        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to Linked List Problems!");
                Queue que = new Queue();
                que.Enqueue(70);
                que.Enqueue(30);
                que.Enqueue(56);
                que.Dequeue();
                que.Display();
        }
    }
}
