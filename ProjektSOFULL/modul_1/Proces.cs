using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektSOFULL.modul_3;
namespace ProjektSOFULL.modul_1
{
    public class Proces
    {
        /*PCB*/
        public string proces_name;
        public Komunikat first_message;
        public bool running;
        public bool stopped;
        public bool blocked;
        public bool stop_waiting;
        public bool czy_sprawdzony;
        public bool semafor_info;
        public int message_semaphore_common;
        public int message_semaphore_receiver;
        public int proces_estimated_time;
        public int proces_last_time;
        public int group_indeks;
        public int instruction_done;
        public int[] cpu_stan = new int[5];

        Form1 currentForm = (Form1)Form1.ActiveForm;
        public Proces(string name, int time, int group)
        {
            proces_name = name;
            first_message = null;
            running = false;
            blocked = false;
            stopped = false;
            proces_estimated_time = time;
            proces_last_time = 0;
            message_semaphore_common = 0;
            message_semaphore_receiver = 0;
            semafor_info = false;
            group_indeks = group;
            instruction_done = 0;
            czy_sprawdzony = true;
        }
        public Proces() { }

        public void cpu_stan_zapisz(Procesor x)
        {
            cpu_stan[0] = x.get_r0();
            cpu_stan[1] = x.get_r1();
            cpu_stan[2] = x.get_r2();
            cpu_stan[3] = x.get_r3();
            proces_last_time = x.get_lr() - cpu_stan[4];
            cpu_stan[4] = x.get_lr();
        }

        public void cpu_stan_wczytaj(Procesor x)
        {
            currentForm.SetText("|||||||WCZYTUJE STAN PROCESORA|||||||");
            x.set_r0(cpu_stan[0]);
            x.set_r1(cpu_stan[1]);
            x.set_r2(cpu_stan[2]);
            x.set_r3(cpu_stan[3]);
            x.set_lr(cpu_stan[4], this.proces_name);
        }

        public void wyswietl()
        {
            currentForm.SetText("DANE PROCESU: Nazwa " + this.proces_name + "\nPET: " + this.proces_estimated_time);

        }
    }
}
