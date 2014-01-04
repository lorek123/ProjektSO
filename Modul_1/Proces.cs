using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proces_modul_nizszy
{
    class Proces
    {
        /*PCB*/
        public string proces_name;
        public Proces proces_next;
        public Proces proces_previous;
        public bool running;
        public bool stopped;
        public bool blocked;
        public int proces_estimated_time;
        public int proces_last_time;
        public bool semafor_info;

        public Proces(string name, Proces n, Proces p, int time)
        {
            proces_name = name;
            proces_next = n;
            proces_previous = p;
            running = false;
            blocked = false;
            stopped = false;
            proces_estimated_time = time;
            proces_last_time = 0;
            semafor_info = false;
        }

       public void wyswietl()
        {
            Console.WriteLine("Nazwa " + proces_name + "\nPET: " + proces_estimated_time);

        }
    }
}
