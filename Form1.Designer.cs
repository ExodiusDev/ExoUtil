namespace ExoUtil
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killSpotifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.killRobloxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.killDiscordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.killRobloxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "hide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ExoUtils by Exodius";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killSpotifyToolStripMenuItem1,
            this.killRobloxToolStripMenuItem1,
            this.killDiscordToolStripMenuItem1,
            this.toolStripSeparator1,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip2";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 120);
            // 
            // killSpotifyToolStripMenuItem1
            // 
            this.killSpotifyToolStripMenuItem1.Name = "killSpotifyToolStripMenuItem1";
            this.killSpotifyToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.killSpotifyToolStripMenuItem1.Text = "Kill Spotify";
            this.killSpotifyToolStripMenuItem1.Click += new System.EventHandler(this.killSpotifyToolStripMenuItem1_Click);
            // 
            // killRobloxToolStripMenuItem1
            // 
            this.killRobloxToolStripMenuItem1.Name = "killRobloxToolStripMenuItem1";
            this.killRobloxToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.killRobloxToolStripMenuItem1.Text = "Kill Roblox";
            this.killRobloxToolStripMenuItem1.Click += new System.EventHandler(this.killRobloxToolStripMenuItem1_Click);
            // 
            // killDiscordToolStripMenuItem1
            // 
            this.killDiscordToolStripMenuItem1.Name = "killDiscordToolStripMenuItem1";
            this.killDiscordToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.killDiscordToolStripMenuItem1.Text = "Kill Discord";
            this.killDiscordToolStripMenuItem1.Click += new System.EventHandler(this.killDiscordToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // killRobloxToolStripMenuItem
            // 
            this.killRobloxToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.killRobloxToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.killRobloxToolStripMenuItem.Name = "killRobloxToolStripMenuItem";
            this.killRobloxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.killRobloxToolStripMenuItem.Text = "Kill Roblox";
            this.killRobloxToolStripMenuItem.Click += new System.EventHandler(this.killRobloxToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 73);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExoUtils";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killSpotifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem killRobloxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem killDiscordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem killRobloxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    }
}

