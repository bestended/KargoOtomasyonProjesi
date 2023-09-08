namespace KargoOtomasyonProjesi
{
    partial class XmlDosyalari
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
            this.btn_sevkiyatXml = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sevkiyatXml
            // 
            this.btn_sevkiyatXml.Location = new System.Drawing.Point(78, 51);
            this.btn_sevkiyatXml.Name = "btn_sevkiyatXml";
            this.btn_sevkiyatXml.Size = new System.Drawing.Size(127, 147);
            this.btn_sevkiyatXml.TabIndex = 0;
            this.btn_sevkiyatXml.Text = "Sevkiyat XML";
            this.btn_sevkiyatXml.UseVisualStyleBackColor = true;
            this.btn_sevkiyatXml.Click += new System.EventHandler(this.btn_sevkiyatXml_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(238, 51);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(127, 147);
            this.btn_customer.TabIndex = 1;
            this.btn_customer.Text = "Customer XML";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 147);
            this.button2.TabIndex = 2;
            this.button2.Text = "Araçlar XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 147);
            this.button3.TabIndex = 3;
            this.button3.Text = "Personeller XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // XmlDosyalari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 249);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.btn_sevkiyatXml);
            this.Name = "XmlDosyalari";
            this.Text = "XmlDosyalari";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sevkiyatXml;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}