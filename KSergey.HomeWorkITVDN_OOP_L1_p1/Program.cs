using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KSergey.HomeWorkITVDN_OOP_L1_p1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //вводим с клавы значение сторон
            Console.WriteLine("Введите значение первой стороны прямоугольника");

            //UNDONE узнать у Вадима как правильно использовать данную конструкцию
            /* как правильно это записывать не полуячилось???
             * if (int.tryparce(Console.ReadLine(), out int input))
            {
                return side1;
            }
            */
            
            double side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение второй стороны прямоугольника");
            double side2 = Convert.ToInt32(Console.ReadLine());

            // инициализирую новый экземпляр класса myRectangle
            Rectangle myRectangle = new Rectangle(side1, side2);

            // вывожу значение площади и периметра
            Console.WriteLine($"Площадь прямоугольника = {myRectangle.Area}. Периметр прямоугольника = {myRectangle.Perimeter}");

            //задержка консоли
            Console.ReadKey();
        }
    }
}
