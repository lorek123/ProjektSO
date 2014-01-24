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
            /*Proces example = new Proces("x", 10, 10);
                SRT_zawiadowca planista = new SRT_zawiadowca(ref example, ref CPU_man.grupy_procesow);
                planista = new SRT_zawiadowca(ref example, ref CPU_man.grupy_procesow);*/

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Form1 Okienko = new Form1();
                Application.Run(Okienko);
                Procesor CPU = new Procesor(Okienko);
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
