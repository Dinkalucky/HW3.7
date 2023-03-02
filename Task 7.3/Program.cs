using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._3
{
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "змінено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "змінено";
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "не змінено";
            myStruct.change = "не змінено";

            Console.WriteLine("Класс");
            ClassTaker(myClass);
            Console.WriteLine(myClass.change);

            Console.WriteLine("Структура");
            StruktTaker(myStruct);
            Console.WriteLine(myStruct.change);
            Console.ReadLine();
        }
    }
}
