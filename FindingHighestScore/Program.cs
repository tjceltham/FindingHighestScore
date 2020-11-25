using System;

namespace FindingHighestScore
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] name = { "John", "Tom", "Hector", "Adjit" };
            int[] score = { 10, 9, 11, 7 };
            int max = 0;
            int indexMax = 0;
            for (int x = 0; x<name.Length; x = x + 1)
            {
                if (score[x] >= max)
                {
                    max = score[x];
                    indexMax = x;
                }

            }
            Console.WriteLine("{0} got the {1}", name[indexMax], max);


        }
    }
}
