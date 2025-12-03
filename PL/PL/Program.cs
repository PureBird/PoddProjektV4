using BL;

namespace PL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Meny(ServiceFabrik.SkapaPoddService()));
        }
    }
}