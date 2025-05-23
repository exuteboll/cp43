using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Введите кол во книг");
            int n = int.Parse(Console.ReadLine());

            Book[] books = new Book[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите название для книги {i + 1}");
                string title = Console.ReadLine();

                Console.WriteLine("Введите автора:");
                string author = Console.ReadLine();

                Console.WriteLine("Введите год выпуска:");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine("Количество страниц:");
                int pages = int.Parse(Console.ReadLine());

                books[i] = new Book(title, author, year, pages);
            }
            Console.WriteLine("Информация о всех книгах: ");
            foreach(Book book in books)
            {
                book.Print();
            }
            Console.ReadKey();
        }
    }
}
