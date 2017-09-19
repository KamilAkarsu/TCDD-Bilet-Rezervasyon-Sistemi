using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridViewKullanımı
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        private void Form5_Load(object sender, EventArgs e)
        {
            label6.BorderStyle = BorderStyle.Fixed3D;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label13.BorderStyle = BorderStyle.Fixed3D; 

            
            label4.Text = Form1.kalkis;
            label5.Text = Form1.varis;
            label9.Text = Form1.yolcuSayisi.ToString();
            label7.Text = Form3.biletno.ToString();
            if (Form1.tekYon == true)
            {
                label11.Text = "Tek Yön";
                label14.Text = Form1.gidisTarihi.ToString();
                label15.Text = "----";
            }
            else
            {
                label11.Text = "Gidiş/Dönüş";
                label14.Text = Form1.gidisTarihi.ToString();
                label15.Text = Form1.donusTarihi.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            this.Hide();
            frm6.Show();
        }

       
    }
}
