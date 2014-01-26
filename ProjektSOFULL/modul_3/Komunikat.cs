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
            currentForm.SetText("Tre��: " + tekst);
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
                nowa.sender_pointer = proces.znalezienie_nazwy(odbiorca, grupa);
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
            currentForm.SetText("Wys�ano komunikat do procesu " + odbiorca);
            currentForm.SetText("Tre��: " + tekst);
        }

        /*  Funkcja s�u��ca do wys�ania komunikatu, jako parametr przyjmuje nazw� procesu odbiorcy, tekst
komunikatu. Na pocz�tku za pomoc� funkcji znalezienie_nazwy nast�puje wyszukanie bloku PCB odbiorcy, oraz wykonanie
na semaforze COMMON operacji P. Utworzony zostaje obiekt komunikatu, kt�ry w parametrze otrzymuje
tekst komunikatu, temu obiektowi jako wska�nik do nadawcy komunikatu, przypisany jest blok kontrolny
procesu aktualnie wykonywanego, czyli tego kt�ry wywo�a� funkcj� wysylania komunikatu. Wska�nik na nast�pny komunikat
jest zerowany. Nast�pnie nale�y doda� obiekt tego komunikatu do jego bloku kontrolnego, gdy nie poosiada
�adnego komunikatu, to jest on przypisany do wska�nika FIRST_MESSAGE, gdy za� posiada ju� jakie�
komunikaty, to odszukuje si� ostatni komunikat i w polu next tego komunikatu dodawany jest aktualnie
wys�any. Na ko�cu wykonywane s� operacje V na semaforach odbiorcy COMMON i RECEIVER. */
        // Tak to powinno wygladac...

        public void Komunikat_bledu()
        {
            currentForm.SetText("Wystapil blad");
        }
    }
}