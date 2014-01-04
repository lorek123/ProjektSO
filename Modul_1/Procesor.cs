using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proces_modul_nizszy
{
    class Procesor
    {
        private int r0; //akumulator
        private int r1;
        private int r2;
        private int r3;
        private int lr;

        /*getery*/
        int get_r0()
        {
            return r0;
        }

        int get_r1()
        {
            return r1;
        }

        int get_r2()
        {
            return r2;
        }

        int get_r3()
        {
            return r3;
        }

        int get_lr()
        {
            return lr;
        }


        /*settery*/
        void set_r0(int value)
        {
            r0 = value;
        }

        void set_r1(int value)
        {
            r1 = value;
        }

        void set_r2(int value)
        {
            r2 = value;
        }

        void set_r3(int value)
        {
            r3 = value;
        }

        void set_lr(int value)
        {
            lr = value;
        }


    }
}
