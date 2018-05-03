using System;
using SortTypes;
using ArrayParse;
using ConsoleStreams;
namespace _4._1
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество строк в матрице");
            int N = cin.Int();
            int[][] matrix = new int[N][];
            Console.WriteLine("Введите матрицу построчно");
            for (int i = 0; i < N; i++)
            {

                matrix[i] = Arrays.ParseInt(Console.ReadLine());
                Sort.Bubble(ref matrix[i]);
            }
            for (int i = 0; i < N; i++)
                Console.WriteLine("Наименьший элемент строки №{0} равен {1}", i + 1, matrix[i][0]);
   
            int min;
            int max = min = matrix[0][0];
            foreach (var u in matrix)
                foreach (int x in u)
                    if (x < min)
                        min = x;
                    else if (x > max)
                        max = x;
            int Count = 0;
            double average = 0;
            foreach (var u in matrix)
                foreach (int x in u)
                {
                    average += x;
                    Count++;
                }
            average -= (min + max);
            Count -= 2;
            average /= Count;
            Console.WriteLine("Среднее значаение элементов матрицы без учета наибольшего и наименьшего равно " + average);
            Console.ReadKey();
        }
    }
}