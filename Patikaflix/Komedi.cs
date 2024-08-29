using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    public class KomediDizi
    {
        public string DiziAdi { get; set; }
        public string DiziTuru { get; set; }
        public string Yonetmen { get; set; }

        public KomediDizi(string diziAdi, string diziTuru, string yonetmen)
        {
            DiziAdi = diziAdi;
            DiziTuru = diziTuru;
            Yonetmen = yonetmen;
        }
    }
}

