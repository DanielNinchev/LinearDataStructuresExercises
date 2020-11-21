using System;
using System.Collections.Generic;

namespace SortSequenceOfNumbersInAnAscendingOrder
{
    class Program
    {
        //Напишете програма, която прочита от конзолата поредица от цели положителни числа. Поредицата спира, когато се въведе празен ред и ги сортира възходящо.
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            try
            {
                string n = null;

                while (true)
                {
                    Console.WriteLine("Enter a positive integer number: ");

                    n = Console.ReadLine();

                    if (string.IsNullOrEmpty(n))
                    {
                        break;
                    }

                    int number = int.Parse(n);

                    if (number <= 0)
                    {
                        Console.WriteLine("The numbers in the sequence must be positive!");
                    }
                    else
                    {
                        numbers.Add(number);
                    }
                }

                numbers.Sort();

                Console.WriteLine($"The numbers in ascending order are: ");
                Console.WriteLine();

                Console.WriteLine(string.Join(", ", numbers));

            }
            catch (FormatException)
            {
                Console.WriteLine("Only integer numbers are allowed in the sequence.");
            }
        }
    }
}
