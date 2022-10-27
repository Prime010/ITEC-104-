public class ProgramStruct
{
    struct Employee
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string CompletedTraining;
    }
    public static void Main(string[] args)
    {

        Employee employee1;

        Console.WriteLine("What is your first name?");
        employee1.FirstName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("What is your last name?");
        employee1.LastName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("How old are you?");
        employee1.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Do you complete your training?");
        employee1.CompletedTraining = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("You entered");
        Console.WriteLine("First Name: " + employee1.FirstName);
        Console.WriteLine("Last Name: " + employee1.LastName);
        Console.WriteLine("Age: " + employee1.Age);
        Console.WriteLine("Completed the Training? " + employee1.CompletedTraining);
    }
}