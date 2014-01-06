using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class Komunikat
    {
        public Proces sender_pointer;
        public Proces next_pointer;
        public int size;
        public string message;
        public int message_size;
        public Komunikat(Proces name, Proces n, int size, string wiadomosc)
        {
            sender_pointer = name;
            next_pointer = n;
            size = name.size();
            message = wiadomosc;
            message_size = wiadomosc.Length;

        }
    }
}
