using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    struct Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int NumberPage { get; set; }
        public Book(string title,string author,int year, int numberPage)
        {
            Title = title;
            Author = author;
            Year = year;
            NumberPage = numberPage;
        }
        public void Print()
        {
            Console.WriteLine($"Название: {Title}\t Автор: {Author}\t Год выпуска: {Year}\t Кол-во страниц{NumberPage}");
        }
    }
}
