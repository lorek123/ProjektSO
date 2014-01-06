using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_Nadzorczy
{
    static class Interpreter
    {
        void find(string rozkaz) {
            string temp;
            temp= rozkaz.Split(" ".ToCharArray()).First();
            switch (temp)
            {

                case  "dodaj":
                    dodaj(Convert.ToInt32(rozkaz.Split(" ".ToCharArray()).Last()));
                    break;
                case "odejmij":
                    odejmij(Convert.ToInt32(rozkaz.Split(" ".ToCharArray()).Last()));
                    break;
                case "pomnoz":
                    pomnoz(Convert.ToInt32(rozkaz.Split(" ".ToCharArray()).Last()));
                    break;
                case "podziel":
                    podziel(Convert.ToInt32(rozkaz.Split(" ".ToCharArray()).Last()));
                    break;
                case "zeruj" :
                    zeruj();
                    break;
                case "zakoncz" :
                    zakoncz();
                    break;
                case"zakoncz_blad":
                    zakoncz_blad();
                    break;
                case "skok_zero":
                    skok_zero(rozkaz.Split(" ".ToCharArray()).Last()); 
            
                    break;
                
                    case "skok_nzero":
                    skok_zero(rozkaz.Split(" ".ToCharArray()).Last()); 
                    break;
            }
        
        }
        void dodaj(int a) {
            Procesor.set_r0(Procesor.get_r0() + a);
        }
        void odejmij(int a) { 
            Procesor.set_r0(Procesor.get_r0() - a);
        }
        void pomnoz(int a) {
            Procesor.set_r0(Procesor.get_r0() * a);
        }
        void podziel(int a) {
            try
            {
                Procesor.set_r0(Procesor.get_r0() / a);
            }
            catch (DivideByZeroException ex)
            {
                zakoncz_blad();
            }

        }
        void zeruj() {
            Procesor.set_r0(0);
        }
        void zakoncz_blad() { }
        void zakoncz() { }
        void skok_zero(string a, int i) 
        {
            i= Modul.Proces_nadzorczy.memory.FindIndex(a);

        }
        int skok_nzero(string a, int i)
        {
           i = Modul.Proces_nadzorczy.memory.FindIndex(a);
        }
        void wypisz(string a) { }
    }
}
