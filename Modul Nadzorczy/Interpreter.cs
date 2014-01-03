using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_Nadzorczy
{
    class Interpreter
    {
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
        void zakoncz_blad(Exception Exception) { }
        void zakoncz() { }
        void skok_zero(string a) { }
        void skok_nzero(string a) { }
        void wypisz(string a) { }
    }
}
