using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul12_2211104004
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int CariNilaiPangkat(int a, int b)
        {
            // Aturan khusus
            if (b == 0) return 1;
            if (b < 0) return -1;
            if (b > 10 || a > 100) return -2;

            try
            {
                checked
                {
                    int hasil = 1;
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                    return hasil;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtInput1.Text, out a) && int.TryParse(txtInput2.Text, out b))
            {
                int hasil = CariNilaiPangkat(a, b);
                lblHasil.Text = $"Hasil: {hasil}";
            }
            else
            {
                lblHasil.Text = "Input tidak valid";
            }
        }
    }
}
