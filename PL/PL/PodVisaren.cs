using PoddProjektV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;


namespace PL
{
    public partial class PodVisaren : Form
    {
        public PodVisaren()
        {
            InitializeComponent();
        }

        public Podcast HamtaPodd(string xmlPoddLank)
        {
            using (XmlReader XMLlasare = XmlReader.Create(xmlPoddLank)) //skapar en xml läsare 
            {
                //klassen syndicationfeed läser av xml filen 
                SyndicationFeed flode = SyndicationFeed.Load(XMLlasare);

                List<Avsnitt> avsnittLista = new List<Avsnitt>();
                foreach (var item in flode.Items)
                {
                    avsnittLista.Add(new Avsnitt
                    {
                        Titel = item.Title.Text,
                        Beskrivning = flode.Description?.Text, //Beskrivning = flode.Description?.Text, Så var det förut
                        PremiarDatum = item.PublishDate.DateTime.ToString("yyyy-MM-dd")
                    });
                }

                Podcast dinPodd = new Podcast //vi skapar ett objket av podden och väljer ut dessa egenskaper
                {
                    Id = Guid.NewGuid().ToString(),
                    Titel = flode.Title.Text,
                    Beskrivning = flode.Description?.Text,
                    Kategori = flode.Categories.ToString(),
                    PoddAvsnitt = avsnittLista
                };
                return dinPodd;
            }
        }



        private void visaPODD_Click_1(object sender, EventArgs e)
        {
            string url = RSSTEXT.Text;
            Podcast dinPodd = HamtaPodd(url);

            var visningsLista = new List<object>
            {
                new
                {
                    Titel = dinPodd.Titel,
                    AntalAvsnitt = dinPodd.PoddAvsnitt?.Count ?? 0,
                    Beskrivning = dinPodd.Beskrivning,
                    id = dinPodd.Id,
                    katergori = dinPodd.Kategori
                }
            };

            poddTabell.DataSource = visningsLista;

            avsnittGrid.DataSource = dinPodd.PoddAvsnitt;


            //grid view kan endast visa saker från en lista så skapar en lista som endast innehåller objektet av podden



        }

        private void RSSTEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void poddTabell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void avsnittGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
