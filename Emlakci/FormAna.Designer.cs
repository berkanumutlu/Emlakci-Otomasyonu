namespace Emlakci
{
    partial class FormAna
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
            this.buttonyenievekle = new System.Windows.Forms.Button();
            this.buttonsorgu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonyenievekle
            // 
            this.buttonyenievekle.Location = new System.Drawing.Point(26, 31);
            this.buttonyenievekle.Name = "buttonyenievekle";
            this.buttonyenievekle.Size = new System.Drawing.Size(120, 40);
            this.buttonyenievekle.TabIndex = 0;
            this.buttonyenievekle.Text = "Kayıt Ekranı";
            this.buttonyenievekle.UseVisualStyleBackColor = true;
            this.buttonyenievekle.Click += new System.EventHandler(this.buttonyenievekle_Click);
            // 
            // buttonsorgu
            // 
            this.buttonsorgu.Location = new System.Drawing.Point(171, 31);
            this.buttonsorgu.Name = "buttonsorgu";
            this.buttonsorgu.Size = new System.Drawing.Size(120, 40);
            this.buttonsorgu.TabIndex = 3;
            this.buttonsorgu.Text = "Sorgulama Ekranı";
            this.buttonsorgu.UseVisualStyleBackColor = true;
            this.buttonsorgu.Click += new System.EventHandler(this.buttonsorgu_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(313, 95);
            this.Controls.Add(this.buttonsorgu);
            this.Controls.Add(this.buttonyenievekle);
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Seçim Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonyenievekle;
        private System.Windows.Forms.Button buttonsorgu;

    }
}