using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_4
{
    public class czytnik : urzadzenie
    {
        Form1 currentForm = (Form1)Form1.ActiveForm;
        String[] wczytaj = new String[1024];
        public string[] load_to_buffer(string nazwa)
        {
            if (nazwa == "czytnik1")
            {
                wczytaj = currentForm.get_czytnik1();
                currentForm.SetText("CZYTNIK: Pobrano dane z czytnika 1");
            }
            else
            {
                wczytaj = currentForm.get_czytnik2();
                currentForm.SetText("CZYTNIK: Pobrano dane z czytnika 2");
            }

            return wczytaj;
        }
    }
}
