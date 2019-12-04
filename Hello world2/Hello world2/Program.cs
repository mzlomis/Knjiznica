#define CSHARP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directives
{
    class WarningDirective
    {
        public static void Main(string[] args)
        {
#if (CSHARP)
            Console.WriteLine("CSHARP is defined");
#else
            Console.Writeline("CSHARP is undefined");
#endif
        }
}
            }