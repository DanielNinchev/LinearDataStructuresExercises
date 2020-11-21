using System;
using System.Collections.Generic;
using System.Linq;

namespace DeleteAllNegativeNumbersFromARow
{
    //Напишете програма, която премахва всички отрицателни числа от дадена редица.
    //Пример: array = {19, -10, 12, -6, -3, 34, -2, 5} → {19, 12, 34, 5}
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 19, -10, 12, -6, -3, 34, -2, 5 };

            List<int> nonNegativeNumbers = new List<int>();

            foreach (var number in array)
            {
                if (number >= 0)
                {
                    nonNegativeNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", nonNegativeNumbers));
        }
    }
}
