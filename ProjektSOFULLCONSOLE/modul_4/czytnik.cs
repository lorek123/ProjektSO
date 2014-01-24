using ProjektSOFULL.modul_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULLCONSOLE.modul_4
{
    class czytnik : urzadzenie
    {
        public string[] load_to_buffer(string nazwa)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(nazwa + ".txt");
            string[] bufor = new string[1024];
            int counter = 0;
            while ((bufor[counter] = file.ReadLine()) != null)
            {
                counter++;
            }
            return bufor;
        }
    }
}
