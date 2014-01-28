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
            modul_3.Procesy _procesy = new modul_3.Procesy();
            modul_1.SRT_zawiadowca zawiadowca = new modul_1.SRT_zawiadowca();
            public void Load(Proces_nadzorczy Nadzorca, modul_1.Procesor CPU)
            {

                _procesy.tworzenie_procesu(Nadzorca.nazwa, int.Parse(Nadzorca.nazwa)-1, Nadzorca.memory.Count());

                string temp;
                for (int i = _procesy.grupy_procesow[int.Parse(Nadzorca.nazwa) - 1].cpu_stan[4]; i <= Nadzorca.memory.Count(); i++)
                {
                 
                    temp = Nadzorca.memory[i];
                    _interpreter.find(temp, CPU,ref Nadzorca.memory);
                    
                }


            }

            bool utworz_urzadzenie_wejscia(string nazwa) { return true; }
            bool utworz_urzadzenie_wyjscia(string nazwa) { return true; }

            string[] pobierzPCBzRunning(string[] a)
            {
                return a;
            }
            public void job(modul_5.Proces_nadzorczy proces_nadzorczy, modul_1.Procesor CPU)
            {

                string aktualnaLinia=proces_nadzorczy.memory.ElementAt(0);
                

                if (!aktualnaLinia.StartsWith("$JOB"))
                {
                    expunge();
                    return;
                }
                string[] daneJob = aktualnaLinia.Split(',');
                daneJob[1].TrimEnd('K');
                /*      if (!czyPamiecJestDostepna(Convert.ToInt32(daneJob[1])))
                      {
                          expunge();
                          return;
                      }
                 */
                //    wielkosc_pamieci = Convert.ToInt32(daneJob[1]);
                scan(daneJob[2]);
                scan(daneJob[3]);
                Load(proces_nadzorczy,CPU);
            }
            private bool scan(string dane)
            {
                if (!dane.StartsWith("IN"))
                {
                    expunge();
                    return false;
                }
                else if (dane.StartsWith("IN"))
                {
                    string[] temp = dane.Split('=');
                    utworz_urzadzenie_wejscia(temp[1]);

                }
                if (!dane.StartsWith("OUT"))
                {
                    expunge();
                    return false;
                }
                else if (dane.StartsWith("OUT"))
                {
                    string[] temp = dane.Split('=');
                    utworz_urzadzenie_wyjscia(temp[1]);

                }

                return false;
            }
            private void expunge()
            {
                //string[] a = pobierzPCBzRunning();
                // string nazwa= a[1];
                // if(!nazwa.startsWith('*')){ 
                //  zatrzymajProces(); 
                //  usunProces();  
                //  if(czyPrzydzielonoPamiec()){
                //  zerujKluczeOchronyPamieci();
                //  zwolnijPamiec();
                //  }
                //
                //}
                //string linia= getline();
                //if(!linia.StartsWith(""$JOB"){return;}
                //job();

            }
    }
}
