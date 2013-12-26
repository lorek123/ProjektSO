using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP
{
    class Proces
    {
        string proces_name;
        Proces proces_next = new Proces();
        Proces proces_previous = new Proces();
        public byte running;
        public byte stopped;
        public byte blocked;
        public int proces_estimated_time;
        public int proces_last_time;

        public Proces()
        {
            proces_name = "proces";
            running = 0;
            stopped = 0;
            blocked = 0;
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
            running = 0;
            blocked = 0;
            stopped = 0;
            proces_estimated_time = time;
            proces_last_time = 0;
        }
    }
}
