using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Edit : Form
    {
        #region Variabile
        List<string> old = new List<string>();
        #endregion

        #region Constructor
        public Edit(List<string> date)
        {
            InitializeComponent();
            tbID.Text = date[0];
            tbName.Text = date[1];
            tbFName.Text = date[2];
            tbPhone.Text = date[3];
            tbEmail.Text = date[4];
            old = date;
        }
        #endregion

        #region Buttons & ButtonEvents
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && tbName.Text != "" && tbFName.Text != "" && tbPhone.Text != "" && tbEmail.Text != "")
            {
                Contact old_c = new Contact(Convert.ToInt32(old[0]), old[1], old[2], old[3], old[4]);
                Contact new_c = new Contact(Convert.ToInt32(tbID.Text),
                                            tbName.Text,
                                            tbFName.Text,
                                            tbPhone.Text,
                                            tbEmail.Text);
                EditComand a = new EditComand(old_c, new_c);
                a.execute();
                Form1.hl.Add(a);
                Program.f1.RefreshDGV();
                this.Dispose();

                Program.f1.Test();
            }        
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        #endregion
    }
}
