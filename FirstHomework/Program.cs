using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhoseGreater();
            //Console.WriteLine();
            //Maximum();
            //Console.WriteLine();
            Remains();
        }

        public static void WhoseGreater()
        {
            Console.WriteLine("Введите первое число");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine($"Первое число: {a} больше второго: {b}");
            else
                Console.WriteLine($"Второе число: {b} больше первого: {a}");
        }

        public static void Maximum()
        {
            Console.WriteLine("Введите первое число");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine($"Первое число максимальное: {a}");

            else if (b > a && b > c)
                Console.WriteLine($"Второе число максимальное: {b}");

            else 
                Console.WriteLine($"Третье число максимальное: {c}");
        }

       public static void Remains()
        {
            Console.WriteLine("Введите число");
            double a = double.Parse(Console.ReadLine());

            if (a % 2 > 0)
                Console.WriteLine("Вы ввели нечётное число");
            else
                Console.WriteLine("Вы ввели чётное число");
        }


    }
}
