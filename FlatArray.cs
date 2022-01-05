using System.Security.Cryptography.X509Certificates;
namespace DataStructures
{
    public static class FlatArray
    {
       static  int[,] twoDiminensionalArray = {{2,3,9,0},{5,5,0,9},{6,4,9,0}};

        static int[] singleArray;
       public static void FlattenArray()
       {
            singleArray = new int[twoDiminensionalArray.Length];
           int count =-1; 
           for(int col=0;col<3; col++)
           {
               for(int row=0; row<4;row++)
               {
                   singleArray[++count] = twoDiminensionalArray[col, row];
               }
           }
       }

       public static void DisplaySingleArray()
       {
           foreach(var item in singleArray)
           {
               System.Console.WriteLine(item);
           }
       }

       public static void SumArray()
       {
           int sum=0;
           for(int col=0;col<3; col++)
           {
               for(int row=0; row<4;row++)
               {
                   sum += twoDiminensionalArray[col, row];
               }
           }
           System.Console.WriteLine(sum);
       }
    }

    
}
