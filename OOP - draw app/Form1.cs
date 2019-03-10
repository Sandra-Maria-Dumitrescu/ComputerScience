using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOO_Proiect1
{
    public partial class Form1 : Form
    {
        PointF a, b;
        int click = 0;
        int currentEvent = 0; //1 pt linie, 2 pt cerc, 3 rectangle

        public Form1()
        {
            InitializeComponent();
            a = new PointF();
            b = new PointF();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void despreAplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatie realizata pentru disciplina APOO.\nStudent: Sandra Maria Dumitrescu\nAn II Informatica", "APOO -Proiect 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            currentEvent = 1;
            Events();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentEvent = 2;
            Events();
        }

        Picture p;
        private void pbTable_MouseUp(object sender, MouseEventArgs e)
        {
            if (click == 0)
            {
                a.X = e.X;
                a.Y = e.Y;
                click++;
            }
            else if (click == 1)
            {
                b.X = e.X;
                b.Y = e.Y;
                click++;

                if (currentEvent == 1)
                {
                    Line l = new Line(a, b, pbTable);
                    GraphicTool.graphics.Add(l);
                    GraphicTool.Draw(l);
                }
                else
                {
                    Circle c = new Circle(a, b, pbTable);
                    GraphicTool.graphics.Add(c);
                    GraphicTool.Draw(c);
                }
            }
        }

        public void Events()
        {
            if (click > 0)
            {
                pbTable.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.pbTable_MouseUp);
                click = 0;
            }

            pbTable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbTable_MouseUp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbTable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbTable_MouseDown);

        }

        private void pbTable_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Picture();
            foreach (Graphic g in GraphicTool.graphics)
            {
                p.Add(g);
            }
            p.Move((PointF)e.Location);

            pbTable.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.pbTable_MouseDown);
        }

    }
}
