using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_3
{
    public class Komunikat
    {
        public modul_1.Proces sender_pointer;
        public int size;
        public string message;
        public Komunikat next;
        Procesy proces;
        modul_1.Semafor semafor;
        Form1 currentForm = (Form1)Form1.ActiveForm;
        public Komunikat(string tekst)
        {
            this.message = tekst;
            this.size = tekst.Length;

        }

        public void Zatrzymanie_zlecenia(string wiadomosc)
        {
            currentForm.SetText(wiadomosc);

        }

        public Komunikat Czytaj_Komunikat()
        {
            string tekst;
            int ile = 0;
            string nadawca;
            modul_1.Proces receiver = proces.znalezienie_nazwy();
            semafor.p_program(receiver);
            currentForm.SetText("MESSAGE_SEMAPHORE_RECEIVER: " + semafor.get_value());
            receiver.message_semaphore_common--;
            currentForm.SetText("MESSAGE_SEMAPHORE_COMMON: " + receiver.message_semaphore_common);
            Komunikat odebrany;
            odebrany = receiver.first_message;
            nadawca = odebrany.sender_pointer.proces_name;
            tekst = odebrany.message;
            ile = ile + tekst.Length;
            receiver.first_message = receiver.first_message.next;
            currentForm.SetText("Odebrano komunikat od procesu " + nadawca);
            currentForm.SetText("Tresc: " + tekst);
            receiver.message_semaphore_common++;
            return odebrany;
        }


        public void Wysylaj_Komunikat(string odbiorca, int grupa, string tekst)
        {
            modul_1.Proces receiver = proces.znalezienie_nazwy(odbiorca, grupa);
            receiver.message_semaphore_common--;
            if (receiver == null)
            {
                Komunikat_bledu();
            }
            else
            {
                currentForm.SetText("MESSAGE_SEMAPHORE_COMMON: " + receiver.message_semaphore_common);
                Komunikat nowa = new Komunikat(tekst);
                nowa.sender_pointer = proces.znalezienie_nazwy();
                nowa.next = null;
                nowa.size = tekst.Length;
                if (receiver.first_message == null)
                {
                    receiver.first_message = nowa;
                }
                else
                {
                    Komunikat temp = receiver.first_message.next;
                    while (temp.next == null)
                    {
                        temp = temp.next;
                    }
                    temp.next = nowa;
                }
                semafor.v_progam();
                currentForm.SetText("MESSAGE_SEMAPHORE_RECEIVER: " + semafor.get_value());
            }
            receiver.message_semaphore_common++;
            currentForm.SetText("Wyslano komunikat do procesu " + odbiorca);
            currentForm.SetText("Tresc: " + tekst);
        }

        
        public void Komunikat_bledu()
        {
            currentForm.SetText("Wystapil blad");
        }
    }
}
