using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowControl
{
    public partial class Form1 : Form
    {
        private Boolean isRun = false;
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oNOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                oNOFFToolStripMenuItem.Text = "OFF(꺼짐)";
                isRun = !isRun;
            }
            else
            {
                oNOFFToolStripMenuItem.Text = "ON(켜짐)";
                isRun = !isRun;
            }
        }

        private void x768PC17ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
