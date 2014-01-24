using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektSOFULL;

namespace ProjektSOFULL.modul_5
{
        static class Interpreter
        {
            public void find(string rozkaz, ref modul_1.Procesor CPU, int do_skoku =0)
            {
                string temp;
                temp = rozkaz.Split(" ".ToCharArray()).First();
                switch (temp)
                {

                    case "dodaj":
                        dodaj(Convert.ToInt32(rozkaz.Split(" ".ToCharArray()).Last()),ref CPU);
                        
                        break;
                    case "odejmij":
                        odejmij(Convert.ToInt32(rozkaz.Split(" ".ToCharArray()).Last()),ref CPU);
                        break;
                    case "pomnoz":
                        pomnoz(Convert.ToInt32(rozkaz.Split(" ".ToCharArray()).Last()),ref CPU);
                        break;
                    case "podziel":
                        podziel(Convert.ToInt32(rozkaz.Split(" ".ToCharArray()).Last()), ref CPU);
                        break;
                    case "zeruj":
                        zeruj(ref CPU);
                        break;
                    case "zakoncz":
                        zakoncz();
                        break;
                    case "zakoncz_blad":
                        zakoncz_blad();
                        break;
                    case "skok_zero":
                        skok_zero(rozkaz.Split(" ".ToCharArray()).Last(),do_skoku,ref CPU);

                        break;

                    case "skok_nzero":
                        skok_zero(rozkaz.Split(" ".ToCharArray()).Last(),do_skoku, ref CPU);
                        break;
                }

            }
            void dodaj(int a, ref modul_1.Procesor CPU)
            {
                CPU.set_r0(CPU.get_r0() + a);
            }
            void odejmij(int a, ref modul_1.Procesor CPU)
            {
                CPU.set_r0(CPU.get_r0() - a);
            }
            void pomnoz(int a, ref modul_1.Procesor CPU)
            {
                CPU.set_r0(CPU.get_r0() * a);
            }
            void podziel(int a, ref modul_1.Procesor CPU)
            {
                try
                {
                    CPU.set_r0(CPU.get_r0() / a);
                }
                catch (DivideByZeroException ex)
                {

                    zakoncz_blad();
                }

            }
            void zeruj(ref modul_1.Procesor CPU)
            {
                CPU.set_r0(0);
            }
            void zakoncz_blad() { }
            void zakoncz() { }
            int skok_zero(string a, int i, ref modul_1.Procesor CPU)
            {
                if (CPU.get_r0() == 0)
                {
                    i = Proces_nadzorczy.memory.FindIndex(a);
                    return i;
                }
                else
                {
                    return i;
                }

            }
            int skok_nzero(string a, int i, ref modul_1.Procesor CPU)
            {
                if (CPU.get_r0() != 0)
                {
                    i = Proces_nadzorczy.memory.FindIndex(a);
                    return i;

                }
                else
                {
                    return i;
                }

            }
            void wypisz(string a) { }
        }
    }
