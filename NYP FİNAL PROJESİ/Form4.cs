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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public static float seferToplamFiyati=0;
        public static bool odemeKartIleMi;
        public static bool odemeNakitIleMi;

        private void Form4_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            label7.Visible = false;
            progressBar1.Visible = false;
            label10.Visible = false;

            Ogrenci ogrenci = new Ogrenci();
            Tam tam = new Tam();
            

            Bilet bilet = new Bilet();

            bilet.ogrenciSayisi = Form2.ogrSayisi;
            bilet.tamSayisi = Form2.tamSayisi;


            int ogrenciTutar = ((ogrenci.fiyatHesapla())*(bilet.ogrenciSayisi)*(Form1.seferFiyati));
            int tamTutar = ((tam.fiyatHesapla())*(bilet.tamSayisi)*(Form1.seferFiyati));

            if (Form1.tekYon == true)
            {
                seferToplamFiyati = (ogrenciTutar + tamTutar);
            }
            else
                seferToplamFiyati = 2 * (ogrenciTutar + tamTutar);

            label9.Text = "Alışverişinizden Elde Edeceğiniz Puan/TL ' niz : " +  (seferToplamFiyati/1000) + " TL'dir.\nPuanınızı Kullanmak İster Misiniz?";
            label4.Text =(bilet.ogrenciSayisi.ToString());
            label5.Text = (bilet.tamSayisi.ToString());
            label6.Text =(seferToplamFiyati.ToString());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            if ((radioButton1.Checked == true || radioButton2.Checked == true))
            {
                if ((radioButton3.Checked == true || radioButton4.Checked == true))
                {
                    if (radioButton1.Checked)
                    {
                        odemeKartIleMi = true;
                    }
                    else
                    {
                        odemeNakitIleMi = true;
                    }

                    
                }
                else
                    MessageBox.Show("Lütfen Puanınızı kullanıp,kullanmayacağınızı seçiniz...");
            }
            else
                MessageBox.Show("Lütfen Ödeme Tipini Seçiniz...", "Ödeme Tipi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label7.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Value = 10;
            progressBar1.Value = 20;
            progressBar1.Value = 30;
            progressBar1.Value = 40;
            progressBar1.Value = 50;
            progressBar1.Value = 60;
            progressBar1.Value = 70;
            progressBar1.Value = 80;
            progressBar1.Value = 90;
            progressBar1.Value = 100;
            button1.Hide();
            button2.Visible = true;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            label10.Visible = true;
            label10.Text = "Puanlarınızı Kullanmak İstemediniz.Bilet Fiyatınız : " + seferToplamFiyati.ToString() + " TL dir.";
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            label10.Visible = true;
            label10.Text = "Güncel Bilet Fiyatınız : " + (seferToplamFiyati - (seferToplamFiyati / 1000)).ToString() + " TL dir.";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            this.Hide();
            frm5.Show();
        }

       
        
    }
}
