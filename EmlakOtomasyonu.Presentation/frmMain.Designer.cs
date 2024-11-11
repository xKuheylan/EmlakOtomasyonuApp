namespace EmlakOtomasyonu.Presentation
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnYeniEvEkle = new Button();
            btnEvSorgula = new Button();
            btnEvListele = new Button();
            btnEvArsivle = new Button();
            btnEvDetay = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnYeniEvEkle
            // 
            btnYeniEvEkle.Location = new Point(12, 12);
            btnYeniEvEkle.Name = "btnYeniEvEkle";
            btnYeniEvEkle.Size = new Size(210, 87);
            btnYeniEvEkle.TabIndex = 0;
            btnYeniEvEkle.Text = "Yeni Ev Ekleme";
            btnYeniEvEkle.UseVisualStyleBackColor = true;
            btnYeniEvEkle.Click += btnYeniEvEkle_Click;
            // 
            // btnEvSorgula
            // 
            btnEvSorgula.Location = new Point(12, 105);
            btnEvSorgula.Name = "btnEvSorgula";
            btnEvSorgula.Size = new Size(210, 72);
            btnEvSorgula.TabIndex = 1;
            btnEvSorgula.Text = "Ev Sorgulama";
            btnEvSorgula.UseVisualStyleBackColor = true;
            btnEvSorgula.Click += btnEvSorgula_Click;
            // 
            // btnEvListele
            // 
            btnEvListele.Location = new Point(1066, 20);
            btnEvListele.Name = "btnEvListele";
            btnEvListele.Size = new Size(193, 47);
            btnEvListele.TabIndex = 1;
            btnEvListele.Text = "Ev Listeleme";
            btnEvListele.UseVisualStyleBackColor = true;
            btnEvListele.Click += btnEvListele_Click;
            // 
            // btnEvArsivle
            // 
            btnEvArsivle.Location = new Point(1066, 195);
            btnEvArsivle.Name = "btnEvArsivle";
            btnEvArsivle.Size = new Size(210, 95);
            btnEvArsivle.TabIndex = 2;
            btnEvArsivle.Text = "Ev Arşivleme";
            btnEvArsivle.UseVisualStyleBackColor = true;
            // 
            // btnEvDetay
            // 
            btnEvDetay.Location = new Point(448, 302);
            btnEvDetay.Name = "btnEvDetay";
            btnEvDetay.Size = new Size(210, 95);
            btnEvDetay.TabIndex = 2;
            btnEvDetay.Text = "Ev Detay";
            btnEvDetay.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(1066, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(193, 104);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(817, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(300, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(418, 210);
            dataGridView1.TabIndex = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 431);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(btnEvDetay);
            Controls.Add(btnEvArsivle);
            Controls.Add(btnEvListele);
            Controls.Add(btnEvSorgula);
            Controls.Add(btnYeniEvEkle);
            Name = "frmMain";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYeniEvEkle;
        private Button btnEvSorgula;
        private Button btnEvListele;
        private Button btnEvArsivle;
        private Button btnEvDetay;
        private ListBox listBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}
