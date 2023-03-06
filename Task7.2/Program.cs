using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Train[] trainArray = new Train[2];
            for (int i = 0; i < trainArray.Length; i++)
            {
                Console.WriteLine($"Введіть пункт назначення {i+1} поїзда ");
                trainArray[i].PointA = Console.ReadLine();
                Console.WriteLine($"Введіть номер {i + 1} поїзда ");
                trainArray[i].TrainNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введіть час відправлення {i + 1} поїзда ");
                trainArray[i].DepTime = Console.ReadLine();

            }
            

            int trainNum;
            Console.WriteLine("Який поїзд бажаєте викликати?");
            Int32.TryParse(Console.ReadLine(), out trainNum);

            for (int i = 0; i<trainArray.Length;i++)
            {
                if (trainArray[i].TrainNumber == trainNum)
                {
                    Console.Write("Ваш поїзд: " + trainArray[i].PointA + " " + trainArray[i].TrainNumber + " " + trainArray[i].DepTime + "\n");
                    break;
                }
                else if(trainArray[i].TrainNumber != trainNum && i==trainArray.Length-1) 
                {
                    Console.WriteLine("Такого поїзда немає, подивіться увесь список поїздів: ");
                }
                
            }
            Console.WriteLine("Всі поїзди:");

            Array.Sort(trainArray);

            foreach (var item in trainArray)
            {
                Console.Write(item.PointA + " " + item.TrainNumber + " " + item.DepTime + "\n");
            }

            Console.ReadLine();

        }
    }
}
