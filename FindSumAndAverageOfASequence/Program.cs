using System;
using System.Collections.Generic;

namespace FindSumAndAverageOfASequence
{
    //Напишете програма, която прочита от конзолата поредица от цели положителни числа. Поредицата спира, когато се въведе празен ред.
    //Програмата трябва да изчислява сумата и средното аритметично на поредицата. Използвайте List<int>.
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Welcome! To add a positive integer number to the sequence, enter it. " +
                "To stop adding numbers to the sequence and calculate the sum and the average of the sequence, press enter.");

            try
            {
                string n = null;

                while (true)
                {
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

                double sum = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }

                double average = sum / numbers.Count;

                Console.WriteLine($"The sum of the sequence is {sum}. The average number of the sequence is {average}.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Only integer numbers are allowed in the sequence.");
            }            
        }
    }
}
