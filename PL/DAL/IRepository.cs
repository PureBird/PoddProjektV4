namespace PoddProjektV4.DAL
{
    public interface IRepository<T>
    {
        Task<bool> LaggTillAsync(T entitet);
        Task<bool> UppdateraAsync(T entitet);
        Task<bool> RaderaAsync(string id);
        Task<T?> HamtaMedIdAsync(string id);
        Task<List<T>> HamtaAlltAsync();
    }
}
