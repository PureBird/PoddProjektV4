using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class GhostWindow : Form
    {
        public GhostWindow()
        {
            InitializeComponent();
            StartProgram();
        }
        private void StartProgram()
        {
            this.Hide();
            Meny menyForm = new Meny();
            menyForm.Show();
        }
    }
}
