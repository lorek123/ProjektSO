using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_4
{
    class drukarka : urzadzenie
    {

        Form1 currentForm = (Form1)Form1.ActiveForm;
        public void print(string do_druku, int nr_dr)
        {
            if (nr_dr == 1)
                currentForm.set_drukarka1(do_druku);
            else if (nr_dr == 2)
                currentForm.set_drukarka2(do_druku);
        }
    }
}
