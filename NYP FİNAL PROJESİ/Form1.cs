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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static int yolcuSayisi;
        public static string kalkis, varis;
        public static bool tekYon;
        public static DateTime gidisTarihi;
        public static DateTime donusTarihi;
        public static int seferFiyati;
        public static float birikenToplamPuan;
        

        private void button1_Click(object sender, EventArgs e)
        {

            kalkis = Convert.ToString(comboBox1.SelectedItem);
            varis = Convert.ToString(comboBox2.SelectedItem);

            if (kalkis == "İstanbul" && varis == "Ankara")
                seferFiyati = 70;
            else if (kalkis == "İstanbul" && varis == "İzmir")
                seferFiyati = 70;
            else if (kalkis == "Ankara" && varis == "İstanbul")
                seferFiyati = 80;
            else if (kalkis == "Ankara" && varis == "İzmir")
                seferFiyati = 80;
            else if (kalkis == "İzmir" && varis == "Ankara")
                seferFiyati = 90;
            else if (kalkis == "İzmir" && varis == "İstanbul")
                seferFiyati = 90;
           




            if (dateTimePicker1.Value < dateTimePicker2.Value)
            {
                if ((comboBox1.SelectedItem != comboBox2.SelectedItem))
                {
                    if ((comboBox1.SelectedItem != null) && (comboBox2.SelectedItem != null) && (comboBox3.SelectedItem != null) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                    {
                        

                        yolcuSayisi = Convert.ToInt16(comboBox3.SelectedItem);

                        Form2 frm2 = new Form2();
                        this.Hide();
                        frm2.Show();
                    }
                    else
                        MessageBox.Show("Lütfen Bilgilerinizi Tam giriniz");
                }
                else
                    MessageBox.Show("Lütfen\nGidiş-Dönüş Tarihlerini\nAynı Olmayacak Şekilde Seçiniz", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Lütfen Zamanda Yolculuk Yapmaya Çalışmayınız :) :) :)", "ZAMANDA YOLCULUK HATASI", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today.AddDays(1).Date;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            dateTimePicker2.Visible = false;
            tekYon = true;
            gidisTarihi = dateTimePicker1.Value;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            dateTimePicker2.Visible = true;
            tekYon = false;
            gidisTarihi = dateTimePicker1.Value;
            donusTarihi= dateTimePicker2.Value;   
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            donusTarihi = dateTimePicker2.Value;
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gidisTarihi=dateTimePicker1.Value;
        }
        }
}
