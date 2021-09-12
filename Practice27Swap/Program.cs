using System;

namespace Practice27Swap
{
    class Program
    {
        class Swap
        {
            public static void swapping(ref int a, ref int b)
            {
                int n;
                n = a;
                a = b;
                b = n;
            }
            static void Main(string[] args)
            {
                int a, b;
                Console.WriteLine("Function : To swap the values of two integer numbers :");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Enter a number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number:");
                b = Convert.ToInt32(Console.ReadLine());
                swapping(ref a, ref b);
                Console.WriteLine("Now the 1st number is : {0} , and the 2nd number is : {1}", a, b);
            }
        }
        
    }
}
