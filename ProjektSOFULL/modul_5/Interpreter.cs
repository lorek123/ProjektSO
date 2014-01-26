﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_5
{
        static class Interpreter
        {
            Form1 currentForm = (Form1)Form1.ActiveForm;
            public void find(string rozkaz, ref modul_1.Procesor CPU, int doskoku = 0)
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
                        podziel(Convert.ToInt32(rozkaz.Split(" ".ToCharArray()).Last()),ref CPU);
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
                        skok_zero(rozkaz.Split(" ".ToCharArray()).Last(), doskoku, ref CPU);

                        break;

                    case "skok_nzero":
                        skok_zero(rozkaz.Split(" ".ToCharArray()).Last(), doskoku, ref CPU,ref pamiec_procesu);
                        break;
                }

            }
            void dodaj(int a,ref modul_1.Procesor CPU)
            {
                CPU.set_r0(CPU.get_r0() + a);
                currentForm.SetText("dodano " + a);
            }
            void odejmij(int a, ref modul_1.Procesor CPU)
            {
                CPU.set_r0(CPU.get_r0() - a);
                currentForm.SetText("odjeto " + a);
            }
            void pomnoz(int a,ref modul_1.Procesor CPU)
            {
                CPU.set_r0(CPU.get_r0() * a);
                currentForm.SetText("pomnozono przez " + a);
            }
            void podziel(int a, ref modul_1.Procesor CPU)
            {
                try
                {
                    CPU.set_r0(CPU.get_r0() / a);
                    currentForm.SetText("podzielono przez " + a);
                }
                catch (DivideByZeroException ex)
                {
                    zakoncz_blad();
                }

            }
            void zeruj(ref modul_1.Procesor CPU)
            {
                CPU.set_r0(0);
                currentForm.SetText("wyzerowano akumulator");
            }
            void zakoncz_blad() {
                currentForm.SetText("Program nie zakonczyl sie pomyslnie");
            }
            void zakoncz() {
                currentForm.SetText("program zakonczyl sie pomyslnie!" );
            }
            int skok_zero(string a, int i, ref modul_1.Procesor CPU,ref List<string> pamiec_procesu)
            {
                if (CPU.get_r0() == 0)
                {
                    i = pamiec_procesu.FindIndex(x => x.Contains(a));
                    currentForm.SetText("wykonano skok");
                    return i;
                }
                else
                {
                    return i;
                }

            }
            int skok_nzero(string a, int i, ref modul_1.Procesor CPU, ref List<string> pamiec_procesu)
            {
                if (CPU.get_r0() != 0)
                {
                    i = pamiec_procesu.FindIndex(x => x.Contains(a));
                    currentForm.SetText("wykonano skok");
                    return i;
                }
                else
                {
                    return i;
                }
            }
            void wypisz(string a) 
            {
                currentForm.SetText(a);
            }
            
        }
    }
