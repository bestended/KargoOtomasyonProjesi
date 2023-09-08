namespace KargoOtomasyonProjesi
{
    partial class SevkiyatRaporlari
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_sevkRaporlarim = new System.Windows.Forms.DataGridView();
            this.btn_sürücüAdi_aracMarka = new System.Windows.Forms.Button();
            this.txt_varisNokta = new System.Windows.Forms.TextBox();
            this.txt_minSevkTutar = new System.Windows.Forms.TextBox();
            this.btn_tutarGirilen = new System.Windows.Forms.Button();
            this.txt_maksSevkTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sevkAdiMarkaKapasite = new System.Windows.Forms.Button();
            this.txt_sevkAdi = new System.Windows.Forms.TextBox();
            this.txt_sevkAdi2 = new System.Windows.Forms.TextBox();
            this.btn_sevkAdi = new System.Windows.Forms.Button();
            this.btn_kalkisTutar = new System.Windows.Forms.Button();
            this.txt_kalkisTutar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_sevkRaporlarim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_sevkRaporlarim);
            this.groupBox1.Location = new System.Drawing.Point(560, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sevkiyat Raporları";
            // 
            // dgw_sevkRaporlarim
            // 
            this.dgw_sevkRaporlarim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_sevkRaporlarim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_sevkRaporlarim.Location = new System.Drawing.Point(3, 16);
            this.dgw_sevkRaporlarim.Name = "dgw_sevkRaporlarim";
            this.dgw_sevkRaporlarim.Size = new System.Drawing.Size(429, 432);
            this.dgw_sevkRaporlarim.TabIndex = 0;
            // 
            // btn_sürücüAdi_aracMarka
            // 
            this.btn_sürücüAdi_aracMarka.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sürücüAdi_aracMarka.ForeColor = System.Drawing.Color.White;
            this.btn_sürücüAdi_aracMarka.Location = new System.Drawing.Point(24, 27);
            this.btn_sürücüAdi_aracMarka.Name = "btn_sürücüAdi_aracMarka";
            this.btn_sürücüAdi_aracMarka.Size = new System.Drawing.Size(408, 41);
            this.btn_sürücüAdi_aracMarka.TabIndex = 2;
            this.btn_sürücüAdi_aracMarka.Text = "Varış noktasına göre araç adı-sürücü adı-araç gideri";
            this.btn_sürücüAdi_aracMarka.UseVisualStyleBackColor = false;
            this.btn_sürücüAdi_aracMarka.Click += new System.EventHandler(this.btn_sürücüAdi_aracMarka_Click);
            // 
            // txt_varisNokta
            // 
            this.txt_varisNokta.Location = new System.Drawing.Point(24, 74);
            this.txt_varisNokta.Name = "txt_varisNokta";
            this.txt_varisNokta.Size = new System.Drawing.Size(408, 20);
            this.txt_varisNokta.TabIndex = 3;
            // 
            // txt_minSevkTutar
            // 
            this.txt_minSevkTutar.Location = new System.Drawing.Point(24, 161);
            this.txt_minSevkTutar.Name = "txt_minSevkTutar";
            this.txt_minSevkTutar.Size = new System.Drawing.Size(187, 20);
            this.txt_minSevkTutar.TabIndex = 5;
            // 
            // btn_tutarGirilen
            // 
            this.btn_tutarGirilen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tutarGirilen.ForeColor = System.Drawing.Color.White;
            this.btn_tutarGirilen.Location = new System.Drawing.Point(24, 114);
            this.btn_tutarGirilen.Name = "btn_tutarGirilen";
            this.btn_tutarGirilen.Size = new System.Drawing.Size(408, 41);
            this.btn_tutarGirilen.TabIndex = 4;
            this.btn_tutarGirilen.Text = "Tutarı girilen değer aralığında olan sevkiyat adı";
            this.btn_tutarGirilen.UseVisualStyleBackColor = false;
            this.btn_tutarGirilen.Click += new System.EventHandler(this.btn_tutarGirilen_Click);
            // 
            // txt_maksSevkTutar
            // 
            this.txt_maksSevkTutar.Location = new System.Drawing.Point(264, 161);
            this.txt_maksSevkTutar.Name = "txt_maksSevkTutar";
            this.txt_maksSevkTutar.Size = new System.Drawing.Size(168, 20);
            this.txt_maksSevkTutar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "----";
            // 
            // btn_sevkAdiMarkaKapasite
            // 
            this.btn_sevkAdiMarkaKapasite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sevkAdiMarkaKapasite.ForeColor = System.Drawing.Color.White;
            this.btn_sevkAdiMarkaKapasite.Location = new System.Drawing.Point(24, 198);
            this.btn_sevkAdiMarkaKapasite.Name = "btn_sevkAdiMarkaKapasite";
            this.btn_sevkAdiMarkaKapasite.Size = new System.Drawing.Size(408, 41);
            this.btn_sevkAdiMarkaKapasite.TabIndex = 8;
            this.btn_sevkAdiMarkaKapasite.Text = "Sevkiyat adına göre arac marka ve kapasitesi";
            this.btn_sevkAdiMarkaKapasite.UseVisualStyleBackColor = false;
            this.btn_sevkAdiMarkaKapasite.Click += new System.EventHandler(this.btn_sevkAdiMarkaKapasite_Click);
            // 
            // txt_sevkAdi
            // 
            this.txt_sevkAdi.Location = new System.Drawing.Point(24, 245);
            this.txt_sevkAdi.Name = "txt_sevkAdi";
            this.txt_sevkAdi.Size = new System.Drawing.Size(408, 20);
            this.txt_sevkAdi.TabIndex = 9;
            // 
            // txt_sevkAdi2
            // 
            this.txt_sevkAdi2.Location = new System.Drawing.Point(24, 331);
            this.txt_sevkAdi2.Name = "txt_sevkAdi2";
            this.txt_sevkAdi2.Size = new System.Drawing.Size(408, 20);
            this.txt_sevkAdi2.TabIndex = 11;
            // 
            // btn_sevkAdi
            // 
            this.btn_sevkAdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sevkAdi.ForeColor = System.Drawing.Color.White;
            this.btn_sevkAdi.Location = new System.Drawing.Point(24, 284);
            this.btn_sevkAdi.Name = "btn_sevkAdi";
            this.btn_sevkAdi.Size = new System.Drawing.Size(408, 41);
            this.btn_sevkAdi.TabIndex = 10;
            this.btn_sevkAdi.Text = "Sevkiyat adına göre arac marka-müşteri adı-personel adı";
            this.btn_sevkAdi.UseVisualStyleBackColor = false;
            this.btn_sevkAdi.Click += new System.EventHandler(this.btn_sevkAdi_Click);
            // 
            // btn_kalkisTutar
            // 
            this.btn_kalkisTutar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kalkisTutar.ForeColor = System.Drawing.Color.White;
            this.btn_kalkisTutar.Location = new System.Drawing.Point(24, 379);
            this.btn_kalkisTutar.Name = "btn_kalkisTutar";
            this.btn_kalkisTutar.Size = new System.Drawing.Size(408, 41);
            this.btn_kalkisTutar.TabIndex = 12;
            this.btn_kalkisTutar.Text = "Kalkış noktasına göre mesafe-tutar";
            this.btn_kalkisTutar.UseVisualStyleBackColor = false;
            this.btn_kalkisTutar.Click += new System.EventHandler(this.btn_kalkisTutar_Click);
            // 
            // txt_kalkisTutar
            // 
            this.txt_kalkisTutar.Location = new System.Drawing.Point(24, 426);
            this.txt_kalkisTutar.Name = "txt_kalkisTutar";
            this.txt_kalkisTutar.Size = new System.Drawing.Size(408, 20);
            this.txt_kalkisTutar.TabIndex = 13;
            // 
            // SevkiyatRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 490);
            this.Controls.Add(this.txt_kalkisTutar);
            this.Controls.Add(this.btn_kalkisTutar);
            this.Controls.Add(this.txt_sevkAdi2);
            this.Controls.Add(this.btn_sevkAdi);
            this.Controls.Add(this.txt_sevkAdi);
            this.Controls.Add(this.btn_sevkAdiMarkaKapasite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maksSevkTutar);
            this.Controls.Add(this.txt_minSevkTutar);
            this.Controls.Add(this.btn_tutarGirilen);
            this.Controls.Add(this.txt_varisNokta);
            this.Controls.Add(this.btn_sürücüAdi_aracMarka);
            this.Controls.Add(this.groupBox1);
            this.Name = "SevkiyatRaporlari";
            this.Text = "SevkiyatRaporlari";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_sevkRaporlarim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_sevkRaporlarim;
        private System.Windows.Forms.Button btn_sürücüAdi_aracMarka;
        private System.Windows.Forms.TextBox txt_varisNokta;
        private System.Windows.Forms.TextBox txt_minSevkTutar;
        private System.Windows.Forms.Button btn_tutarGirilen;
        private System.Windows.Forms.TextBox txt_maksSevkTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sevkAdiMarkaKapasite;
        private System.Windows.Forms.TextBox txt_sevkAdi;
        private System.Windows.Forms.TextBox txt_sevkAdi2;
        private System.Windows.Forms.Button btn_sevkAdi;
        private System.Windows.Forms.Button btn_kalkisTutar;
        private System.Windows.Forms.TextBox txt_kalkisTutar;
    }
}