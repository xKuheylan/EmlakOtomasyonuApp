namespace EmlakOtomasyonu.Presentation
{
    partial class frmEvKayit
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
            comboBoxSemt = new ComboBox();
            txtFiyat = new TextBox();
            txtAlan = new TextBox();
            txtOdaSayisi = new TextBox();
            SuspendLayout();
            // 
            // comboBoxSemt
            // 
            comboBoxSemt.FormattingEnabled = true;
            comboBoxSemt.Location = new Point(29, 122);
            comboBoxSemt.Name = "comboBoxSemt";
            comboBoxSemt.Size = new Size(151, 28);
            comboBoxSemt.TabIndex = 0;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(250, 231);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(125, 27);
            txtFiyat.TabIndex = 1;
            // 
            // txtAlan
            // 
            txtAlan.Location = new Point(250, 278);
            txtAlan.Name = "txtAlan";
            txtAlan.Size = new Size(125, 27);
            txtAlan.TabIndex = 1;
            // 
            // txtOdaSayisi
            // 
            txtOdaSayisi.Location = new Point(250, 326);
            txtOdaSayisi.Name = "txtOdaSayisi";
            txtOdaSayisi.Size = new Size(125, 27);
            txtOdaSayisi.TabIndex = 1;
            // 
            // frmEvKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOdaSayisi);
            Controls.Add(txtAlan);
            Controls.Add(txtFiyat);
            Controls.Add(comboBoxSemt);
            Name = "frmEvKayit";
            Text = "frmEvKayit";
            Load += frmEvKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSemt;
        private TextBox txtFiyat;
        private TextBox txtAlan;
        private TextBox txtOdaSayisi;
    }
}