using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class HibasIsbnSzamException:Exception
    {
        string hibasISBNszam;
        string hibasAdat;
        string hibasSzerzo;
        string hibasCim;
        int hibasKiadasiEv;
        string hibasNyelv;
        bool hibasEnciklopedia;
        char hibaseBook;
        string hibasLeltariSzam;

        public string HibasISBNSzam
        {
            get { return hibasISBNszam; }
            set { hibasISBNszam = value;}
        }

        public string HibasAdat
        {
            get { return hibasAdat;}
            set { hibasAdat = value;}
        }

        public string HibasSzerzo
        {
            get { return HibasSzerzo; }
            set { hibasSzerzo = value; }
        }

        public string HibasCim
        {
            get { return HibasCim; }
            set { hibasCim = value; }
        }

        public int HibasKiadasiEv
        {
            get { return HibasKiadasiEv; }
            set { hibasKiadasiEv = value;}
        }

        public string HibasNyelv
        {
            get { return HibasNyelv; }
            set { hibasNyelv = value; }
        }

        public bool HibasEnciklopedia
        {
            get { return HibasEnciklopedia; }
            set { hibasEnciklopedia = value; }
        }

        public char HibaseBook
        {
            get { return HibaseBook; }
            set { hibaseBook = value; }
        }

        public string HibasLeltariSzam
        {
            get { return HibasLeltariSzam; }
            set { HibasLeltariSzam = value; }
        }
        public HibasIsbnSzamException(string hibasISBNszam, string hibasAdat, string hibasSzerzo, string hibasCim, int hibasKiadasiEv, string hibasNyelv, bool hibasEnciklopedia, char hibaseBook, string hibasLeltariSzam)
        {
            HibasISBNSzam = hibasISBNszam;
            HibasAdat = hibasAdat;
            HibasSzerzo= hibasSzerzo;
            HibasCim= hibasCim;
            HibasKiadasiEv=hibasKiadasiEv;
            HibasNyelv=hibasNyelv;
            HibasEnciklopedia=hibasEnciklopedia;
            HibaseBook = hibaseBook;
            HibasLeltariSzam=hibasLeltariSzam;

        }
    }
}
