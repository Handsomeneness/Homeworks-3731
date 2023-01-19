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
        }

        public static void ThreeDigitNumber()
        {
            Console.WriteLine("Введите трёхзначное число");
            double number = double.Parse(Console.ReadLine());
            string count = number.ToString();

            string result = count.Length < 3 || count.Length > 3 ? "Вы ввели некорректное число" : count.Substring(1, 1);
            Console.WriteLine(result);
        }
    }
}
