using System;
using System.Collections.Generic;

namespace DeleteAllNumbersThatHaveAnOddCountInArray
{
    //Напишете програма, която при дадена редица изтрива всички числа, които се срещат нечетен брой пъти.
    //Пример: array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            int counter;

            List<int> nonOddNumbers = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }

                if (counter % 2 == 0)
                {
                    nonOddNumbers.Add(array[i]);
                }
            }

            Console.WriteLine(string.Join(", ",nonOddNumbers));
        }
    }
}
