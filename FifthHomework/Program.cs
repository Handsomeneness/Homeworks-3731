using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Message("Введите длину массива");
            int[] array = GenerateArray(number, 100, 999);
            PrintArray(array);
            SortArray(array);
            Console.WriteLine($"Количество чётных: {CountOfEven(array)}");
            Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {MinMaxSearch(array)}");

            Console.WriteLine();

            int number2 = Message("Введите длину массива");
            int[] array2 = GenerateArray(number2, 1, 99);
            PrintArray(array2);
            Console.WriteLine($"Сумма элементов на нечётных позициях:  {SummUnevenElemets(array2)}");
            PairSearch(array2);
            Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {MinMaxSearch(array2)}");

        }

        public static int Message(string msg)
        {
            Console.WriteLine(msg);
            return int.Parse(Console.ReadLine() ?? "0");
        }
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

        public static int CountOfEven(int[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write(array[array.Length - 1] + "]");
            Console.WriteLine();
        }

        public static void SortArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                Console.Write(array[i] + ", ");
            }
            Console.Write(array[array.Length - 1] + "]");
            Console.WriteLine();
        }

        public static int SummUnevenElemets(int[] array)
        {
            int summ = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                summ += array[i];
            }
            return summ;
        }

        public static void PairSearch(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] ==  array[i+1])
                {
                    Console.WriteLine($"Элемент {i} : {array[i]} пара элементу {i+1} : {array[i+1]}");
                }
            }
        }

        public static int MinMaxSearch(int[] array)
        {
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return max - min;
        }
    }
}
