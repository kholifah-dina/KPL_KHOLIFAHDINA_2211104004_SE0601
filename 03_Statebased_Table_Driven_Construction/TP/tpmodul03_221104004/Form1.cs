using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul03_221104004
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Cek apakah input tidak kosong
            if (!string.IsNullOrWhiteSpace(input))
            {
                label1.Text = "Halo " + input;
            }
            else
            {
                label1.Text = "Silakan masukkan nama Anda.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
