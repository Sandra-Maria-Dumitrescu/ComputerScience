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
    public partial class DobandaForm : Form
    {
        public DobandaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void tfSumaDepusa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tfRataDobanda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tfDurata_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCalcDobanda_Click(object sender, EventArgs e)
        {
            if (tfSumaDepusa.Text == "" || tfRataDobanda.Text == "" || tfDurata.Text == "")
            {
                MessageBox.Show("Toate campurile sunt necesasre.");
                return;
            }

            double suma = Double.Parse(tfSumaDepusa.Text);
           // MessageBox.Show("Suma1: "+ tfSumaDepusa.Text);
           // MessageBox.Show("Suma2: " + suma);


            double perioadaDepozit = Double.Parse(tfDurata.Text);
            double dobandaDepozit = Double.Parse(tfRataDobanda.Text);

            DobandaObj dobandaObj= new DobandaObj();
            double dobanda = dobandaObj.CalculeazaDobanda(suma, dobandaDepozit, perioadaDepozit);
            tfRezultatDobanda.Text = dobanda.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tfSumaDepusa.Text = "";
            tfRataDobanda.Text = "";
            tfDurata.Text = "";
            tfRezultatDobanda.Text = "";
        }
    }
}
