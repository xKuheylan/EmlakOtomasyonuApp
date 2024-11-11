using System;
using System.IO;
using System.Windows.Forms;

namespace EmlakOtomasyonu.Presentation
{
    public partial class frmEvKayit : Form
    {
        public frmEvKayit()
        {
            InitializeComponent();
        }

        private void frmEvKayit_Load(object sender, EventArgs e)
        {
            // Semt listesini ComboBox'a yükleme
            string[] iller = File.ReadAllLines(Path.Combine(Application.StartupPath, "iller.txt"));
            comboBoxSemt.Items.AddRange(iller);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan verileri okuma
            string fiyat = txtFiyat.Text;
            string alan = txtAlan.Text;
            string odaSayisi = txtOdaSayisi.Text;
            string semt = comboBoxSemt.SelectedItem.ToString();

            // Ev bilgilerini dosyaya yazma
            string evData = $"{fiyat},{alan},{odaSayisi},{semt}";
            File.AppendAllText("satilik.txt", evData + Environment.NewLine);

            MessageBox.Show("Ev başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
