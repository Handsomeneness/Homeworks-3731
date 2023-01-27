using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Message("Введите первое число");
            double b = Message("Введите второе число");
            Choice(a, b);
            Console.WriteLine();

            double value = Message("введите число");
            ElementsSumm(value);
            Console.WriteLine();

            int arrLenght = Message("Введите длину массива");
            int[] array = GenerateArray(arrLenght, 0, 50);
            PrintArray("Сгенерированный массив", array);
        }

        
        public static int Message(string msg)
        {
            Console.WriteLine(msg);
            return int.Parse(Console.ReadLine() ?? "0");
        }

        #region 25
        public static void Choice(double a, double b)
        {
            Console.WriteLine();
            Console.WriteLine("Доступные команды");
            Console.WriteLine("1: -");
            Console.WriteLine("2: +");
            Console.WriteLine("3: /");
            Console.WriteLine("4: *");
            Console.WriteLine("5: Возведение в степень");
            Console.WriteLine("Введите команду");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Console.WriteLine($"Ответ: {a - b}");
                    break;
                case 2:
                    Console.WriteLine($"Ответ: {a + b}");
                    break;
                case 3:
                    Console.WriteLine($"Ответ: {a / b}");
                    break;
                case 4:
                    Console.WriteLine($"Ответ: {a * b}");
                    break;
                case 5:
                    Console.WriteLine($"Ответ: {Math.Pow(a, b)}");
                    break;
                default:
                    Console.WriteLine("Такой команды не существует");
                    break;
            }
        }
        #endregion

        #region 27
        public static void ElementsSumm(double value)
        {
            string summ = value.ToString();
            int temp = 0;
            for (int i = 0; i < summ.Length; i++)
            {
                temp += int.Parse(summ.Substring(i, 1));
            }
            Console.WriteLine(temp);
        }
        #endregion

        #region 29
        public static int[] GenerateArray(int number, int begin, int end)
        {
            Random random = new Random();
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(begin, end);
            }
            return array;
        }

        public static void PrintArray(string msg, int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write(array[i]+", ");
            }
            Console.Write(array[array.Length-1]+"]");
            Console.WriteLine();
        }
        #endregion
    }
}
