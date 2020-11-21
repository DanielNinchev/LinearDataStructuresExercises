using System;
using System.Collections.Generic;

namespace ReadNNumbersAndPrintThemInReversedOrder
{
    //Напишете програма, която прочита N цели числа от конзолата и ги отпечатва в обратен ред. Използвайте класа Stack<int>.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Enter the value of N:");

            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    throw new ArgumentException("N must be a positive integer number!");
                }

                Stack<int> numbers = new Stack<int>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter a positive integer number:");

                    int number = int.Parse(Console.ReadLine());

                    if (number <= 0)
                    {
                        throw new ArgumentException("Only positive integer numbers are allowed!");
                    }
                    else
                    {
                        numbers.Push(number);
                    }
                }

                while (numbers.Count > 0)
                {
                    Console.Write($"{numbers.Pop()}, ");
                }

                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Only positive integer numbers are allowed.");
            }
        }
    }
}
