using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddProjektV4.DAL
{
    public interface IRepository<T>
    {
        void LaggTill(T entitet);
        bool Uppdatera(T entitet);
        bool Radera(string id);
        T? HamtaMedId(string id);
        List<T> HamtaAllt();

        Task LaggTillAsync(T entitet);
        Task<bool> UppdateraAsync(T entitet);
        Task<bool> RaderaAsync(string id);
        Task<T?> HamtaMedIdAsync(string id);
        Task<List<T>> HamtaAlltAsync();
    }
}
