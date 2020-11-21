using System;
using System.Collections.Generic;

namespace PrintTheFirst50NumbersFromASequence
{
    //Дадена е следната поредица:
    //S1 = N;
    //S2 = S1 + 1;
    //S3 = 2* S1 + 1;
    //S4 = S1 + 2;
    //S5 = S2 + 1;
    //S6 = 2* S2 + 1;
    //S7 = S2 + 2;
    //...
    //Използвайки класа Queue<T> напишете програма, която по дадено N отпечатва на конзолата първите 50 числа от тази поредица.
    //Пример: N= 2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the value of N: ");

                double n = double.Parse(Console.ReadLine());

                Queue<double> sequence = new Queue<double>();

                sequence.Enqueue(n);

                int counter = 0;

                while (sequence.Count > 0 && counter < 50)
                {
                    double current = sequence.Dequeue();
                    Console.Write(" " + current);

                    sequence.Enqueue(current + 1);

                    sequence.Enqueue(2*current + 1);

                    sequence.Enqueue(current + 2);

                    counter++;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ivalid number!");
            }          
        }
    }
}
