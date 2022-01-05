using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class Queue
    {
        static int Size { get; set; } = 10;
        static  public int Front , Rear = -1;
        static int [] queue = new int[Size];
        static int count = 0;


        public static  void Enqueue(int item)
        {
            if(Rear == Size-1)
                throw new Exception("Stack Overflow");

            if(count is 0)
                Front++; 

            queue[++Rear] = item; count++;
        }

        public static void Dequeue()
        {
            if(Front == Size-1)
                throw new Exception("Stack Underflow");

           queue[Front] = 0;
           Front++;
        }

        public static void DisplayQueue()
        {
            for (int i = 0; i < queue.Length; i++)
            {
                if(queue[i] != 0)
                    System.Console.WriteLine(queue[i]);
            }
        }
    }
}