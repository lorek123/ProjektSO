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
        private string name;
        private int group_number;
        Form1 currentForm = (Form1)Form1.ActiveForm;
        Komunikat tekst;
        modul_1.Semafor semafor;

        //informacja odnosnie szukanego procesu
        public void getparam(out string name_search, out int number)
        {
            name_search = name;
            number = group_number;

        }

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
                currentForm.SetText("Utworzono proces" + nazwa + " jego czas to " + grupy_procesow[(numer)].proces_estimated_time.ToString() + " DEKLAROWANY CZAS " + czas);
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
                        currentForm.SetText("Zatrzymano proces" + nazwa);
                       // tekst.Zatrzymanie_zlecenia("Zatrzymano proces" + nazwa);
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
                 currentForm.SetText("Usunieto proces" + nazwa);
                //tekst.Zatrzymanie_zlecenia("Usunieto proces" + nazwa);
            }

        }
        // znalezienie procesu, ktory w danym momencie jest uruchomiony
        public void znalezienie_procesu()
        {
            istnieje = false;
            int licznik = 0;
            int number;
            string name_search;
            foreach (modul_1.Proces proces in grupy_procesow)
            {
                if (proces.running)
                {
                    istnieje = true;
                    licznik = grupy_procesow.IndexOf(proces);
                    currentForm.SetText("Znaleziono proces" + proces.proces_name + "w grupie o indeksie" + proces.group_indeks);
                    //tekst.Zatrzymanie_zlecenia("Znaleziono proces" + proces.proces_name + "w grupie o indeksie" + proces.group_indeks);
                    break;

                }
            }

            if (istnieje)
            {
                name_search = grupy_procesow[licznik].proces_name;
                number = grupy_procesow[licznik].group_indeks;
                getparam(out name_search, out number);
            }
            else
            {
                tekst.Komunikat_bledu();
            }

        }
        // znalezienie po nazwie i numerze grupy i zwrocenie konkretnego procesu
        //nie wiem czemu tak
        
        public modul_1.Proces znalezienie_nazwy(string nazwa, int grupa)
        {
            istnieje = false;
            int licznik = 0;
            foreach (modul_1.Proces proces in  grupy_procesow)
            {
                if (proces.group_indeks == grupa && proces.proces_name == nazwa)
                {
                    istnieje = true;
                    licznik = grupy_procesow.IndexOf(proces);
                    break;

                }
            }

            if (istnieje)
            {
                return grupy_procesow[licznik];
            }
            else
            {
                
                tekst.Komunikat_bledu();
                return null;
                
            }


        }

        public modul_1.Proces znalezienie_nazwy()
        {
            istnieje = false;
            int licznik = 0;
            foreach (modul_1.Proces proces in grupy_procesow)
            {
                if (proces.running)
                {
                    istnieje = true;
                    licznik = grupy_procesow.IndexOf(proces);
                    break;

                }
            }

            if (istnieje)
            {
                return grupy_procesow[licznik];
            }
            else
            {

                tekst.Komunikat_bledu();
                return null;

            }


        }
         

        //zatrzymanie procesu
        public void zatrzymanie_procesu(string nazwa, int numer)
        {
            int licznik = 0;

            foreach (modul_1.Proces proces in grupy_procesow)
            {
                if (proces.group_indeks == numer && proces.proces_name == nazwa)
                {
                    licznik = grupy_procesow.IndexOf(proces);
                    if (proces.running)
                    {
                     
                        proces.running = false;
                        currentForm.SetText("Zatrzymano proces" + nazwa);
                        //tekst.Zatrzymanie_zlecenia("Zatrzymano proces" + nazwa);
                    }
                    break;

                }
                else
                {
                    tekst.Komunikat_bledu();
                    break;
                }

            }
        }

        //uruchomienie procesu
        public void uruchomienie_procesu(string nazwa, int numer)
        {
            int licznik = 0;

            foreach (modul_1.Proces proces in grupy_procesow)
            {
                if (proces.group_indeks == numer && proces.proces_name == nazwa)
                {
                    licznik = grupy_procesow.IndexOf(proces);
                    if (proces.running)
                    {
                        proces.running = true;
                        currentForm.SetText("Uruchomiono proces" + nazwa);
                       // tekst.Zatrzymanie_zlecenia("Uruchomiono proces" + nazwa);
                    }
                    break;

                }
                else
                {
                    tekst.Komunikat_bledu();
                    break;
                }

            }

        }
       /* // Zatrzymanie zlecenia i powiadomienie programu nadzorczego
        public void Zakonczenie_realizacji_zlecenia(int grupa)
        {
            tekst.Wysylaj_Komunikat("*IBSUP", grupa, "KONIEC ZLECENIA");
        } */
    }
    
}
