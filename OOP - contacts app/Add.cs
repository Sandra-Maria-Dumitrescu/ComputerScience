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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbID.Text != "" && tbName.Text != "" && tbFName.Text != "" && tbPhone.Text != "" && tbEmail.Text != "")
            {
                Contact c = new Contact(Convert.ToInt32(tbID.Text),
                                        tbName.Text,
                                        tbFName.Text,
                                        tbPhone.Text,
                                        tbEmail.Text);
                AddComand a = new AddComand(c);
                a.execute();
                Form1.hl.Add(a);
                Program.f1.RefreshDGV();
                this.Dispose();

                //Program.f1.Test();
            }        
        }

        private void Add_Load(object sender, EventArgs e)
        {
            tbID.Text = SQL.getMaxID().ToString();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
