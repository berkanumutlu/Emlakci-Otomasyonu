using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class SatilikEv : Ev
    {
        public SatilikEv(int emlakNumarasi, int katNumarasi, int odaSayisi, int satilikevFiyati)
        {
            this.EmlakNumarasi = emlakNumarasi;
            this.KatNumarasi = katNumarasi;
            this.OdaSayisi = odaSayisi;
            this.SatilikevFiyati = satilikevFiyati;
        }

        public override string EvBilgileri()
        {
            string veri = String.Format("EmlakNO: {0}, Tur: {1}, Semt: {2}, KatNO: {3}, Oda Sayısı: {4}, Alanı: {5}, Fiyat: {6}, Yaş: {7}", EmlakNumarasi, Tur, Semt, KatNumarasi, OdaSayisi, Alani, SatilikevFiyati, YapimTarihi);
            return veri;
        }
    }
}