using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DictionaryMetodOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContainsKey : Koleksiyon içindeki Key'lerde aranan değer varsa True, yoksa False döndürür
            //ContainsValue
            Dictionary<string, int> KisilerveDTarihleri = new Dictionary<string, int>();

            KisilerveDTarihleri.Add("Betül", 1990);
            KisilerveDTarihleri.Add("Ali", 1950);
            KisilerveDTarihleri.Add("Veli", 1987);
            KisilerveDTarihleri.Add("Lale", 2000);
            KisilerveDTarihleri.Add("Gül", 2000);
            KisilerveDTarihleri.Add("Ayşe", 2000);

            Console.WriteLine("İsminiz: ");
            string ad = Console.ReadLine();
            bool varMi = KisilerveDTarihleri.ContainsKey(ad);

            if (varMi)
            {
                int dYili = KisilerveDTarihleri[ad];
                int yas = DateTime.Now.Year - dYili;
                Console.WriteLine(yas);
            }
            else
            {
                Console.WriteLine("Bu değer koleksiyonda yoktur. Eklemek için aşağıdaki bilgileri doldurunuz.");
                Console.WriteLine(ad + " isimli kişinin doğum yılını giriniz: ");
                int dogumYili = int.Parse(Console.ReadLine());
                KisilerveDTarihleri.Add(ad, dogumYili);
                Listele(KisilerveDTarihleri);
            }
        }

        static void Listele(Dictionary<string, int> liste)
        {
            Console.Clear();
            Console.WriteLine("Koleksiyonda " + liste.Count + " adet kayıt mevcuttur.");

            //Dictionarydeki değerleri yazdırdık
            foreach (KeyValuePair<string,int> item in liste)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            foreach (var item in liste.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in liste.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
