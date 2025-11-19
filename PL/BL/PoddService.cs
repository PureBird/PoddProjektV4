using MongoDB.Driver;
using PoddProjektV4.DAL;
using PoddProjektV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddProjektV4.BL
{
    public class PoddService
    {

        private readonly PoddRepository _repository;
        public PoddService(PoddRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<string>> HamtaUnikaKategorier()
        {
            var allaPoddar = await HamtaAllaPoddarAsync();
            List<string> kategoriLista = new List<string>();

            foreach (var podcast in allaPoddar)
            {
                string? kategori = podcast.Kategori;

                if (!string.IsNullOrEmpty(kategori) && !kategoriLista.Contains(kategori))
                {
                    kategoriLista.Add(kategori);
                }
            }

            return kategoriLista;

        }

        //public async Task<bool> TaBortEnKategoriFranPoddAsync(string poddId, string kategoriAttTaBort)
        //{
        //    return await repository.TaBortEnKategoriFranPoddAsync(poddId, kategoriAttTaBort);
        //}
        //public async Task<int> TaBortKategoriFranAllaAsync(string kategori)
        //{
        //    return await repository.TaBortKategoriFranAllaAsync(kategori);
        //}

        public async Task<bool> PodcastFinnsAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);

            return await _repository
                .podcastKollektion
                .Find(filter)
                .AnyAsync();
        }
        public async Task LaggTillAsync(Podcast podcast)
        {
            if (!await PodcastFinnsAsync(podcast.Id))
            {
                await _repository.LaggTillAsync(podcast);
            }
        }
        public async Task<bool> UppdateraAsync(Podcast nyPodcast)
        {
            return await _repository.UppdateraAsync(nyPodcast);
        }
        public async Task<bool> RaderaAsync(string id)
        {
            return await _repository.RaderaAsync(id);
        }
        public async Task<Podcast?> HamtaMedIdAsync(string id)
        {
            return await _repository.HamtaMedIdAsync(id);
        }
        public async Task<List<Podcast>> HamtaAllaPoddarAsync()
        {
            return await _repository.HamtaAlltAsync();
        }
    }
}
