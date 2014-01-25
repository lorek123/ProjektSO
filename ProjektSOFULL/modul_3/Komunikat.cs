using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_3
{
        public class Komunikat
        {
            public Proces sender_pointer;
            public Proces next_pointer;
            //public int size;
            public string message;
            //public int message_size;
            Form1 currentForm = (Form1)Form1.ActiveForm;
            public Komunikat(Proces name, Proces n, string wiadomosc)
            {
                sender_pointer = name;
                next_pointer = n;
                //size = name.size();
                message = wiadomosc;
                //message_size = wiadomosc.Length;

            }

            public void Zatrzymanie_zlecenia(string wiadomosc)
            {
                currentForm.SetText(wiadomosc);
                

            }

            public void Czytaj_Komunikat(string komunikat, Procesy nadawca)
            {


            }

            public void Wysylaj_Komunikat(string komunikat, Procesy odbiorca)
            {


            }

            public void Komunikat_bledu()
            {
                currentForm.SetText("Wystapil blad");
            }
        }
    }
