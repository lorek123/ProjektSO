using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSOFULL.modul_1
{
    public class Procesor
    {
        private int r0;
        private int r1;
        private int r2;
        private int r3;
        private int lr;

        /*getery*/
        public int get_r0()
        {
            return r0;
        }

        public int get_r1()
        {
            return r1;
        }

        public int get_r2()
        {
            return r2;
        }

        public int get_r3()
        {
            return r3;
        }

        public int get_lr()
        {
            return lr;
        }


        /*settery*/
        public void set_r0(int value)
        {
            r0 = value;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nowa wartosc r0: " + value);
            Console.ResetColor();
            
        }

        public void set_r1(int value)
        {
            r1 = value;
           Console.ForegroundColor = ConsoleColor.Blue;
           Console.WriteLine("Nowa wartosc r1: " + value);
           Console.ResetColor();
        }

        public void set_r2(int value)
        {
            r2 = value;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nowa wartosc r2: " + value);
            Console.ResetColor();
        }

        public void set_r3(int value)
        {
            r3 = value;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nowa wartosc r3: " + value);
            Console.ResetColor();
        }

        public void set_lr(int value)
        {
            lr = value;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nowa wartosc lr: " + value);
            Console.ResetColor();
        }


    }

}
