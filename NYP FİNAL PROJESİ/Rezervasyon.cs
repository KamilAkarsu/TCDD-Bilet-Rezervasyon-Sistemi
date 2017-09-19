using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGridViewKullanımı
{
    public class Rezervasyon
    {
        private float puan { get; set; }
        public float Puan { get { return puan; } }
        protected int seferFiyati { get; set; }
        public int SeferFiyati { get { return seferFiyati; } }

       
        
       
        public virtual int  fiyatHesapla()
        {
            seferFiyati = 1;
            return seferFiyati;
        }
    }
}
