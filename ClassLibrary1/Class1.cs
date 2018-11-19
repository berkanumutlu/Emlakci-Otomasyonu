using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ClassLibrary1
{
    public abstract class Ev
    {
        // Alanlar ( Fields )
        private int odaSayisi, katNumarasi, emlakNumarasi, kiralikevDepozitosu, kiralikevKirasi, satilikevFiyati;
        private double alani;
        private DateTime yapimTarihi;
        private string tur , semt;
        private bool aktif;

        public enum Turler
        {
            Mustakil,
            Apartman_Dairesi,
            Dubleks,
            Villa,
            AVM,
            Galeri,
            Plaza,
            Konut_Arsasi,
            Ticari_Arsa,
        }

        // Özellikler ( Properties )
        // Tüm alanlar için gerekli Property tanımlamaları yazılıyor.
        public int OdaSayisi
        {
            get { return odaSayisi; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
                if (value<0)
                {
                    sw.WriteLine(String.Format("[{0:f}] Oda sayısı değeri: {1} olarak girildi.", DateTime.Now, value));

                    odaSayisi = 0;
                }
                else
                {
                    sw.WriteLine(String.Format("[{0:f}] Oda sayısı değeri: {1} olarak girildi.", DateTime.Now, value));

                    odaSayisi = value;
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public int KatNumarasi
        {
            get { return katNumarasi; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
                if (value < 0)
                {
                    sw.WriteLine(String.Format("[{0:f}] Kat Numarası değeri: {1} olarak girildi.", DateTime.Now, value));

                    katNumarasi = 0;
                }
                else
                {
                    sw.WriteLine(String.Format("[{0:f}] Kat Numarası değeri: {1} olarak girildi.", DateTime.Now, value));

                    katNumarasi = value;
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public double Alani
        {
            get { return alani; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
                if (value < 0)
                {
                    sw.WriteLine(String.Format("[{0:f}] Alan değeri: {1} olarak girildi.", DateTime.Now, value));

                    alani = 0.0;
                }
                else
                {
                    sw.WriteLine(String.Format("[{0:f}] Alan değeri: {1} olarak girildi.", DateTime.Now, value));

                    alani = value;
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public int EmlakNumarasi
        {
            get { return emlakNumarasi; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
                if (value < 0)
                {
                    sw.WriteLine(String.Format("[{0:f}] Emlak numarası değeri: {1} olarak girildi.", DateTime.Now, value));

                    emlakNumarasi = 0;
                }
                else
                {
                    sw.WriteLine(String.Format("[{0:f}] Emlak numarası değeri: {1} olarak girildi.", DateTime.Now, value));

                    emlakNumarasi = value;
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public int KiralikevDepozitosu
        {
            get { return kiralikevDepozitosu; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
                if (value < 0)
                {
                    sw.WriteLine(String.Format("[{0:f}] Kiralık ev Depozitosu değeri: {1} olarak girildi.", DateTime.Now, value));

                    kiralikevDepozitosu = 0;
                }
                else
                {
                    sw.WriteLine(String.Format("[{0:f}] Kiralık ev Depozitosu değeri: {1} olarak girildi.", DateTime.Now, value));

                    kiralikevDepozitosu = value;
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public int KiralikevKirasi
        {
            get { return kiralikevKirasi; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
                if (value < 0)
                {
                    sw.WriteLine(String.Format("[{0:f}] Kiralık ev Kirası değeri: {1} olarak girildi.", DateTime.Now, value));

                    kiralikevKirasi = 0;
                }
                else
                {
                    sw.WriteLine(String.Format("[{0:f}] Kiralık ev Kirası değeri: {1} olarak girildi.", DateTime.Now, value));

                    kiralikevKirasi = value;
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public int SatilikevFiyati
        {
            get { return satilikevFiyati; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
                if (value < 0)
                {
                    sw.WriteLine(String.Format("[{0:f}] Satılık ev Fiyatı değeri: {1} olarak girildi.", DateTime.Now, value));

                    satilikevFiyati = 0;
                }
                else
                {
                    sw.WriteLine(String.Format("[{0:f}] Satılık ev Fiyatı değeri: {1} olarak girildi.", DateTime.Now, value));

                    satilikevFiyati = value;
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public DateTime YapimTarihi
        {
            get { return yapimTarihi; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));

                if (value.Year > DateTime.Now.Year)// Bulunulan günün tarihinden ileride bir tarih girilmiş ise bulunulan günün tarihi olarak atanır.
                {
                    sw.WriteLine(String.Format("[{0:f}] Yapım tarihi değeri: {1:d} olarak girildi.", DateTime.Now, value));
                    value = DateTime.Now;
                }
                else
                {
                    sw.WriteLine(String.Format("[{0:f}] Yapım tarihi değeri: {1:d} olarak girildi.", DateTime.Now, value));
                    int yas = DateTime.Today.Year - value.Year;// Evin yaşını gün ve ay değerlerine dikkat ederek hesaplar.
                    if (value > DateTime.Today.AddYears(-yas))
                    {
                        yas--;
                    }
                    value = DateTime.Parse(yas.ToString());

                    yapimTarihi = value;
                }

                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public string Tur
        {
            get { return tur; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));

                sw.WriteLine(String.Format("[{0:f}] Tür değeri: {1} olarak girildi.", DateTime.Now, value));

                tur = value;

                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public string Semt
        {
            get { return semt; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));

                sw.WriteLine(String.Format("[{0:f}] Semt değeri: {1} olarak girildi.", DateTime.Now, value));

                semt = value;

                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        public bool Aktif
        {
            get { return aktif; }
            set
            {
                FileStream fs = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));

                sw.WriteLine(String.Format("[{0:f}] Evin aktiflik değeri: {1} olarak girildi.", DateTime.Now, value));

                aktif = value;

                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        // Kurucu Metot ( Constructor )
        public Ev()
        {
            odaSayisi = 0;
            katNumarasi = 0;
            emlakNumarasi = 0;
            kiralikevDepozitosu = 0;
            kiralikevKirasi = 0;
            satilikevFiyati = 0;
            alani = 0.0;
            yapimTarihi = DateTime.Today;
            tur = String.Empty;
            semt = String.Empty;
            aktif = false;
        }

        public Ev(int emlakNumarasi, string tur, double alani, DateTime yapimTarihi, string semt)
        {
            this.emlakNumarasi = emlakNumarasi;
            this.tur = tur;
            this.alani = alani;
            this.yapimTarihi = yapimTarihi;
            this.semt = semt;
        }

        public Ev(int emlakNumarasi, int katNumarasi, int odaSayisi, int kiralikevDepozitosu, int kiralikevKirasi)
        {
            this.emlakNumarasi = emlakNumarasi;
            this.katNumarasi = katNumarasi;
            this.odaSayisi = odaSayisi;
            this.kiralikevDepozitosu = kiralikevDepozitosu;
            this.kiralikevKirasi = kiralikevKirasi;
        }

        public Ev(int emlakNumarasi, int katNumarasi, int odaSayisi, int satilikevFiyati)
        {
            this.emlakNumarasi = emlakNumarasi;
            this.katNumarasi = katNumarasi;
            this.odaSayisi = odaSayisi;
            this.satilikevFiyati = satilikevFiyati;
        }

        public Ev(int emlakNumarasi, bool aktif)
        {
            this.emlakNumarasi = emlakNumarasi;
            this.aktif = aktif;
        }

        // Metotlar
        public abstract string EvBilgileri();

        public int FiyatHesapla()
        {
            int katsayi;
            if (File.Exists("room_cost.txt"))
            {
                FileStream fs = new FileStream("room_cost.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string dosya = sr.ReadLine();
                katsayi = Int32.Parse(dosya);

                sr.Close();
                fs.Close();
            }
            else
            {
                katsayi = 200;
            }
            return kiralikevKirasi = katsayi * odaSayisi;
        }
    }
}