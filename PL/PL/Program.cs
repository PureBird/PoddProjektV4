using PoddProjektV4.BL;
using PoddProjektV4.DAL;
using PoddProjektV4.Models;
using System.Diagnostics;
using System.Windows.Forms;

namespace PL
{
    internal static class Program
    {
        private static readonly PoddService _poddService = new PoddService(new PoddRepository());
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Meny(_poddService));
            
        }
    }
}