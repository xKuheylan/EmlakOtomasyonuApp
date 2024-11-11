namespace EmlakOtomasyonu.Presentation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniEvEkle_Click(object sender, EventArgs e)
        {
            frmEvKayit evKayitForm = new frmEvKayit();
            evKayitForm.Show();
        }

        private void btnEvSorgula_Click(object sender, EventArgs e)
        {
            frmEvSorgulama evSorgulamaForm = new frmEvSorgulama();
            evSorgulamaForm.Show();
        }

        private void btnEvListele_Click(object sender, EventArgs e)
        {

        }
    }
}
