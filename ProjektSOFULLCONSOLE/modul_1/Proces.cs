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
        public bool stop_waiting;
        public bool czy_sprawdzony;
        public bool semafor_info;
        public int message_semaphore_common;
        public int message_semaphore_receiver;
        public List<string> first_message;
        public int proces_estimated_time;
        public int proces_last_time;
        public int group_indeks;
        public int instruction_done;
        public int[] cpu_stan = new int[5];

        public Proces(string name, int time, int group, ref List<string> fm)
        {
            proces_name = name;
            running = false;
            blocked = false;
            stopped = false;
            proces_estimated_time = time;
            proces_last_time = 0;
            message_semaphore_common = 0;
            message_semaphore_receiver = 0;
            first_message = fm;
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

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nazwa " + proces_name + "\nPET: " + proces_estimated_time);
            Console.ResetColor();
        }
    }
}
