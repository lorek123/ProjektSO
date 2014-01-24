using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_1
{
    class Semafor
    {
        private int value;
        public List<Proces> semafor_list_waiting = new List<Proces>();

        public Semafor()
        {
            value = 5;
            //tescik();
        }

        /*Odciecie 1 od wartosci semafora*/
        public void p_program(ref Proces x)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            Console.ResetColor();
        }

        /*Dodanie 1 do wartosci semafora*/
        public void v_progam()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            Console.ResetColor();
        }

        public void semafor_waiting()
        {
            Proces x = semafor_list_waiting[0];
            semafor_list_waiting.RemoveAt(0);
            //zwróć proces do listy
        }

       private void tescik()
        {
            Proces x, y, z;
            x = new Proces("x", 10, 0);
            y = new Proces("y", 10, 0);
            z = new Proces("z", 10, 0);

            p_program(ref x);
            p_program(ref y);
            p_program(ref z);
            v_progam();
        }

    }


}
