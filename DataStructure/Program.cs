using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to Linked List Problems!");
                LinkList ln = new LinkList();
                ln.Add(56);
                ln.Add(30);
                ln.Add(70);
                ln.RemoveLastNode();
                Console.WriteLine("After removing is : ");
                ln.Display();
        }
        }
}
