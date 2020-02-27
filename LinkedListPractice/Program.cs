using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            LNode startingNode = new LNode("test data");
            LinkedList testList = new LinkedList(startingNode);
            testList.insertInBack("another test.");
            Console.ReadKey();
            
        }
    }
}
