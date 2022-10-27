public class ProgramStruct
{
    struct Employee
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public int height;
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
        Console.WriteLine("Height in centimeters?");
        employee1.height = int.Parse(Console.ReadLine());
        Console.WriteLine("================");
        Console.WriteLine("You entered");
        Console.WriteLine("First Name: " + employee1.FirstName);
        Console.WriteLine("Last Name: " + employee1.LastName);
        Console.WriteLine("Possition in Volleyball: " + employee1.Age + " years old ");
        Console.WriteLine("Completed the Training? " + employee1.height + " cm ");
    }
}