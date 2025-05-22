using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }
         static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
        static void Main(string[] args)
        {

        MyClass myclass = new MyClass();
        myclass.change = "не изменено";
        MyStruct mystruct = new MyStruct();
        mystruct.change = "Не изменено";
        ClassTaker(myclass);
        StructTaker(mystruct);
        Console.WriteLine($"Структура: " + mystruct.change);
        Console.WriteLine($"Класс: " + myclass.change);
        Console.ReadKey();
           
          
        }
    }
}
