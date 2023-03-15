using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_4_mod4_1302210048
{
    internal class posisikaraktergame
    {
       public enum state
        {
            Jongkok,
            Berdiri,
            Terbang,
            Tengkurap,
        }
        public enum Tombol
        {
            Tombol_W,
            Tombol_S,
            Tombol_X,
        }
        public class gerak
        {
            public state prevstate;
            public state nextstate;
            public Tombol tombol;

            public  gerak(state prevstate, state nextstate, Tombol tombol)
               {
                 this .prevstate = prevstate;
                 this .nextstate = nextstate;
                 this .tombol = tombol;

               }

            
        }
        public static void Main()
        {
            gerak[] pergerakan =
            {
                new gerak(state)
            }
        }
    }
}
