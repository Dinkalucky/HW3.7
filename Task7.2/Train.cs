using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    internal struct Train
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
    }
}
