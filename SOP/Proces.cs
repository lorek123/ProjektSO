using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proces_modul_nizszy
{
    class Proces
    {
        string proces_name;
        Proces proces_next = new Proces();
        Proces proces_previous = new Proces();
        public bool running;
        public bool stopped;
        public bool blocked;
        public int proces_estimated_time;
        public int proces_last_time;

        public Proces()
        {
            proces_name = "proces";
            running = false;
            stopped = false;
            blocked = false;
            proces_next = null;
            proces_previous = null;
            proces_estimated_time = 0;
            proces_last_time = 0;
        }

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
        }
    }
}
