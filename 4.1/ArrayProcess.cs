using System;
namespace ArrayParse
{
    class Arrays
    {
        public static int[] ParseInt(ref string str)
        {
            string[] element = str.Split(' ');
            int[] arr = new int[element.Length];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(element[i]);
            return arr;
        }
        public static double[] ParseDouble(ref string str)
        {
            string[] element = str.Split(' ');
            double[] arr = new double[element.Length];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = double.Parse(element[i]);
            return arr;
        }
        public static int[] ParseInt(string str)
        {
            string[] element = str.Split(' ');
            int[] arr = new int[element.Length];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(element[i]);
            return arr;
        }
        public static double[] ParseDouble(string str)
        {
            string[] element = str.Split(' ');
            double[] arr = new double[element.Length];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = double.Parse(element[i]);
            return arr;
        }
    }
}