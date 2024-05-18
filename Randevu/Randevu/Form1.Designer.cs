namespace Randevu
{
    partial class Randevu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.bntRandevuEkle = new System.Windows.Forms.Button();
            this.listBoxRandevular = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(27, 49);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(205, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // bntRandevuEkle
            // 
            this.bntRandevuEkle.Location = new System.Drawing.Point(80, 77);
            this.bntRandevuEkle.Name = "bntRandevuEkle";
            this.bntRandevuEkle.Size = new System.Drawing.Size(87, 34);
            this.bntRandevuEkle.TabIndex = 2;
            this.bntRandevuEkle.Text = "Kaydet";
            this.bntRandevuEkle.UseVisualStyleBackColor = true;
            this.bntRandevuEkle.Click += new System.EventHandler(this.bntRandevuEkle_Click);
            // 
            // listBoxRandevular
            // 
            this.listBoxRandevular.FormattingEnabled = true;
            this.listBoxRandevular.ItemHeight = 16;
            this.listBoxRandevular.Location = new System.Drawing.Point(247, 12);
            this.listBoxRandevular.Name = "listBoxRandevular";
            this.listBoxRandevular.Size = new System.Drawing.Size(170, 180);
            this.listBoxRandevular.TabIndex = 3;
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(429, 210);
            this.Controls.Add(this.listBoxRandevular);
            this.Controls.Add(this.bntRandevuEkle);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Randevu";
            this.Text = "Randevu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button bntRandevuEkle;
        private System.Windows.Forms.ListBox listBoxRandevular;
    }
}

