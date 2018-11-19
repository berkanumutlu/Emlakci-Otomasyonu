namespace Emlakci
{
    partial class KayitEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelemlaktipi = new System.Windows.Forms.Label();
            this.cmbemlaktipi = new System.Windows.Forms.ComboBox();
            this.labelemlakturu = new System.Windows.Forms.Label();
            this.cmbemlakturu = new System.Windows.Forms.ComboBox();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.txtdepozito = new System.Windows.Forms.TextBox();
            this.labeldepozito = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.labelfiyat = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelyapimtarihi = new System.Windows.Forms.Label();
            this.labeliki = new System.Windows.Forms.Label();
            this.labelm = new System.Windows.Forms.Label();
            this.labelalani = new System.Windows.Forms.Label();
            this.numkatnumarasi = new System.Windows.Forms.NumericUpDown();
            this.numalani = new System.Windows.Forms.NumericUpDown();
            this.numodasayisi = new System.Windows.Forms.NumericUpDown();
            this.labelkatnumarasi = new System.Windows.Forms.Label();
            this.labelodasayisi = new System.Windows.Forms.Label();
            this.cmbsemt = new System.Windows.Forms.ComboBox();
            this.labelsemt = new System.Windows.Forms.Label();
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.labelil = new System.Windows.Forms.Label();
            this.rbkiralik = new System.Windows.Forms.RadioButton();
            this.rbsatilik = new System.Windows.Forms.RadioButton();
            this.labeltl = new System.Windows.Forms.Label();
            this.labeltl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numkatnumarasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numalani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numodasayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelemlaktipi
            // 
            this.labelemlaktipi.AutoSize = true;
            this.labelemlaktipi.Location = new System.Drawing.Point(12, 27);
            this.labelemlaktipi.Name = "labelemlaktipi";
            this.labelemlaktipi.Size = new System.Drawing.Size(62, 13);
            this.labelemlaktipi.TabIndex = 0;
            this.labelemlaktipi.Text = "Emlak Tipi :";
            // 
            // cmbemlaktipi
            // 
            this.cmbemlaktipi.FormattingEnabled = true;
            this.cmbemlaktipi.Items.AddRange(new object[] {
            "Konut",
            "İşyeri",
            "Arsa"});
            this.cmbemlaktipi.Location = new System.Drawing.Point(80, 24);
            this.cmbemlaktipi.Name = "cmbemlaktipi";
            this.cmbemlaktipi.Size = new System.Drawing.Size(99, 21);
            this.cmbemlaktipi.TabIndex = 1;
            this.cmbemlaktipi.SelectedIndexChanged += new System.EventHandler(this.cmbemlaktipi_SelectedIndexChanged);
            // 
            // labelemlakturu
            // 
            this.labelemlakturu.AutoSize = true;
            this.labelemlakturu.Location = new System.Drawing.Point(224, 27);
            this.labelemlakturu.Name = "labelemlakturu";
            this.labelemlakturu.Size = new System.Drawing.Size(67, 13);
            this.labelemlakturu.TabIndex = 2;
            this.labelemlakturu.Text = "Emlak Türü :";
            // 
            // cmbemlakturu
            // 
            this.cmbemlakturu.FormattingEnabled = true;
            this.cmbemlakturu.Location = new System.Drawing.Point(297, 24);
            this.cmbemlakturu.Name = "cmbemlakturu";
            this.cmbemlakturu.Size = new System.Drawing.Size(121, 21);
            this.cmbemlakturu.TabIndex = 3;
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.Location = new System.Drawing.Point(172, 228);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonkaydet.TabIndex = 41;
            this.buttonkaydet.Text = "Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // txtdepozito
            // 
            this.txtdepozito.Location = new System.Drawing.Point(272, 194);
            this.txtdepozito.Name = "txtdepozito";
            this.txtdepozito.Size = new System.Drawing.Size(86, 20);
            this.txtdepozito.TabIndex = 40;
            this.txtdepozito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labeldepozito
            // 
            this.labeldepozito.AutoSize = true;
            this.labeldepozito.Location = new System.Drawing.Point(211, 197);
            this.labeldepozito.Name = "labeldepozito";
            this.labeldepozito.Size = new System.Drawing.Size(55, 13);
            this.labeldepozito.TabIndex = 39;
            this.labeldepozito.Text = "Depozito :";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(76, 194);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(86, 20);
            this.txtfiyat.TabIndex = 38;
            this.txtfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelfiyat
            // 
            this.labelfiyat.AutoSize = true;
            this.labelfiyat.Location = new System.Drawing.Point(35, 197);
            this.labelfiyat.Name = "labelfiyat";
            this.labelfiyat.Size = new System.Drawing.Size(38, 13);
            this.labelfiyat.TabIndex = 37;
            this.labelfiyat.Text = "Kirası :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // labelyapimtarihi
            // 
            this.labelyapimtarihi.AutoSize = true;
            this.labelyapimtarihi.Location = new System.Drawing.Point(211, 164);
            this.labelyapimtarihi.Name = "labelyapimtarihi";
            this.labelyapimtarihi.Size = new System.Drawing.Size(71, 13);
            this.labelyapimtarihi.TabIndex = 35;
            this.labelyapimtarihi.Text = "Yapım Tarihi :";
            // 
            // labeliki
            // 
            this.labeliki.AutoSize = true;
            this.labeliki.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeliki.Location = new System.Drawing.Point(323, 135);
            this.labeliki.Name = "labeliki";
            this.labeliki.Size = new System.Drawing.Size(9, 9);
            this.labeliki.TabIndex = 34;
            this.labeliki.Text = "2";
            // 
            // labelm
            // 
            this.labelm.AutoSize = true;
            this.labelm.Location = new System.Drawing.Point(313, 138);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(15, 13);
            this.labelm.TabIndex = 33;
            this.labelm.Text = "m";
            // 
            // labelalani
            // 
            this.labelalani.AutoSize = true;
            this.labelalani.Location = new System.Drawing.Point(211, 137);
            this.labelalani.Name = "labelalani";
            this.labelalani.Size = new System.Drawing.Size(36, 13);
            this.labelalani.TabIndex = 32;
            this.labelalani.Text = "Alanı :";
            // 
            // numkatnumarasi
            // 
            this.numkatnumarasi.Location = new System.Drawing.Point(117, 162);
            this.numkatnumarasi.Name = "numkatnumarasi";
            this.numkatnumarasi.Size = new System.Drawing.Size(47, 20);
            this.numkatnumarasi.TabIndex = 31;
            this.numkatnumarasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numalani
            // 
            this.numalani.Location = new System.Drawing.Point(253, 135);
            this.numalani.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numalani.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numalani.Name = "numalani";
            this.numalani.Size = new System.Drawing.Size(54, 20);
            this.numalani.TabIndex = 29;
            this.numalani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numalani.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numodasayisi
            // 
            this.numodasayisi.Location = new System.Drawing.Point(117, 135);
            this.numodasayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numodasayisi.Name = "numodasayisi";
            this.numodasayisi.Size = new System.Drawing.Size(47, 20);
            this.numodasayisi.TabIndex = 30;
            this.numodasayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numodasayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelkatnumarasi
            // 
            this.labelkatnumarasi.AutoSize = true;
            this.labelkatnumarasi.Location = new System.Drawing.Point(35, 164);
            this.labelkatnumarasi.Name = "labelkatnumarasi";
            this.labelkatnumarasi.Size = new System.Drawing.Size(76, 13);
            this.labelkatnumarasi.TabIndex = 27;
            this.labelkatnumarasi.Text = "Kat Numarası :";
            // 
            // labelodasayisi
            // 
            this.labelodasayisi.AutoSize = true;
            this.labelodasayisi.Location = new System.Drawing.Point(48, 137);
            this.labelodasayisi.Name = "labelodasayisi";
            this.labelodasayisi.Size = new System.Drawing.Size(63, 13);
            this.labelodasayisi.TabIndex = 28;
            this.labelodasayisi.Text = "Oda Sayısı :";
            // 
            // cmbsemt
            // 
            this.cmbsemt.FormattingEnabled = true;
            this.cmbsemt.Location = new System.Drawing.Point(254, 93);
            this.cmbsemt.Name = "cmbsemt";
            this.cmbsemt.Size = new System.Drawing.Size(121, 21);
            this.cmbsemt.TabIndex = 26;
            // 
            // labelsemt
            // 
            this.labelsemt.AutoSize = true;
            this.labelsemt.Location = new System.Drawing.Point(211, 96);
            this.labelsemt.Name = "labelsemt";
            this.labelsemt.Size = new System.Drawing.Size(37, 13);
            this.labelsemt.TabIndex = 25;
            this.labelsemt.Text = "Semt :";
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Konya"});
            this.cmbil.Location = new System.Drawing.Point(61, 93);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(121, 21);
            this.cmbil.TabIndex = 24;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // labelil
            // 
            this.labelil.AutoSize = true;
            this.labelil.Location = new System.Drawing.Point(37, 96);
            this.labelil.Name = "labelil";
            this.labelil.Size = new System.Drawing.Size(18, 13);
            this.labelil.TabIndex = 23;
            this.labelil.Text = "İl :";
            // 
            // rbkiralik
            // 
            this.rbkiralik.AutoSize = true;
            this.rbkiralik.Checked = true;
            this.rbkiralik.Location = new System.Drawing.Point(135, 61);
            this.rbkiralik.Name = "rbkiralik";
            this.rbkiralik.Size = new System.Drawing.Size(53, 17);
            this.rbkiralik.TabIndex = 21;
            this.rbkiralik.TabStop = true;
            this.rbkiralik.Text = "Kiralık";
            this.rbkiralik.UseVisualStyleBackColor = true;
            this.rbkiralik.CheckedChanged += new System.EventHandler(this.rbkiralik_CheckedChanged);
            // 
            // rbsatilik
            // 
            this.rbsatilik.AutoSize = true;
            this.rbsatilik.Location = new System.Drawing.Point(254, 61);
            this.rbsatilik.Name = "rbsatilik";
            this.rbsatilik.Size = new System.Drawing.Size(53, 17);
            this.rbsatilik.TabIndex = 22;
            this.rbsatilik.Text = "Satılık";
            this.rbsatilik.UseVisualStyleBackColor = true;
            this.rbsatilik.CheckedChanged += new System.EventHandler(this.rbsatilik_CheckedChanged);
            // 
            // labeltl
            // 
            this.labeltl.AutoSize = true;
            this.labeltl.Location = new System.Drawing.Point(168, 197);
            this.labeltl.Name = "labeltl";
            this.labeltl.Size = new System.Drawing.Size(20, 13);
            this.labeltl.TabIndex = 42;
            this.labeltl.Text = "TL";
            // 
            // labeltl2
            // 
            this.labeltl2.AutoSize = true;
            this.labeltl2.Location = new System.Drawing.Point(364, 197);
            this.labeltl2.Name = "labeltl2";
            this.labeltl2.Size = new System.Drawing.Size(20, 13);
            this.labeltl2.TabIndex = 42;
            this.labeltl2.Text = "TL";
            // 
            // KayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.labeltl2);
            this.Controls.Add(this.labeltl);
            this.Controls.Add(this.buttonkaydet);
            this.Controls.Add(this.txtdepozito);
            this.Controls.Add(this.labeldepozito);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.labelfiyat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelyapimtarihi);
            this.Controls.Add(this.labeliki);
            this.Controls.Add(this.labelm);
            this.Controls.Add(this.labelalani);
            this.Controls.Add(this.numkatnumarasi);
            this.Controls.Add(this.numalani);
            this.Controls.Add(this.numodasayisi);
            this.Controls.Add(this.labelkatnumarasi);
            this.Controls.Add(this.labelodasayisi);
            this.Controls.Add(this.cmbsemt);
            this.Controls.Add(this.labelsemt);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.labelil);
            this.Controls.Add(this.rbkiralik);
            this.Controls.Add(this.rbsatilik);
            this.Controls.Add(this.cmbemlakturu);
            this.Controls.Add(this.labelemlakturu);
            this.Controls.Add(this.cmbemlaktipi);
            this.Controls.Add(this.labelemlaktipi);
            this.Name = "KayitEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.KayitEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numkatnumarasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numalani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numodasayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelemlaktipi;
        private System.Windows.Forms.ComboBox cmbemlaktipi;
        private System.Windows.Forms.Label labelemlakturu;
        private System.Windows.Forms.ComboBox cmbemlakturu;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.TextBox txtdepozito;
        private System.Windows.Forms.Label labeldepozito;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label labelfiyat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelyapimtarihi;
        private System.Windows.Forms.Label labeliki;
        private System.Windows.Forms.Label labelm;
        private System.Windows.Forms.Label labelalani;
        private System.Windows.Forms.NumericUpDown numkatnumarasi;
        private System.Windows.Forms.NumericUpDown numalani;
        private System.Windows.Forms.NumericUpDown numodasayisi;
        private System.Windows.Forms.Label labelkatnumarasi;
        private System.Windows.Forms.Label labelodasayisi;
        private System.Windows.Forms.ComboBox cmbsemt;
        private System.Windows.Forms.Label labelsemt;
        private System.Windows.Forms.ComboBox cmbil;
        private System.Windows.Forms.Label labelil;
        private System.Windows.Forms.RadioButton rbkiralik;
        private System.Windows.Forms.RadioButton rbsatilik;
        private System.Windows.Forms.Label labeltl;
        private System.Windows.Forms.Label labeltl2;
    }
}