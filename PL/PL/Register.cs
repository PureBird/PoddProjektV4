using BL;
using Models;


namespace PL
{
    public partial class Register : Form
    {
        private readonly PoddService service;
        private List<Podcast> laddadePoddar;
        private readonly Meny menyForm;
        private bool trycktTillbaka = false;
        public Register(Meny originalForm, PoddService service)
        {
            InitializeComponent();
            this.service = service;
            this.menyForm = originalForm;
            this.laddadePoddar = new List<Podcast>();
            this.Load += FyllSida;
            FilterComboBox.SelectedIndexChanged += FilterComboBoxSelect;
            dataGridView1.CellClick += CellKlickad;
        }

        private async void FyllSida(object? sender, EventArgs e)
        {
            await FyllComboBox();
            await FyllRegister();
        }

        private async Task FyllComboBox()
        {
            FilterComboBox.Items.Add("Alla Poddar");
            List<string> kategoriLista = new List<string>();
            kategoriLista = await service.HamtaUnikaKategorier();

            foreach (var kategori in kategoriLista)
            {
                FilterComboBox.Items.Add(kategori);
            }

            FilterComboBox.SelectedIndex = 0;

        }

        private async Task FyllRegister()
        {
            laddadePoddar = await service.HamtaAlltAsync();
            dataGridView1.Rows.Clear();

            foreach (var podcast in laddadePoddar)
            {
                dataGridView1.Rows.Add(
                    podcast.Titel, podcast.Beskrivning, podcast.PoddAvsnitt != null ? podcast.PoddAvsnitt.Count : 0);
            }
            TillbakaBtn.Enabled = true;
        }

        private async void FilterComboBoxSelect(object? sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (FilterComboBox.Text == "Alla Poddar")
            {
                laddadePoddar = await service.HamtaAlltAsync();
            }

            else
            {
                laddadePoddar = await service.HamtaPoddarMedKategori(FilterComboBox.Text);
            }

            foreach (var podcast in laddadePoddar)
            {
                dataGridView1.Rows.Add(
                    podcast.Titel,
                    podcast.Beskrivning,
                    podcast.PoddAvsnitt != null ? podcast.PoddAvsnitt.Count : 0
                );
            }
        }

        private void CellKlickad(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Podcast valdPodcast = laddadePoddar[e.RowIndex];

            new PoddInfo(valdPodcast, menyForm, service).Show();
            this.Hide();
        }


        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            trycktTillbaka = true;
            menyForm.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!trycktTillbaka) Application.Exit();
            base.OnFormClosing(e);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
