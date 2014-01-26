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
            currentForm.SetText("Treœæ: " + tekst);
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
            currentForm.SetText("Wys³ano komunikat do procesu " + odbiorca);
            currentForm.SetText("Treœæ: " + tekst);
        }

        /*  Funkcja s³u¿¹ca do wys³ania komunikatu, jako parametr przyjmuje nazwê procesu odbiorcy, tekst
komunikatu. Na pocz¹tku za pomoc¹ funkcji znalezienie_nazwy nastêpuje wyszukanie bloku PCB odbiorcy, oraz wykonanie
na semaforze COMMON operacji P. Utworzony zostaje obiekt komunikatu, który w parametrze otrzymuje
tekst komunikatu, temu obiektowi jako wskaŸnik do nadawcy komunikatu, przypisany jest blok kontrolny
procesu aktualnie wykonywanego, czyli tego który wywo³a³ funkcjê wysylania komunikatu. WskaŸnik na nastêpny komunikat
jest zerowany. Nastêpnie nale¿y dodaæ obiekt tego komunikatu do jego bloku kontrolnego, gdy nie poosiada
¿adnego komunikatu, to jest on przypisany do wskaŸnika FIRST_MESSAGE, gdy zaœ posiada ju¿ jakieœ
komunikaty, to odszukuje siê ostatni komunikat i w polu next tego komunikatu dodawany jest aktualnie
wys³any. Na koñcu wykonywane s¹ operacje V na semaforach odbiorcy COMMON i RECEIVER. */
        // Tak to powinno wygladac...







        public void Komunikat_bledu()
        {
            currentForm.SetText("Wystapil blad");
        }
    }
}