using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AutokGetterSetter12A.Model
{
    internal class Auto
    {
        private string _marka;
        private string _tipus;
        private string _szin;
        private static int _darabszamJarmu;
        private static int _szemelyautoDarab;
        private static int _sportautoDarab;
        private static int _ismeretlenDarab;



        public Auto(string marka, string tipus, string szin)
        {
            Marka = marka;
            Tipus = tipus;
            Szin = szin;
            DarabszamJarmu++;
            if (Marka == "ismeretlen")
            {
                IsmeretlenDarab++;
            }
            else if (Marka.ToLower() == "ferrari")
            {
                SportautoDarab++;
            }
            else { SzemelyautoDarab++; }

        }
        public string Marka { 
            get => _marka; 
            set 
            {
                string kisbetus = value.ToLower();
                if (kisbetus == "derbi" || kisbetus == "aprilia" || kisbetus == "kawasaki")
                {

                }
            }
        }
        public string Tipus { get => _tipus; set => _tipus = value; }
        public string Szin { get => _szin; set => _szin = value; }
        public static int DarabszamJarmu { get => _darabszamJarmu; set => _darabszamJarmu = value; }
        public static int SzemelyautoDarab { get => _szemelyautoDarab; set => _szemelyautoDarab = value; }
        public static int SportautoDarab { get => _sportautoDarab; set => _sportautoDarab = value; }
        public static int IsmeretlenDarab { get => _ismeretlenDarab; set => _ismeretlenDarab = value; }
    }
}
