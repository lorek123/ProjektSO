using ProjektSOFULL.modul_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjektSOFULLCONSOLE.modul_4
{
    class drukarka : urzadzenie
    {
        public void print(string do_druku)
        {
            string sciezka = @"C:\\sop_system\\log.txt";
            FileStream fs = new FileStream(sciezka, FileMode.OpenOrCreate, FileAccess.Write);

            try
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(do_druku);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.StackTrace);
                Console.ResetColor();
            } 
        }
    }
}
