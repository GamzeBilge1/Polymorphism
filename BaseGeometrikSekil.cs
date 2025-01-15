using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Pratik
{
    public class BaseGeometrikSekil //temel sınıf 
    { 
         //propertyler
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        // Alan Hesaplama Metodu
        public virtual void AlanHesapla(int yukseklik, int genislik)  // üçgende alan hesabını değiştirebilmek , override edebilmek için virtual tanımlıyoruz
        {
            Console.WriteLine("alan: "+yukseklik*genislik);
        }

    }
}
