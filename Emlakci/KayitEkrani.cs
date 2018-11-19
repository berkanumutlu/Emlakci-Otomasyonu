using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ClassLibrary1;

namespace Emlakci
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void KayitEkrani_Load(object sender, EventArgs e)// Form başlatıldığında Emlak tipini ve İli seçer. (Hataları önlemek için)
        {
            cmbemlaktipi.Text = "Konut";
            cmbil.Text = "Ankara";
        }

        private void cmbemlaktipi_SelectedIndexChanged(object sender, EventArgs e)// Seçilen Emlak Tipine göre emlak türlerini ekler.
        {
            cmbemlakturu.Items.Clear();

            if (cmbemlaktipi.Text == "Konut")
            {
                cmbemlakturu.Items.Add(Ev.Turler.Mustakil.ToString());
                cmbemlakturu.Items.Add(Ev.Turler.Apartman_Dairesi.ToString());
                cmbemlakturu.Items.Add(Ev.Turler.Dubleks.ToString());
                cmbemlakturu.Items.Add(Ev.Turler.Villa.ToString());
            }
            else if (cmbemlaktipi.Text == "İşyeri")
            {
                cmbemlakturu.Items.Add(Ev.Turler.AVM.ToString());
                cmbemlakturu.Items.Add(Ev.Turler.Galeri.ToString());
                cmbemlakturu.Items.Add(Ev.Turler.Plaza.ToString());
            }
            else if (cmbemlaktipi.Text == "Arsa")
            {
                cmbemlakturu.Items.Add(Ev.Turler.Konut_Arsasi.ToString());
                cmbemlakturu.Items.Add(Ev.Turler.Ticari_Arsa.ToString());
            }
            cmbemlakturu.Text = cmbemlakturu.Items[0].ToString();
        }

        private void rbkiralik_CheckedChanged(object sender, EventArgs e)// Kiralık seçilirse Depozito kısmını aktif eder.
        {
            labelfiyat.Text = "Kirası :";
            labeldepozito.Visible = true;
            txtdepozito.Visible = true;
            labeltl2.Visible = true;
        }

        private void rbsatilik_CheckedChanged(object sender, EventArgs e)// Satılık seçilirse Depozito kısmını devre dışı bırakır.
        {
            labelfiyat.Text = "Fiyat :";
            labeldepozito.Visible = false;
            txtdepozito.Visible = false;
            labeltl2.Visible = false;
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)// Seçilen İle göre semtleri checkboxta listeler.
        {
            cmbsemt.Items.Clear();

            FileStream fs = new FileStream(cmbil.Text + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));

            string dosya = sr.ReadLine();
            while (dosya!=null)
            {
                cmbsemt.Items.Add(dosya);
                dosya = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            cmbsemt.Text = cmbsemt.Items[0].ToString();
        }

        Ev[] evler = new Ev[100];

        public void kaydetme()
        {
            if (rbkiralik.Checked)
            {
                for (int i = 0; i < evler.Length; i++)
                {
                    if (evler[i]==null)
                    {
                        evler[i] = new KiralikEv(i, Convert.ToInt32(numkatnumarasi.Value), Convert.ToInt32(numodasayisi.Value), Convert.ToInt32(txtdepozito.Text));
                        evler[i].KiralikevDepozitosu = Convert.ToInt32(txtfiyat.Text);
                        evler[i].Aktif = true;
                        evler[i].FiyatHesapla();

                        DosyayaKaydet(0, evler[i].EvBilgileri(), evler[i].EmlakNumarasi.ToString());
                        break;
                    }
                }
            }
            if (rbsatilik.Checked)
            {
                for (int i = 0; i < evler.Length; i++)
                {
                    if (evler[i] == null)
                    {
                        evler[i] = new SatilikEv(i, Convert.ToInt32(numkatnumarasi.Value), Convert.ToInt32(numodasayisi.Value), Convert.ToInt32(txtfiyat));
                        evler[i].SatilikevFiyati = Int32.Parse(txtfiyat.Text);
                        evler[i].Aktif = true;

                        DosyayaKaydet(1, evler[i].EvBilgileri(), evler[i].EmlakNumarasi.ToString());
                        break;
                    }
                }
            }
        }

        string dosya;
        public void DosyayaKaydet(int tur, string veri, string klasor)// Gönderilen verilere göre klasör oluşturuluyor.
        {
            if (tur==0)// tur 0 ise kiralik demektir.
            {
                dosya = "kiralik.txt";
            }
            else if (tur==1)// tur 1 ise satılık demektir.
            {
                dosya = "satilik.txt";
            }

            StreamWriter sw = new StreamWriter(dosya);

            Directory.CreateDirectory(klasor);

            sw.Write(veri);

            sw.Flush();
            sw.Close();
        }

        private void buttonkaydet_Click(object sender, EventArgs e)// Tüm alanları kontrol eder, boş ise uyarı verir, dolu ise
        {
            if (rbkiralik.Checked)
            {
                if (txtfiyat.Text.Length == 0 || txtdepozito.Text.Length == 0)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                }
                else
                {

                    this.Close();
                }
            }
            else if (rbsatilik.Checked)
            {
                if (txtfiyat.Text.Length == 0)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                }
                else
                {

                    this.Close();
                }
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)// Textboxlara sadece rakam girmeyi sağlar.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
