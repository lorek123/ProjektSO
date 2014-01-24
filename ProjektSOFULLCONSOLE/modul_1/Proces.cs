using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_1
{
    public class Proces
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
        public bool czy_sprawdzony;
        public int[] cpu_stan = new int[5];

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
            czy_sprawdzony = true;
        }

        public void cpu_stan_zapisz(Procesor x)
        {
            cpu_stan[0] = x.get_r0();
            cpu_stan[1] = x.get_r1();
            cpu_stan[2] = x.get_r2();
            cpu_stan[3] = x.get_r3();
            cpu_stan[4] = x.get_lr();
        }

        public void wyswietl()
        {
            Console.WriteLine("Nazwa " + proces_name + "\nPET: " + proces_estimated_time);

        }
    }
}
