using PoddProjektV4.BL;
using PoddProjektV4.DAL;
using PoddProjektV4.Models;
using System.Diagnostics;
using System.Windows.Forms;

namespace PL
{
    internal static class Program
    {
        private static readonly MongoDBServices service = new MongoDBServices();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Meny());
            Debug.WriteLine("hallå");

            Avsnitt avsnitt1 = new Avsnitt("Duschen", "Duschen är kall idag", "2025-11-14");

            List<Avsnitt> listAvsnitt1 = new List<Avsnitt>();
            listAvsnitt1.Add(avsnitt1);

            Podcast podcast1 = new Podcast("1", "dusch podcasten", "En podd att lyssna på i duschen", "Humor", listAvsnitt1);

            service.LaggTillPodcast(podcast1);

            List<Podcast> allaPodcasts = service.HamtaAllaPodcasts();

            foreach (Podcast p in allaPodcasts)
            {
                System.Diagnostics.Debug.WriteLine(p.Titel);
            }

            int totalForms = Application.OpenForms.Count;
            if (totalForms < 2)
            {
                bool visible = true;

                if (totalForms == 1)
                {
                    visible = Application.OpenForms[0].Visible;
                }
                if (!visible)
                {
                    Application.Exit();
                }
         
            }

        }
    }
}