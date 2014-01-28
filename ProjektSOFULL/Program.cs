using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektSOFULL.modul_1;
using ProjektSOFULL.modul_3;
using ProjektSOFULL.modul_4;
using ProjektSOFULL.modul_5;

namespace ProjektSOFULL
{
    static class Program
    {
        public static Kernel jadro = new Kernel();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        /*
         * Proces testowy = new Proces("Testowy", 10, 0);
        *SRT_zawiadowca planista = new SRT_zawiadowca(testowy);
        *Semafor x = new Semafor();
        */

        /*
         * Proces example = new Proces("x", 10, 10);
         * SRT_zawiadowca planista = new SRT_zawiadowca(ref example, ref CPU_man.grupy_procesow);
         * planista = new SRT_zawiadowca(ref example, ref CPU_man.grupy_procesow);
         */

        /*Wykonywanie operacji systemu*/
        public static void system_up()
        {
            Form1 currentForm = (Form1)Form1.ActiveForm;
            
            //currentForm.SetText("Witamy w systemie PROJEKT SO FULL");
            IPLRTN x = new IPLRTN();
            

        }
    }
}
