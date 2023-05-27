namespace VTDGP_uyg1
{
    partial class FRMOGRENCİGİRİS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMOGRENCİGİRİS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrNo = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGuvenlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblGuvenlikKodu = new System.Windows.Forms.Label();
            this.PbDegistir = new System.Windows.Forms.PictureBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDegistir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISKENDERUN TEKNIK UNIVERSITESİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(644, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖĞRENCİ NO";
            // 
            // TxtOgrNo
            // 
            this.TxtOgrNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrNo.Location = new System.Drawing.Point(290, 119);
            this.TxtOgrNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtOgrNo.MaxLength = 9;
            this.TxtOgrNo.Name = "TxtOgrNo";
            this.TxtOgrNo.Size = new System.Drawing.Size(241, 32);
            this.TxtOgrNo.TabIndex = 2;
            this.TxtOgrNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(290, 155);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(241, 32);
            this.TxtSifre.TabIndex = 4;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "ŞİFRE";
            // 
            // TxtGuvenlik
            // 
            this.TxtGuvenlik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGuvenlik.Location = new System.Drawing.Point(290, 190);
            this.TxtGuvenlik.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGuvenlik.Name = "TxtGuvenlik";
            this.TxtGuvenlik.Size = new System.Drawing.Size(111, 32);
            this.TxtGuvenlik.TabIndex = 6;
            this.TxtGuvenlik.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "GÜVENLİK KODU";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LblGuvenlikKodu
            // 
            this.LblGuvenlikKodu.AutoSize = true;
            this.LblGuvenlikKodu.Location = new System.Drawing.Point(406, 197);
            this.LblGuvenlikKodu.Name = "LblGuvenlikKodu";
            this.LblGuvenlikKodu.Size = new System.Drawing.Size(63, 25);
            this.LblGuvenlikKodu.TabIndex = 7;
            this.LblGuvenlikKodu.Text = "label5";
            this.LblGuvenlikKodu.Click += new System.EventHandler(this.label5_Click);
            // 
            // PbDegistir
            // 
            this.PbDegistir.Image = ((System.Drawing.Image)(resources.GetObject("PbDegistir.Image")));
            this.PbDegistir.Location = new System.Drawing.Point(503, 192);
            this.PbDegistir.Name = "PbDegistir";
            this.PbDegistir.Size = new System.Drawing.Size(28, 28);
            this.PbDegistir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbDegistir.TabIndex = 8;
            this.PbDegistir.TabStop = false;
            this.PbDegistir.Click += new System.EventHandler(this.PbDegistir_Click);
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiris.Location = new System.Drawing.Point(290, 228);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(241, 32);
            this.BtnGiris.TabIndex = 9;
            this.BtnGiris.Text = " GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            this.BtnGiris.MouseLeave += new System.EventHandler(this.BtnGiris_MouseLeave);
            this.BtnGiris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnGiris_MouseMove);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(324, 266);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(207, 29);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "ŞİFRE GÖSTER/GİZLE";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FRMOGRENCİGİRİS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 391);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.PbDegistir);
            this.Controls.Add(this.LblGuvenlikKodu);
            this.Controls.Add(this.TxtGuvenlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOgrNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMOGRENCİGİRİS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRMOGRENCİGİRİS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDegistir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrNo;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGuvenlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblGuvenlikKodu;
        private System.Windows.Forms.PictureBox PbDegistir;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

