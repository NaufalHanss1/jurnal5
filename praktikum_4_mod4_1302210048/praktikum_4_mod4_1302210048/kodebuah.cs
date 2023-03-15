using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_4_mod4_1302210048
{
    internal class kodebuah
    {
        public enum BUAH
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka,

        }
    public static string getcodebuah(BUAH namabuah)
        {
            string[] Kode = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
            return Kode[(int)namabuah];
        }
    }
}
