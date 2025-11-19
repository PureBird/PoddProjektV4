using PoddProjektV4.DAL;
using PoddProjektV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddProjektV4.BL
{
    internal class PoddService
    {

        private readonly PoddRepository repository;
        public PoddService(PoddRepository repository)
        {
            this.repository = repository;
        }
        public async Task<bool> TaBortEnKategoriFranPoddAsync(string poddId, string kategoriAttTaBort)
        {
            return await repository.TaBortEnKategoriFranPoddAsync(poddId, kategoriAttTaBort);
        }
        public async Task<int> TaBortKategoriFranAllaAsync(string kategori)
        {
            return await repository.TaBortKategoriFranAllaAsync(kategori);
        }

    }
}
