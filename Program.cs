using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonSerialiser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var youtubeur = new Youtubeur()
            {
                Nom = "VloggerDeFrance",
                Prenom="Charles",
                TitreChaine="Ma chaine de vlogs"
            };

            var videos = new List<VideoYoutube>
            {
                new VideoYoutube{Titre="Mamami", Duree=50, Youtubeur=youtubeur, Tags=new List<string>{"Voyage","Espagne"} },
                new VideoYoutube{Titre="Black", Duree=80, Youtubeur=youtubeur, Tags=new List<string>{"Street","France"} },
                new VideoYoutube{Titre="Charlemagne", Duree=60, Youtubeur=youtubeur, Tags=new List<string>{"Ville","Europe"} }
            };

            youtubeur.videos=videos;

            var json=JsonSerializer.Serialize(youtubeur, new JsonSerializerOptions { ReferenceHandler=ReferenceHandler.Preserve, WriteIndented=true, Encoder= JavaScriptEncoder.UnsafeRelaxedJsonEscaping});

            Console.WriteLine(json);
        }
    }
}
