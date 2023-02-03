using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Message("Введите длину массива");
            int[] array = GenerateArray(number);
            Console.WriteLine($"Количество положительных элементов: {CountGreaterThanZero(array)}");

            Console.WriteLine();

            double b1 = Message("Введите значение b1");
            double k1 = Message("Введите значение k1");
            double b2 = Message("Введите значение b2");
            double k2 = Message("Введите значение k2");
            Intersection(b1, k1, b2, k2);
        }

        public static int Message(string msg)
        {
            Console.WriteLine(msg);
            return int.Parse(Console.ReadLine() ?? "0");
        }

        #region 41
        public static int[] GenerateArray(int number)
        {
            string msg = "Введите число";
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(msg);
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        public static int CountGreaterThanZero(int[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item > 0)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion

        #region 43
        public static void Intersection(double b1, double k1, double b2, double k2)
        {
            double x;
            double y;
            if ((k1 == k2) && (b1 == b2))
            {
               Console.WriteLine("Прямые совпадают");
            }

            else if (k1 == k2)
            {
                Console.WriteLine("Прямые параллельны");
            }

            else
            {
               x = (b2 - b1) / (k1 - k2);

               y = k1 * (b2 - b1) / (k1 - k2) + b1;

               Console.WriteLine($"Пересечение в точке: ({x};{y})"); ;
            }
        }
        #endregion
    }
}
