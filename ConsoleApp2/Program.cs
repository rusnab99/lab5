using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string str = Console.ReadLine();

            int wordBegin = 0;
            int maxLength = 0;
            int CurrenWordLength = -1;
            var word = new List<char>();
            for(int i=1;i<str.Length;i++)
            {
                if (char.IsLetter(str[i]) && (str[i - 1] == ' '))
                {
                    wordBegin = i;
                    CurrenWordLength++;
                }
                else if (char.IsLetter(str[i]))
                    CurrenWordLength++;
                else if (CurrenWordLength > maxLength)
                    {
                        maxLength = CurrenWordLength;
                        for (int j = 0; j < i-wordBegin+1; j++)
                            word.Add(str[j + wordBegin]);
                    CurrenWordLength = 0;
                }
                   else  CurrenWordLength = 0;


            }
            Console.Write("Самое длинное слово "); 
                for (int j = 0; j < maxLength; j++) Console.Write(word[j]);
                Console.WriteLine(" имеет длину {0} символов",  maxLength);
            Console.ReadKey();
        }
    }
}
