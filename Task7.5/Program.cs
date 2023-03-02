using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Notebook notebook = new Notebook("NewNotes_2023","Bullet Journal",2345);
            notebook.ShowStruct();
            Console.ReadLine();
        }
    }
}
