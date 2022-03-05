using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //mengubah title window
            this.Text = "Kalkulator";
            //change size dan posisi form ke tengah display
            this.Size = new Size(300, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        float num1, ans;
        int count;

        private void button2_Click(object sender, EventArgs e) // tombol 2
        {
            label1.Text = label1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e) // tombol 4
        {
            label1.Text = label1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e) // tombol 6
        {
            label1.Text = label1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e) // tombol 7
        {
            label1.Text = label1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e) // tombol 8
        {
            label1.Text = label1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e) // tombol " + "
        {
            num1 = float.Parse(label1.Text);
            label1.Text = "";
            count = 2;
        }

        private void button1_Click(object sender, EventArgs e) // tombol 1
        {
            label1.Text = label1.Text + "1";
        }

        private void label1_Click(object sender, EventArgs e) // label untuk menampilkan hasil
        { }

        private void button12_Click(object sender, EventArgs e) // tombol " = "
        {
            compute(count);
        }

        public void compute(int count) // fungsi pertambahan
        {
            ans = num1 + float.Parse(label1.Text);
            label1.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e) // tombol 3
        {
            label1.Text = label1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e) // tombol 5
        {
            label1.Text = label1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e) // tombol 9
        {
            label1.Text = label1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e) // tombol 0
        {
            label1.Text = label1.Text + "0";
        }
    }
}
