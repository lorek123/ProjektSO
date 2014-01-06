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
        public List<Procesy> lista_procesow = new List<Procesy>();
        public string name;
        public string nazwa_procesu;
        private bool istnieje;

        //do listy wszystkich grup procesow dodaje nowa grupe procesow
        public Procesy(List<Procesy> nazwa)
        {
            
        }


        //XC
        public void tworzenie_procesu(string nazwa, List<Procesy> lista)
        {

            foreach (Proces proces.proces_name in arrayList)
            {
                if (vals.Contains(proces.proces_name))
                {
                    returnValue = true;
                    break;
                }
                vals.Add(s);
            }
            if (lista.Exists(nazwa))
            {
                Console.Write("Proces o takiej nazwie juz istnieje");
                XQUE();
            }
            else
            {
                XA(nazwa);

                XF(nazwa);

            }
        }

        private bool HasDuplicates(string[] arrayList)
        {
            List<string> vals = new List<string>();
            bool returnValue = false;
            foreach (string s in arrayList)
            {
                if (vals.Contains(s))
                {
                    returnValue = true;
                    break;
                }
                vals.Add(s);
            }


            return returnValue;
        }
        //usuniecie procesu
        public void XD(string nazwa, List<string> lista, List<Procesy> list)
        {
            istnieje = false;
             while (istnieje == false)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if(lista.Exists(nazwa)){
                        XD(list[i]);
                        lista.RemoveAt(i);
                        istnieje = true;
                    }
                    
                }
            }
        }




    }
}
