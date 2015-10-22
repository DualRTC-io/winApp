namespace windowControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화면크기설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x720PC20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x768PC17ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x720PC20ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Window Sharing";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.화면크기설정ToolStripMenuItem,
            this.oNOFFToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 92);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 화면크기설정ToolStripMenuItem
            // 
            this.화면크기설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x720PC20ToolStripMenuItem,
            this.x768PC17ToolStripMenuItem,
            this.x720PC20ToolStripMenuItem1});
            this.화면크기설정ToolStripMenuItem.Name = "화면크기설정ToolStripMenuItem";
            this.화면크기설정ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.화면크기설정ToolStripMenuItem.Text = "화면 크기 설정";
            // 
            // oNOFFToolStripMenuItem
            // 
            this.oNOFFToolStripMenuItem.Name = "oNOFFToolStripMenuItem";
            this.oNOFFToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.oNOFFToolStripMenuItem.Text = "OFF(꺼짐)";
            this.oNOFFToolStripMenuItem.Click += new System.EventHandler(this.oNOFFToolStripMenuItem_Click);
            // 
            // x720PC20ToolStripMenuItem
            // 
            this.x720PC20ToolStripMenuItem.Name = "x720PC20ToolStripMenuItem";
            this.x720PC20ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.x720PC20ToolStripMenuItem.Text = "1280 x 720 (PC 20\")";
            // 
            // x768PC17ToolStripMenuItem
            // 
            this.x768PC17ToolStripMenuItem.Name = "x768PC17ToolStripMenuItem";
            this.x768PC17ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.x768PC17ToolStripMenuItem.Text = "1024 x 768 (PC 17\")";
            this.x768PC17ToolStripMenuItem.Click += new System.EventHandler(this.x768PC17ToolStripMenuItem_Click);
            // 
            // x720PC20ToolStripMenuItem1
            // 
            this.x720PC20ToolStripMenuItem1.Name = "x720PC20ToolStripMenuItem1";
            this.x720PC20ToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.x720PC20ToolStripMenuItem1.Text = "1600 x 1200 (Tablet 7\")";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화면크기설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNOFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x720PC20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x768PC17ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x720PC20ToolStripMenuItem1;
    }
}

