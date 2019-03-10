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
    public partial class RataForm : Form
    {
        public RataForm()
        {
            InitializeComponent();
        }

        private void tfValCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Caractere invalide");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Caractere invalide");
            }
        }

        private void tfPerioadaCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Caractere invalide");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Caractere invalide");
            }
        }

        private void tfDobanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Caractere invalide");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Caractere invalide");
            }
        }

        // calculeaza rata lunara
        private void btnCalcRata_Click(object sender, EventArgs e)
        {
            if (tfValCredit.Text == "" || tfPerioadaCredit.Text == "" || tfDobanda.Text == "")
            {
                MessageBox.Show("Toate campurile sunt necesasre.");
                return;
            }

            double valCredit = Double.Parse(tfValCredit.Text);
            double perioadaCredit = Double.Parse(tfPerioadaCredit.Text);
            double dobandaCredit = Double.Parse(tfDobanda.Text);

            RataObj rataObj = new RataObj();

            double rata = rataObj.CalculeazaRata(valCredit, perioadaCredit, dobandaCredit);
            tfRezultatRata.Text = rata.ToString();
        }

        // back to main form
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        // Reset button
        private void button2_Click(object sender, EventArgs e)
        {
            tfValCredit.Text = "";
            tfPerioadaCredit.Text = "";
            tfDobanda.Text = "";
            tfRezultatRata.Text = "";
        }
    }
}
