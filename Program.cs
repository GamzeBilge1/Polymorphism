
using Polymorphism_Pratik;

BaseGeometrikSekil geometrikSekil = new Kare(); // Kare sınıfından bir nesne üretiyoruz ancak temel sınıf (BaseGeometrikSekil) türünde bir referans kullanıyoruz.
                                                // Bu, polimorfizm sağlıyor.
geometrikSekil.AlanHesapla(6,6);

BaseGeometrikSekil geometrikSekil2 = new Dikdortgen(); // Dikdörtgen sınıfından bir nesne üretiyoruz ancak temel sınıf (BaseGeometrikSekil) türünde bir referans kullanıyoruz.
geometrikSekil2.AlanHesapla(6, 7);


BaseGeometrikSekil geometrikSekil3 = new Ucgen();// Üçgen sınıfından bir nesne üretiyoruz ancak temel sınıf (BaseGeometrikSekil) türünde bir referans kullanıyoruz.
geometrikSekil3.AlanHesapla(6, 8);