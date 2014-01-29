using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_5
{
    public class Ladowanie
    {
        Interpreter _interpreter = new Interpreter();
        public modul_3.Procesy _procesy;
        modul_1.SRT_zawiadowca zawiadowca;
        public Ladowanie()
        {
            _interpreter = new Interpreter();
            _procesy = new modul_3.Procesy();
            zawiadowca = new modul_1.SRT_zawiadowca();
        }

        public void Load(Proces_nadzorczy Nadzorca, modul_1.Procesor CPU)
        {

            _procesy.tworzenie_procesu(Nadzorca.nazwa, int.Parse(Nadzorca.nazwa) - 1, Nadzorca.memory.Count());

            string temp;
            int adres_skoku = 0;
            for (int i = _procesy.grupy_procesow[int.Parse(Nadzorca.nazwa) - 1].cpu_stan[4]; i <= Nadzorca.memory.Count(); i++)
            {

                temp = Nadzorca.memory[i];
                _interpreter.find(temp, CPU, ref Nadzorca.memory, ref adres_skoku);
                CPU.set_lr(CPU.get_lr() + 1);
                zawiadowca.srt(_procesy.grupy_procesow, CPU);
                if (!_procesy.grupy_procesow[int.Parse(Nadzorca.nazwa) - 1].running)
                {
                    break;
                }
            }


        }

        bool utworz_urzadzenie_wejscia(string nazwa) { return true; }
        bool utworz_urzadzenie_wyjscia(string nazwa) { return true; }

        string[] pobierzPCBzRunning(string[] a)
        {
            return a;
        }
        public void job(modul_3.Procesy lista, modul_5.Proces_nadzorczy proces_nadzorczy, modul_1.Procesor CPU)
        {
            Form1 currentForm = (Form1)Form1.ActiveForm;
            string aktualnaLinia = proces_nadzorczy.memory.ElementAt(0);
            currentForm.SetText("Wykonuje metode job dla " + proces_nadzorczy.nazwa);
            if (!aktualnaLinia.StartsWith("$JOB"))
            {
                expunge(lista, proces_nadzorczy);
                return;
            }
            string[] daneJob = aktualnaLinia.Split(',');
            daneJob[1].TrimEnd('K');
            Load(proces_nadzorczy, CPU);
        }

        private void expunge(modul_3.Procesy lista_procesow, Proces_nadzorczy Nadzorca)
        {
            lista_procesow.usuniecie_procesu(Nadzorca.nazwa, int.Parse(Nadzorca.nazwa));
        }
    }
}
