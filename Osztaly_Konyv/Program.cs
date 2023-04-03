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
            bool enciklopedia = ;
            char eBook = char.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy ISBN számot: ");

            try
            {
                konyvek.Add(new Konyv());
            }
            catch (HibasIsbnSzamException e)
            {
                hibak.Add($"Hibás ISBN szám: {e.HibasISBNSzam}\nHibás adat: {e.HibasAdat}");
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

            for (int i = 0; i < 100; i++)
            {
                Konyv egyKonyv = new Konyv(11111111111, "a", "ab", 2002, "m", false, 'n');
                Console.WriteLine(i);
            }
            int szorzo=(int)Math.Ceiling()

            Console.ReadKey();
        }
    }
}
