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

        //public bool PassarKategoriKrav(string kategori)
        //{
        //    if(kategori.Length > 15) return false;
        //    return true;
        //}

        //public bool PassarPodcastKrav(Podcast podcast)
        //{
        //    if(string.IsNullOrEmpty(podcast.Titel) || podcast.Titel.Length > 50) return false;
        //    if(string.IsNullOrEmpty(podcast.Beskrivning) || podcast.Beskrivning.Length > 500) return false;
        //    if(!PassarKategoriKrav(podcast.Kategori)) return false;
        //    return true;
        //}

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
        public async Task<List<Podcast>> HamtaPoddarMedKategori(string kategori)
        {
            var allaPoddar = await HamtaAllaPoddarAsync();
            return allaPoddar.Where(p => p.Kategori == kategori)
                .ToList();
        }
        public async Task<bool> TaBortEnKategoriFranPoddAsync(string poddId)
        {
            return await _repository.TaBortEnKategoriFranPoddAsync(poddId);
        }
        public async Task<int> TaBortKategoriFranAllaAsync(string kategori)
        {
            return await _repository.TaBortKategoriFranAllaAsync(kategori);
        }
        public async Task<bool> AndraKategoriForEnPoddAsync(string poddId, string nyKategori)
        {
            return await _repository.AndraKategoriForEnPoddAsync(poddId, nyKategori);
        }
        public async Task<int> AndraKategorierForAllaPoddarAsync(string gammalKategori, string nyKategori)
        {
            return await _repository.AndraKategorierForAllaPoddarAsync(gammalKategori, nyKategori);
        }
        public async Task<bool> PodcastFinnsAsync(string id)
        {
            return await _repository.HamtaMedIdAsync(id) != null;
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
