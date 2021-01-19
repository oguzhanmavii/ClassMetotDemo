using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
   public class MusteriManager
    {


        public void Ekle(Musteri musteri)
        {       
            Console.Write("Müsterinin Üye Numarasını giriniz :");
            musteri.Id = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("Musterinin Adini giriniz  :");
            musteri.Ad = Convert.ToString(Console.ReadLine());
            Console.Write("Müsterinin Soyadini giriniz  :");
            musteri.Soyad = Convert.ToString(Console.ReadLine());
            Console.Write("Müsterinin Mesleğini giriniz :");
            musteri.Meslek = Convert.ToString(Console.ReadLine());
            Console.Write("Müsterinin Yaşını giriniz  :");
            musteri.Yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Müsterinin Maaşını giriniz  ");
            musteri.Maas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMüsteri Basarili Bir Şekilde Eklendi..");
           
        }

        public void Sil(Musteri musteri)
        {
            Console.Write("Müsterinin Üye Numarasını giriniz :");
            musteri.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Musterinin Adini giriniz  :");
            musteri.Ad = Convert.ToString(Console.ReadLine());
            Console.Write("Müsterinin Soyadini giriniz  :");
            musteri.Soyad = Convert.ToString(Console.ReadLine());
            Console.Write("Müsterinin Mesleğini giriniz :");
            musteri.Meslek = Convert.ToString(Console.ReadLine());
            Console.Write("Müsterinin Yaşını giriniz  :");
            musteri.Yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Müsterinin Maaşını giriniz  ");
            musteri.Maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMüsteri Basarili Bir Şekilde Silindi..");

        }

        public void listeleme(Musteri musteri)
        {
            int ıd, yas, maas;
            string ad, soyad, meslek;
            Console.Write("Müsterinin Üye Numarasını giriniz :");
            ıd=  musteri.Id = Convert.ToInt32(Console.ReadLine());
             Console.Write("Musterinin Adini giriniz  :");
            ad= musteri.Ad = Convert.ToString(Console.ReadLine());
            Console.Write("Müsterinin Soyadini giriniz  :");
            soyad= musteri.Soyad = Convert.ToString(Console.ReadLine());
            Console.Write("Müsterinin Mesleğini giriniz :");
            meslek= musteri.Meslek = Convert.ToString(Console.ReadLine());
            Console.Write("Müsterinin Yaşını giriniz  :");
            yas= musteri.Yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Müsterinin Maaşını giriniz  ");
            maas= musteri.Maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(ıd + "\n" + ad + "\n" + soyad + "\n" + meslek + "\n" + yas + "\n" + maas);
            Console.WriteLine("\nMüsteri Basarili Bir Şekilde Listelendi.. ");

        }

    }
}
