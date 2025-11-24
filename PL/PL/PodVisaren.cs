using PoddProjektV4.BL;
using PoddProjektV4.DAL;
using PoddProjektV4.Models;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using System.Xml;


namespace PL
{
    public partial class PodVisaren : Form
    {
        private Podcast dinPodd;
        private readonly Meny _meny;
        private readonly PoddService _poddService;
        private bool tryckTillbaka = false;
        public PodVisaren(Meny meny, PoddService _poddService)
        {
            InitializeComponent();
            _meny = meny;
            _poddService = new PoddService();


        }

        public Podcast HamtaPodd(string xmlPoddLank)
        {
            try
            {
                using (XmlReader XMLlasare = XmlReader.Create(xmlPoddLank)) //skapar en xml läsare 
                {
                    //klassen syndicationfeed läser av xml filen 
                    SyndicationFeed flode = SyndicationFeed.Load(XMLlasare);


                    //hämtar itunes-kategori
                    string kategoriText = flode.ElementExtensions //skapar kategori variabel
                        .Where(extension => extension.OuterName == "category" && //den letar efter category det är outername för att "itunes" är ett objekt i rss flödet så det räknas inte som outer name
                    extension.OuterNamespace.Contains("itunes")) //säkerställ att det är category för att "itunes" måste stå först
                        .Select(extension =>
                    {
                        //i rss står det category="comedy" vi måste ha en xml läsare för att kunna läsa av det 
                        using XmlReader XMLlasare = extension.GetReader();
                        XMLlasare.MoveToContent();
                        return XMLlasare.GetAttribute("text"); //läsa det som står i "text"
                    })
                        .FirstOrDefault();//ta första du hittar, kan vara null om inget hittas 


                    List<Avsnitt> avsnittLista = new List<Avsnitt>();
                    foreach (var item in flode.Items)
                    {
                        avsnittLista.Add(new Avsnitt
                        {
                            Titel = item.Title.Text,
                            Beskrivning = Regex.Replace(item.Summary?.Text ?? "", "<.*?>", "").Trim(), //Beskrivning = flode.Description?.Text, Så var det förut
                            PremiarDatum = item.PublishDate.DateTime.ToString("yyyy-MM-dd")
                        });
                    }

                    Podcast dinPodd = new Podcast //vi skapar ett objket av podden och väljer ut dessa egenskaper
                    {
                        Id = Guid.NewGuid().ToString(),
                        Titel = flode.Title.Text,
                        Beskrivning = flode.Description?.Text,
                        Kategori = kategoriText,
                        PoddAvsnitt = avsnittLista
                    };
                    return dinPodd;
                }
            }
            catch (System.Net.Http.HttpRequestException)
            {
                MessageBox.Show("Länken är felaktigt, kontrollera att sidan finns");
                return null;
            }
               
                catch (System.UriFormatException
)
            {
                MessageBox.Show("Länken är felaktigt, kontrollera att sidan finns");
                return null;
            }

        }




        private void visaPODD_Click_1(object sender, EventArgs e)
        {
            if (Validering.IsTomStrang(RSSTEXT.Text))
            {
                MessageBox.Show("Vänligen mata in en länk");
                return;
            }

            if (Validering.arHTTPSLank(RSSTEXT.Text))
            {
                MessageBox.Show("Länken måste vara HTTPS");
                return;
            }


            try
            {
                string url = RSSTEXT.Text;
                dinPodd = HamtaPodd(url);

                if (dinPodd == null)
            {
                
                return;
            }

                var visningsLista = new List<object>
            {
                new
                {
                    titel = dinPodd.Titel,
                    AntalAvsnitt = dinPodd.PoddAvsnitt?.Count ?? 0,
                    beskrivning = dinPodd.Beskrivning,
                    id = dinPodd.Id,
                    kategori = dinPodd.Kategori
                }
            };

                poddTabell.DataSource = visningsLista;

                avsnittGrid.DataSource = dinPodd.PoddAvsnitt;


                //grid view kan endast visa saker från en lista så skapar en lista som endast innehåller objektet av podden
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Länken är felaktigt, kontrollera att sidan finns");
                return;
            }


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

        private async void sparaBTN_Click(object sender, EventArgs e)
        {
            bool lyckadSpara = false;

            if (dinPodd != null){
                lyckadSpara = await _poddService.LaggTillAsync(dinPodd);
            }

            if (dinPodd == null)
            {
                MessageBox.Show("Du måste hämta en podd för att kunna spara");
                return;
            }

            if (lyckadSpara)
            {
                MessageBox.Show("podden sparades");
            }
            else
            {
                MessageBox.Show("Det gick inte att spara podden");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            tryckTillbaka = true;
            _meny.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!tryckTillbaka) Application.Exit();
            base.OnFormClosing(e);
        }
    }
}
