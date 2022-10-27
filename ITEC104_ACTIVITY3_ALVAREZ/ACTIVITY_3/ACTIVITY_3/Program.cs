using System;

namespace Activity_03
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] emails = { "yuriprime@gmail.com", "primezeravla@gmail.com", "alvarezjulian@gmail.com" };
            string[] usernames = { "yuriprime_5", "primezeravla_5", "alvarezjulian_5" };
            string[] passwords = { "PrimeAlvarez1", "PRimeAlvarez2", "PrimeAlvatrez3" };

            Console.Write("Index: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("\nemail: {0}", emails[index]);
            Console.WriteLine("username: " + usernames[index]);
            Console.WriteLine("password: " + passwords[index]);

            Console.ReadKey();
            Console.WriteLine("\nPress any key to Continue. . .");
        }
    }
}
