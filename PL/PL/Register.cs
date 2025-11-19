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


namespace PL
{
    public partial class Register : Form
    {
        private PoddService service;
        public Register()
        {
            InitializeComponent();
            
            var mongoDB = new MongoDBServices();
            var repo = new PoddRepository(mongoDB);
            service = new PoddService(repo);

            this.Load += FyllSida;
        }

        private void FyllSida(object sender, EventArgs e)
        {
            FyllRegister(sender, e);
            FyllComboBox(sender, e);
        }

        private void FyllComboBox(object sender, EventArgs e)
        {
            FilterComboBox.Items.Add("AllaPoddar");
            List<string> kategoriLista = new List<string>(); 
            kategoriLista = service.HamtaUnikaKategorier();

            foreach (var kategori in kategoriLista) {
                FilterComboBox.Items.Add(kategori);
            }

        }

        private void FyllRegister(object sender, EventArgs e)
        {
            var allaPoddar = service.HamtaAllaPoddar();
            dataGridView1.Rows.Clear();

            foreach (var podcast in allaPoddar)
            {
                dataGridView1.Rows.Add(
                    podcast.Titel, podcast.Beskrivning, podcast.PoddAvsnitt != null ? podcast.PoddAvsnitt.Count : 0);
            }
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            //Meny menyForm = new Meny();
            //menyForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
