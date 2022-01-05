using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            
             System.Console.WriteLine(new Factorial().FactLoop(5));
              
            
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
         

        }
    }
}
