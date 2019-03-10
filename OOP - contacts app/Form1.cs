using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Agenda
{
    public partial class Form1 : Form
    {
        #region Variabile
        static DataGridViewRow row = new DataGridViewRow();
        public static HistoryList hl = new HistoryList();
        Image UndoOn = Image.FromFile(@"D:\Facultate\APOO-Agenda\Agenda\img\undo.png");
        Image UndoOff = Image.FromFile(@"D:\Facultate\APOO-Agenda\Agenda\img\undooff.png");
        Image RedoOn = Image.FromFile(@"D:\Facultate\APOO-Agenda\Agenda\img\redo.png");
        Image RedoOff = Image.FromFile(@"D:\Facultate\APOO-Agenda\Agenda\img\redooff.png");
        Image RemoveOff = Image.FromFile(@"D:\Facultate\APOO-Agenda\Agenda\img\remove_off.png");
        Image RemoveOn = Image.FromFile(@"D:\Facultate\APOO-Agenda\Agenda\img\remove.png");
        Image EditOff = Image.FromFile(@"D:\Facultate\APOO-Agenda\Agenda\img\edit_off.png");
        Image EditOn = Image.FromFile(@"D:\Facultate\APOO-Agenda\Agenda\img\edit.png");
        static List<string> date = new List<string>();
        #endregion

        #region Form & FormEvents
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gUI_DGVTableAdapter.Fill(this.agendaDataSet.GUI_DGV);
            Disable();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                Thread.Sleep(1000);
                notifyIcon1.ShowBalloonTip(1000, "Hello", "Agenda is running!", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        #endregion

        #region Enable/Disable
        public void Enable()
        {
            btRemove.Enabled = true;
            btEdit.Enabled = true;
        }

        public void EnableUndo()
        {
            btUndo.Enabled = true;
        }

        public void DisableUndo()
        {
            btUndo.Enabled = false;
        }

        public void EnableRedo()
        {
            btRedo.Enabled = true;
        }

        public void DisableRedo()
        {
            btRedo.Enabled = false;
        }

        public void Disable()
        {
            btRemove.Enabled = false;
            btEdit.Enabled = false;
            btUndo.Enabled = false;
            btRedo.Enabled = false;
        }

        public void Test()
        {
            if (!hl.Before())
                EnableUndo();
            else DisableUndo();

            if (!hl.isLast())
                EnableRedo();
            else DisableRedo();
        }
        #endregion    

        #region Buttons & ButtonEvents
        private void btAdd_Click(object sender, EventArgs e)
        {
            (new Add()).ShowDialog();
        }

        private void btUndo_Click(object sender, EventArgs e)
        {
            if (!hl.Before())
            {
                hl.cmds[hl.cursor].undo();
                hl.Back();
                this.RefreshDGV();
                Test();
            }         
        }   

        private void btRedo_Click(object sender, EventArgs e)
        {
            if (!hl.isLast())
            {
                hl.Forward();
                hl.cmds[hl.cursor].redo();               
                this.RefreshDGV();
                Test();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btUndo_EnabledChanged(object sender, EventArgs e)
        {
            if (btUndo.Enabled == false)
                btUndo.BackgroundImage = UndoOff;
            else btUndo.BackgroundImage = UndoOn;
        }

        private void btRedo_EnabledChanged(object sender, EventArgs e)
        {
            if (btRedo.Enabled == false)
                btRedo.BackgroundImage = RedoOff;
            else btRedo.BackgroundImage = RedoOn;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            (new Edit(date)).ShowDialog();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            Contact c = new Contact(Convert.ToInt32(date[0]), date[1], date[2], date[3], date[4]);
            RemoveComand a = new RemoveComand(c);
            a.execute();
            hl.Add(a);
            RefreshDGV();

            Test();
        }

        private void btRemove_EnabledChanged(object sender, EventArgs e)
        {
            if (btRemove.Enabled == false)
                btRemove.BackgroundImage = RemoveOff;
            else
                btRemove.BackgroundImage = RemoveOn;
        }

        private void btEdit_EnabledChanged(object sender, EventArgs e)
        {
            if (btEdit.Enabled == false)
                btEdit.BackgroundImage = EditOff;
            else
                btEdit.BackgroundImage = EditOn;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Dispose();
        }
        #endregion

        #region DGV & DGVEvents
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btRemove.PerformClick();

            if (e.KeyCode == Keys.Enter)
                btEdit.PerformClick();

            if (e.KeyCode == Keys.Add)
                btAdd.PerformClick();

            if (e.KeyData == (Keys.Control | Keys.Z))
                btUndo.PerformClick();

            if (e.KeyData == (Keys.Control | Keys.X))
                btRedo.PerformClick();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Enable();
                date.Clear();
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                nudIndex.Value = e.RowIndex + 1;
            }
            else
            {
                nudIndex.Value = -1;
                btRemove.Enabled = false;
                btEdit.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Enable();
                date.Clear();
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                date.Add(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                nudIndex.Value = e.RowIndex + 1;
            }
            else
            {
                nudIndex.Value = -1;
                btRemove.Enabled = false;
                btEdit.Enabled = false;
            }
        }

        public void RefreshDGV()
        {
            this.gUI_DGVTableAdapter.Fill(this.agendaDataSet.GUI_DGV);
        }

        #endregion     

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;       
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
