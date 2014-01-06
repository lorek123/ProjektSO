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
        public bool running;
        public bool stopped;
        public bool blocked;
        public int proces_estimated_time;
        public int proces_last_time;
        public bool semafor_info;
        public int group_indeks;
        public int instruction_done;

        public Proces(string name, int time, int group)
        {
            proces_name = name;
            running = false;
            blocked = false;
            stopped = false;
            proces_estimated_time = time;
            proces_last_time = 0;
            semafor_info = false;
            group_indeks = group;
            instruction_done = 0;
        }

       public void wyswietl()
        {
            Console.WriteLine("Nazwa " + proces_name + "\nPET: " + proces_estimated_time);

        }
    }
}
