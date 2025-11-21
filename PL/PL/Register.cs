using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoddProjektV4.DAL;
using PoddProjektV4.BL;
using PoddProjektV4.Models;
using MongoDB.Driver;


namespace PL
{
    public partial class Register : Form
    {
        private PoddService service;
        private List<Podcast> laddadePoddar;
        public Register(Meny originalForm)
        {
            InitializeComponent();
            
            var mongoDB = new MongoDBServices();
            var repo = new PoddRepository();
            service = new PoddService(repo);
            Meny menyForm = originalForm;

            this.Load += FyllSida;
            FilterComboBox.SelectedIndexChanged += FilterComboBoxSelect;
            dataGridView1.CellClick += CellKlickad;

        }

        private void FyllSida(object sender, EventArgs e)
        {
            FyllRegister(sender, e);
            FyllComboBox(sender, e);
        }

        private async Task FyllComboBox(object sender, EventArgs e)
        {
            FilterComboBox.Items.Add("Alla Poddar");
            List<string> kategoriLista = new List<string>(); 
            kategoriLista = await service.HamtaUnikaKategorier();

            foreach (var kategori in kategoriLista) {
                FilterComboBox.Items.Add(kategori);
            }

        }

        private async Task FyllRegister(object sender, EventArgs e)
        {
            laddadePoddar = await service.HamtaAllaPoddarAsync();
            dataGridView1.Rows.Clear();

            foreach (var podcast in laddadePoddar)
            {
                dataGridView1.Rows.Add(
                    podcast.Titel, podcast.Beskrivning, podcast.PoddAvsnitt != null ? podcast.PoddAvsnitt.Count : 0);
            }
        }

        private async void FilterComboBoxSelect(object sender, EventArgs e)
        {
            var allaPoddar = await service.HamtaAllaPoddarAsync();

            dataGridView1.Rows.Clear();

            if (FilterComboBox.Text == "Alla Poddar")
            {
                laddadePoddar = allaPoddar;
                //await FyllRegister(sender, e);
            }

            else
            {
                laddadePoddar = allaPoddar
                    .Where(p => p.Kategori == FilterComboBox.Text)
                    .ToList();
                    
                //    Clear();
                //laddadePoddar = await service.HamtaAllaPoddarAsync();
                //dataGridView1.Rows.Clear();
                //foreach (var podcast in laddadePoddar)
                //{
                //    if (podcast.Kategori == FilterComboBox.Text)
                //    {
                //        dataGridView1.Rows.Add(
                //            podcast.Titel, podcast.Beskrivning, podcast.PoddAvsnitt != null ? podcast.PoddAvsnitt.Count : 0);
                //    }
                //}
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

        private void CellKlickad(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Podcast valdPodcast = laddadePoddar[e.RowIndex];

            new PoddInfo(valdPodcast).Show();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            menyForm.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            menyForm.Show();
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
