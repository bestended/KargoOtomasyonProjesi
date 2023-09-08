namespace KargoOtomasyonProjesi
{
    partial class AracRaporlari
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
            this.btn_sürücüAdi_aracMarka = new System.Windows.Forms.Button();
            this.txt_sürücüAdi = new System.Windows.Forms.TextBox();
            this.dgw_aracRapor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_aracMarka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_miniGider = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_maksiGider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_giderSiralamaAzCok = new System.Windows.Forms.Button();
            this.btn_giderSiralaCokAz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_aracRapor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sürücüAdi_aracMarka
            // 
            this.btn_sürücüAdi_aracMarka.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sürücüAdi_aracMarka.ForeColor = System.Drawing.Color.White;
            this.btn_sürücüAdi_aracMarka.Location = new System.Drawing.Point(21, 27);
            this.btn_sürücüAdi_aracMarka.Name = "btn_sürücüAdi_aracMarka";
            this.btn_sürücüAdi_aracMarka.Size = new System.Drawing.Size(334, 23);
            this.btn_sürücüAdi_aracMarka.TabIndex = 0;
            this.btn_sürücüAdi_aracMarka.Text = "Sürücü ismine göre araba markası";
            this.btn_sürücüAdi_aracMarka.UseVisualStyleBackColor = false;
            this.btn_sürücüAdi_aracMarka.Click += new System.EventHandler(this.btn_sürücüAdi_aracMarka_Click);
            // 
            // txt_sürücüAdi
            // 
            this.txt_sürücüAdi.Location = new System.Drawing.Point(21, 56);
            this.txt_sürücüAdi.Name = "txt_sürücüAdi";
            this.txt_sürücüAdi.Size = new System.Drawing.Size(334, 20);
            this.txt_sürücüAdi.TabIndex = 1;
            // 
            // dgw_aracRapor
            // 
            this.dgw_aracRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_aracRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_aracRapor.Location = new System.Drawing.Point(3, 16);
            this.dgw_aracRapor.Name = "dgw_aracRapor";
            this.dgw_aracRapor.Size = new System.Drawing.Size(449, 335);
            this.dgw_aracRapor.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_aracRapor);
            this.groupBox1.Location = new System.Drawing.Point(409, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 354);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Raporları";
            // 
            // txt_aracMarka
            // 
            this.txt_aracMarka.Location = new System.Drawing.Point(21, 158);
            this.txt_aracMarka.Name = "txt_aracMarka";
            this.txt_aracMarka.Size = new System.Drawing.Size(334, 20);
            this.txt_aracMarka.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Araç Markasına göre   ->   Kapasite-Gider-Müşteri adı-Adres-tel-ödeme durum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_miniGider
            // 
            this.txt_miniGider.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_miniGider.Location = new System.Drawing.Point(21, 255);
            this.txt_miniGider.Name = "txt_miniGider";
            this.txt_miniGider.Size = new System.Drawing.Size(146, 20);
            this.txt_miniGider.TabIndex = 7;
            this.txt_miniGider.Text = "Min gider değeri girin...";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(21, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gideri girilen  aralıkta olan  =>  arac markası-sevkiyat adı-varış noktası-mesafe" +
    "";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_maksiGider
            // 
            this.txt_maksiGider.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_maksiGider.Location = new System.Drawing.Point(209, 255);
            this.txt_maksiGider.Name = "txt_maksiGider";
            this.txt_maksiGider.Size = new System.Drawing.Size(146, 20);
            this.txt_maksiGider.TabIndex = 8;
            this.txt_maksiGider.Text = "Maks gider değeri girin...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "---";
            // 
            // btn_giderSiralamaAzCok
            // 
            this.btn_giderSiralamaAzCok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_giderSiralamaAzCok.ForeColor = System.Drawing.Color.White;
            this.btn_giderSiralamaAzCok.Location = new System.Drawing.Point(21, 297);
            this.btn_giderSiralamaAzCok.Name = "btn_giderSiralamaAzCok";
            this.btn_giderSiralamaAzCok.Size = new System.Drawing.Size(334, 33);
            this.btn_giderSiralamaAzCok.TabIndex = 10;
            this.btn_giderSiralamaAzCok.Text = "Araç gider azdan çoğa göre sıralama";
            this.btn_giderSiralamaAzCok.UseVisualStyleBackColor = false;
            this.btn_giderSiralamaAzCok.Click += new System.EventHandler(this.btn_giderSiralamaAzCok_Click);
            // 
            // btn_giderSiralaCokAz
            // 
            this.btn_giderSiralaCokAz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_giderSiralaCokAz.ForeColor = System.Drawing.Color.White;
            this.btn_giderSiralaCokAz.Location = new System.Drawing.Point(21, 336);
            this.btn_giderSiralaCokAz.Name = "btn_giderSiralaCokAz";
            this.btn_giderSiralaCokAz.Size = new System.Drawing.Size(334, 31);
            this.btn_giderSiralaCokAz.TabIndex = 11;
            this.btn_giderSiralaCokAz.Text = "Araç gider çoktan aza göre sıralama";
            this.btn_giderSiralaCokAz.UseVisualStyleBackColor = false;
            this.btn_giderSiralaCokAz.Click += new System.EventHandler(this.btn_giderSiralaCokAz_Click);
            // 
            // AracRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.btn_giderSiralaCokAz);
            this.Controls.Add(this.btn_giderSiralamaAzCok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maksiGider);
            this.Controls.Add(this.txt_miniGider);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_aracMarka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_sürücüAdi);
            this.Controls.Add(this.btn_sürücüAdi_aracMarka);
            this.Name = "AracRaporlari";
            this.Text = "AracRaporlari";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_aracRapor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sürücüAdi_aracMarka;
        private System.Windows.Forms.TextBox txt_sürücüAdi;
        private System.Windows.Forms.DataGridView dgw_aracRapor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_aracMarka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_miniGider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_maksiGider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_giderSiralamaAzCok;
        private System.Windows.Forms.Button btn_giderSiralaCokAz;
    }
}