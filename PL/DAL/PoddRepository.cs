using MongoDB.Driver;
using PoddProjektV4.Models;
using PoddProjektV4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddProjektV4.DAL
{
    public class PoddRepository : IRepository<Podcast>
    {
        private readonly MongoDBServices _mongoDBServices;
        public PoddRepository(MongoDBServices mongoDBServices)
        {
            _mongoDBServices = mongoDBServices;
        }
        public bool PodcastFinns(string ID)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, ID);

            return _mongoDBServices.podcastKollektion.Find(filter).Any();
        }
        public void LaggTill(Podcast podcast)
        {
            if (!PodcastFinns(podcast.Id))
            {
                _mongoDBServices.podcastKollektion.InsertOne(podcast);
            }
        }
        public bool Uppdatera(Podcast nyPodcast)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, nyPodcast.Id);
            var uppdatering = Builders<Podcast>.Update
                .Set(p => p.Titel, nyPodcast.Titel)
                .Set(p => p.Beskrivning, nyPodcast.Beskrivning)
                .Set(p => p.Kategori, nyPodcast.Kategori)
                .Set(p => p.PoddAvsnitt, nyPodcast.PoddAvsnitt);

            var resultat = _mongoDBServices.podcastKollektion.UpdateOne(filter, uppdatering);
            return resultat.ModifiedCount > 0;
        }
        public bool Radera(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            var resultat = _mongoDBServices.podcastKollektion.DeleteOne(filter);
            return resultat.DeletedCount > 0;
        }
        public Podcast? HamtaMedId(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            Podcast? podcastKopia = _mongoDBServices.podcastKollektion.Find(filter).FirstOrDefault();
            return podcastKopia;
        }
        public List<Podcast> HamtaAllt()
        {
            var filter = Builders<Podcast>.Filter.Empty;
            List<Podcast> listaMedPodcasts = _mongoDBServices.podcastKollektion.Find(filter).ToList();
            return listaMedPodcasts;
        }
    }
}
