using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 54
            int rows = Message("Введите количество строк матрицы");       //Получаем от пользователя данные и записываем в переменную
            int columns = Message("Введите количество столбцов матрицы"); //Получаем от пользователя данные и записываем в переменную
            int[,] matrix = GenerateMatrix(rows, columns);                //Генерируем матрицу целых чисел из полученных данных
            PrintMatrix(matrix);                                          //Выводим нашу матрицу
            SortMatrix(matrix);                                           //Сортируем элементы в порядке убывания
            Console.WriteLine();                                          //Новая строка
            PrintMatrix(matrix);                                          //Выводим нашу матрицу
            #endregion
            Console.WriteLine();                                          //Новая строка
            #region 56
            int rows2 = Message("Введите количество строк матрицы");      //Получаем от пользователя данные и записываем в переменную
            int columns2 = Message("Введите количество столбцов матрицы");//Получаем от пользователя данные и записываем в переменную
            int[,] matrix2 = GenerateMatrix(rows2, columns2);             //Генерируем матрицу целых чисел из полученных данных
            PrintMatrix(matrix2);                                         //Выводим нашу матрицу
            RowWithMinSElementsSum(matrix2);                              //Выводим строчку с минимальной суммой элементов
            #endregion
            Console.WriteLine();
            #region 58
            int rows3 = Message("Введите количество строк матрицы");       //Получаем от пользователя данные и записываем в переменную
            int columns3 = Message("Введите количество столбцов матрицы"); //Получаем от пользователя данные и записываем в переменную
            int[,] matrix3 = GenerateMatrix(rows3, columns3);              //Генерируем матрицу целых чисел из полученных данных
            int[,] matrix4 = GenerateMatrix(rows3, columns3);              //Генерируем матрицу целых чисел из полученных данных
            PrintMatrix(matrix3);                                          //Выводим нашу матрицу
            Console.WriteLine();                                           //Новая строка
            PrintMatrix(matrix4);                                          //Выводим нашу матрицу
            Console.WriteLine();                                           //Новая строка
            int[,] newMatrix = MultiplyMatrixes(matrix3, matrix4, rows3, columns3); //Записываем в переменную матрицу, полученную в методе
            PrintMatrix(newMatrix);                                        //Выводим нашу матрицу
            #endregion
            Console.WriteLine();                                           //Новая строка
            #region 60
            int elements = Message("Введите количество матриц");           //Получаем от пользователя данные и записываем в переменную
            int rows4 = Message("Введите количество строк матрицы");       //Получаем от пользователя данные и записываем в переменную
            int columns4 = Message("Введите количество столбцов матрицы"); //Получаем от пользователя данные и записываем в переменную
            int[,,] matrix5 = GenerateMatrix3D(elements, rows4, columns4); //Генерируем 3D матрицу целых чисел из полученных данных
            PrintMatrix3D(matrix5);                                        //Выводим нашу матрицу
            #endregion
            Console.WriteLine();                                           //Новая строка
            #region 62
            int len = 4;                                                   //Переменная длины массива построчно и постолбцово
            int[,] table = new int[len, len];                              //Генерируем табличку из переменной длины
            FillArraySpiral(table, len);                                   //Заполняем табличку спирально
            PrintArray(table);                                             //Выводим нашу спиральную табличку
            #endregion
        }

        //Метод для получения данных от пользователя
        public static int Message(string msg)
        {
            Console.WriteLine(msg);                         //Просим пользователя ввести какое-то целое число
            return int.Parse(Console.ReadLine() ?? "0");    //Считываем это самое число 
        }

        //Метод генерации матрицы целых чисел
        public static int[,] GenerateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];                 //Генерируем матрицу из количества строк и столбцов
            Random random = new Random();                           //Инициализируем рандом
            for (int i = 0; i < rows; i++)                          //Делаем два цикла для заполнения матрицы
            {                                                       //Сначала цикл по строкам
                for (int j = 0; j < columns; j++)                   //Затем цикл по столбцам
                {
                    matrix[i, j] = random.Next(0,100);              //Заполняем матрицу случайными вещественными числами
                }                                                   //Для заполнения числами больше 1, умножаем на нужное число
            }                                                       //Округляем до двух знаков после запятой
            return matrix;
        }

        //Метод сортировки матрицы по убыванию значений в каждой строке
        public static void SortMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)               //Делаем 3 цикла для сортировки матрицы
            {                                                           //Сначала цикл по строкам
                for (int j = 0; j < matrix.GetLength(1); j++)           //Затем цикл по столбцам
                {                       
                    for (int r = 0; r < matrix.GetLength(1) - 1; r++)   //И ещё один для сравнения элемментов между собой в строке
                    {
                        if (matrix[i, r] < matrix[i, r + 1])            //Если элемент меньше предыдущего, то он занимает его место
                        {
                            int temp = matrix[i, r + 1];      //Создаём временную переменную в которую помещаем следующий элемент строки
                            matrix[i, r + 1] = matrix[i, r];  //Следующему элементу присваиваем значение текущего
                            matrix[i, r] = temp;              //Текущему элементу присваиваем значение следующего
                        }
                    }
                }
            }
        }

        //Метод вывода матрицы целых чисел
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)       //Делаем два цикла для вывода матрицы
            {                                                   //Сначала цикл по строкам
                for (int j = 0; j < matrix.GetLength(1); j++)   //Затем цикл по столбцам
                {
                    Console.Write($"[{matrix[i, j]}]" + " ");   //Выводим элемент матрицы
                }
                Console.WriteLine();                            //Новая строчка
            }
        }

        //Метод вывода строки с наименьшей суммой элементов
        public static void RowWithMinSElementsSum(int[,] matrix)
        {
            int minRow = 0;                                 //Создаём переменную для минимальной строки
            int minSumRow = 0;                              //Создаём переменную для минимальной суммы строки
            int sumRow = 0;                                 //Создаём переменную для суммы элементов строки
            for (int i = 0; i < matrix.GetLength(1); i++)   //Создаём цикл, который будет выполняться пока i < количества столбцов
            {
                minRow += matrix[0, i];                     //Суммируем в переменную элементы из матрицы
            }
            for (int i = 0; i < matrix.GetLength(0); i++)   //Создаём цикл, который будет выполняться пока i < количества строк
            {
                for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j]; //Создаём цикл, который будет выполняться пока j < количества столбцов
                if (sumRow < minRow)                        //Если сумма элементов строки меньше минимальной суммы строки,
                {
                    minRow = sumRow;                        //то минимальной становится эта строка
                    minSumRow = i;                          //Записываем в переменную, какая именно строка содержит минимальную сумму
                }
                sumRow = 0;                                 //В конце цикла обнуляем переменную с суммой строки
            }
            Console.WriteLine($"{minSumRow + 1} строка является строкой c наименьшей суммой элементов");//Выводим номер строки
        }

        //Метод умножения элементов двух матриц между собой
        public static int[,] MultiplyMatrixes(int[,] firstMatrix, int[,] secondMatrix, int rows, int columns)
        {
            int[,] newMatrix = new int [rows,columns];               //Создаём новую матрицу, которая получится из двух старых
            for (int i = 0; i < firstMatrix.GetLength(0); i++)       //Создаём цикл по строчкам первой матрицы
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)  //Создаём цикл по столбцам второй матрицы
                {
                    newMatrix[i, j] = 0;                             //Обнуляем элемент матрицы
                    for (int r = 0; r < firstMatrix.GetLength(1); r++)//Создаём цикл по столбцам первой матрицы
                    {
                        newMatrix[i, j] += firstMatrix[i, r] * secondMatrix[r, j];  //Записываем в ячейку матрицы перемноженные значения старых матриц
                    }
                }
            }
            return newMatrix;   //Возвращаем нашу матрицу
        }

        //Метод генерации матрицы трёхмерных чисел
        public static int[,,] GenerateMatrix3D(int matrixCount ,int rows, int columns)
        {
            int[,,] matrix = new int[matrixCount, rows, columns];   //Генерируем матрицу или матрицы из количества строк и столбцов
            Random random = new Random();                           //Инициализируем рандом
            for (int i = 0; i < matrix.GetLength(0); i++)           //Делаем три цикла для заполнения матрицы или матриц
            {                                                       //Сначала цикл по количеству матриц
                for (int j = 0; j < matrix.GetLength(1); j++)       //Затем цикл по строкм
                {
                    for (int r = 0; r < matrix.GetLength(2); r++)   //После цикл по столбцам
                    {
                        matrix[i, j, r] = random.Next(10, 99);      //Записываем случайное число в диапазоне от 10 до 99
                    }
                                                                    
                }                                                   
            }                                                       
            return matrix;
        }

        //Метод вывода трёхмерной матрицы целых чисел
        public static void PrintMatrix3D(int[,,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)                        //Делаем три цикла для вывода матрицы
            {                                                                    //Сначала цикл по количеству матриц
                for (int j = 0; j < matrix.GetLength(1); j++)                    //Затем цикл по строкам
                {
                    Console.WriteLine();                                         //Разделяем матрицы
                    for (int r = 0; r < matrix.GetLength(2); r++)                //После цикл по столбцам
                    {
                        Console.Write($"[{matrix[i, j, r]}({i},{j},{r})]" + " ");//Выводим элемент матрицы
                    }
                }
                Console.WriteLine();                                             //Новая строчка
            }
        }

        //Метод заполнения массива спирально
        public static void FillArraySpiral(int[,] array, int n)
        {
            int i = 0, j = 0;                                        //Создаём две переменные для индексов массива
            int value = 1;                                           //Создаём переменную с начальным значением
            for (int q = 0; q < n * n; q++)                          //Создаём цикл, который будет выполняться, пока массив не
            {                                                        //будет заполнен
                int r = 0;                                           //Переменная, чтобы вовремя выйти из цикла
                do { array[i, j++] = value++; } while (++r < n - 1); //Создаём несколько циклов, чтобы как раз заполнить наш массив
                for (r = 0; r < n - 1; r++) array[i++, j] = value++; //спирально
                for (r = 0; r < n - 1; r++) array[i, j--] = value++;
                for (r = 0; r < n - 1; r++) array[i--, j] = value++;
                ++i; ++j;
                n = n < 2 ? 0 : n - 2;
            }
        }

        //Метод вывода двумерного массива
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)            //Создаём цикл по строчкам
            {
                for (int j = 0; j < array.GetLength(1); j++)        //Создаём цикл по столбцам
                {
                    if (array[i, j] < 10)                           //Выводим наши элементы
                    {                                               
                        Console.Write("0" + array[i, j]);
                        Console.Write(" ");
                    }
                    else Console.Write(array[i, j] + " ");          
                }
                Console.WriteLine();
            }
        }
    }
}
