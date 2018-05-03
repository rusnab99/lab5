using System;
using ArrayParse;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите упорядоченный массив А");
            int[] A = Arrays.ParseInt(Console.ReadLine());
            Console.WriteLine("Введите упорядоченный массив B");
            int[] B = Arrays.ParseInt(Console.ReadLine());
            int n = A.Length;
            int m = B.Length;
            int[] C = new int[n + m];
            //nothing personal, just OOP

            Console.WriteLine("Результат слияния и упорядочивания массивов:");
            for(int i=1,nfor=0,mfor=0;i<=n+m;i++)
            {
                C[i] = A[nfor] < B[mfor] ? A[nfor++] : B[mfor++];
                Console.Write(C[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
