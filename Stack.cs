namespace DataStructures
{
    public static class Stack
    {
        public static int maxValue { get; set; } = 10;
        public static int top  = -1;
        public static int[] stackArray { get; set; } = new int[maxValue];

        public static void Push(int item)
        {
            if(IsFull())
            {
                maxValue++;
                stackArray.CopyTo(new int[maxValue], 0); 
            }
            stackArray[++top] = item;
        }


        public static void Pop()
        {
            if(IsEmpty())
            {
                System.Console.WriteLine("Stack is empty");
               return;
            }
            stackArray[top] = 0;
            top--;
        }

        public static bool IsEmpty()
        {
            return top == -1;
        }

        public static bool IsFull()
        {
            return top == maxValue-1;
        }
        
        
    }
}
