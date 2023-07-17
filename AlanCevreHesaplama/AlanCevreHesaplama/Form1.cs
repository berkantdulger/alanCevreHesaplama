using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanCevreHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Uzun kenarı giriniz";
            label2.Text = "Kısa kenarı giriniz";
            button1.Text = "hesapla";
            label3.Text = "";
            radioButton1.Text = "alan hesapla";
            radioButton2.Text = "çevre hesapla";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int kisaKenar = int.Parse(textBox1.Text);
            int uzunKenar = int.Parse(textBox2.Text);
            if (radioButton1.Checked)
            {
                kisaKenar = kisaKenar * uzunKenar;
                label3.Text = "alan:" + kisaKenar;
            }
            else if (radioButton2.Checked)
            {
                kisaKenar = 2 * (kisaKenar + uzunKenar);
                label3.Text = "çevre:" + kisaKenar;

            }
            else {

                MessageBox.Show("lütfen hangi işlem yapılacağını seçiniz");
            
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
