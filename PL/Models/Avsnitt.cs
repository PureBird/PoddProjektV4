using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace PoddProjektV4.Models
{
    public class Avsnitt
    {

        [BsonElement("titel")]
        public string Titel { get; set; }

        [BsonElement("beskrivning")]
        public string Beskrivning { get; set; }

        [BsonElement("premiarDatum")]
        public string PremiarDatum { get; set; }
        public Avsnitt() {}

        public Avsnitt(string titel, string beskrivning, string premiarDatum) 
        {
            Titel = titel;
            Beskrivning = beskrivning;
            PremiarDatum = premiarDatum;
        }


    }
}
