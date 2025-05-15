using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul12_2211104004
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }
        private void btnCek_Click(object sender, EventArgs e)
        {
            int angka;
            if (int.TryParse(txtInput.Text, out angka))
            {
                string hasil = CariTandaBilangan(angka);
                lblHasil.Text = $"Tanda: {hasil}";
            }
            else
            {
                lblHasil.Text = "Input tidak valid";
            }
        }


    }
}
