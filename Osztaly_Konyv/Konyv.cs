using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Konyv
    {
        public string isbnSzam;
        public string szerzo;
        public string muCime;
        public int kiadasiEv;
        public string nyelv;
        public bool enciklopedia;
        public char eBook;

        public string IsbnSzam
        {
            get { return isbnSzam; }
            set {
                if (IsbnSzam.Length==10) 
                {
                    throw new Osztaly_Konyv.Exceptions.HibasIsbnSzamException();
                }
                else
                {
                    IsbnSzam = value;
                }
            }
        }

        public string Szerzo
        {
            get { return szerzo; }
            set { szerzo = value; }
        }

        public string MuCime
        {
            get { return muCime; }
            set { muCime = value; }
        }

        public int KiadasiEv
        {
            get { return kiadasiEv; }
            set { kiadasiEv = value; }
        }

        public string Nyelv
        {
            get { return nyelv; }
            set { nyelv = value; }
        }

        public bool Enciklopedia
        {
            get { return enciklopedia; }
            set { enciklopedia = value; }
        }

        public char EBook
        {
            get { return eBook; }
            set { eBook = value; }
        }

        public Konyv(long isbnSzam, string szerzo, string muCime, int kiadasiEv, string nyelv, bool enciklopedia, char eBook)
        {
            IsbnSzam = (int)isbnSzam;
            Szerzo = szerzo;
            MuCime = muCime;
            KiadasiEv = kiadasiEv;
            Nyelv = nyelv;
            Enciklopedia = enciklopedia;
            EBook = eBook;
        }

        public Konyv()
        {

        }

        ~Konyv() //destruktor <--> konstruktor
        {
            Console.WriteLine("...");
        }
    }
}
