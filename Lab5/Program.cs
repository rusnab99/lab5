using System;

namespace Lab5
{
    class Program
    {
        static int PositiveCount(ref  int[]  array)
        {
            int quantity = 0;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i] >= 0) quantity++;
            }
            return quantity;
        }
        static int EvenCount(ref int[] array)
        {
            int quantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0) quantity++;
            }
            return quantity;
        }
        static int MinNegativeIndex(ref int[] array)
        {
            int number=-1;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <min)
                {
                    min = array[i];
                    number = i;
                }
            }
            return number;
        }
        static void Main()
        {
            int[] array = new int[15];
            Random r = new Random();
            Console.WriteLine("Массив:");
            for(int i=0;i<15;i++)
            {
                array[i] = r.Next(-100, 101);
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine("\nВ массиве содержиться {0} не отрицательных элементов", PositiveCount(ref array));
            Console.WriteLine("\nВ массивесщдержиться {0} четных чисел",EvenCount(ref array));
            int min = MinNegativeIndex(ref array);
            if (min == -1)
                Console.WriteLine("Все Элементы не отрицательны");
            else
                Console.WriteLine("Наименьший отрицательный элемент имеет номер {0} и равен {1}", min, array[min]);
            for (int i = 1; i < 15; i += 2)
                Console.Write(array[i] + "  ");
            Console.ReadKey();
        }
    }
}
