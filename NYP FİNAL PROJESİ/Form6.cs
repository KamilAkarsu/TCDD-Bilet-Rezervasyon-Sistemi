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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İyi Günler Dileriz","ÇIKIŞ");
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Osmanlı topraklarında demiryolunun tarihi,\n1851 yılında 211 km’lik Kahire-İskenderiye Demiryolu hattının imtiyazının verilmesiyle,bugünkü milli sınırlar içindeki demiryollarının tarihi ise 23 Eylül 1856 yılında 130 km’lik İzmir-Aydın Demiryolu hattının imtiyazının verilmesiyle başlar.\n+Osmanlı Demiryolları, bir süre Nafia Nezareti (Bayındırlık Bakanlığı)’nin Turuk ve Meabir (Yol ve İnşaat) Dairesi tarafından yönetildi. 24 Eylül 1872 tarihinde de demiryolu yapım ve işletmesini gerçekleştirmek üzere Demiryolları İdaresi kuruldu.\nOsmanlı Döneminde yapılan 4.136 km’lik bölümü bugünkü milli sınırlarımız içerisinde kaldı. Bu hatların 1.377 kilometresi devlet eliyle işletilmekteydi.\nCumhuriyetin kurulması ve demiryollarının devletleştirilmesine karar verilmesinden sonra Demiryolu işletmeciliği için 24 Mayıs 1924 tarih ve 506 sayılı Kanun ile Nafia Vekâletine (Bayındırlık Bakanlığı) bağlı “Anadolu- Bağdat Demiryolları Müdüriyeti Umumiyesi” kuruldu. Demiryolu alanında ilk bağımsız yönetim birimi olarak demiryollarının yapımı ve işletilmesinin bir arada yürütülmesini sağlamak amacıyla da 31 Mayıs 1927 tarih ve 1042 sayılı Kanun ile Nafia Vekaleti (Bayındırlık Bakanlığı)'ne bağlı “Devlet Demiryolları ve Limanları İdare-i Umumiyesi” kuruldu. Devlet Demiryolları ve Limanları İşletme Umum Müdürlüğü adıyla 1939 yılında Münakalat Vekaleti (Ulaştırma Bakanlığı)’ne bağlandı. Cumhuriyet öncesinde yapılan ve yabancı şirketler tarafından işletilen hatlar, 1928–1948 yılları arasında satın alınarak millileştirildi.\n22 Temmuz 1953 tarihine kadar katma bütçeli bir devlet idaresi şeklinde yönetilen Kuruluşumuz, bu tarihte çıkarılan 6186 sayılı Kanunla Ulaştırma Bakanlığına bağlı olarak “Türkiye Cumhuriyeti Devlet Demiryolları İşletmesi (TCDD)” adı altında İktisadi Devlet Teşekkülü haline getirildi.+\nSon olarak, 08.06.1984 tarih ve 233 sayılı KHK ile de “Kamu İktisadi Kuruluşu” hüviyetini alan ve TÜLOMSAŞ, TÜDEMSAŞ ve TÜVASAŞ olmak üzere üç adet bağlı ortaklığı bulunan TCDD, halen Ulaştırma, Denizcilik ve Haberleşme Bakanlığının ilgili kuruluşu olarak faaliyetini sürdürmektedir.\n1856 YILINDAN GÜNÜMÜZE DEMİRYOLU HATLARI\nCumhuriyet Dönemindeki özellikle demiryolunun altın çağı olarak nitelenen Cumhuriyetimizin ilk yıllarındaki demiryolu politikasını daha iyi anlamak açısından Cumhuriyet dönemi öncesinin değerlendirilmesinde yarar vardır. Çünkü geçmiş bilinmeden, bugün anlaşılamaz.+\nBu nedenle, ülkemiz demiryolu tarihi; Cumhuriyet öncesi,Cumhuriyet dönemi (1923-1950 Dönemi) ve 1950 sonrası dönem olarak üç başlık altında incelenmelidir. Bu dönemlerin belirgin özelliği; birincisinde demiryolu hatlarının büyük bölümünün yabancılara verilen imtiyazla yaptırılması, ikincisinde demiryolu ulaştırmasının altın çağı olması, üçüncüsünde ise demiryolu ulaştırmasının yok sayılması, ihmal edilmesidir.","HAKKINDA");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("T.C. DEVLET DEMİRYOLLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ\n\nAdres: Altındağ İlçesi Anafartalar Mahallesi Hipodrom Caddesi No:3 ANKARA\nTelefon: 0312 309 05 15 \nTicaret Sicil No veya MERSİS No: 0294-0034-1880-0010","İLETİŞİM BİLGİLERİ");
        }
    }
}
