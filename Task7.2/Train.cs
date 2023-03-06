using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task7._2
{
    internal struct Train:IComparable
    {
        private string pointA;
        private int trainNumber;
        private string depTime;

        public string PointA
        {
            get { return pointA; }
            set { pointA = value; }
        }

        public int TrainNumber
        {
            get { return trainNumber; }
            set { trainNumber = value; }
        }

        public string DepTime
        {
            get { return depTime; }
            set { depTime = value; }
        }

        public int CompareTo(object obj)
        {
            if (obj is Train train) return TrainNumber.CompareTo(train.TrainNumber);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
