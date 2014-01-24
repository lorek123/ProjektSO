using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_3
{
    public class Procesy
    {
        //public List<Procesy> lista_procesow = new List<Procesy>();
        public List<modul_1.Proces> grupy_procesow = new List<modul_1.Proces>();
        private bool istnieje;
        Komunikat tekst;

        //do listy wszystkich grup procesow dodaje nowa grupe procesow
        public Procesy()
        {

        }


        //utworzenie procesu
        public void tworzenie_procesu(string nazwa, int numer, int czas)
        {
            istnieje = false;

            foreach (modul_1.Proces proces in grupy_procesow)
            {
                if (proces.group_indeks == numer && proces.proces_name == nazwa)
                {
                    istnieje = true;
                    tekst.Komunikat_bledu();
                    break;
                }

            }

            if (!istnieje)
            {
                grupy_procesow.Add(new modul_1.Proces(nazwa, czas, numer));
                tekst.Zatrzymanie_zlecenia("Utworzono proces" + nazwa);

            }
        }

        //zatrzymanie procesu
        public void zatrzymanie_procesu(string nazwa, int numer)
        {

            foreach (modul_1.Proces proces in grupy_procesow)
            {

                if (proces.group_indeks == numer && proces.proces_name == nazwa)
                {
                    proces.running = false;
                    tekst.Zatrzymanie_zlecenia("Zatrzymano proces" + nazwa);
                    break;
                }

            }

        }


        //usuniecie procesu
        public void usuniecie_procesu(string nazwa, int numer)
        {
            istnieje = false;
            int licznik = 0;

            foreach (modul_1.Proces proces in grupy_procesow)
            {
                if (proces.group_indeks == numer && proces.proces_name == nazwa)
                {
                    istnieje = true;
                    licznik = grupy_procesow.IndexOf(proces);
                    if (proces.running)
                    {
                        proces.running = false;
                        tekst.Zatrzymanie_zlecenia("Zatrzymano proces" + nazwa);
                    }
                    break;

                }
                else
                {
                    tekst.Komunikat_bledu();
                    break;
                }

            }
            if (istnieje)
            {
                grupy_procesow.RemoveAt(licznik);
                tekst.Zatrzymanie_zlecenia("Usunieto proces" + nazwa);
            }

        }

        public string znalezienie_procesu()
        {
            istnieje = false;
            int licznik = 0;
            string nazwa_procesu;
            foreach (modul_1.Proces proces in grupy_procesow)
            {
                if (proces.running)
                {
                    istnieje = true;
                    licznik = grupy_procesow.IndexOf(proces);
                    tekst.Zatrzymanie_zlecenia("Znaleziono proces" + proces.proces_name + "w grupie o indeksie" + proces.group_indeks);
                    break;

                }
            }

            if (istnieje)
            {
                nazwa_procesu = grupy_procesow[licznik].proces_name;
                return nazwa_procesu;

            }
            else
            {
                tekst.Komunikat_bledu();
            }

        }
    }
    
}
