using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektSOFULL.modul_3;
using ProjektSOFULL;

namespace ProjektSOFULL.modul_1
{

    public class SRT_zawiadowca
    {
        private List<Proces> test = new List<Proces>(); //testowe
        public int tau;
        public int proces_indeks;
        private double a = 0.5;

        Form1 currentForm = (Form1)Form1.ActiveForm;
        /*glowna czesc algorytmu*/
        public SRT_zawiadowca(ref Proces run, ref List<Proces> grupy_procesow)
        {
            
            oblicz_czas(run);
            foreach (Proces x in grupy_procesow)
            {
                if (x.blocked == false && x.stopped == false)
                {
                    oblicz_czas(x);
                }
            }
            currentForm.SetText("Obliczone nowe czasy przewidywane do konca procesow");

            proces_indeks = min_czas(run, grupy_procesow);
            if (proces_indeks >= 0)
            {
                if (grupy_procesow[proces_indeks] != run)
                {
                    /*  uruchom nowy proces*/
                    run.running = false;
                    run.czy_sprawdzony = false;
                    grupy_procesow[proces_indeks].running = true;
                    currentForm.SetText("Uruchomiono proces o nazwie " + grupy_procesow[proces_indeks].proces_name);
                }
                else
                {
                    /*nie zmieniaj i kontynuuj stary*/
                    currentForm.SetText("Kontynuujemy proces o nazwie " + grupy_procesow[proces_indeks].proces_name);
                }
            }
            else
                currentForm.SetText("Kontynuujemy proces o nazwie " + run.proces_name);
        }

        /*obliczanie czasu procesow*/
        void oblicz_czas(Proces x)
        {
            if (x != null && x.czy_sprawdzony == false)
            {
                tau = Convert.ToInt32(a * x.proces_last_time + a * x.proces_estimated_time);
                x.proces_estimated_time = tau;
                x.czy_sprawdzony = true;
            }
        }

        /*wyszukiwanie minimalnego czasu procesu*/
        int min_czas(Proces a, List<Proces> grupy_procesow)
        {
            currentForm.SetText("Wyszukiwanie min czasu procesu");
            int x = -1;
            int min = a.proces_estimated_time;
            if (grupy_procesow.Count() > 0)
            {
                foreach (Proces p in grupy_procesow)
                {
                    if (min > p.proces_estimated_time && p.blocked == false && p.stopped == false)
                    {
                        min = p.proces_estimated_time;
                        x = test.IndexOf(p);
                    }
                }
            }
            else
            {
                currentForm.SetText("Nie ma zadnego procesu na liscie");
            }

            return x;
        }

        private void tescik()
        {
            Proces x, y, z;
            //x = new Proces("x", 10, 0);
            //y = new Proces("y", 10, 0);
            //z = new Proces("z", 10, 0);

            //test.Add(x);
            //test.Add(y);
            //test.Add(z);
        }

    }

}
