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

        public HibasIsbnSzamException(string hibasISBNszam, string hibasAdat)
        {
            HibasISBNSzam = hibasISBNszam;
            HibasAdat = hibasAdat;
        }
    }
}
