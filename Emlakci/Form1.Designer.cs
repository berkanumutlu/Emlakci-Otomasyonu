namespace Emlakci
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelkullaniciadi = new System.Windows.Forms.Label();
            this.labelsifre = new System.Windows.Forms.Label();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.buttongirisyap = new System.Windows.Forms.Button();
            this.cbgorunurluk = new System.Windows.Forms.CheckBox();
            this.buttoncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelkullaniciadi
            // 
            this.labelkullaniciadi.AutoSize = true;
            this.labelkullaniciadi.Location = new System.Drawing.Point(137, 181);
            this.labelkullaniciadi.Name = "labelkullaniciadi";
            this.labelkullaniciadi.Size = new System.Drawing.Size(69, 13);
            this.labelkullaniciadi.TabIndex = 0;
            this.labelkullaniciadi.Text = "Kullanıcı adı :";
            // 
            // labelsifre
            // 
            this.labelsifre.AutoSize = true;
            this.labelsifre.Location = new System.Drawing.Point(172, 207);
            this.labelsifre.Name = "labelsifre";
            this.labelsifre.Size = new System.Drawing.Size(34, 13);
            this.labelsifre.TabIndex = 1;
            this.labelsifre.Text = "Şifre :";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(212, 178);
            this.txtkullaniciadi.MaxLength = 16;
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txtkullaniciadi.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(212, 204);
            this.txtsifre.MaxLength = 16;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 3;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // buttongirisyap
            // 
            this.buttongirisyap.Location = new System.Drawing.Point(236, 230);
            this.buttongirisyap.Name = "buttongirisyap";
            this.buttongirisyap.Size = new System.Drawing.Size(75, 23);
            this.buttongirisyap.TabIndex = 5;
            this.buttongirisyap.Text = "Giriş Yap";
            this.buttongirisyap.UseVisualStyleBackColor = true;
            this.buttongirisyap.Click += new System.EventHandler(this.buttongirisyap_Click);
            // 
            // cbgorunurluk
            // 
            this.cbgorunurluk.AutoSize = true;
            this.cbgorunurluk.Location = new System.Drawing.Point(295, 207);
            this.cbgorunurluk.Name = "cbgorunurluk";
            this.cbgorunurluk.Size = new System.Drawing.Size(15, 14);
            this.cbgorunurluk.TabIndex = 4;
            this.cbgorunurluk.UseVisualStyleBackColor = true;
            this.cbgorunurluk.CheckedChanged += new System.EventHandler(this.cbgorunurluk_CheckedChanged);
            // 
            // buttoncikis
            // 
            this.buttoncikis.Location = new System.Drawing.Point(237, 12);
            this.buttoncikis.Name = "buttoncikis";
            this.buttoncikis.Size = new System.Drawing.Size(75, 23);
            this.buttoncikis.TabIndex = 6;
            this.buttoncikis.Text = "Çıkış";
            this.buttoncikis.UseVisualStyleBackColor = true;
            this.buttoncikis.Click += new System.EventHandler(this.buttoncikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(this.buttoncikis);
            this.Controls.Add(this.cbgorunurluk);
            this.Controls.Add(this.buttongirisyap);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.labelsifre);
            this.Controls.Add(this.labelkullaniciadi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkullaniciadi;
        private System.Windows.Forms.Label labelsifre;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button buttongirisyap;
        private System.Windows.Forms.CheckBox cbgorunurluk;
        private System.Windows.Forms.Button buttoncikis;
    }
}

