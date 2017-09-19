using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGridViewKullanımı
{
    public class Ogrenci :Yolcu
    {
        public Ogrenci()
        {

        }
        public override int fiyatHesapla()
        {
            seferFiyati = base.fiyatHesapla();
            return seferFiyati;
        }
    }
}
