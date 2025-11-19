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
        public readonly IMongoCollection<Podcast> podcastKollektion;
        public PoddRepository()
        {
            var klient = new MongoClient("mongodb+srv://OruMongoDBAdmin:hej@orumongodb.8yb9y4t.mongodb.net/?appName=OruMongoDB");
            var databas = klient.GetDatabase("OruMongoDB");
            podcastKollektion = databas.GetCollection<Podcast>("Poddar");
        }
        public async Task<bool> LaggTillAsync(Podcast podcast)
        {
            try
            {
                await podcastKollektion.InsertOneAsync(podcast);
                return true;
            }
            catch
            {
                return false;
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

            var resultat = await podcastKollektion
                .UpdateOneAsync(filter, uppdatering);

            return resultat.ModifiedCount > 0;
        }
        public async Task<bool> RaderaAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);

            var resultat = await podcastKollektion
                .DeleteOneAsync(filter);

            return resultat.DeletedCount > 0;
        }
        public async Task<Podcast?> HamtaMedIdAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);

            Podcast? podcastKopia = await podcastKollektion
                .Find(filter)
                .FirstOrDefaultAsync();

            return podcastKopia;
        }
        public async Task<List<Podcast>> HamtaAlltAsync()
        {
            var filter = Builders<Podcast>.Filter.Empty;

            List<Podcast> listaMedPodcasts = await podcastKollektion
                .Find(filter)
                .ToListAsync();

            return listaMedPodcasts;
        }
        public async Task<bool> TaBortEnKategoriFranPoddAsync(string poddId, string kategoriAttTaBort)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, poddId);
            var update = Builders<Podcast>.Update.Set(kategoriAttTaBort, "");

            var resultat = await podcastKollektion.UpdateOneAsync(filter, update);

            return resultat.ModifiedCount > 0;
        }
        /*public async Task<int> TaBortKategoriFranAllaAsync(string kategoriAttTaBort)
        {
            //Måste ändra kategorier till en List
            //Då måste även Eq ändras till AnyEq
            var filter = Builders<Podcast>.Filter.Eq(p => p.Kategori, kategoriAttTaBort);
            var update = Builders<Podcast>.Update.Pull(p => p.Kategori, kategoriAttTaBort);
            
            var resultat = await podcastKollektion
                .UpdateManyAsync(filter, update);

            //Kanske endast vill returnera siffran ändrade dokument? 
            return (int)resultat.ModifiedCount;
        }*/
        public async Task<bool> AndraKategoriForEnPoddAsync(string poddId, string nyKategori)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, poddId);
            var update = Builders<Podcast>.Update.Set(p => p.Kategori, nyKategori);

            var resultat = await podcastKollektion
                .UpdateOneAsync(filter, update);

            return resultat.ModifiedCount > 0;
        }
        public async Task<int> AndraKategorierForAllaPoddarAsync(string gammalKategori, string nyKategori)
        {
            var filter = Builders<Podcast>.Filter.Eq("Kategori", gammalKategori);
            var update = Builders<Podcast>.Update.Set("Kategori.$", nyKategori);

            var resultat = await podcastKollektion
                .UpdateManyAsync(filter, update);

            return (int)resultat.ModifiedCount;
        }
    }
}
