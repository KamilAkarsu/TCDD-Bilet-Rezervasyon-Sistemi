using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGridViewKullanımı
{ 
    public class Sefer : Rezervasyon
    {
        public List<Koltuk> koltuk = new List<Koltuk>();

        public List<Sefer> sefer = new List<Sefer>();

       
        
        public string kalkisYeri { get; set; }      
        public string varisYeri { get; set; }       
        public DateTime gidisTarihi { get; set; }   
        public DateTime donusTarihi { get; set; }   



        public Sefer()
        {

        }
        public Sefer(string kalkisYeri,string varisYeri,DateTime kalkisZamani,DateTime varisZamani)
        {
            this.kalkisYeri = kalkisYeri;
            this.varisYeri = varisYeri;
            this.gidisTarihi = kalkisZamani;
            this.donusTarihi = varisZamani;
        }
      
        public void seferEkleme(Sefer s)
        {
            sefer.Add(s);
        }

        public string seferListele()
        {
            string temp = "";
            if (Form1.tekYon == false)
            {
                foreach (var a in sefer)
                {
                    temp += "Güzergah Bilgileri\n\nKalkılacak Şehir : " + a.kalkisYeri + "\nVarılacak Şehir : " + a.varisYeri +
                    "\nGidiş Zamanı : " + a.gidisTarihi.ToString() + "\nDönüş Zamanı : " + a.donusTarihi.ToString();
                }
            }
            else if (Form1.tekYon == true)
            {
                foreach (var a in sefer)
                {
                    temp += "Güzergah Bilgileri\n\nKalkılacak Şehir : " + a.kalkisYeri + "\nVarılacak Şehir : " + a.varisYeri +
                    "\nGidiş Zamanı : " + a.gidisTarihi.ToString();
                }
            }
            return temp;

        }
        
    }
}
