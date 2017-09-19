using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGridViewKullanımı
{
    public class Bilet : Rezervasyon
    {
        public string biletNo { get; set; } 
        public int ogrenciSayisi { get; set; }
        public int  tamSayisi { get; set; }
        public int fiyat { get; set; }
    }
}
