using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class KiralikEv : Ev
    {
        public KiralikEv(int emlakNumarasi, int katNumarasi, int odaSayisi, int kiralikevDepozitosu)
        {
            this.EmlakNumarasi = emlakNumarasi;
            this.KatNumarasi = katNumarasi;
            this.OdaSayisi = odaSayisi;
            this.KiralikevDepozitosu = kiralikevDepozitosu;
        }

        public override string EvBilgileri()
        {
            string veri = String.Format("EmlakNO: {0}, Tur: {1}, Semt: {2}, KatNO: {3}, Oda Sayısı: {4}, Alanı: {5}, Depozito: {6}, Kira: {7}, Yaş: {8}", EmlakNumarasi, Tur, Semt, KatNumarasi, OdaSayisi, Alani, KiralikevDepozitosu, KiralikevKirasi, YapimTarihi);
            return veri;
        }
    }
}