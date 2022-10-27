using System;

namespace Activity4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] element = { 3, 9, 12, 18, 21, 65, 76, };
            Console.WriteLine("ARRAY_PRIME_PROGRAM");
            Console.WriteLine("Enter Element[0]= {0}", element[0]);
            Console.WriteLine("Enter Element[1]= {0}", element[1]);
            Console.WriteLine("Enter Element[2]= {0}", element[2]);
            Console.WriteLine("Enter Element[3]= {0}", element[3]);
            Console.WriteLine("Enter Element[4]= {0}", element[4]);
            Console.WriteLine("Enter Element[4]= {0}", element[5]);
            Console.WriteLine("Enter Element[4]= {0}", element[6]);
            Console.WriteLine("Odd Numbers: {0}, {1}, {2}, {3}.", element[0], element[1], element[4], element[5]);
            Console.WriteLine("Even Numbers: {0}, {1}, {2}.", element[2], element[3], element[6]); 
            Console.ReadKey();
        }
    }
}