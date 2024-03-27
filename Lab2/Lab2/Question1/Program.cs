using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{ 
     public class book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title:{Title}");
        Console.WriteLine($"Author:{Author}");
    }
}
    public class Program
    {
        static void Main(string[] args)
        {
        book book = new book();
        book.Title = "Harry Potter";
        book.Author = "J.K.Rowling";
        Console.WriteLine("\nBook Information:");
        book.DisplayInfo();
        }
    }
}
