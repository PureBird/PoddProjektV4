using DAL;
using Models;

namespace BL
{
    public class PoddService : IService<Podcast>
    {
        private readonly PoddRepository _repository;
        public PoddService(PoddRepository repo)
        {
            _repository = repo;
        }
        public async Task<bool> LaggTillAsync(Podcast podcast)
        {
            return await _repository.LaggTillAsync(podcast);
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
        public async Task<List<Podcast>> HamtaAlltAsync()
        {
            return await _repository.HamtaAlltAsync();
        }
        public async Task<List<string>> HamtaUnikaKategorier()
        {
            var allaPoddar = await HamtaAlltAsync();
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
            var allaPoddar = await HamtaAlltAsync();
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
    }
}
