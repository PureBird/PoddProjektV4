using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddProjektV4.DAL
{
    public interface IRepository<T>
    {
        public void LaggTill(T entitet);
        public bool Uppdatera(T entitet);
        public bool Radera(string id);
        public T? HamtaMedId(string id);
        public List<T> HamtaAllt();
    }
}
