using System;
using System.Collections.Generic;

namespace CountTheFrequencyOfEachNumberInARow
{
    //Напишете програма, която по даден масив от цели числа в интервала [0..1000] намира по колко пъти се среща всяко число.
    //Пример: array = {3, 4, 4, 2, 3, 3, 4, 3, 2} 
    //2 → 2 пъти
    //3 → 4 пъти
    //4 → 3 пъти

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            int counter;

            List<int> numbers = new List<int>();

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

                if (!numbers.Contains(array[i]))
                {
                    numbers.Add(array[i]);

                    Console.WriteLine($"{array[i]} -> {counter} times;");
                }
            }
        }
    }
}
