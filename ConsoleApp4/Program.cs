using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] stairedArray =
            {
                new int[2,2],new int[2,3],new int[3,2]
            };
            Random rand = new Random();
            for (int it = 0; it < 3; it++)
                for (int Is = 0; Is < stairedArray[it].GetLength(0); Is++)
                    for (int stupid = 0; stupid < stairedArray[it].GetLength(1);stupid++)
                        stairedArray[it][Is, stupid] = rand.Next();
            int[] min = new int[3];
            for (int i = 0; i < 3; i++)
                for (int k = 0; k < stairedArray[i].GetLength(0); k++)
                {
                    min[i]=stairedArray[i][k, 0];
                    for (int j = 0; j < stairedArray[i].GetLength(1); j++)
                        if (stairedArray[i][k, j] < min[i])
                            min[i] = stairedArray[i][k, j];
                }
            int index = 1;
            foreach (var t in stairedArray)
            {
                Console.WriteLine("Массив №{0}:", index++);
                for (int i = 0; i < t.GetLength(0); i++)
                {
                    for (int j = 0; j < t.GetLength(1); j++)
                        Console.Write(t[i, j] + "\t");
                    Console.WriteLine();
                }
            }
            index = 0;
            foreach (var r in min)
                Console.WriteLine("Минимальный элемнт маиисва №{1} равен {0}", r, ++index);
            Console.WriteLine("сумма минимальных элементов равна " + min.Sum());
            Console.ReadLine();
        }

    }
}
