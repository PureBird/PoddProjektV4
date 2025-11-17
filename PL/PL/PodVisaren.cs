using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;

namespace PoddProjektV3._2
{
    public partial class PodVisaren : Form
    {
        public PodVisaren()
        {
            InitializeComponent();
        }

        /*public Podd HamtaPodd(string xmlPoddLank)
        {
            using (XmlReader XMLlasare = XmlReader.Create(xmlPoddLank)) //skapar en xml läsare 
            {
                //klassen syndicationfeed läser av xml filen 
                SyndicationFeed flode = SyndicationFeed.Load(XMLlasare);

                Podd dinPodd = new Podd //vi skapar ett objket av podden och väljer ut dessa egenskaper
                {
                    Titel = flode.Title.Text,
                    AntalAvsnitt = flode.Items.Count(),
                    Beskrivning = flode.Description?.Text
                };
                return dinPodd;
            }
        }*/

        private void VisaPodd_Click(object sender, EventArgs e)
        {
            /*string url = textBox1.Text; //hämtar länken och skickar den i hamtaPodd parametern som är en string 
            Podd dinPodd = HamtaPodd(url);
            dataGridView1.DataSource = new List<Podd> { dinPodd };
            //grid view kan endast visa saker från en lista så skapar en lista som endast innehåller objektet av podden*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
