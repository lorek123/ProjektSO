﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSOFULL.modul_5
{
    class IPLRTN
    {

        Form1 currentForm = (Form1)Form1.ActiveForm;
        IPLRTN(){
            currentForm.SetText("Witamy w systemie PROJEKT SO FULL");
        }
    }
}
