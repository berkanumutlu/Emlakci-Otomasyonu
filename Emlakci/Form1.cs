using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Emlakci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("users.txt", FileMode.Open, FileAccess.Read);// Users.txt dosyası 2 satırdan oluşmalıdır. Aksi takdirde program çalışmayacaktır.
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));// 1. satır kullanıcı adı, 2. satır şifre için ayırılmıştır.

            int sayac = 0;
            string dosya = sr.ReadToEnd();
            foreach (char krktr in dosya)
            {
                if (krktr.Equals('\n'))
                {
                    sayac++;
                }
            }

            if (sayac!=1)
            {
                MessageBox.Show("Users.txt dosyası hatalı!");
                MessageBox.Show(sayac.ToString());
                Environment.Exit(0);
            }

        }

        FormAna formana = new FormAna();

        string[] kullanicibilgileri = new string[2];

        private void buttongirisyap_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("users.txt", FileMode.Open, FileAccess.Read);// Dosyadan Kullanıcı adı ve Şifre bilgilerini alır ve diziye kaydeder.
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));

            string dosya = sr.ReadLine();
            dosya = dosya.Trim();// Kullanıcı adının başında ve sonunda bulunan boşlukları siler.
            kullanicibilgileri[0] = dosya;
            dosya = sr.ReadLine();
            dosya = dosya.Trim();// Şifrenin başında ve sonunda bulunan boşlukları siler.
            kullanicibilgileri[1] = dosya;

            sr.Close();
            fs.Close();

            if (txtkullaniciadi.Text.Length==0 || txtsifre.Text.Length==0)// Kullanıcı adı ve Şifre bölümüne hiçbir şey yazılmamış ise uyarı verir.
            {
                MessageBox.Show("Lütfen Kullanıcı adı ve Şifre bölümünü doldurun.");
            }
            else if (txtkullaniciadi.Text == kullanicibilgileri[0] && txtsifre.Text == kullanicibilgileri[1])// Dosyadan alınan Kullanıcı adı ve Şifre bilgileri ile girilen bilgileri karşılaştırır, doğru ise Ana Forma geçiş yapar.
            {
                txtkullaniciadi.ResetText();
                txtsifre.ResetText();

                this.Close();
            }
            else// Kullanıcı adı ve Şifrenin yanlış girildiğine dair uyarı verir.
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış.");
                txtkullaniciadi.ResetText();
                txtsifre.ResetText();
            }
        }

        private void cbgorunurluk_CheckedChanged(object sender, EventArgs e)// Şifrenin görünürlüğünü değiştirir.
        {
            if (cbgorunurluk.Checked==true)
            {
                txtsifre.UseSystemPasswordChar = false;// Şifre bölümünü okunur yazı haline getirir.
            }
            else
            {
                txtsifre.UseSystemPasswordChar = true;// Şifre bölümünü * şekline getirir.
            }
        }

        private void buttoncikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);// Programdan çıkış yapmayı sağlar.
        }
    }
}
