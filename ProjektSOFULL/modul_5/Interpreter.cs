using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_5
{
        public class Interpreter
        {
           public void find(string rozkaz, modul_1.Procesor CPU,ref List<string> pamiec_procesu,ref int doskoku)
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
                        skok_zero(int.Parse(rozkaz.Split(" ".ToCharArray()).Last()),  ref CPU, ref pamiec_procesu);

                        break;

                    case "skok_nzero":
                        skok_nzero(int.Parse(rozkaz.Split(" ".ToCharArray()).Last()), ref CPU,ref pamiec_procesu);
                        break;
                }

            }
            void dodaj(int a,ref modul_1.Procesor CPU)
            {

                Form1 currentForm = (Form1)Form1.ActiveForm;
                CPU.set_r0(CPU.get_r0() + a);
                currentForm.SetText("dodano " + a);
            }
            void odejmij(int a, ref modul_1.Procesor CPU)
            {

                Form1 currentForm = (Form1)Form1.ActiveForm;
                CPU.set_r0(CPU.get_r0() - a);
                currentForm.SetText("odjeto " + a);
            }
            void pomnoz(int a,ref modul_1.Procesor CPU)
            {

                Form1 currentForm = (Form1)Form1.ActiveForm;
                CPU.set_r0(CPU.get_r0() * a);
                currentForm.SetText("pomnozono przez " + a);
            }
            void podziel(int a, ref modul_1.Procesor CPU)
            {
                try
                {

                    Form1 currentForm = (Form1)Form1.ActiveForm;
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

                Form1 currentForm = (Form1)Form1.ActiveForm;
                CPU.set_r0(0);
                currentForm.SetText("wyzerowano akumulator");
            }
            void zakoncz_blad() {

                Form1 currentForm = (Form1)Form1.ActiveForm;
                currentForm.SetText("Program nie zakonczyl sie pomyslnie");
            }
            void zakoncz() {

                Form1 currentForm = (Form1)Form1.ActiveForm;
                currentForm.SetText("program zakonczyl sie pomyslnie!" );

            }
            int skok_zero(int aktualna_linia, ref modul_1.Procesor CPU,ref List<string> pamiec_procesu)
            {
                if (CPU.get_r1() == 0)
                {

                    Form1 currentForm = (Form1)Form1.ActiveForm;
                    currentForm.SetText("wykonano skok");
                    return aktualna_linia;
                }
                else
                {
                    return aktualna_linia+1;
                }

            }
            int skok_nzero(int aktualna_linia, ref modul_1.Procesor CPU, ref List<string> pamiec_procesu)
            {
                if (CPU.get_r1() != 0)
                {
                    Form1 currentForm = (Form1)Form1.ActiveForm;
                    currentForm.SetText("wykonano skok");
                    return aktualna_linia;
                }
                else
                {
                    return aktualna_linia + 1;
                }
            }
            void wypisz(string a) 
            {
                Form1 currentForm = (Form1)Form1.ActiveForm;
                currentForm.SetText(a);
            }
            
        }
    }
