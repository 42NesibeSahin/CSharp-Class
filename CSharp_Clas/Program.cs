using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Clas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisanlar kisi1 = new Calisanlar();
            kisi1.Ad = "Nesibe";
            kisi1.Soyad = "şahin";
            kisi1.no = 123456;
            kisi1.depertman = "yazılımcı";

            Calisanlar kisi2 = new Calisanlar();
            kisi2.Ad = "deneme ad";
            kisi2.Soyad = "deneme soyad";
            kisi2.no = 789456;
            kisi2.depertman = "deneme depertamanı";

            kisi1.CalisanBilgileri();
            Console.WriteLine("\n*****************\n");
            kisi2.CalisanBilgileri();


            Console.ReadLine();
        }
    }
     class Calisanlar
     { 
        public string Ad;
        public string Soyad;
        public int no;
        public string depertman;
        
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı :" + Ad);
            Console.WriteLine("Çalışanın Soyadı :" + Soyad);
            Console.WriteLine("Çalışanın Numarası :" + no);
            Console.WriteLine("Çalışanın Depertmanı :" + depertman);
        }

     }
}
