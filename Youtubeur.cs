using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialiser
{
    internal class Youtubeur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string TitreChaine { get; set; }
        public List<VideoYoutube> videos { get; set; }
    }
}
