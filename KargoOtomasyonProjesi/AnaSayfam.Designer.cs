namespace KargoOtomasyonProjesi
{
    partial class AnaSayfam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfam));
            this.btn_personeller = new KargoOtomasyonProjesi.roundButton();
            this.btn_Sevkiyat = new KargoOtomasyonProjesi.roundButton();
            this.btn_müsteriler = new KargoOtomasyonProjesi.roundButton();
            this.btn_arabalar = new KargoOtomasyonProjesi.roundButton();
            this.SuspendLayout();
            // 
            // btn_personeller
            // 
            this.btn_personeller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_personeller.BackgroundImage")));
            this.btn_personeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_personeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_personeller.Location = new System.Drawing.Point(835, 42);
            this.btn_personeller.Name = "btn_personeller";
            this.btn_personeller.Size = new System.Drawing.Size(232, 251);
            this.btn_personeller.TabIndex = 3;
            this.btn_personeller.UseVisualStyleBackColor = true;
            this.btn_personeller.Click += new System.EventHandler(this.btn_personeller_Click);
            // 
            // btn_Sevkiyat
            // 
            this.btn_Sevkiyat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sevkiyat.BackgroundImage")));
            this.btn_Sevkiyat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sevkiyat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sevkiyat.Location = new System.Drawing.Point(578, 42);
            this.btn_Sevkiyat.Name = "btn_Sevkiyat";
            this.btn_Sevkiyat.Size = new System.Drawing.Size(232, 251);
            this.btn_Sevkiyat.TabIndex = 2;
            this.btn_Sevkiyat.UseVisualStyleBackColor = true;
            this.btn_Sevkiyat.Click += new System.EventHandler(this.btn_Sevkiyat_Click);
            // 
            // btn_müsteriler
            // 
            this.btn_müsteriler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_müsteriler.BackgroundImage")));
            this.btn_müsteriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_müsteriler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_müsteriler.Location = new System.Drawing.Point(296, 42);
            this.btn_müsteriler.Name = "btn_müsteriler";
            this.btn_müsteriler.Size = new System.Drawing.Size(232, 251);
            this.btn_müsteriler.TabIndex = 1;
            this.btn_müsteriler.UseVisualStyleBackColor = true;
            this.btn_müsteriler.Click += new System.EventHandler(this.btn_müsteriler_Click);
            // 
            // btn_arabalar
            // 
            this.btn_arabalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_arabalar.BackgroundImage")));
            this.btn_arabalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_arabalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_arabalar.Location = new System.Drawing.Point(12, 42);
            this.btn_arabalar.Name = "btn_arabalar";
            this.btn_arabalar.Size = new System.Drawing.Size(232, 251);
            this.btn_arabalar.TabIndex = 0;
            this.btn_arabalar.UseVisualStyleBackColor = true;
            this.btn_arabalar.Click += new System.EventHandler(this.btn_arabalar_Click);
            // 
            // AnaSayfam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 378);
            this.Controls.Add(this.btn_personeller);
            this.Controls.Add(this.btn_Sevkiyat);
            this.Controls.Add(this.btn_müsteriler);
            this.Controls.Add(this.btn_arabalar);
            this.Name = "AnaSayfam";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private roundButton btn_arabalar;
        private roundButton btn_müsteriler;
        private roundButton btn_Sevkiyat;
        private roundButton btn_personeller;
    }
}