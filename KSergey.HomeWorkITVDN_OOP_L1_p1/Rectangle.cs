using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSergey.HomeWorkITVDN_OOP_L1_p1
{
    class Rectangle
    {
        // создаю входящие поля
        private double side1;
        private double side2;

        // создаю конструктор и  прописываю значения полей по умолчанию
        public Rectangle(double side1, double side2)
            {

            this.side1 = side1;
            this.side2 = side2;


            }

        // метод расчитывающий прощадь прямоугольника
        double AreaCalculator()
        {
            return side1*side2;
        }

        // свойство только для чтения возвращает значение площади
        public double Area
        { get
            {
                return this.AreaCalculator();
            }
        }
        // метод расчитывающий периметр прямоугольника
        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        // свойство только для чтения возращает значение периметра
        public double Perimeter
        {
            get
            {
                return this.PerimeterCalculator();
            }
        }
    }
}
