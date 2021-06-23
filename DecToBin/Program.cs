using System;

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Киселев Денис
            // 1. Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.


            Console.WriteLine("Здравствуйте! Эта программа переведет ваше целое число из десятичной системы в двличную.");

            Console.Write("\nВведите число: ");
            int decNum = Convert.ToInt32(Console.ReadLine());

            string binary = ToBinary(decNum);

            Console.WriteLine($"\nВаше число в двоичной форме: {binary}"); ;
        }

        static public string ToBinary(int n)
        {
            if (n < 2) return n.ToString();

            var divisor = n / 2;
            var remainder = n % 2;

            return ToBinary(divisor) + remainder;
        }
    }
}
