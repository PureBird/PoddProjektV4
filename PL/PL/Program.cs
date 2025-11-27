using PoddProjektV4.BL;
using PoddProjektV4.DAL;

namespace PL
{
    internal static class Program
    {
        private static readonly PoddService _poddService = new PoddService();
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Meny(_poddService));
        }
    }
}