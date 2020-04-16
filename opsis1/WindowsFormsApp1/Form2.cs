using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WindowsFormsApp1
{
    
public partial class menu : Form
    {
       //[DllImport("User32.dll")]
        public menu()
        {
            InitializeComponent();
        }
        int n = 0;
        public event FormClosingEventHandler FormClosing;
        private void Lab1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
            n++;
        }

        private void Lab2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        Form3 form3;
        private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show($"Are you sure want to close current window {MdiChildren.Length}?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    ActiveMdiChild.Close();
                    break;
                case DialogResult.No:
                    //Action if No
                    break;
            }
            if (form3 == null)
            { closeToolStripMenuItem1.Visible = false; }

        }
        private void CreateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
            closeToolStripMenuItem1.Visible = true;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show($" Are you sure want close progect)", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    ActiveForm.Close();
                    break;
                case DialogResult.No:
                    break;


            }
        }

        private void CollapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show($" Are you sure want close all mdi window)", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    for (int i = 0; i <= MdiChildren.Count(); i++)
                        ActiveMdiChild.WindowState = FormWindowState.Minimized;
                    break;
                case DialogResult.No:
                    break;


            }
        }

        private void PlaceInWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void PlaceInWindowVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void NamberOfWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show($"namber child - {MdiChildren.Count()}", "About program", MessageBoxButtons.OK, MessageBoxIcon.Information))
            {
                case DialogResult.OK:
                    break;
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            switch (MessageBox.Show("you are sure?", "close window", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case DialogResult.Yes:
                    base.OnClosed(e);
                    break;
                case DialogResult.No:
                    break;

            }

        }
        private void Lab3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            //f.MdiParent = this;
            f.Show();
            //f.Opacity = .50;
            
        }
    }
    
}
