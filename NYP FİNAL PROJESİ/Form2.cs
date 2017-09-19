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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        int ys = Form1.yolcuSayisi;
        Sefer sefer = new Sefer();
        Koltuk koltuk = new Koltuk();

        
        
        public static string ad, soyad;
        public static long tc;
        public static string tur;
        public static int koltukNumarasi;
        public static int ogrSayisi=0;
        public static int tamSayisi=0;
        




        private void button1_Click(object sender, EventArgs e)
        {

            koltuk.numara = Convert.ToInt16(comboBox2.SelectedItem);
            sefer.kalkisYeri = Form1.kalkis;
            sefer.varisYeri = Form1.varis;
            sefer.gidisTarihi = Form1.gidisTarihi;
            sefer.donusTarihi = Form1.donusTarihi;

            
            if ((comboBox1.SelectedItem != null && comboBox2.SelectedItem != null) && ((textBox1.Text != null) && (textBox2.Text != null) && (textBox3.Text != null)))
            {
                string kelime = Convert.ToString(comboBox1.SelectedItem);
                if (kelime == "Öğrenci")
                    ogrSayisi++;
                else
                    tamSayisi++;
            
                if (ys != 0)
                {
                    int a = dataGridView1.Rows.Add();

                    dataGridView1.Rows[a].Cells[0].Value = koltuk.numara;
                    dataGridView1.Rows[a].Cells[1].Value = textBox1.Text.ToUpper();
                    dataGridView1.Rows[a].Cells[2].Value = textBox2.Text.ToUpper();
                    dataGridView1.Rows[a].Cells[3].Value = textBox3.Text;
                    dataGridView1.Rows[a].Cells[4].Value = sefer.kalkisYeri.ToUpper();
                    dataGridView1.Rows[a].Cells[5].Value = sefer.varisYeri.ToUpper();
                    dataGridView1.Rows[a].Cells[8].Value = Convert.ToString(comboBox1.SelectedItem).ToUpper();

                    if (Form1.tekYon == true)
                    {
                        dataGridView1.Rows[a].Cells[6].Value = sefer.gidisTarihi;
                        dataGridView1.Rows[a].Cells[7].Value = "\t---------";
                        
                    }
                    else if (Form1.tekYon == false)
                    {
                        dataGridView1.Rows[a].Cells[6].Value = sefer.gidisTarihi;
                        dataGridView1.Rows[a].Cells[7].Value = sefer.donusTarihi;
                    }

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();


                    if (ys == 1)
                    {
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox3.Visible = false;
                        comboBox1.Visible = false;
                        comboBox2.Visible=false;
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label5.Visible = false;
                        label7.Visible = false;
                        button2.Visible = true;
                        button1.Visible = false;
                        progressBar1.Show();
                        label6.Visible = true;
                    }
                    ys -= 1;
                    
                }
            }
            else
            {
                MessageBox.Show("Lütfen Eksik Bilgileri Doldurunuz", "EKSİK BİLGİ MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comboBox2.Items.Remove(koltuk.numara.ToString());
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            progressBar1.Visible = false;
            label6.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= ys; i++)
            {
                ad = dataGridView1.Rows[i].Cells[1].Value.ToString();
                soyad = dataGridView1.Rows[i].Cells[2].Value.ToString();
                tc = Convert.ToInt64(dataGridView1.Rows[i].Cells[3].Value.ToString());
                tur = Convert.ToString(dataGridView1.Rows[i].Cells[8].Value.ToString());
            }
            
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
