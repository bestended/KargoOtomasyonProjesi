namespace KargoOtomasyonProjesi
{
    partial class PersonelRaporlari
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
            this.dgw_personelRapor = new System.Windows.Forms.DataGridView();
            this.btn_sürücüAdi_aracMarka = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_minMaas = new System.Windows.Forms.TextBox();
            this.txt_maksMaas = new System.Windows.Forms.TextBox();
            this.txt_persAdi = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_personelAdim = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_personelRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_personelRapor);
            this.groupBox1.Location = new System.Drawing.Point(532, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Raporları";
            // 
            // dgw_personelRapor
            // 
            this.dgw_personelRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_personelRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_personelRapor.Location = new System.Drawing.Point(3, 16);
            this.dgw_personelRapor.Name = "dgw_personelRapor";
            this.dgw_personelRapor.Size = new System.Drawing.Size(480, 407);
            this.dgw_personelRapor.TabIndex = 0;
            // 
            // btn_sürücüAdi_aracMarka
            // 
            this.btn_sürücüAdi_aracMarka.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sürücüAdi_aracMarka.ForeColor = System.Drawing.Color.White;
            this.btn_sürücüAdi_aracMarka.Location = new System.Drawing.Point(31, 28);
            this.btn_sürücüAdi_aracMarka.Name = "btn_sürücüAdi_aracMarka";
            this.btn_sürücüAdi_aracMarka.Size = new System.Drawing.Size(408, 41);
            this.btn_sürücüAdi_aracMarka.TabIndex = 1;
            this.btn_sürücüAdi_aracMarka.Text = "Personel ünvanına göre gruplama";
            this.btn_sürücüAdi_aracMarka.UseVisualStyleBackColor = false;
            this.btn_sürücüAdi_aracMarka.Click += new System.EventHandler(this.btn_sürücüAdi_aracMarka_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Maaşı girilen değer aralığında olanlar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(31, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(408, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Personel adına göre sevkiyat adı-varış-kalkış noktası";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_minMaas
            // 
            this.txt_minMaas.Location = new System.Drawing.Point(31, 154);
            this.txt_minMaas.Name = "txt_minMaas";
            this.txt_minMaas.Size = new System.Drawing.Size(150, 20);
            this.txt_minMaas.TabIndex = 4;
            // 
            // txt_maksMaas
            // 
            this.txt_maksMaas.Location = new System.Drawing.Point(291, 154);
            this.txt_maksMaas.Name = "txt_maksMaas";
            this.txt_maksMaas.Size = new System.Drawing.Size(148, 20);
            this.txt_maksMaas.TabIndex = 5;
            // 
            // txt_persAdi
            // 
            this.txt_persAdi.Location = new System.Drawing.Point(31, 267);
            this.txt_persAdi.Name = "txt_persAdi";
            this.txt_persAdi.Size = new System.Drawing.Size(408, 20);
            this.txt_persAdi.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(31, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(408, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "Personel adı-görevi-Unvanı-Varış Noktası-maaşı-gideceği mesafe-sevk tutarı";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_personelAdim
            // 
            this.txt_personelAdim.Location = new System.Drawing.Point(31, 374);
            this.txt_personelAdim.Name = "txt_personelAdim";
            this.txt_personelAdim.Size = new System.Drawing.Size(408, 20);
            this.txt_personelAdim.TabIndex = 8;
            // 
            // PersonelRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.txt_personelAdim);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_persAdi);
            this.Controls.Add(this.txt_maksMaas);
            this.Controls.Add(this.txt_minMaas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sürücüAdi_aracMarka);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonelRaporlari";
            this.Text = "PersonelRaporlari";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_personelRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_personelRapor;
        private System.Windows.Forms.Button btn_sürücüAdi_aracMarka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_minMaas;
        private System.Windows.Forms.TextBox txt_maksMaas;
        private System.Windows.Forms.TextBox txt_persAdi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_personelAdim;
    }
}