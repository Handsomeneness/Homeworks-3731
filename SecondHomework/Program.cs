using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeDigitNumber();
            Console.WriteLine();
            ThirdNumber();
            Console.WriteLine();
            DayOfWeek();
        }

        public static void ThreeDigitNumber()
        {
            Console.WriteLine("Введите трёхзначное число");
            int number = int.Parse(Console.ReadLine());
            string count = number.ToString();

            string result = count.Length < 3 || count.Length > 3 ?
                "Вы ввели некорректное или отрицательное число" : count.Substring(1, 1);
            Console.WriteLine(result);
        }

        public static void ThirdNumber()
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            string count = number.ToString();

            string result = count.Length < 3 || count.Substring(0, 1) == "-" ?
                "В вашем числе нет третьей цифры или оно отрицательное" : count.Substring(2, 1);
            Console.WriteLine(result);
        }

        public static void DayOfWeek()
        {
            Console.WriteLine("Введите день недели");
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 5)
                Console.WriteLine("Будний день, пора на галеру");
            else if (day <= 0 || day > 7)
                Console.WriteLine("Не в этой вселенной");
            else
                Console.WriteLine("Выходной! Ведьмак не ждёт!");
        }
    }
}
