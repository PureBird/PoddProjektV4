using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PoddProjektV4.Models
{
    public class Podcast
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("titel")]
        public string Titel { get; set; }

        [BsonElement("beskrivning")]
        public string Beskrivning { get; set; }

        [BsonElement("kategori")]
        public string Kategori { get; set; } = "";

        [BsonElement("poddAvsnitt")]
        public List<Avsnitt> PoddAvsnitt { get; set; }
        public Podcast() { }

        public Podcast(string id, string titel, string beskrivning, string kategori, List<Avsnitt> poddAvsnitt) 
        {
            Id = id;
            Titel = titel;
            Beskrivning = beskrivning;
            Kategori = kategori;
            PoddAvsnitt = poddAvsnitt;
        }

    }
}
