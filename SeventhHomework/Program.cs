using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhHomework
{
    class Program
    {

        static void Main(string[] args)
        {
            int rows = Message("Введите количество строк матрицы"); //Получаем от пользователя данные и записываем в переменную
            int columns = Message("Введите количество столбцов матрицы"); //Получаем от пользователя данные и записываем в переменную
            double[,] matrix = GenerateMatrix(rows, columns);//Генерируем матрицу вещественных чисел из полученных данных
            PrintMatrixColorful(matrix, rows, columns);//Выводим матрицу разным цветом

            Console.WriteLine();

            int rows2 = Message("Введите количество строк матрицы"); //Получаем от пользователя данные и записываем в переменную
            int columns2 = Message("Введите количество столбцов матрицы"); //Получаем от пользователя данные и записываем в переменную
            int[,] matrixFibonachi = GenerateMatrixFibonachi(rows2, columns2);//Генерируем матрицу из чисел Фибоначчи
            PrintMatrix(matrixFibonachi, rows2, columns2);//Выводим матрицу
            int rowPosition = Message("Введите позицию в строке матрицы");//Получаем индекс строки
            int columnPosition = Message("Введите позицию в столбце матрицы");//Получаем индекс столбца
            PrintMatrixElement(matrixFibonachi, rowPosition, columnPosition);//Выводим матрицу

            Console.WriteLine();

            int rows3 = Message("Введите количество строк матрицы"); //Получаем от пользователя данные и записываем в переменную
            int columns3 = Message("Введите количество столбцов матрицы"); //Получаем от пользователя данные и записываем в переменную
            int[,] matrix3 = GenerateMatrixEnum(rows3, columns3);//Генерируем матрицу целых чисел
            PrintAvgOfColumn(matrix3, rows3, columns3);//Выводим среднее арифметическое в каждом столбце
        }

        //Метод для получения данных от пользователя
        public static int Message(string msg)
        {
            Console.WriteLine(msg); //Просим пользователя ввести какое-то целое число
            return int.Parse(Console.ReadLine() ?? "0"); //Считываем это самое число 
        }

        //Метод для генерации матрицы вещественных чисел
        public static double[,] GenerateMatrix(int rows, int columns)
        {
            double[,] matrix = new double[rows, columns];//Генерируем матрицу из количества строк и столбцов
            Random random = new Random();                //Инициализируем рандом
            for (int i = 0; i < rows; i++)               //Делаем два цикла для заполнения матрицы
            {                                            //Сначала цикл по строкам
                for (int j = 0; j < columns; j++)        //Затем цикл по столбцам
                {
                    matrix[i, j] = Math.Round(random.NextDouble() * 100, 2); //Заполняем матрицу случайными вещественными числами
                }                                                           //Для заполнения числами больше 1, умножаем на нужное число
            }                                                                //Округляем до двух знаков после запятой
            return matrix;
        }

        //Метод для генерации матрицы числами Фибоначчи
        public static int[,] GenerateMatrixFibonachi(int rows, int columns, int firstFibonachi = 0, int secondFibonachi = 1)
        {
            int[,] matrix = new int[rows, columns];//Генерируем матрицу из количества строк и столбцов
            int temp;                              //Создаём временную переменную, которая пригодится позже
            matrix[0, 0] = firstFibonachi;         //Первое число Фибоначчи фиксировано, задаём его
            matrix[0, 1] = secondFibonachi;        //Второе число Фибоначчи тоже фиксировано, задаём его
            for (int i = 0; i < rows; i++)         //Делаем два цикла для заполнения матрицы
            {                                      //Сначала цикл по строкам
                for (int j = 2; j < columns; j++)  //Затем цикл по столбцам
                {
                    temp = firstFibonachi;         //Во временную переменную записываем первое число Фибоначчи
                    matrix[i, j] = firstFibonachi + secondFibonachi;    //Задаём элементу матрицы значение суммы двух чисел Фибоначчи
                    firstFibonachi = secondFibonachi;   //Присваиваем первому числу значение второго
                    secondFibonachi += temp;            //Увеличиваем значение второго числа на значение первого
                }
            }
            return matrix;                          //Возвращаем готовую матрицу
        }

        //Метод генерации матрицы целых чисел
        public static int[,] GenerateMatrixEnum(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];//Генерируем матрицу из количества строк и столбцов
            Random random = new Random();          //Инициализируем рандом
            for (int i = 0; i < rows; i++)         //Делаем два цикла для заполнения матрицы
            {                                      //Сначала цикл по строкам
                for (int j = 0; j < columns; j++)  //Затем цикл по столбцам
                {
                    matrix[i, j] = random.Next(0, 100); //Заполняем матрицу случайными целыми числами от 0 до 100
                }
            }
            return matrix;                         //Возвращаем готовую матрицу
        }

        //Метод вывода матрицы разными цветами
        public static void PrintMatrixColorful(double[,] matrix, int rows, int columns)
        {
            ConsoleColor[] color = new ConsoleColor[]   //Создаём массив из всех доступных цветов консоли
            {ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue,
             ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
             ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
             ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};

            for (int i = 0; i < rows; i++)          //Делаем два цикла для вывода матрицы
            {                                       //Сначала цикл по строкам
                for (int j = 0; j < columns; j++)   //Затем цикл по столбцам
                {
                    Console.ForegroundColor = color[new Random().Next(0,16)]; //Меняем цвет консоли на случайный из массива
                    Console.Write($"[{matrix[i,j]}]" + " ");                  //Выводим элемент матрицы
                    Console.ResetColor();                                     //Делаем консоль стандартного цвета
                }
                Console.WriteLine();                                          //Новая строчка
            }
        }

        //Метод вывода матрицы целых чисел
        public static void PrintMatrix(int[,] matrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)                      //Делаем два цикла для вывода матрицы
            {                                                   //Сначала цикл по строкам
                for (int j = 0; j < columns; j++)               //Затем цикл по столбцам
                {
                    Console.Write($"[{matrix[i, j]}]" + " ");   //Выводим элемент матрицы
                }
                Console.WriteLine();                            //Новая строчка
            }
        }

        //Метод вывода элемента матрицы целых чисел под заданными пользователем индексами
        public static void PrintMatrixElement(int[,] matrix, int rowPosition, int columnPosition)
        {
            try                                                                 //Используем блок try catch для избежания вылетов
            {       
                Console.WriteLine(matrix[rowPosition, columnPosition]);         //Выводим элемент матрицы под заданными индексами
            }
            catch (Exception)
            {                                                                   //Если индексов, которые ввёл пользователь не
                Console.WriteLine("Элемента с такой позицией не существует");   //существет, то выводим соответсвующее сообщение
            }
        }

        //Метод вывода матрицы целых чисел, а также среднего арифметического в каждом столбце
        public static void PrintAvgOfColumn(int[,] matrix, int rows, int columns)
        {
            int[] summ = new int[columns];                      //Записываем количество столбцов в новую переменную
            for (int i = 0; i < rows; i++)                      //Делаем два цикла для вывода матрицы
            {                                                   //Сначала цикл по строкам
                for (int j = 0; j < columns; j++)               //Затем цикл по столбцам
                {
                    Console.Write($"[{matrix[i, j]}]" + " ");   //Выводим элемент матрицы
                    summ[i] += matrix[j, i];                    //Записываем в переменную все значения из матрицы под индексами i и j
                }
                Console.WriteLine();                            //Новая строка
            }
            Console.WriteLine();                                //Отступ
            foreach (double item in summ)                       //Делаем цикл для вывода всех средних арифметических
            {
                Console.WriteLine(Math.Round(item / columns,2));//Вывод среднего для колонки
            }

        }
    }
}
