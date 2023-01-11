using System;

public class ProgramStruct
{
    struct Employee
    {
        public string FIRSTNAME;
        public string LASTNAME;
        public int AGE;
        public string CCOMPLETED_TRAINING;
    }
    public static void Main(string[] args)
    {

        Employee employee_PRIME;

        Console.WriteLine("What is your first name?");
        employee_PRIME.FIRSTNAME = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        employee_PRIME.LASTNAME = Console.ReadLine();

        Console.WriteLine("How old are you?");
        employee_PRIME.AGE = int.Parse(Console.ReadLine());

        Console.WriteLine("Have you complete your training?");
        employee_PRIME.CCOMPLETED_TRAINING = Console.ReadLine();

        Console.WriteLine("You entered");
        Console.WriteLine("First Name: " + employee_PRIME.FIRSTNAME);
        Console.WriteLine("Last Name: " + employee_PRIME.LASTNAME);
        Console.WriteLine("Age: " + employee_PRIME.AGE);
        Console.WriteLine("Completed the Training? " + employee_PRIME.CCOMPLETED_TRAINING);
    }
}