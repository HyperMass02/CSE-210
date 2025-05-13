using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("Plese select an option:");
            Console.WriteLine("1. Create a new resume");
            Console.WriteLine("2. View existing resumes");
            Console.WriteLine("3. Exit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Resume();
                    break;
                case "2":
                    break;
                case "3":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        {
            
        }
    }
}
