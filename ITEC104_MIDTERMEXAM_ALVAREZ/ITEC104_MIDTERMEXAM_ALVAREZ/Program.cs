Stack<int> st = new Stack<int>();

Console.WriteLine("Stack Menu (size--10)");
Console.WriteLine("\t 1: Add an Element");
Console.WriteLine("\t 2: See Top Element");
Console.WriteLine("\t 3: Remove Top Element");
Console.WriteLine("\t 4: Display Stack Element");
Console.WriteLine("\t 5: Exit");

while (true)
{

    Console.Write("\nSelect what you want to do: ");
    int choice = Convert.ToInt32(Console.ReadLine());



    switch (choice)
    {
        case 1:
            Console.Write("Enter the element: ");
            int element = Convert.ToInt32(Console.ReadLine());
            if (st.Count != 10)
            {
                st.Push(element);
                Console.WriteLine("Item is pushed successfully!\n");
            }
            else
            {
                Console.WriteLine("Stack is already complete. \n");
            }
            break;


        case 2:
            Console.WriteLine("Top element: {0}. \n", st.Peek());
            break;

        case 3:
            st.Pop();
            Console.WriteLine("Top element was removed completely! \n");
            break;

        case 4:
            foreach (var item in st)
            {
                Console.WriteLine(" " + item);
            }
            break;

        case 5:
            Environment.ExitCode = 0;
            break;

        default:
            Console.WriteLine("Stack was unsuccessfully! \n ");
            break;

    }
}


