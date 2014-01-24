using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektSOFULL.modul_1;
using ProjektSOFULL.modul_2;
using ProjektSOFULL.modul_3;
using ProjektSOFULL.modul_4;
using ProjektSOFULL.modul_5;

namespace ProjektSOFULL
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            try
            {
                /*Proces testowy = new Proces("Testowy", 10, 0);
                *SRT_zawiadowca planista = new SRT_zawiadowca(testowy);
                *Semafor x = new Semafor();
                */
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                Procesor CPU = new Procesor();
                Procesy CPU_man = new Procesy();
                /*Proces example = new Proces("x", 10, 10);
                SRT_zawiadowca planista = new SRT_zawiadowca(ref example, ref CPU_man.grupy_procesow);
                planista = new SRT_zawiadowca(ref example, ref CPU_man.grupy_procesow);*/

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
