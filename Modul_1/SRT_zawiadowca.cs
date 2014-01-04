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

        /*glowna czesc algorytmu*/
        public SRT_zawiadowca(Proces run)
        {
            //tescik();
                oblicz_czas(run);
                foreach (Proces x in test)
                {
                    if (x.blocked == false && x.stopped == false)
                    {
                        oblicz_czas(x);
                    }
                }
                Console.WriteLine("Obliczone nowe czasy przewidywane do konca procesow");

                proces_indeks = min_czas(run);
                if (proces_indeks >= 0)
                {
                    if (test[proces_indeks] != run)
                    {
                        /*  uruchom nowy proces*/
                        run.running = false;
                        test[proces_indeks].running = true;
                        Console.WriteLine("Uruchomiono proces o nazwie " + test[proces_indeks].proces_name);
                    }
                    else
                    {
                        /*nie zmieniaj i kontynuuj stary*/
                        Console.WriteLine("Kontynuujemy proces o nazwie " + test[proces_indeks].proces_name);
                    }
                }
                else
                    Console.WriteLine("Kontynuujemy proces o nazwie " + run.proces_name);
            
        }

        /*obliczanie czasu procesow*/
        void oblicz_czas(Proces test2)
        {
            if (test2 != null)
            {
                tau = Convert.ToInt32(a * test2.proces_last_time + a * test2.proces_estimated_time);
                test2.proces_estimated_time = tau;
            }
        }

        /*wyszukiwanie minimalnego czasu procesu*/
        int min_czas(Proces a)
        {
            Console.WriteLine("Wyszukiwanie min czasu procesu");
            int x = -1;
            int min = a.proces_estimated_time;
            if (test.Count() > 0)
            {
                foreach (Proces p in test)
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
                Console.WriteLine("Nie ma zadnego procesu na liscie");
            }
            
            return x;
        }

        private void tescik()
        {
            Proces x, y, z;
            x = new Proces("x", null, null, 10);
            y = new Proces("y", x, null, 10);
            z = new Proces("z", y, null, 10);
            x.proces_next = y;
            y.proces_next = z;

            test.Add(x);
            test.Add(y);
            test.Add(z);
        }

    }
}
