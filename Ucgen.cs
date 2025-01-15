using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Pratik
{
    public class Ucgen : BaseGeometrikSekil
    {
        public override void AlanHesapla(int yukseklik, int genislik) // temel sınıftaki metodu override edip metodun içerisini üçgen hesabı için değiştiriyoruz.
        {
            Console.WriteLine("Üçgen:");
            Console.WriteLine("Alan: "+(genislik*yukseklik)/2); 
        }
    }
}
