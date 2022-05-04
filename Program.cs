using System;

namespace OddNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = 0;
            CheckNumber checkNumber = new CheckNumber();
            Console.Write("Podaj liczbę do sprawdzenia: ");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out inputNumber))
                {
                    Console.WriteLine("To nie jest liczba całkowita! Spróbuj ponownie!");
                    continue;
                }
                else
                    break;
            }
            if (checkNumber.EvenOrOdd(inputNumber))
                Console.WriteLine("Liczba parzysta!");
            else
                Console.WriteLine("Liczba nieparzysta!");
        }
    }
}