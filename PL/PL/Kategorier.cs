using PoddProjektV4.BL;
using PoddProjektV4.DAL;
using PoddProjektV4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Kategorier : Form
    {
        private readonly PoddService _poddService;
        public Kategorier()
        {
            InitializeComponent();

            MongoDBServices mongoDBServices = new MongoDBServices();
            PoddRepository poddRepository = new PoddRepository();
            //_poddService = new PatrickPoddService(poddRepository);

            RensaUI();
            CreateRbn.Checked = true;

            List<Podcast> podcasts = new List<Podcast>();

            Podcast podcast1 = new Podcast();
            podcast1.Kategori = "Komedi, Rock, Rapp";

            Podcast podcast2 = new Podcast();
            podcast2.Kategori = "komedi, rock, Dokumentär";

            podcasts.Add(podcast1);
            podcasts.Add(podcast2);

            List<string> Kategorier = UnikifieraKategorier(podcasts);

            for (int i = 0; i < Kategorier.Count; i++)
            {
                CatCbx.Items.Add(Kategorier[i]);
            }

            //Meny meny = new Meny();
            //meny.Show();

        }

        //Tar ut kategorierna ur alla medskickade Podcasts och spottar ut alla unika kategorier.
        public List<string> UnikifieraKategorier(List<Podcast> AllaPodcasts)
        {
            List<string> UnikaKategorier = new List<string>();

            foreach (Podcast podcast in AllaPodcasts)
            {
                List<string> MojligaNyaKategorier = SplittaKategoriFalt(podcast);
                for (int i = 0; i < MojligaNyaKategorier.Count; i++)
                {
                    if (!KategoriFinns(MojligaNyaKategorier[i], UnikaKategorier))
                    {
                        UnikaKategorier.Add(StorForstaBokstav(MojligaNyaKategorier[i]));
                    }
                }
            }

            return UnikaKategorier;
        }

        //Tar emot en KategoriSträng och kollar om den finns i KategoriListan som skickas med.
        public bool KategoriFinns(string Kategori, List<string> KategoriLista)
        {
            for (int i = 0; i < KategoriLista.Count; i++)
            {
                if (KategoriLista[i].ToLower().Equals(Kategori.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

        //Eftersom kategorifältet i Podcast.Kategori kan se ut exempelvis ("Komedi, Dokumentär, Skräck") så
        //splittar den här metoden upp strängen in i en List där 0=Komedi, 1=Dokumentär, 2=Skräck
        public List<string> SplittaKategoriFalt(Podcast podcast)
        {
            List<string> KategoriLista = new List<string>();
            string[] Kategorier = podcast.Kategori.Split(", ");

            foreach (string Kategori in Kategorier)
            {
                KategoriLista.Add(Kategori);
            }

            return KategoriLista;
        }

        //Tar emot strängen och förstorar endast första bokstaven.
        public string StorForstaBokstav(string kategori)
        {
            kategori = kategori.ToLower();
            return char.ToUpper(kategori[0]) + kategori.Substring(1);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //huvudmeny något show
        }

        private void RensaUI()
        {
            //Första raden
            CatTbx.Visible = false;
            CatTbx.Text = "";
            CatCbx.Visible = false;
            CatBtn.Visible = false;
            AlertLbl.Text = "";
            AlertLblEditCount.Text = "";

            //Andra raden
            CatLblEdit.Visible = false;
            CatTbxEdit.Visible = false;
            CatTbxEdit.Text = "";
            CatBtnEdit.Visible = false;
        }

        private void CreateRbn_CheckedChanged(object sender, EventArgs e)
        {
            RensaUI();
            CatLbl.Text = "Namnet på den nya kategorin:";
            CatTbx.Visible = true;
            CatBtn.Visible = true;
            CatBtn.Text = "Skapa";
            //CatBtn.Enabled = true;
        }

        private void EditRbn_CheckedChanged(object sender, EventArgs e)
        {
            RensaUI();
            //Första raden
            CatLbl.Text = "Kategorin att ändra namn på:";
            CatCbx.Visible = true;

            //Andra raden
            CatLblEdit.Visible = true;
            CatTbxEdit.Visible = true;
            CatBtnEdit.Visible = true;
        }

        private void DeleteRbn_CheckedChanged(object sender, EventArgs e)
        {
            RensaUI();
            CatLbl.Text = "Kategorin som du vill radera:";
            CatCbx.Visible = true;
            CatBtn.Visible = true;
            CatBtn.Text = "Radera";
        }

        private void CatBtn_Click(object sender, EventArgs e)
        {
            if (CatBtn.Text.Equals("Skapa") && !string.IsNullOrWhiteSpace(CatTbx.Text) /*Denna Check ska finnas i valideraren*/)
            {
                //CatTbx
                //Borde man behöva välja Podcast att lägga till kategorin på eller hur ska vi göra med kategorier?
            }
            else if (CatBtn.Text.Equals("Radera") && !string.IsNullOrWhiteSpace(CatCbx.Text) /*Denna Check ska finnas i valideraren*/)
            {
                //CatCbx
                //Frågar en extra gång. Krav*
                var result = MessageBox.Show("Är du säker? Detta går inte att ångra!", 
                    "Du vill radera kategorin: \"" + CatCbx.Text + "\"",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //int antalRaderade _poddService.TaBortKategoriFranAllaAsync(CatCbx.Text);
                    //AlertLbl.Text = "Kategorin " + CatCbx.Text + " har raderats från " + antalRaderade + " podcasts.";
                    AlertLbl.Text = "Kategorin " + CatCbx.Text + " har raderats från 7 podcasts.";
                    CatCbx.Items.Remove(CatCbx.Text);
                }
            }
        }

        private void CatBtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CatCbx.Text))
            {
                AlertLbl.Text = "Välj en kategori att byta namn på.";
                return;
            }
            else if (string.IsNullOrWhiteSpace(CatTbxEdit.Text))
            {
                AlertLbl.Text = "Ange ett nytt namn på kategorin.";
                return;
            }

            var result = MessageBox.Show("Är du säker? Detta kommer ändra alla platser denna kategori" +
                " befinner sig på!", "Du vill redigera namnet på kategorin: \"" + CatCbx.Text + "\"!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //int antalRaderade _poddService.TaBortKategoriFranAllaAsync(CatCbx.Text);
                //int antalAndrade = _poddService.AndraKategoriNamnForAllaAsync();
                //AlertLbl.Text = "Kategorin " + CatCbx.Text + " har raderats från " + antalRaderade + " podcasts.";
                AlertLbl.Text = "Kategorin \"" + CatCbx.Text + "\" har bytts till sitt nya namn \"" + CatTbxEdit.Text + "\".";
                //AlertLblEditCount.Text = "Ändringen påverkade " + antalAndrade + " podcasts.";
                AlertLblEditCount.Text = "Ändringen påverkade 7 podcasts.";
                CatCbx.Items[CatCbx.SelectedIndex] = StorForstaBokstav(CatTbxEdit.Text);
            }
        }
    }
}
