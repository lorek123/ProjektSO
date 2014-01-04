using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proces_modul_nizszy
{
    class Program
    {
        static void Main()
        {
            try
            {
                /*Proces testowy = new Proces("Testowy", null, null, 10);
                *SRT_zawiadowca planista = new SRT_zawiadowca(testowy);
                *Semafor x = new Semafor();
                */
                Console.ReadKey();
            }
            catch (Exception x)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x.StackTrace);
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
