using System;
namespace SortTypes
{
    class Sort
    {
        public static void Bubble(ref int[] arr)
        {
            
            for(int i=0;i<arr.Length-1;i++)
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        arr[j] ^= arr[j+1];
                        arr[j+1] ^= arr[j];
                        arr[j] ^= arr[j+1];
                    }
                }

        }
       
        public static void Bubble(ref long[] arr)
        {

            for (int i = 0; i < arr.Length-1; i++)
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        arr[j] ^= arr[j + 1];
                        arr[j + 1] ^= arr[j];
                        arr[j] ^= arr[j + 1];
                    }
                }

        }
        public static void Bubble(ref uint[] arr)
        {

            for (int i = 0; i < arr.Length-1; i++)
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        arr[j] ^= arr[j + 1];
                        arr[j + 1] ^= arr[j];
                        arr[j] ^= arr[j + 1];
                    }
                }

        }
        public static void Bubble(ref ulong[] arr)
        {

            for (int i = 0; i < arr.Length-1; i++)
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        arr[j] ^= arr[j + 1];
                        arr[j + 1] ^= arr[j];
                        arr[j] ^= arr[j + 1];
                    }
                }

        }
       /*public static void Bubble(ref float[] arr)
        {

            for (int i = 0; i < arr.Length-1; i++)
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        arr[j] ^= arr[j + 1];
                        arr[j + 1] ^= arr[j];
                        arr[j] ^= arr[j + 1];
                    }
                }

        }
        //public static void Bubble(ref double[] arr)
        {

            for (int i = 0; i < arr.Length-1; i++)
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        arr[j] ^= arr[j + 1];
                        arr[j + 1] ^= arr[j];
                        arr[j] ^= arr[j + 1];
                    }
                }

        }*/
    }
}