using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace modul15_NIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tombol Register
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validasi panjang
            if (username.Length < 8 || username.Length > 20 || password.Length < 8 || password.Length > 20)
            {
                lblOutput.Text = "Username/Password harus 8-20 karakter.";
                return;
            }

            // Validasi hanya alfabet + angka (ASCII)
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                lblOutput.Text = "Username hanya boleh huruf dan angka (ASCII).";
                return;
            }

            // Validasi password rules
            if (!Regex.IsMatch(password, @"^(?=.*\d)(?=.*[A-Z])(?=.*[!@#$%^&*]).+$"))
            {
                lblOutput.Text = "Password harus ada huruf besar, angka, dan simbol (!@#$%^&*).";
                return;
            }

            if (password.ToLower().Contains(username.ToLower()))
            {
                lblOutput.Text = "Password tidak boleh mengandung username.";
                return;
            }

            if (UserStorage.UsernameExists(username))
            {
                lblOutput.Text = "Username sudah terdaftar.";
                return;
            }

            string hashed = Helper.HashPassword(password);
            UserStorage.SaveUser(new User { Username = username, PasswordHash = hashed });

            lblOutput.Text = "Registrasi berhasil!";
        }

        // Tombol Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            var user = UserStorage.FindUser(username);
            if (user == null)
            {
                lblOutput.Text = "Username tidak ditemukan.";
                return;
            }

            string hashed = Helper.HashPassword(password);
            if (user.PasswordHash == hashed)
            {
                lblOutput.Text = "Login berhasil!";
            }
            else
            {
                lblOutput.Text = "Password salah.";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
