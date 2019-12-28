using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc=1, n;
            label2.Text = "";
            try {
                n = Convert.ToInt16(textBox1.Text);
                label2.Text = n + "! = ";
                for (int i = n; i >= 1; i--)
                {
                    label2.Text += i;
                    sonuc = sonuc * i;
                    if (i != 1) {
                        label2.Text += " * ";
                    }
                }
                label2.Text += " = " + sonuc;
                
            }
            catch {
                MessageBox.Show("Lütfen sayı girin!");
                textBox1.Focus();
            }

        }
    }
}
