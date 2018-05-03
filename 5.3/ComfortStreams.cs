using System;

namespace ConsoleStreams
{
    class cin
    {
        
        public static int Int()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result)) Console.WriteLine("Uncorrect format, try again");
            return result;
        }
        public static long Long()
        {
            long result;
            while (!long.TryParse(Console.ReadLine(), out result)) Console.WriteLine("Uncorrect format, try again");
            return result;
        }
        public static uint UInt()
        {
            uint result;
            while (!uint.TryParse(Console.ReadLine(), out result)) Console.WriteLine("Uncorrect format, try again");
            return result;
        }
        public static ulong ULong()
        {
            ulong result;
            while (!ulong.TryParse(Console.ReadLine(), out result)) Console.WriteLine("Uncorrect format, try again");
            return result;
        }
        public static double Double()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) Console.WriteLine("Uncorrect format, try again");
            return result;
        }
        public static float Float()
        {
            float result;
            while (!float.TryParse(Console.ReadLine(), out result)) Console.WriteLine("Uncorrect format, try again");
            return result;
        }
    }
    
}