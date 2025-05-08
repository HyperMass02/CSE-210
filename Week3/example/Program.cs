class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1._title = "The Great Gatsby";
        book1._author = "F. Scott Fitzgerald";
        book1._pageCount = 180;
        
        Book book2 = new Book();
        book2._title = "To Kill a Mockingbird";
        book2._author = "Harper Lee";
        book2._pageCount = 281;

        Book book3 = new Book();
        book3._title = "1984";
        book3._author = "George Orwell";
        book3._pageCount = 328;

        Book book4 = new Book();
        book4._title = "The Catcher in the Rye"; 
        book4._author = "J.D. Salinger";
        book4._pageCount = 277;

        string summary1 = book1.getSummary();
        string summary2 = book2.getSummary();
        string summary3 = book3.getSummary();
        string summary4 = book4.getSummary();
        Console.WriteLine(summary1);
        Console.WriteLine(summary2);
        Console.WriteLine(summary3);
        Console.WriteLine(summary4);
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}