namespace prjIndexersICE2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books(100, 1, "It Ends With Us", "Colleen Hoover");

            Console.WriteLine("Book Price: " + books[0]);
            Console.WriteLine("Book ISBN: " + books[1]);
            Console.WriteLine("Book Title: " + books[2]);
            Console.WriteLine("Book Author: " + books[3]);
            Console.Write("\n");

            Books book = new Books(1, 4, "Watch Me", "Tahereh Mafi");

            Console.WriteLine("Book Price: " + book["price"]);
            Console.WriteLine("Book ISBN: " + book["ISBN"]);
            Console.WriteLine("Book Title: " + book["title"]);
            Console.WriteLine("Book Author: " + book["author"]);
        }
    }
}
