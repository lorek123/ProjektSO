﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_1
{
    class Semafor
    {
        Form1 currentForm = (Form1)Form1.ActiveForm;
        private int value;
        public List<Proces> semafor_list_waiting = new List<Proces>();

        public Semafor()
        {
            value = 5;
        }

        public int get_value()
        {
            return value;
        }

        /*Odciecie 1 od wartosci semafora*/
        public void p_program(Proces x)
        {
            currentForm.SetText("SEMAFOR: Wykonuje program P semafora");
            /*kontynuuj*/
            if (value > 0)
            {
                /*Dostep do danych dla procesu z listy oczekujacych*/
                currentForm.SetText("SEMAFOR: Operacja P - przyznaje dostep do semafora");
                x.semafor_info = true;

            }
            else
            {
                /*nie ma mozliwosci dostepu do semafora - dodanie do listy oczekujacych*/
                currentForm.SetText("SEMAFOR: Operacja p -brak dostepu - dodaje proces na liste oczekujacych");
                semafor_list_waiting.Add(x);
            }
            value -= 1;
        }

        /*Dodanie 1 do wartosci semafora*/
        public void v_progam()
        {
            currentForm.SetText("Wykonuje program V semafora");
            value += 1;
            /*kontynuuj*/
            if (semafor_list_waiting.Count() > 0)
            {
                currentForm.SetText("SEMAFOR: Operacja V - przyznaje dostep procesowi z listy oczekujacych");
                semafor_waiting();
            }
            else
            {
                currentForm.SetText("SEMAFOR: Operacja V - lista oczekujacych procesow pod semaforem jest pusta");
            }
        }

        public void semafor_waiting()
        {
            Proces x = semafor_list_waiting[0];
            semafor_list_waiting.RemoveAt(0);
            //zwróć proces do listy
        }
    }
}
