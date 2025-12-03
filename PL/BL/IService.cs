namespace BL
{
    public interface IService<T>
    {
        Task<bool> LaggTillAsync(T entitet);
        Task<bool> UppdateraAsync(T entitet);
        Task<bool> RaderaAsync(string id);
        Task<T?> HamtaMedIdAsync(string id);
        Task<List<T>> HamtaAlltAsync();
    }
}
