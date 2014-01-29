using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjektSOFULL.modul_5
{
    public class IPLRTN
    {
        public modul_1.Procesor CPU;
        public modul_5.Interpreter interpreter;
        public List<modul_5.Proces_nadzorczy> Lista_modulow_nadzorczych = new List<modul_5.Proces_nadzorczy>();
        public modul_5.Ladowanie proces_ladowania = new modul_5.Ladowanie();
        modul_3.Procesy lista_procesow = new modul_3.Procesy();
        modul_5.Ladowanie _ladowanie = new modul_5.Ladowanie();
        Form1 currentForm = (Form1)Form1.ActiveForm;
        public IPLRTN()
        {
            Form1 currentForm = (Form1)Form1.ActiveForm;
            currentForm.SetText("Witamy w systemie PROJEKT SO FULL");
            CPU = new modul_1.Procesor();
            interpreter = new modul_5.Interpreter();

            modul_5.Proces_nadzorczy _modul_nadzorczy = new modul_5.Proces_nadzorczy();
            currentForm.SetText("Zaladuj kody programow");
            while (true)
            {

                if (!(String.IsNullOrEmpty(currentForm.get_czytnik1().ElementAt(0))) && !(String.IsNullOrEmpty(currentForm.get_czytnik2().ElementAt(0))))
                {
                    Lista_modulow_nadzorczych.Add(new Proces_nadzorczy());
                    Lista_modulow_nadzorczych[0].memory = currentForm.get_czytnik1().ToList();
                    Lista_modulow_nadzorczych[0].nazwa = "1";
                    Lista_modulow_nadzorczych.Add(new Proces_nadzorczy());
                    Lista_modulow_nadzorczych[1].memory = currentForm.get_czytnik2().ToList();
                    Lista_modulow_nadzorczych[1].nazwa = "2";
                    break;
                }
                else
                {
                    if ((String.IsNullOrEmpty(currentForm.get_czytnik1().ElementAt(0)) && String.IsNullOrEmpty(currentForm.get_czytnik2().ElementAt(0))))
                    {
                        currentForm.set_drukarka2("Wprowadz kod programu");
                        currentForm.set_drukarka1("Wprowadz kod programu");
                    }
                    if (String.IsNullOrEmpty(currentForm.get_czytnik1().ElementAt(0)))
                    {
                        currentForm.set_drukarka2("Wprowadz kod programu");
                    }
                    else
                    {
                        currentForm.set_drukarka1("Wprowadz kod programu");

                    }
                    Thread.Sleep(1000);
                }
            }
           //zrob jak wyzej z new
            while (true)
            {
                try
                {
                    if (proces_ladowania._procesy.grupy_procesow.Any())
                    {
                        if (proces_ladowania._procesy.grupy_procesow[0].running)
                        {
                            currentForm.SetText("1");
                            proces_ladowania.job(_ladowanie._procesy, Lista_modulow_nadzorczych[0], CPU);
                        }
                    }
                    else
                    {
                        if (proces_ladowania._procesy.grupy_procesow.Any())
                        {
                            if (proces_ladowania._procesy.grupy_procesow[1].running)
                            {
                                currentForm.SetText("2");
                                proces_ladowania.job(_ladowanie._procesy, Lista_modulow_nadzorczych[1], CPU);
                            }
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    currentForm.SetText(ex.StackTrace);
                }


            }
        }
    }
}


