using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Modul3
{
    class Procesy
    {
        //public List<Procesy> lista_procesow = new List<Procesy>();
        public List<Proces> grupy_procesow = new List<Proces>();
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
        
            foreach (Proces proces in grupy_procesow)
              {
                   if (proces.group_indeks == numer && proces.proces_name == nazwa)
                      {
                          istnieje = true;
                          tekst.Komunikat_bledu();            //ZROBIC TO
                          break;
                      }
                    
            }

            if (!istnieje)
            {
                grupy_procesow.Add(new Proces(nazwa, czas, numer));
                tekst.Zatrzymanie_zlecenia("Utworzono proces" + nazwa);      // ZROBIC   , komunikat o zakonczeniu                            
                
            }
        }

       
        //usuniecie procesu
        public void usuniecie_procesu(string nazwa, int numer)
        {
            istnieje = false;
            int licznik = 0;

            foreach (Proces proces in grupy_procesow)
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

        public void znalezienie_procesu(string nazwa)
        {
            istnieje = false;
            foreach (Proces proces in grupy_procesow)
            {
                if (proces.proces_name == nazwa){
                    Zatrzymanie_zlecenia("Znaleziono proces" + nazwa + "w grupie o indeksie" + proces.group_indeks);

                }
                break;
        }



    }
}
