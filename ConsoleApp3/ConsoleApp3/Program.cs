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
            Console.WriteLine("Enter a character");
            char ch = (char)Console.Read();
            if (Char.IsUpper(ch))
            {
                Console.WriteLine("Upper case");
            }
            if (Char.IsDigit(ch))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("not alphanumerical");
            }
        }
    }
}
