using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string firstPoint = trainArray[0].PointA;
            int firstNumber = trainArray[0].TrainNumber;
            string firstTime = trainArray[0].DepTime;
            for (int i = 0; i < trainArray.Length; i++)
            {
                for (int j = i; j < trainArray.Length; j++)
                {
                    if (trainArray[i].TrainNumber > trainArray[j].TrainNumber)
                    {
                        firstNumber = trainArray[j].TrainNumber;
                        firstPoint = trainArray[j].PointA;
                        firstTime = trainArray[j].DepTime;
                        trainArray[j].TrainNumber = trainArray[i].TrainNumber;
                        trainArray[j].PointA = trainArray[i].PointA;
                        trainArray[j].DepTime = trainArray[i].DepTime;
                        trainArray[i].TrainNumber = firstNumber;
                        trainArray[i].PointA = firstPoint;
                        trainArray[i].DepTime = firstTime;
                    }
                }
            }

            int trainNum;
            Console.WriteLine("Який поїзд бажаєте викликати?");
            Int32.TryParse(Console.ReadLine(), out trainNum);

            foreach (var item in trainArray)
            {
                if (item.TrainNumber == trainNum)
                {
                    Console.Write("Ваш поїзд: " + item.PointA + " " + item.TrainNumber + " " + item.DepTime + "\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Такого поїзда немає, подивіться увесь список поїздів: ");
                }
                
            }

            Console.WriteLine("Всі поїзди:");

            foreach (var item in trainArray)
            {
                Console.Write(item.PointA + " " + item.TrainNumber + " " + item.DepTime + "\n");
            }

            Console.ReadLine();

        }
    }
}
