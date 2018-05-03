using System;


namespace _2._2
{
    class Program
    {
        static void Main()
        {
            int[] array = { 421, 62, 37, 14 };
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]+"  ");
            for(int i=1;i<array.Length;i++)
            {
                array[0] ^= array[i];
                array[i] ^= array[0];
                array[0] ^= array[i];
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + "  ");
            Console.ReadKey();
        }
    }
}
