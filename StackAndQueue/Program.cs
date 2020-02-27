using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }



    public class Stack
    {
        const int max = 20;
        object[] arr = new object[max];
        int arrCount = 0;

        public void Push(object ob)
        {
            if (arrCount < max)
            {
                arr[arrCount] = ob;
                arrCount++;
            }
            else
            {
                Console.WriteLine("The Stack is Full");
            }
        }

        public object pop()
        {
            if (arrCount > 0)
            {
                Object rOb = arr[arrCount];
                arr[arrCount] = null;
                arrCount--;
                return rOb;
            }
            else
            {
                Console.WriteLine("The Stack is Full");
                return null;
            }
        }
    }

    public class Queue{
        const int max = 20;
        object[] arr = new object[max];
        int Qsize = 0;

        public void Add(object ob)
        {
            if(Qsize < max)
            {
                Qsize++;
                arr[Qsize - 1] = ob;
            }
            else
            {
                Console.WriteLine("The queue is full.");
            }
        }
        public object Pop()
        {
            
            if(Qsize > 0)
            {
                object rOb = arr[0];
                if (Qsize == 1)
                {
                    arr[0] = null;
                    Qsize--;
                    return rOb;
                }
                else
                {
                    for(int i = 0; i < Qsize-1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    arr[Qsize - 1] = null;
                    Qsize--;
                    return rOb;
                }

            }
            else
            {
                Console.WriteLine("The Stack is empty.");
                return null;
            }
            
        }

    }
}
