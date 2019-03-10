using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculeazaDobanda
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // show form rata
        private void btnRata_Click(object sender, EventArgs e)
        {
            RataForm form = new RataForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        // shoW form dobanda
        private void btnDobanda_Click(object sender, EventArgs e)
        {
            DobandaForm form = new DobandaForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
