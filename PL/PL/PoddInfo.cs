using PoddProjektV4.BL;
using PoddProjektV4.DAL;
using PoddProjektV4.Models;
using System.Diagnostics;
using System.Text;


namespace PL
{
    public partial class PoddInfo : Form
    {
        private readonly PoddService service;
        private Podcast Podcast;
        private bool trycktTillbaka = false;
        private readonly Meny menyForm;

        public PoddInfo(Podcast podcast, Meny meny)
        {
            InitializeComponent();

            var repo = new PoddRepository();
            service = new PoddService(repo);
            Podcast = podcast;
            menyForm = meny;



            //Labels
            PoddTitel.Text = Validering.StrangMaxLangd(podcast.Titel, 20);
            Kategori1.Text = Validering.StrangMaxLangd(podcast.Kategori, 20);


           

            //Textboxes
            VisaAvsnittTitelListBox(podcast);

            AvsnittInfo.ReadOnly = true;
            AvsnittInfo.BackColor = SystemColors.Window;

            tbNykategori.PlaceholderText = "Ny kategori";
            txbAndraTitel.PlaceholderText = "Ny titel";

        }

        public void VisaAvsnittTitelListBox(Podcast podcast)
        {
            AvsnittTitel.DataSource = null;
            AvsnittTitel.DataSource = podcast.PoddAvsnitt;
            AvsnittTitel.DisplayMember = "Titel";
        }

        public void VisaAvsnittInfoTextBox(Avsnitt avsnitt)
        {
            if (avsnitt == null)
            {
                AvsnittInfo.Text = "Inget avsnitt valt.";
                return;
            }

            var info = new StringBuilder();
            info.AppendLine($"Titel: {avsnitt.Titel}");
            info.AppendLine($"Beskrivning: {avsnitt.Beskrivning}");
            info.AppendLine($"Publicerad: {avsnitt.PremiarDatum}");

            AvsnittInfo.Text = info.ToString();
        }

        private void AvsnittTitel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvsnittTitel.SelectedItem is Avsnitt valtAvsnitt)
            {
                VisaAvsnittInfoTextBox(valtAvsnitt);
            }
        }


        private async void btnAndraKategori_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Validering.IsTomStrang(txbAndraTitel.Text));
            if (!Validering.IsTomStrang(tbNykategori.Text))
            {
                Podcast.Kategori = tbNykategori.Text;
                await service.UppdateraAsync(Podcast);
                Kategori1.Text = Validering.StrangMaxLangd(Podcast.Kategori, 20);
            }
        }

        private async void btnAndraTitel_Click(object sender, EventArgs e)
        {
            if (!Validering.IsTomStrang(txbAndraTitel.Text))
            {
                Podcast.Titel = txbAndraTitel.Text;
                await service.UppdateraAsync(Podcast);
                PoddTitel.Text = Validering.StrangMaxLangd(Podcast.Titel, 20);
            }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            trycktTillbaka = true;
            var registerForm = new Register(menyForm, service);
            registerForm.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!trycktTillbaka) Application.Exit();
            base.OnFormClosing(e);
        }

        private async void btnTaBort_Click(object sender, EventArgs e)
        {
            var svar = MessageBox.Show(
            "Är du säker på att du vill ta bort denna podcast?",
            "Bekräfta borttagning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
 );

            if (svar == DialogResult.Yes)
            {
                await service.RaderaAsync(Podcast.Id);
                MessageBox.Show("Podcasten har tagits bort.");
            }
            else
            {
                return;
            }
        }
    }
}
