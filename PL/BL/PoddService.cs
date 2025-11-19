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

        private readonly PoddRepository repository;
        public PoddService(PoddRepository repository)
        {
            this.repository = repository;
        }
        public List<Podcast> HamtaAllaPoddar()
        {
            return repository.HamtaAllt();
        }
        public bool TaBortPodcast(string id)
        {
            return repository.Radera(id);
        }

        public List<String> HamtaUnikaKategorier()
        {
            var allaPoddar = HamtaAllaPoddar();
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

    }
}
