using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddProjektV4.Models
{
    internal class Kategori
    {
        public string Name { get; set; }
        public List<Podcast> PoddLista { get; set; }

    }
}
