﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_4
{


    class czytnik : urzadzenie
    {
        Form1 currentForm = (Form1)Form1.ActiveForm;
        String[] czytnik = new String[1024];
        public string[] load_to_buffer(string nazwa)
        {
            if (!nazwa)
                czytnik = currentForm.get_czytnik1();
            else
                czytnik = currentForm.get_czytnik2();

            return czytnik;
        }
    }
}
