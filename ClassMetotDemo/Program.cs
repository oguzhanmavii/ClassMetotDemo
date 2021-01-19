using System;

namespace ClassMetotDemo
{
   public class Program
    {
       public static void Main(string[] args)
        {
          
            Musteri  musteri = new Musteri();

            MusteriManager manager = new MusteriManager();
          
            anamenu:
            int secim;

            Console.WriteLine("1-Müsteri Ekleme\n2-Müsteri Listeleme\n3-Müsteri Silme");

            secim = Convert.ToInt32(Console.ReadLine());
         
            switch(secim)
            {
                case 1:
                    manager.Ekle(musteri);
                    break;

                case 2:

                    manager.listeleme(musteri);
                    break;

                case 3:
                    manager.Sil(musteri);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nLütfen bastıgınız tuşu kontrol ediniz ve tekrar giriniz Böyle bir seçim bulunamadı !");                   
                    goto anamenu;
                    break;
                    
            }
        }
    }
}
