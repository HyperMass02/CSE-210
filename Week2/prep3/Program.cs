class Program{
    static void Main()
    {   
            Console.WriteLine("What is your number? ");
            string enumber = Console.ReadLine() ?? "unknown";

        while (true)
        {            
            Console.WriteLine("Enter your guess: ");
            string eguess = Console.ReadLine() ?? "unknown";

            int number = int.Parse(enumber);
            int guess = int.Parse(eguess);

            if (number == guess)
            {
                Console.WriteLine("Congratulations! You've guessed the magic number!");
                break;
            }
            else if (number >= guess) {
                Console.WriteLine("Higher");
                continue;
            }
            else if (number <= guess) {
                Console.WriteLine("Lower");
                continue;                  
            }
        }
    }
}