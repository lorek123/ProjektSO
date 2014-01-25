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

        public Komunikat Czytaj_Komunikat(string odbiorca)
        {
            string tekst;
            int ile=0;
            string nadawca;
            modul_1.Proces receiver = Procesy.znalezienie_nazwy(odbiorca);
            receiver.semafor.p_program(Program x);
            currentForm.SetText("MESSAGE_SEMAPHORE_RECEIVER: " + modul_1.receiver.modul_1.semafor.value);
            receiver.modul_1.message_semaphore_common--;
            currentForm.SetText("MESSAGE_SEMAPHORE_COMMON: " +modul_1.receiver.modul_1.message_semaphore_common);
            Komunikat odebrany;
            odebrany = receiver.modul_1.first_message;
            nadawca = odebrany.sender_pointer.name;
            tekst = odebrany.message;
            ile = ile + tekst.Length;
            receiver.modul_1.first_message = receiver.modul_1.first_message.next;
            currentForm.SetText("Odebrano komunikat od procesu " + nadawca);
            currentForm.SetText("Treść: " + tekst);
            receiver.modul_1.message_semaphore_common++;
            return odebrany;
}



        public void Wysylaj_Komunikat(string odbiorca, string tekst)
        {
            modul_1.Proces receiver = Procesy.znalezienie_nazwy(odbiorca);
            receiver.mnessage_semaphore_common--;
            if (receiver == null)
            {
                Komunikat_bledu();
            }
            else
            {
                currentForm.SetText("MESSAGE_SEMAPHORE_COMMON: " + receiver.message_semaphore_common);
                Komunikat nowa = new Komunikat(tekst);
                nowa.sender_pointer = Procesy.znalezienie_nazwy(odbiorca, grupa);
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
                receiver.semafor.v_progam();
                currentForm.SetText("MESSAGE_SEMAPHORE_RECEIVER: " + receiver.semafor.value);
            }
            receiver.message_semaphore_common++;
            currentForm.SetText("Wysłano komunikat do procesu " + odbiorca);
            currentForm.SetText("Treść: " + tekst);

            /*Funkcja służąca do wysłania komunikatu, jako parametr przyjmuje nazwę procesu odbiorcy, tekst
komunikatu. Na początku za pomocą funkcji znalezienie_nazwy następuje wyszukanie bloku PCB odbiorcy, oraz wykonanie
na semaforze COMMON operacji P. Utworzony zostaje obiekt komunikatu, który w parametrze otrzymuje
tekst komunikatu, temu obiektowi jako wskaźnik do nadawcy komunikatu, przypisany jest blok kontrolny
procesu aktualnie wykonywanego, czyli tego który wywołał funkcję wysylania komunikatu. Wskaźnik na następny komunikat
jest zerowany. Następnie należy dodać obiekt tego komunikatu do jego bloku kontrolnego, gdy nie poosiada
żadnego komunikatu, to jest on przypisany do wskaźnika FIRST_MESSAGE, gdy zaś posiada już jakieś
komunikaty, to odszukuje się ostatni komunikat i w polu next tego komunikatu dodawany jest aktualnie
wysłany. Na końcu wykonywane są operacje V na semaforach odbiorcy COMMON i RECEIVER. */
            // Tak to powinno wygladac...

        }



        public void Komunikat_bledu()
        {
            currentForm.SetText("Wystapil blad");
        }
    }
    }
