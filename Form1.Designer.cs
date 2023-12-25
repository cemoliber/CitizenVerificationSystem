namespace TCKontrol
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.kontrolButon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSİM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYİSİM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Yılı:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(137, 47);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(167, 22);
            this.isim.TabIndex = 4;
            // 
            // soyisim
            // 
            this.soyisim.Location = new System.Drawing.Point(137, 100);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(167, 22);
            this.soyisim.TabIndex = 5;
            this.soyisim.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(137, 206);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(167, 22);
            this.dt.TabIndex = 7;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(137, 153);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(167, 22);
            this.txtTC.TabIndex = 6;
            // 
            // kontrolButon
            // 
            this.kontrolButon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.kontrolButon.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontrolButon.Location = new System.Drawing.Point(137, 254);
            this.kontrolButon.Name = "kontrolButon";
            this.kontrolButon.Size = new System.Drawing.Size(167, 33);
            this.kontrolButon.TabIndex = 8;
            this.kontrolButon.Text = "KONTROL ET";
            this.kontrolButon.UseVisualStyleBackColor = false;
            this.kontrolButon.Click += new System.EventHandler(this.kontrolButon_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(31, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(394, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kontrolButon);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TC NO DOĞRULAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox soyisim;
        private System.Windows.Forms.TextBox dt;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button kontrolButon;
        private System.Windows.Forms.Button button1;
    }
}

