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
    public partial class SorguEkrani : Form
    {
        public SorguEkrani()
        {
            InitializeComponent();
        }

        private void SorguEkrani_Load(object sender, EventArgs e)// Form başlatıldığında Emlak tipini ve İli seçer. (Hataları önlemek için)
        {
            cmbemlaktipisorg.Text = "Konut";
            cmbilsorg.Text = "Ankara";
        }

        private void cmbemlaktipisorg_SelectedIndexChanged(object sender, EventArgs e)// Seçilen Emlak Tipine göre emlak türlerini ekler.
        {
            cmbemlakturusorg.Items.Clear();

            if (cmbemlaktipisorg.Text == "Konut")
            {
                cmbemlakturusorg.Items.Add(Ev.Turler.Mustakil.ToString());
                cmbemlakturusorg.Items.Add(Ev.Turler.Apartman_Dairesi.ToString());
                cmbemlakturusorg.Items.Add(Ev.Turler.Dubleks.ToString());
                cmbemlakturusorg.Items.Add(Ev.Turler.Villa.ToString());
            }
            else if (cmbemlaktipisorg.Text == "İşyeri")
            {
                cmbemlakturusorg.Items.Add(Ev.Turler.AVM.ToString());
                cmbemlakturusorg.Items.Add(Ev.Turler.Galeri.ToString());
                cmbemlakturusorg.Items.Add(Ev.Turler.Plaza.ToString());
            }
            else if (cmbemlaktipisorg.Text == "Arsa")
            {
                cmbemlakturusorg.Items.Add(Ev.Turler.Konut_Arsasi.ToString());
                cmbemlakturusorg.Items.Add(Ev.Turler.Ticari_Arsa.ToString());
            }
            cmbemlakturusorg.Text = cmbemlakturusorg.Items[0].ToString();
        }

        private void cmbilsorg_SelectedIndexChanged(object sender, EventArgs e)// Seçilen İle göre semtleri checkboxta listeler.
        {
            cmbsemtsorg.Items.Clear();

            FileStream fs = new FileStream(cmbilsorg.Text + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));

            string dosya = sr.ReadLine();
            while (dosya != null)
            {
                cmbsemtsorg.Items.Add(dosya);
                dosya = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            cmbsemtsorg.Text = cmbsemtsorg.Items[0].ToString();
        }

        private void buttonsorgula_Click(object sender, EventArgs e)// Tüm alanları kontrol eder, boş ise uyarı verir, dolu ise...
        {
            if (txtminfiyatsorg.Text.Length == 0 || txtmaxfiyatsorg.Text.Length == 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
            else
            {

                this.Close();
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)// Textboxlara sadece rakam girmeyi sağlar.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
