using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //bu classlara model class denir

    public class Kitap
    {
        public Kitap()
        {
        }

        public Kitap(string ad, string sayfasi, string yazari)
        {
            Ad = ad;
            Sayfasi = sayfasi;
            Yazari = yazari;
        }

        //constractor
        public Kitap(int kitapId, string ad, string sayfasi, string yazari)
        {
            KitapId = kitapId;
            Ad = ad;
            Sayfasi = sayfasi;
            Yazari = yazari;
        }

        public int KitapId { get; set; }
        public string Ad { get; set; }
        public string Sayfasi { get; set; }
        public string Yazari { get; set; }
    }
}