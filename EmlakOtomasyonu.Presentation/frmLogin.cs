using System;
using System.IO;
using System.Windows.Forms;

namespace EmlakOtomasyonu.Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // users.txt dosyasındaki kullanıcı bilgilerini okuma
            string[] lines = File.ReadAllLines("users.txt");
            bool loginSuccessful = false;

            foreach (string line in lines)
            {
                string[] credentials = line.Split(',');
                if (credentials.Length == 2 &&
                    credentials[0] == username &&
                    credentials[1] == password)
                {
                    loginSuccessful = true;
                    break;
                }
            }

            if (loginSuccessful)
            {
                // Başarılı giriş: frmMain formunu aç ve frmLogin'i kapat
                frmMain mainForm = new frmMain();
                mainForm.Show();
                this.Hide(); // frmLogin'i gizle
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
