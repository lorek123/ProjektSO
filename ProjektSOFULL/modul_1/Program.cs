using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_1
{
    public class Program
    {
        static void Main()
        {
            try
            {
                /*Proces testowy = new Proces("Testowy", 10, 0);
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

