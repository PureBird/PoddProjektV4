using DAL;

namespace BL
{
    public static class ServiceFabrik
    {
        public static PoddService SkapaPoddService()
        {
            PoddRepository repository = new PoddRepository();
            return new PoddService(repository);
        }
    }
}
