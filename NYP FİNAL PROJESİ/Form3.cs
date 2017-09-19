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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Random random = new Random();
        public static string biletno;
        private void Form3_Load(object sender, EventArgs e)
        {
            Bilet bilet = new Bilet();
            bilet.biletNo = random.Next(888, 999).ToString();
            biletno = bilet.biletNo.ToString();

            

            Yolcu yolcu = new Yolcu();

            yolcu.ad = Form2.ad.ToUpper();
            yolcu.soyAd = Form2.soyad.ToUpper();
            yolcu.tcNo = Convert.ToInt64(Form2.tc);
            yolcu.yolcuTuru = Form2.tur.ToUpper();
            yolcu.yolcuEkle(yolcu);
            label2.Text = yolcu.YolcuListele() +"\nBilet No : " + bilet.biletNo.ToString(); //Bilet Sahibinin ve Bilet No nun Değerini yazdırıcak

            Sefer sefer = new Sefer(Form1.kalkis, Form1.varis, Form1.gidisTarihi, Form1.donusTarihi); //Nesne Başlatıcısı

            sefer.kalkisYeri = Form1.kalkis.ToUpper();
            sefer.varisYeri = Form1.varis.ToUpper();
            sefer.gidisTarihi = Form1.gidisTarihi;
            sefer.donusTarihi = Form1.donusTarihi;
            sefer.seferEkleme(sefer);
            label3.Text =sefer.seferListele(); //Güzergah ve Tarih Bilgilerini yazdırıcak

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2=new Form2();
            this.Hide();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
