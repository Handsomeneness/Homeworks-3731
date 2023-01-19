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
            //ThreeDigitNumber();
            //Console.WriteLine();
            ThirdNumber();
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
    }
}
