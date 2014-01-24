using ProjektSOFULL.modul_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjektSOFULLCONSOLE.modul_4
{
    class czytnik : urzadzenie
    {
        public string[] load_to_buffer(string nazwa)
        {
            try
            {
                StreamReader file = new StreamReader(nazwa + ".txt");
                string[] bufor = new string[1024];
                int counter = 0;
                while ((bufor[counter] = file.ReadLine()) != null)
                {
                    counter++;
                }
                return bufor;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.StackTrace);
                Console.ResetColor();
                return null;
            } 
        }
    }
}
