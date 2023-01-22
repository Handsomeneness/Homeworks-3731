using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome();
            Console.WriteLine();

            double X1 = Message("Введите координату X первой точки");
            double Y1 = Message("Введите координату Y первой точки");
            double Z1 = Message("Введите координату Z первой точки");
            double X2 = Message("Введите координату X второй точки");
            double Y2 = Message("Введите координату Y второй точки");
            double Z2 = Message("Введите координату Z второй точки");
            Point first = new Point(X1, Y1, Z1);
            Point second = new Point(X2, Y2, Z2);
            PointDistance(first, second);

            Console.WriteLine();
            Cube();
        }

        public static void Palindrome()
        {
            // Просим пользователя ввести значение.
            Console.WriteLine("Введите число");
            // Считываем значение в строковую переменную.
            string number = Console.ReadLine();
            // Далее делаем проверку, совпадает ли перевёрнутое число,
            // числу введённому пользователем с помощью полезных расширений
            // и выводим соответствующее сообщение.
            // P.S. Люблю всё же больше пользоваться if else, чем тернарным оператором,
            // приятнее глазу.
            if (number.Reverse().SequenceEqual(number))
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");
        }

        #region Task 21
        // Создаём метод в котором просим ввести значение и возвращаем его в созданную переменную
        public static int Message(string msg)
        {
            Console.WriteLine(msg);
            return int.Parse(Console.ReadLine() ?? "0");
        }

        // Создаём метод для вычисления расстояния между точками, но прежде создаём отдельную структуру Point
        // в котором будут храниться координаты точек. Вычисляем координаты по точкам, введённым пользователем.
        public static void PointDistance(Point first, Point second)
        {
            Console.WriteLine(Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2) 
                + Math.Pow(second.Z - first.Z, 2)));
        }
        #endregion

        public static void Cube()
        {
            // Просим пользователя ввести значение.
            Console.WriteLine("Введите число");
            // Считываем значение в строковую переменную.
            int number = int.Parse(Console.ReadLine());
            // Вводим ещё одну переменную для вывода кубов и присваиваем значение 1.
            int temp = 1;
            // Создаём цикл, в котором пока индекс i меньше числа, интересующих нас кубов number,
            // выводим кубы с помощью полезного класса Math и его метода Pow(возведение в степень),
            // в который передаём нашу переменную вывода и число степени и увеличиваем нашу переменную вывода на 1.
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Math.Pow(temp, 3));
                temp++;
            }
        }

    }
}
