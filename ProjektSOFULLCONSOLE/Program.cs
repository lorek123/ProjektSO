using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektSOFULL.modul_1;
using ProjektSOFULL.modul_3;
using ProjektSOFULL.modul_4;
using ProjektSOFULL.modul_5;
namespace ProjektSOFULLCONSOLE
{
    class Program
    {
        static void Main()
        {
            try
            {
                /*Proces testowy = new Proces("Testowy", 10, 0);
                *SRT_zawiadowca planista = new SRT_zawiadowca(testowy);
                *Semafor x = new Semafor();
                */
                Procesor CPU = new Procesor();
                Procesy CPU_man = new Procesy();


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
