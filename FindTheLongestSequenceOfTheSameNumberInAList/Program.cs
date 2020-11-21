using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        //Напишете метод, който намира най-дългата подредица от равни числа (не е нужно да са последователни) в даден List<int> и връща като резултат нов List<int> с тази
        //подредица. Напишете програма, която проверява дали този метод работи коректно.
        static void FindLongestSequenceOfSameNumbersInList(List<int> numbers)
        {
            List<int> result = new List<int>();

            int counter = 0;
            int bestCounter = int.MinValue;
            int startIndex = 0;
            int currentIndex = 0;

            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0 || numbers[i] != numbers[i - 1])
                {
                    counter = 1;
                    currentIndex = i;
                }
                else
                {
                    counter++;
                }

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    startIndex = currentIndex;
                }
            }

            for (int i = 0; i < bestCounter; i++)
            {
                result.Add(numbers[startIndex]);
            }

            Console.WriteLine(string.Join(", ", result));
        } 

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){11, 5, 3, 101, 41, 4, 2, 2, 10, 3, 9, 9, 9, 55, 43, 11, 7, 7, 7, 101, 101, 101};

            FindLongestSequenceOfSameNumbersInList(numbers);
        }
    }
}
