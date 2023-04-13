using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Osztaly_Konyv.Exceptions;

namespace Osztaly_Konyv
{
    public class Konyv
    {
        private string isbnSzam;
        private string szerzo;
        private string cim;
        private int _kiadasEv;
        private string nyelv;
        private bool enciklopediae;
        private char eBook;
        private string leltariSzam;
        private Random rand = new Random();

        public string IsbnSzam
        {
            get => isbnSzam;
            set
            {
                if (value.Length != 10 && value.Length != 13)
                {
                    throw new HibasIsbnSzamException(value.Length);
                }
                switch (value.Length)
                {
                    case 10:
                        int szam3 = 0;
                        int n3 = 10;
                        int oszto = 0;
                        for (int i = 0; i < 9; i++)
                        {
                            if (n3 >= 2 && n3 <= 10)
                            {
                                szam3 += n3 * int.Parse(value[i].ToString());
                                n3--;

                            }
                        }
                        while ((oszto * 11) < szam3)
                        {
                            oszto++;
                        }
                        if ((oszto * 11) - szam3 != int.Parse(value[9].ToString()))
                        {
                            throw new HibasIsbnSzamException();
                        }
                        break;
                    case 13:
                        int szam2 = 0;
                        int n2;
                        for (int i = 0; i < 12; i++)
                        {
                            if (i % 2 == 0)
                            {
                                n2 = 1;
                                szam2 += n2 * int.Parse(value[i].ToString());
                            }
                            else
                            {
                                n2 = 3;
                                szam2 += n2 * int.Parse(value[i].ToString());
                            }
                        }
                        if (szam2 % 10 != int.Parse(value[12].ToString()))
                        {
                            throw new HibasIsbnSzamException();
                        }

                        break;
                    default:
                        break;
                }
                isbnSzam = value;

            }
        }

        public string Szerzo 
        {
            get => szerzo; 
            set
            {
                if (value.Length<6)
                {
                    throw new Exception(value.Length);
                }
                szerzo = value;
            }
        }
        public string Cim 
        {
            get => cim;
            set
            {
                if (value.Lenght < 1)
                {
                    throw new Exception(value.Length);
                }
                cim = value;
            }
        }
        public int KiadasEv 
        {
            get => _kiadasEv; 
            set
            {
                for (int i = -10000; i < 2023; i++)
                {
                    if(i<-10000 && i>2023)
                    {
                        throw new Exception(value);
                    }
                    
                }
                _kiadasEv = value;
            }
        }
        public string Nyelv 
        {
            get => nyelv;
            set
            {
                if (value=="") 
                {
                    throw new Exception(value);
                }
                nyelv = value;
            }
        }
        public bool Enciklopediae 
        {
            get => enciklopediae;
            set
            {
                if (value!=true || value!=false)
                {
                    throw new Exception(value);
                }
                enciklopediae = value;
            }
        }
        public char Ebook 
        {
            get => eBook;
            set
            {
                if(value!='i' || value!='i')
                {
                    throw new Exception();
                }
                eBook = value;
            }
        }
        public string LeltariSzam
        {
            get => leltariSzam;
            set
            {
                if (value.Length!=11)
                {
                    throw new HibasIsbnSzamException(value.Length);
                }
                leltariSzam= value;
            }
        }

        public Konyv()
        {

        }

        public Konyv(string isbnSzam, string szerzo, string cim, int kiadasEv, string nyelv, bool enciklopediae, char ebook, string leltariSzam)
        {
            IsbnSzam = isbnSzam;
            Szerzo = szerzo;
            Cim = cim;
            KiadasEv = kiadasEv;
            Nyelv = nyelv;
            Enciklopediae = enciklopediae;
            Ebook = ebook;
            LeltariSzam=leltariSzam;
        }

        ~Konyv()
        {
            Console.WriteLine("...");
        }
    }
}