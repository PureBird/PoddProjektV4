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
        private readonly Meny _menyForm;
        private bool trycktTillbaka = false;
        public Kategorier(Meny meny, PoddService poddService)
        {
            _poddService = poddService;
            _menyForm = meny;

            InitializeComponent();

            

            RensaUI();
            EditRbn.Checked = true;

            FyllCbxMedKategorierAsync();
        }

        public async void FyllCbxMedKategorierAsync()
        {
            List<string> UnikaKategorier = await _poddService.HamtaUnikaKategorier();
            for (int i = 0; i < UnikaKategorier.Count; i++)
            {
                CatCbx.Items.Add(UnikaKategorier[i]);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            trycktTillbaka = true;
            _menyForm.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(!trycktTillbaka) Application.Exit();
            base.OnFormClosing(e);
        }

        private void RensaUI()
        {
            //Första raden
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

        //När användaren klickar på radera knappen.
        private async void CatBtn_Click(object sender, EventArgs e)
        {
            if (!Validering.IsTomStrang(CatCbx.Text))
            {
                //Frågar en extra gång om användaren är säker på sitt val. Krav*
                var result = MessageBox.Show("Är du säker? Detta går inte att ångra!", 
                    "Du vill radera ALLA platser kategorin: \"" + CatCbx.Text + "\" förekommer på.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int antalRaderade = await _poddService.TaBortKategoriFranAllaAsync(CatCbx.Text);
                    AlertLbl.Text = "Kategorin " + CatCbx.Text + " har raderats från " + antalRaderade + " podcasts.";
                    CatCbx.Items.Remove(CatCbx.Text);
                }
            }
        }

        private async void CatBtnEdit_Click(object sender, EventArgs e)
        {
            if (Validering.IsTomStrang(CatCbx.Text))
            {
                AlertLbl.Text = "Välj en kategori att byta namn på.";
                return;
            }
            else if (Validering.IsTomStrang(CatTbxEdit.Text))
            {
                AlertLbl.Text = "Ange ett nytt namn på kategorin.";
                return;
            }

            //Frågar en extra gång om användaren är säker på sitt val.
            var result = MessageBox.Show("Är du säker? Detta kommer ändra ALLA platser denna kategori" +
                " befinner sig på!", "Du vill redigera namnet på kategorin: \"" + CatCbx.Text + "\".",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int antalAndrade = await _poddService.AndraKategorierForAllaPoddarAsync(CatCbx.Text, CatTbxEdit.Text);
                AlertLbl.Text = "Kategorin \"" + CatCbx.Text + "\" har bytts till sitt nya namn \"" + CatTbxEdit.Text + "\".";
                AlertLblEditCount.Text = "Ändringen påverkade " + antalAndrade + " podcasts.";
                CatCbx.Items[CatCbx.SelectedIndex] = CatTbxEdit.Text;
            }
        }
    }
}
