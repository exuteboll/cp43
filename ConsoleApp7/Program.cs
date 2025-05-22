using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook noteBook = new NoteBook();
            noteBook.Price = 15523;
            noteBook.Model = "Intel";
            noteBook.Proizv = "amd";
            noteBook.Print();
            Console.ReadKey();
        }
    }
}
