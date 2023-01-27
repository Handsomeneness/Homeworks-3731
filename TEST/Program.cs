using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа
            //   ввод данных
            int num = ReadData("Введите число: ");


            bool result = PalinTest(num);
            if (result)
            {
                PrintData("Число является палиндромом");
            }
            else
            {
                PrintData("Число не является палиндромом");
            }

            // вывод данных 
            


        }

        // 1. Метод читает данные от пользователя
       public static int ReadData(string msg)
        {
            Console.WriteLine(msg);
            return int.Parse(Console.ReadLine() ?? "0");
        }


        // 2. Метод PalinTest - определения палиндрома 
       public static bool PalinTest(int n)
        {
            int d1 = n / 10000;
            int d2 = (n / 1000) % 10;
            int d3 = (n / 10) % 10;
            int d4 = n % 10;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            bool res = ((d1 == d4) && (d2 == d3)) ? true : false;
            return res;
        }


        // 3. Метод вывода результата пользователю
        public static void PrintData(string msg1)
        {
            Console.WriteLine(msg1);
        }


    }
}
