using PoddProjektV4.Models;
using PoddProjektV4.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TestServiceReg
    {

        private PoddRepository repository;

        public TestServiceReg(PoddRepository repository)
        {
            this.repository = repository;
        }

        public List<Podcast> HamtaAllaPoddar()
        {
            return repository.HamtaAllt();
        }

        public Podcast? HamtaPodcast(string id)
        {
            return repository.HamtaMedId(id);
        }

        public void LaggTillPodcast(Podcast podcast)
        {
            repository.LaggTill(podcast);
        }

        public bool UppdateraPodcast(Podcast podcast)
        {
            return repository.Uppdatera(podcast);
        }

        public bool TaBortPodcast(string id)
        {
            return repository.Radera(id);
        }
    }
}
