using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGridViewKullanımı
{
    public class Yolcu : Rezervasyon
    {
        public string ad { get; set; }      
        public string soyAd { get; set; }   
        public long tcNo { get; set; }      
       
        public string yolcuTuru { get; set; } 


        public List<Yolcu> yolcuListesi = new List<Yolcu>();
        
        public Yolcu()
        {
                
        }
        public Yolcu(string ad,string soyAd,long tcNo,string yolcuTuru)
        {
            this.ad = ad;
            this.soyAd = soyAd;
            this.tcNo = tcNo;
            this.yolcuTuru = yolcuTuru;
        }

      
        public void yolcuEkle(Yolcu y)
        {
            yolcuListesi.Add(y);
        }
      
        public  string YolcuListele()
        {
            string temp = "";
            foreach (var x in yolcuListesi)
            {
                temp += "Bileti Alanın\n\nAdı : " + x.ad + "\nSoyadı : " + x.soyAd +
                "\nTC Numarası : " + x.tcNo.ToString() + "\nBilet Tipi : " +
                x.yolcuTuru + "\nRezerve Ettiği Koltuk Sayısı : " + Form1.yolcuSayisi.ToString(); ;
            }
            return temp;
        }

    }
}


       