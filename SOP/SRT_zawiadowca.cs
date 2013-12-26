using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proces_modul_nizszy
{
    class SRT_zawiadowca
    {

        public List<Proces> test = new List<Proces>();
        public int tau;
        public int proces_indeks;
        private double a = 0.5;

        SRT_zawiadowca(Proces run)
        {
            foreach (Proces x in test)
            {
                oblicz_czas(x);
            }

            proces_indeks = min_czas();
            if (test[proces_indeks] != run)
            {
                run.running = false;
                test[proces_indeks].running = true;
            } // uruchom nowy proces
            else
            {
            }// kontynuuj proces
        }


        void oblicz_czas(Proces test2)
        {
            tau = Convert.ToInt32(a * test2.proces_last_time + a * test2.proces_estimated_time);
            test2.proces_estimated_time = tau;
        }

        int min_czas()
        {
            Proces a = new Proces();
            int x = 0;
            int min = a.proces_estimated_time;

            foreach (Proces p in test)
            {
                if (min > a.proces_estimated_time && a.blocked == false && a.stopped == false)
                {
                    min = a.proces_estimated_time;
                    x = test.IndexOf(p);
                }
            }

            return x;
        }


    }
}
