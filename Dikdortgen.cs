using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Pratik
{
    internal class Dikdortgen : BaseGeometrikSekil
    {
        public override void AlanHesapla(int yukseklik, int genislik)
        {
            Console.WriteLine("Dikdörtgen");
            base.AlanHesapla(yukseklik, genislik); // temel sınıftaki metodu aynı şekilde kullanıyoruz.
        }
    }
}
