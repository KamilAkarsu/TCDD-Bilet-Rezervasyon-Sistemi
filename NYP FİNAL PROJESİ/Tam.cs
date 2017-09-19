using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGridViewKullanımı
{
    public class Tam : Yolcu
    {
        public Tam()
        {

        }
        public override int fiyatHesapla()
        {
            seferFiyati = base.fiyatHesapla();
            return seferFiyati*2;
        }
    }
}
