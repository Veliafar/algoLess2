using System;

namespace PowMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Киселев Денис
            // 2. Реализовать функцию возведения числа a в степень b:


            Console.WriteLine("Здравствуйте! Эта программа переведет ваше целое число из десятичной системы в двличную.");

            Console.Write("\nВведите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите степень: ");
            int pow = Convert.ToInt32(Console.ReadLine());

            num = ToPow(num, pow);
            Console.WriteLine($"\nВаше число: {num}");
        }

        static int ToPow(int num, int pow)
        {
            int baseNum = num;
            for (int i = 2; i <= pow; i++)
            {
                num *= baseNum;
            }
            return num;
        }
    }
}
