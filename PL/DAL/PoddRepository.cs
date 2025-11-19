using MongoDB.Driver;
using PoddProjektV4.Models;
//using PoddProjektV4.BL;
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
        public bool PodcastFinns(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);

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


        public async Task<bool> PodcastFinnsAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);

            return await _mongoDBServices
                .podcastKollektion
                .Find(filter)
                .AnyAsync();
        }
        public async Task LaggTillAsync(Podcast podcast)
        {
            if (!await PodcastFinnsAsync(podcast.Id))
            {
                await _mongoDBServices
                    .podcastKollektion
                    .InsertOneAsync(podcast);
            }
        }
        public async Task<bool> UppdateraAsync(Podcast nyPodcast)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, nyPodcast.Id);

            var uppdatering = Builders<Podcast>.Update
                .Set(p => p.Titel, nyPodcast.Titel)
                .Set(p => p.Beskrivning, nyPodcast.Beskrivning)
                .Set(p => p.Kategori, nyPodcast.Kategori)
                .Set(p => p.PoddAvsnitt, nyPodcast.PoddAvsnitt);

            var resultat = await _mongoDBServices
                .podcastKollektion
                .UpdateOneAsync(filter, uppdatering);

            return resultat.ModifiedCount > 0;
        }
        public async Task<bool> RaderaAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);

            var resultat = await _mongoDBServices
                .podcastKollektion
                .DeleteOneAsync(filter);

            return resultat.DeletedCount > 0;
        }
        public async Task<Podcast?> HamtaMedIdAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);

            Podcast? podcastKopia = await _mongoDBServices
                .podcastKollektion
                .Find(filter)
                .FirstOrDefaultAsync();

            return podcastKopia;
        }
        public async Task<List<Podcast>> HamtaAlltAsync()
        {
            var filter = Builders<Podcast>.Filter.Empty;

            List<Podcast> listaMedPodcasts = await _mongoDBServices
                .podcastKollektion
                .Find(filter)
                .ToListAsync();

            return listaMedPodcasts;
        }
        /*public async Task<bool> TaBortEnKategoriFranPoddAsync(string poddId, string kategoriAttTaBort)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, poddId);
            var update = Builders<Podcast>.Update.Pull(p => p.Kategori, kategoriAttTaBort);

            var resultat = await _mongoDBServices
                .podcastKollektion
                .UpdateOneAsync(filter, update);

            return resultat.ModifiedCount > 0;
        }
        public async Task<int> TaBortKategoriFranAllaAsync(string kategoriAttTaBort)
        {
            //Måste ändra kategorier till en List
            //Då måste även Eq ändras till AnyEq
            var filter = Builders<Podcast>.Filter.Eq(p => p.Kategori, kategoriAttTaBort);
            var update = Builders<Podcast>.Update.Pull(p => p.Kategori, kategoriAttTaBort);
            
            var resultat = await _mongoDBServices
                .podcastKollektion
                .UpdateManyAsync(filter, update);

            //Kanske endast vill returnera siffran ändrade dokument? 
            return (int)resultat.ModifiedCount;
        }*/
        public async Task<bool> AndraKategoriForEnPoddAsync(string poddId, string gammalKategori, string nyKategori)
        {
            //Lägger två filter.
            var filter = Builders<Podcast>.Filter.And(
                Builders<Podcast>.Filter.Eq(p => p.Id, poddId),
                Builders<Podcast>.Filter.Eq("Kategori", gammalKategori) //Eftersom Kategori är en Array.
                );

            //"Kategori" utgår från att detta är namnet på en array i dokumentet.
            //$-tecknet anger att det endast är det första elementet som matchar kraven som ska ändras.
            //Därmed, titta i arrayen med filtret -> Ersätt med nyKategori -> Lämna resten orört.
            var update = Builders<Podcast>.Update.Set("Kategori.$", nyKategori);

            var resultat = await _mongoDBServices
                .podcastKollektion
                .UpdateOneAsync(filter, update);

            return resultat.ModifiedCount > 0;
        }
        public async Task<int> AndraKategorierForAllaPoddarAsync(string gammalKategori, string nyKategori)
        {
            var filter = Builders<Podcast>.Filter.Eq("Kategori", gammalKategori);
            var update = Builders<Podcast>.Update.Set("Kategori.$", nyKategori);

            var resultat = await _mongoDBServices
                .podcastKollektion
                .UpdateManyAsync(filter, update);

            return (int)resultat.ModifiedCount;
        }
    }
}
