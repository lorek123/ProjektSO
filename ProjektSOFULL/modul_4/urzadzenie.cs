using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_4
{
    class urzadzenie
    {
        private string device_name;
        urzadzenie(string nazwa)
        {
            device_name = nazwa;
        }

        public void przyjmij_komunikat(string komunikat)
        {
            //append to drukarka

        }
        public void set_name(string nazwa)
        {
            device_name = nazwa;
        }
        public string get_name()
        {
            return device_name;
        }
    }
}
