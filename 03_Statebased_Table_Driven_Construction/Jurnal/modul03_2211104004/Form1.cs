using System;
using System.Windows.Forms;

namespace modul03_2211104004
{
    public partial class Form1 : Form
    {
        string input = "";      // Menyimpan input saat ini (angka string)
        int angka1 = 0;         // Menyimpan angka pertama
        int angka2 = 0;         // Menyimpan angka kedua
        char operasi;           // Menyimpan operator (+)

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Menghubungkan semua tombol angka ke event yang sama
            button1.Click += btnAngka_Click;
            button2.Click += btnAngka_Click;
            button3.Click += btnAngka_Click;
            button4.Click += btnAngka_Click;
            button5.Click += btnAngka_Click;
            button6.Click += btnAngka_Click;
            button7.Click += btnAngka_Click;
            button8.Click += btnAngka_Click;
            button9.Click += btnAngka_Click;
            button10.Click += btnAngka_Click;

            // Hubungkan tombol operasi
            btnPlus.Click += btnPlus_Click;
            btnEquals.Click += btnEquals_Click;

            txtOutput.Text = "";
        }

        // Event semua tombol angka
        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtOutput.Text = input;
        }

        // Tombol '+'
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input, out angka1))
            {
                operasi = '+';
                input = ""; // kosongkan input untuk angka ke-2
                txtOutput.Text = ""; // bersihkan tampilan
            }
        }

        // Tombol '='
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input, out angka2))
            {
                int hasil = 0;

                if (operasi == '+')
                {
                    hasil = angka1 + angka2;
                }

                txtOutput.Text = hasil.ToString();
                input = ""; // reset input
            }
        }
    }
}
