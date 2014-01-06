using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modul_Nadzorczy
{
    class Ladowanie
    {
        void Load(int pamiec) {
            string temp;
            while (true) {
                temp= getline();

            }
        
        }

        int wielkosc_pamieci;
        private string getline() { return "a"; }
        private bool czyPamiecJestDostepna(int wielkosc_pamieci)
        {
            return true; 
        }
        bool utworz_urzadzenie_wejscia(string nazwa) { return true; }
        bool utworz_urzadzenie_wyjscia(string nazwa) { return true; }

        string[] pobierzPCBzRunning(string[] a)
        {
            return a;
        }
        private void job()
        {
            string aktualnaLinia;
            aktualnaLinia = getline();

            if (!aktualnaLinia.StartsWith("$JOB"))
            {
                expunge();
                return;
            }

            string[] daneJob = aktualnaLinia.Split(',');
            daneJob[1].TrimEnd('K');
            if (!czyPamiecJestDostepna(Convert.ToInt32(daneJob[1])))
            {
                expunge();
                return;
            }
            wielkosc_pamieci = Convert.ToInt32(daneJob[1]);
            scan(daneJob[2]);
            scan(daneJob[3]);
            Load(wielkosc_pamieci);
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
                return true;
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
                return true;
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
