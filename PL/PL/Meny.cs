using BL;
using System.Diagnostics;

namespace PL
{
    public partial class Meny : Form
    {
        private readonly PoddService _poddService;
        public Meny(PoddService poddService)
        {
            InitializeComponent();
            _poddService = poddService;
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register(this, _poddService);

            registerForm.Show();
            this.Hide();
        }

        private void sokBtn_Click(object sender, EventArgs e)
        {
            PodVisaren sokForm = new PodVisaren(this, _poddService);

            sokForm.Show();
            this.Hide();
        }
        private void kategorierBtn_Click(object sender, EventArgs e)
        {
            Kategorier kategoriForm = new Kategorier(this, _poddService);

            kategoriForm.Show();
            this.Hide();
        }
    }
}
