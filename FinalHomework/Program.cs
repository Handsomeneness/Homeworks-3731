using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "hello", "2", "world", ":-)", "Russia", "Kazan" };  //Создаём массив производных элементов
            PrintArray(array);  //Печатаем массив

            Console.WriteLine();    //Новая строка  

            string[] newArray = CreateNewArray(array, CountStringInArray(array)); //Новый массив из элементов предыдущего

            PrintArray(newArray);   //Печатаем наш массив

            Console.WriteLine();    //Новая строка
        }

        //Метод для печати нашего массива
        public static void PrintArray(string[] inputArray)
        {
            foreach (var item in inputArray)    //Создаём цикл
            {
                Console.Write($"{item}  ");     //Печатаем каждый элемент массива
            }
        }

        //Метод для подсчёта строк, содержащих меньше 3-х символов либо равных 3 символам
        public static int CountStringInArray(string[] array)
        {
            int len = array.Length;                     //Создаём переменную и помещаем в неё длину массива
            int count = 0;                              //Создаём переменную количества
            int maxLengthString = 3;                    //Создаём переменную для обозначения максимума доступной длины
            for (int i = 0; i < len; i++)               //Создаём цикл, пока он меньше длины массива
            {
                if (array[i].Length <= maxLengthString) //Если длина элемента массива меньше, либо равна максимуму, 
                {
                    count++; //увеличиваем количество
                }
            }
            return count; //Возвращаем в переменной количество
        }

        // Method for creating a new array from strings less than or equal to 3 characters that it finds in the input array
        // ! pass the result of the CountStringInArray method to the countWords argument !
        //Метод для генерации массива из строк, которые меньше, либо равны 3 символам
        public static  string[] CreateNewArray(string[] array, int countChars)
        {
            int len = array.Length; //Создаём переменную для обозначения длины массива
            string[] newArray = new string[countChars];  //Создаём новый массив из количества подходящих элементов
            int index = 0;      //Переменная для индекса
            int maxLengthString = 3;    //Переменная для возможного максимума
            for (int i = 0; i < len; i++)   //Цикл пока меньше длины массива
            {
                if (array[i].Length <= maxLengthString) //Если длина элменета массива меньше, либо равна 3
                {
                    newArray[index] = array[i]; //То заполняем массив этими элементами
                    index++; //Увеличиваем индекс
                }
            }
            return newArray; //Возвращаем наш массив
        }
    }
}
