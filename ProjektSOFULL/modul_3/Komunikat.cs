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
