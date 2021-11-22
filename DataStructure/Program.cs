using System;

namespace DataStructure
{
    class Program
    {
        private static int position;

        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to Linked List Problems!");
                LinkList ln = new LinkList();
                ln.Add(56);
                ln.Add(30);
                ln.Add(70);
                ln.Display();
                int pos = ln.Search(40);
                ln.DeleteNodeAtParticularPosition(pos);
        }
    }
}
