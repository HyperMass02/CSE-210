using System;
class Program
{
    static void Main(string[] args)
    {
        List<int> theList = new List<int>();
        while (true){
            

            Console.WriteLine("Enter number: ");
            string enumber = Console.ReadLine() ?? "unknown";
            int fnumber = int.Parse(enumber);

            
            if (fnumber == 0)
            {
                int count = theList.Count;
                int sum = theList.Sum();
                int max = theList.Max();
                int total = 0;

                foreach (int number in theList)
                {
                    total += number;
                }
                float average = (float)total / count;
                Console.WriteLine($"Count of the list: {count}");
                Console.WriteLine($"Max of the list: {max}");
                Console.WriteLine($"Total of the list: {total}");
                Console.WriteLine($"Average of the list: {average}");
                Console.WriteLine("The sorted list is:");
                foreach (int numbers in theList.OrderBy(n => n))
                {
                    Console.WriteLine(numbers);
                }
                    break;

                }
                else if (fnumber != 0)
                {
                    theList.Add(fnumber);
                    continue;

                }
            }
            
        }


        


    }