using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinthHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 64
            int number = Message("Введите число");//Получаем от пользователя данные и записываем в переменную
            NaturalNumbers(number);               //Выводим все натуральные числа от N до 1
            #endregion
            Console.WriteLine();                  //Новая строка
            #region 66
            int m = Message("Введите число M");//Получаем от пользователя данные и записываем в переменную
            int n = Message("Введите число N");//Получаем от пользователя данные и записываем в переменную
            SumFromMToN(m, n);                 //Выводи сумму элементов от M до N 
            #endregion
            Console.WriteLine();               //Новая строка
            #region 68
            int m2 = Message("Введите число M");//Получаем от пользователя данные и записываем в переменную
            int n2 = Message("Введите число N");//Получаем от пользователя данные и записываем в переменную
            AkkermanFunction(m2, n2);           //Выводим функцию Аккермана
            #endregion
        }


        //Метод для получения данных от пользователя
        public static int Message(string msg)
        {
            Console.WriteLine(msg);                         //Просим пользователя ввести какое-то целое число
            return int.Parse(Console.ReadLine() ?? "0");    //Считываем это самое число 
        }

        //Метод для вывода всех натуральных чисел от N до 1
        public static void NaturalNumbers(int number, int count = 1)
        {
            if (count > number)                     //Если переменная, определяющая количество выводимых элементов больше введённого                           
                return;                             //пользователем числа, то просто возвращаемся

            else
            {                                       //Иначе вызываем наш метод(делаем рекурсию), в который записываем число, введённое
                NaturalNumbers(number, count + 1);  //пользователем и количество выводимых элементов + 1, count запоминается
                Console.Write(count + " ");         //Выводим значение count
            }
        }

        //Метод суммы чисел от M до N
        public static int SumMN(int m, int n)
        {
            int res;                    //Создаём переменную для хранения результата выполения программы
            if (m == n)                 //Если числа, введённые пользователем равны, то просто возвращаемся
                return 0;

            else
            {                           
                m++;                    //Иначе увеличиваем m на 1
                res = m + SumMN(m, n);  //В результат записываем сумму m нового и m старого
                return res;             //Возвращаем результат
            }
        }

        //Метод для вывода суммы чисел от M до N
        public static void SumFromMToN(int m, int n)
        {
            Console.Write(SumMN(m - 1, n)); //Выводим сумму элементов от m до n
        }

        //Метод вычисления функции Аккермана
        public static int Akkerman(int m, int n)
        {
            if (m == 0)                                         //Если m равно 0,
            {                                                   //то возвращаем n+1
                return n + 1;
            }
            else if (n == 0 && m > 0)                           //Иначе если n равно 0 и m больше 0
            {
                return Akkerman(m - 1, 1);                      //Возвращаем результат нашего рекурсивного метода
            }
            else
            {                                                   //Иначе возвращаем результат рекурсивного метода
                return (Akkerman(m - 1, Akkerman(m, n - 1)));   //после вызова рекурсивного метода
            }
        }

        //Метод для вывода функции Аккермана
        public static void AkkermanFunction(int m, int n)
        {
            Console.WriteLine(Akkerman(m, n));                  //Выводи функцию Аккермана
        }

    }
}
