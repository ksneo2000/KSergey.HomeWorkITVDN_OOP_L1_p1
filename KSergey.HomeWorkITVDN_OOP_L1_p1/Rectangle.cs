using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSergey.HomeWorkITVDN_OOP_L1_p1
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
            {

            this.side1 = side1;
            this.side2 = side2;


            }

        public double AreaCalculator(double side1, double side2)
        {
            return side1*side2;
        }

        public double Area
        { get
            {
                return Area;
            }
        }


    }
}
