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
        private Boolean isChrome = true;
        private Boolean isFirefox = true;
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
                System.Diagnostics.Process IEProcess = new System.Diagnostics.Process();
                IEProcess.StartInfo.FileName = "chrome.exe";
                IEProcess.StartInfo.Arguments = "https://112.108.40.152";
                try 
                {
                    IEProcess.Start();
                }
                catch
                {
                    isChrome = false;
                }

                if (!isChrome)
                {
                    IEProcess.StartInfo.FileName = "firefox.exe";
                    IEProcess.StartInfo.Arguments = "https://112.108.40.152";
                    try
                    {
                        IEProcess.Start();
                    }
                    catch
                    {
                        isFirefox = false;
                    }
                }
                if (!isChrome && !isFirefox)
                {
                    MessageBox.Show("크롬과 파이어폭스가 없어염.ㅠㅠ");
                }
            
                
                oNOFFToolStripMenuItem.Text = "ON(켜짐)";
                isRun = !isRun;
            }
        }

        private void x768PC17ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
