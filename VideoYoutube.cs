using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialiser
{
    internal class VideoYoutube
    {
        public string Titre { get; set; }
        public int Duree { get; set; }
        public Youtubeur Youtubeur { get; set; }
        public List<string> Tags { get; set; }
    }
}
