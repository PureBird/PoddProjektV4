using PoddProjektV4.BL;

namespace PL
{
    public partial class Kategorier : Form
    {
        private readonly PoddService _poddService;
        private readonly Meny _menyForm;
        private bool trycktTillbaka = false;
        public Kategorier(Meny meny, PoddService poddService)
        {
            InitializeComponent();

            _poddService = poddService;
            _menyForm = meny;

            RensaUI();
            EditRbn.Checked = true;

            FyllCbxMedKategorierAsync();
        }

        public async void FyllCbxMedKategorierAsync()
        {
            CatCbx.Enabled = false;
            List<string> UnikaKategorier = await _poddService.HamtaUnikaKategorier();
            for (int i = 0; i < UnikaKategorier.Count; i++)
            {
                //Begränsar längden på kategorinamn i comboboxen till 15 karaktärer.
                CatCbx.Items.Add(Validering.StrangMaxLangd(UnikaKategorier[i], 15));
            }
            CatCbx.Enabled = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            trycktTillbaka = true;
            _menyForm.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!trycktTillbaka) Application.Exit();
            base.OnFormClosing(e);
        }

        private void RensaUI()
        {
            //Första raden
            CatCbx.Visible = false;
            CatBtn.Visible = false;
            AlertLbl.Text = "";

            //Andra raden
            CatLblEdit.Visible = false;
            CatTbxEdit.Visible = false;
            CatTbxEdit.Text = "";
            CatBtnEdit.Visible = false;
            AlertLblEditCount.Text = "";
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
            //Första raden
            CatLbl.Text = "Kategorin som du vill radera:";
            CatCbx.Visible = true;
            CatBtn.Visible = true;
            CatBtn.Text = "Radera";
        }

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
                    string KategoriAttRadera = CatCbx.Text;
                    //Om namnet i CatCbx är längre än 15 tecken,
                    //är namnet trunkerat och vi måste hämta det fullständiga namnet.
                    if (CatCbx.Text.Length > 15)
                    {
                        var TempLista = await _poddService.HamtaUnikaKategorier();
                        KategoriAttRadera = TempLista[CatCbx.SelectedIndex];
                    }

                    int antalRaderade = await _poddService.TaBortKategoriFranAllaAsync(KategoriAttRadera);
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
                string KategoriAttRadera = CatCbx.Text;
                //Om namnet i CatCbx är längre än 15 tecken,
                //är namnet trunkerat och vi måste hämta det fullständiga namnet.
                if (CatCbx.Text.Length > 15)
                {
                    var TempLista = await _poddService.HamtaUnikaKategorier();
                    KategoriAttRadera = TempLista[CatCbx.SelectedIndex];
                }

                int antalAndrade = await _poddService.AndraKategorierForAllaPoddarAsync(KategoriAttRadera, CatTbxEdit.Text);
                AlertLbl.Text = "Kategorin \"" + CatCbx.Text + "\" har bytts till sitt nya namn \"" + CatTbxEdit.Text + "\".";
                AlertLblEditCount.Text = "Ändringen påverkade " + antalAndrade + " podcasts.";
                //Uppdaterar namnet i comboboxen. Trunkerar om det är längre än 15 tecken.
                CatCbx.Items[CatCbx.SelectedIndex] = Validering.StrangMaxLangd(CatTbxEdit.Text, 15);
            }
        }

        private void CatTbxEdit_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = CatBtnEdit;
        }

        private void CatCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeleteRbn.Checked)
            {
                AcceptButton = CatBtn;
            }
            else if (EditRbn.Checked)
            {
                AcceptButton = CatBtnEdit;
            }
        }
    }
}
