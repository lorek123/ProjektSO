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
        public Proces first_waiter = new Proces();
        public Proces proces_running = new Proces();
        public List<Proces> semafor_list_waiting = new List<Proces>();


        public Semafor()
        {
            value = 5;
            first_waiter = null;
            proces_running = null;
        }


        /*Odciecie 1 od wartosci semafora*/
        public void p_program()
        {
            Console.WriteLine("Wykonuje program P semafora");
            value -= 1;
            /*kontynuuj*/
            if (value > 0)
            {
                /*Dostep do danych dla procesu z listy oczekujacych*/
            }
        }

        /*XV*/
        public void v_progam()
        {
            Console.WriteLine("Wykonuje program V semafora");
            value += 1;
            /*kontynuuj*/
            if (semafor_list_waiting.Count() != 0 && value > 0)
            {
                //URUCHOM PROCES
                semafor_list_waiting.RemoveAt(0);
            }
        }
        /*xper*/
        public void zawiadowca_run()
        {
            /////////////////////////////////////////POPRAW
            Console.WriteLine("Twoj zawiadowca - zapierdala");
        }

    }
}
