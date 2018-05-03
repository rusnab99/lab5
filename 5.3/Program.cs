using System;
using System.Threading;
using ConsoleStreams;
namespace _5._3
{
    class Program
    {
        public class Data
        {
           public int[,] matrix;
           public int N, M;

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            Data data=new Data();
            data.N = cin.Int();
            Console.WriteLine("Введите M");
            data.M = cin.Int();

            data.matrix=  new int[data.N, data.M]; 
            Random rnd=new Random();
            for (int i = 0; i < data.N; i++)
                for (int j = 0; j < data.M; j++)
                    data.matrix[i, j] = rnd.Next();
            var thread = new Thread(new ParameterizedThreadStart(showMatrix));
            bool[,] matrix=new bool[data.N, data.M];
            thread.Start(data);
            for (int i = 0; i < data.N; i++)
                for (int j = 0; j < data.M; j++)
                     matrix[i,j]= isLess(ref data, i, j);

            thread.Join();
            for (int i = 0; i < data.N; i++)
                for (int j = 0; j < data.M; j++)
                    if (matrix[i,j])
                Console.WriteLine("Элемент с индексами [{0},{1}] является локальным минимумом",i+1,j+1);
                else
                        Console.WriteLine("Элемент с индексами [{0},{1}] неявляется локальным минимумом", i + 1, j + 1);
            Console.ReadKey();
        }
        public static void showMatrix(Object data)
        {
            
            for (int i =0 ; i < ((Data)data).N; i++)
            {
                for (int j = 0; j < ((Data)data).M; j++)
                    Console.Write(((Data)data).matrix[i, j] + "\t");
                Console.WriteLine(); 
            }
        }
        static bool isLess(ref Data data, int k, int l)
        {
            for (int i = k - 1; i <= k + 1; i++)
                for (int j = l - 1; j <= l + 1; j++)
                    if (!(i == k && j == l))
                        try
                        {
                            if (data.matrix[i, j] <= data.matrix[k, l]) return false;
                        }
                        catch { }

            return true;
        }
    }
}
