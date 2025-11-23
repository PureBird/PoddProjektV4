using MongoDB.Driver;
using PoddProjektV4.Models;
//using PoddProjektV4.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddProjektV4.DAL
{
    public class PoddRepository : IRepository<Podcast>
    {
        private readonly MongoClient _klient;
        private readonly IMongoCollection<Podcast> _podcastKollektion;
        public PoddRepository()
        {
            _klient = new MongoClient("mongodb+srv://OruMongoDBAdmin:hej@orumongodb.8yb9y4t.mongodb.net/?appName=OruMongoDB");
            var databas = _klient.GetDatabase("OruMongoDB");
            _podcastKollektion = databas.GetCollection<Podcast>("Poddar");
        }
        public async Task<bool> LaggTillAsync(Podcast podcast)
        {
            //Här används using eftersom sessionen inte automatiskt
            //fångas av C#:s "garbage collector". På det här viset
            //säkerställer vi att sessionen stängs ner korrekt. Ungefär
            //på samma sätt som om vi använde Dispose() eller using
            //på en filström.
            using var session = await _klient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await _podcastKollektion.InsertOneAsync(session, podcast);
                await session.CommitTransactionAsync();
                return true;
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                PrintaExceptionMeddelande(ex);
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

            using var session = await _klient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var resultat = await _podcastKollektion.UpdateOneAsync(session, filter, uppdatering);
                await session.CommitTransactionAsync();
                return resultat.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                PrintaExceptionMeddelande(ex);
                return false;
            }
        }
        public async Task<bool> RaderaAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);

            using var session = await _klient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var resultat = await _podcastKollektion.DeleteOneAsync(session, filter);
                await session.CommitTransactionAsync();
                return resultat.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                PrintaExceptionMeddelande(ex);
                return false;
            }
        }
        public async Task<Podcast?> HamtaMedIdAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);

            Podcast? podcastKopia = await _podcastKollektion
                .Find(filter)
                .FirstOrDefaultAsync();

            return podcastKopia;
        }
        public async Task<List<Podcast>> HamtaAlltAsync()
        {
            var filter = Builders<Podcast>.Filter.Empty;

            List<Podcast> listaMedPodcasts = await _podcastKollektion
                .Find(filter)
                .ToListAsync();

            return listaMedPodcasts;
        }
        public async Task<bool> TaBortEnKategoriFranPoddAsync(string poddId)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, poddId);
            var uppdatering = Builders<Podcast>.Update.Set(p => p.Kategori, "");

            using var session = await _klient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var resultat = await _podcastKollektion.UpdateOneAsync(session, filter, uppdatering);
                await session.CommitTransactionAsync();
                return resultat.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                PrintaExceptionMeddelande(ex);
                return false;
            }
        }
        public async Task<int> TaBortKategoriFranAllaAsync(string kategoriAttTaBort)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Kategori, kategoriAttTaBort);
            var uppdatering = Builders<Podcast>.Update.Set(p => p.Kategori, "");

            using var session = await _klient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var resultat = await _podcastKollektion.UpdateManyAsync(session, filter, uppdatering);
                await session.CommitTransactionAsync();
                return (int)resultat.ModifiedCount;
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                PrintaExceptionMeddelande(ex);
                return -1;
            }
        }
        public async Task<bool> AndraKategoriForEnPoddAsync(string poddId, string nyKategori)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, poddId);
            var uppdatering = Builders<Podcast>.Update.Set(p => p.Kategori, nyKategori);

            using var session = await _klient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var resultat = await _podcastKollektion.UpdateOneAsync(session, filter, uppdatering);
                await session.CommitTransactionAsync();
                return resultat.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                PrintaExceptionMeddelande(ex);
                return false;
            }
        }
        public async Task<int> AndraKategorierForAllaPoddarAsync(string gammalKategori, string nyKategori)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Kategori, gammalKategori);
            var uppdatering = Builders<Podcast>.Update.Set(p => p.Kategori, nyKategori);

            using var session = await _klient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var resultat = await _podcastKollektion.UpdateManyAsync(session, filter, uppdatering);
                await session.CommitTransactionAsync();
                return (int)resultat.ModifiedCount;
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                PrintaExceptionMeddelande(ex);
                return -1;
            }
        }
        public void PrintaExceptionMeddelande(Exception ex)
        {
            Debug.WriteLine("EX.MESSAGE: " + ex.Message + "\nEX.TOSTRING(): " + ex.ToString());
        }
    }
}
