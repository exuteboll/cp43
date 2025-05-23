using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    class Program
    {
        /// <summary>
        /// метод класс такер принимает значения класса и изменяет значение change (myClass)
        /// <summary>
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }
        /// <summary>
        /// Метод структуры такер принимает структуру и изменяет поле структуры change
        /// <summary>
         static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
        static void Main(string[] args)
        {

        MyClass myclass = new MyClass(); // создаем экземпляр класса
        myclass.change = "не изменено"; // инициализируем поля
        MyStruct mystruct = new MyStruct(); // создаем экземпляр структуры
        mystruct.change = "Не изменено"; // инициализируем поля
        CW($"MyClass.change = {MyClass.change}");
           cw($"MyStruct.change = {MyStruct.change}");
            //вызываем методы 
        ClassTaker(myclass);
        StructTaker(mystruct);
        Console.WriteLine($"Структура: " + mystruct.change);
        Console.WriteLine($"Класс: " + myclass.change);
        Console.ReadKey();
           
          
        }
    }
}
