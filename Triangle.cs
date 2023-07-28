using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxApp
{
    public class Triangle:IFigure
    {
        private double storA;
        private double storB;
        private double storC;

        public Triangle(double storA,double storB, double storC)
        {
                this.storA = storA;
                this.storB = storB;
                this.storC = storC;
        }

        public double CalculateArea()
        {
            double p = (storA + storB + storC) / 2; // находим полупериметр
            return  Math.Sqrt(p*(p-storA)*(p-storB)*(p-storC));
        }
        public bool IsRightAngled()
        {
            double[] stors = {storA, storB, storC};
            Array.Sort(stors);
            return Math.Pow(stors[2], 2) == Math.Pow(stors[0], 2) + Math.Pow(stors[1],2);
        }
    }
}
