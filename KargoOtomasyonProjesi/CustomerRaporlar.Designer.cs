namespace KargoOtomasyonProjesi
{
    partial class CustomerRaporlar
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_müsteriRaporlar = new System.Windows.Forms.DataGridView();
            this.btn_ad_marka_varis = new System.Windows.Forms.Button();
            this.txt_müsteriAdi1 = new System.Windows.Forms.TextBox();
            this.txt_müsteriAdi = new System.Windows.Forms.TextBox();
            this.btn_ödemeyenler = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_müsteriAdres = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_müsteriRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(28, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müşteri adı-ödeme durumu-Araç markası-Araç kapasite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_müsteriRaporlar);
            this.groupBox1.Location = new System.Drawing.Point(485, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Raporları";
            // 
            // dgw_müsteriRaporlar
            // 
            this.dgw_müsteriRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_müsteriRaporlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_müsteriRaporlar.Location = new System.Drawing.Point(3, 16);
            this.dgw_müsteriRaporlar.Name = "dgw_müsteriRaporlar";
            this.dgw_müsteriRaporlar.Size = new System.Drawing.Size(437, 437);
            this.dgw_müsteriRaporlar.TabIndex = 0;
            // 
            // btn_ad_marka_varis
            // 
            this.btn_ad_marka_varis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ad_marka_varis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ad_marka_varis.Location = new System.Drawing.Point(28, 131);
            this.btn_ad_marka_varis.Name = "btn_ad_marka_varis";
            this.btn_ad_marka_varis.Size = new System.Drawing.Size(371, 44);
            this.btn_ad_marka_varis.TabIndex = 2;
            this.btn_ad_marka_varis.Text = "Müşteri adı-Araba markası-sevkiyat varış";
            this.btn_ad_marka_varis.UseVisualStyleBackColor = true;
            this.btn_ad_marka_varis.Click += new System.EventHandler(this.btn_ad_marka_varis_Click);
            // 
            // txt_müsteriAdi1
            // 
            this.txt_müsteriAdi1.Location = new System.Drawing.Point(28, 79);
            this.txt_müsteriAdi1.Name = "txt_müsteriAdi1";
            this.txt_müsteriAdi1.Size = new System.Drawing.Size(371, 20);
            this.txt_müsteriAdi1.TabIndex = 3;
            // 
            // txt_müsteriAdi
            // 
            this.txt_müsteriAdi.Location = new System.Drawing.Point(28, 181);
            this.txt_müsteriAdi.Name = "txt_müsteriAdi";
            this.txt_müsteriAdi.Size = new System.Drawing.Size(371, 20);
            this.txt_müsteriAdi.TabIndex = 4;
            // 
            // btn_ödemeyenler
            // 
            this.btn_ödemeyenler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ödemeyenler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ödemeyenler.Location = new System.Drawing.Point(28, 232);
            this.btn_ödemeyenler.Name = "btn_ödemeyenler";
            this.btn_ödemeyenler.Size = new System.Drawing.Size(371, 44);
            this.btn_ödemeyenler.TabIndex = 5;
            this.btn_ödemeyenler.Text = "Borcunu ödemeyenleri getirme";
            this.btn_ödemeyenler.UseVisualStyleBackColor = true;
            this.btn_ödemeyenler.Click += new System.EventHandler(this.btn_ödemeyenler_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(28, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(371, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Adresi girilen müşteriyle ilgilenen personel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_müsteriAdres
            // 
            this.txt_müsteriAdres.Location = new System.Drawing.Point(28, 365);
            this.txt_müsteriAdres.Name = "txt_müsteriAdres";
            this.txt_müsteriAdres.Size = new System.Drawing.Size(371, 20);
            this.txt_müsteriAdres.TabIndex = 7;
            // 
            // CustomerRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 497);
            this.Controls.Add(this.txt_müsteriAdres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ödemeyenler);
            this.Controls.Add(this.txt_müsteriAdi);
            this.Controls.Add(this.txt_müsteriAdi1);
            this.Controls.Add(this.btn_ad_marka_varis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "CustomerRaporlar";
            this.Text = "CustomerRaporlar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_müsteriRaporlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_müsteriRaporlar;
        private System.Windows.Forms.Button btn_ad_marka_varis;
        private System.Windows.Forms.TextBox txt_müsteriAdi1;
        private System.Windows.Forms.TextBox txt_müsteriAdi;
        private System.Windows.Forms.Button btn_ödemeyenler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_müsteriAdres;
    }
}