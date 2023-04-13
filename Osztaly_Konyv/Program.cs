using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {
        static List<Konyv> konyvek = new List<Konyv>();
        static void Main(string[] args)
        {
            List<string> hibak = new List<string>();
            string isbnSzam = Console.ReadLine();
            string szerzo = Console.ReadLine();
            string muCime = Console.ReadLine();
            int kiadasiEv = int.Parse(Console.ReadLine());
            string nyelv = Console.ReadLine();
            bool enciklopedia = bool.Parse(Console.ReadLine());
            char eBook = char.Parse(Console.ReadLine());
            string leltariSzam = Console.ReadLine();
            Console.WriteLine("Adj meg egy ISBN számot: ");

            try
            {
                konyvek.Add(new Konyv());
            }
            catch (HibasIsbnSzamException e)
            {
                hibak.Add($"Hibás ISBN szám: {e.HibasISBNSzam}\nHibás adat: {e.HibasAdat}\nHibás szerző: {e.HibasSzerzo}\nHibás cím: {e.HibasCim}\nHibás kiadási év: {e.HibasKiadasiEv}\nHibás nyelv: {e.HibasNyelv}\nHibás enciklopédia: {e.HibasEnciklopedia}\nHibás eBook: {e.HibaseBook}\nHibás leltári szám: {e.HibasLeltariSzam}");
                Console.WriteLine(e.Message);
            }

            //Konyv osztály
            //isbnSzam
            //szerzők
            //mű címe
            //kiadási éve
            //nyelv
            //enciklopedia - bool
            //eBook - i/n (char)

            /*for (int i = 0; i < 100; i++)
            {
                Konyv egyKonyv = new Konyv("11111111111", "a", "ab", 2002, "magyar", false, 'n');
                Console.WriteLine(i);
            }
            int szorzo=(int)Math.Ceiling()*/

            KonyvesPolc konyvesPolc1 = new KonyvesPolc();

            try
            {
                Konyv konyv1 = new Konyv("0306406152", "Szerző 1", "Cím 1", 2023, "Magyar", true, 'n', "12345678901");
                Konyv konyv2 = new Konyv("0306406152", "Szerző 1", "Cím 1", 2018, "Magyar", false, 'n', "24397586410");
                konyvesPolc1.konyvHozzaAdasa(konyv1);
                konyvesPolc1.konyvHozzaAdasa(konyv2);
            }
            catch (HibasIsbnSzamException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int konyvszam = konyvesPolc1.konyvekSzama;
            Console.WriteLine(konyvszam);
            Console.WriteLine(konyvesPolc1.konyvekSzama);
            Console.WriteLine(konyvesPolc1.konyvekSzamaFuggveny());




            Console.ReadKey();
        }
    }
}
