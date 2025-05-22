using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    struct NoteBook
    {
        public string Model { get; set; }
        public string Proizv { get; set; }
        public int Price { get; set; }

        public NoteBook(string model, string proizv, int price )
        {
            Model = model;
            Proizv = proizv;
            Price = price;
        }
        public void Print()
        { Console.WriteLine($"MOdel: {Model}\t Proizv: {Proizv}\t Price: {Price}"); }
    }
}
