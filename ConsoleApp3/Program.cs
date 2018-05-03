using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввеите l");
            int l = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder(l+1);
            str.Length = l;
            Random rand = new Random();
            int Char;
            for(int i=0;i<l;i++)
            {
                Char = rand.Next('q'-9,'z');
                switch(Char)
                {
                    case 'q' - 9:str[i] = '0';break;
                    case 'q' - 8: str[i] = '1'; break;
                    case 'q' - 7: str[i] = '2'; break;
                    case 'q' - 6: str[i] = '3'; break;
                    case 'q' - 5: str[i] = '4'; break;
                    case 'q' - 4: str[i] = '5'; break;
                    case 'q' - 3: str[i] = '!'; break;
                    case 'q' - 2: str[i] = '?'; break;
                    case 'q' - 1: str[i] = ';'; break;
                    default: str[i] = (char)Char;break;
                }
            }
            Console.WriteLine("Строка до обработки:\n{0}", str);
            for(int i =0;i<l;i++)
            {
                if (str[i] == '!') str[i] = '_';
            }
            Console.WriteLine("Строка после обработки:\n{0}", str);
            Console.ReadLine();
        }
    }
}
