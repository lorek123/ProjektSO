using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proces_modul_nizszy
{
    class Semafor
    {
        private int value;
        public List<Proces> semafor_list_waiting = new List<Proces>();

        public Semafor()
        {
            value = 2;
            tescik();
        }

        /*Odciecie 1 od wartosci semafora*/
        public void p_program(Proces x)
        {
            Console.WriteLine("Wykonuje program P semafora");

            /*kontynuuj*/
            if (value > 0)
            {
                /*Dostep do danych dla procesu z listy oczekujacych*/
                Console.WriteLine("Operacja P: Przyznaje dostep do semafora");
                x.semafor_info = true;

            }
            else
            {
                /*nie ma mozliwosci dostepu do semafora - dodanie do listy oczekujacych*/
                Console.WriteLine("Operacja P: Brak dostepu - dodaje proces na liste oczekujacych");
                semafor_list_waiting.Add(x);
            }
            value -= 1;
        }

        /*Dodanie 1 do wartosci semafora*/
        public void v_progam()
        {
            Console.WriteLine("Wykonuje program V semafora");
            value += 1;
            /*kontynuuj*/
            if (semafor_list_waiting.Count() > 0)
            {
                Console.WriteLine("Operacja V: Przyznaje dostep procesowi z listy oczekujacych");
                semafor_waiting();       
            }
            else
            {
                Console.WriteLine("Operacja V: Lista oczekujacych procesow pod semaforem jest pusta");
            }
        }

        public void semafor_waiting()
        {
            Proces x = semafor_list_waiting[0];
            semafor_list_waiting.RemoveAt(0);
        }

        void tescik()
        {
            Proces x, y, z;
            x = new Proces("x", null, null, 10);
            y = new Proces("y", null, null, 10);
            z = new Proces("z", null, null, 10);

            p_program(x);
            p_program(y);
            p_program(z);
            v_progam();
        }

    }
}
