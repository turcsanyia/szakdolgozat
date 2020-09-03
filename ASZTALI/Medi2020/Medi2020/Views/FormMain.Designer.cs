namespace Medi2020.Views
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemBetegfelvetel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrvosok = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrvosiRendelesek = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPenzugyek = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBetegfelvetel,
            this.toolStripMenuItemOrvosok,
            this.toolStripMenuItemOrvosiRendelesek,
            this.toolStripMenuItemPenzugyek,
            this.toolStripMenuItemKilepes});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 40);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemBetegfelvetel
            // 
            this.toolStripMenuItemBetegfelvetel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemBetegfelvetel.Image")));
            this.toolStripMenuItemBetegfelvetel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemBetegfelvetel.Name = "toolStripMenuItemBetegfelvetel";
            this.toolStripMenuItemBetegfelvetel.Size = new System.Drawing.Size(119, 36);
            this.toolStripMenuItemBetegfelvetel.Text = "Betegfelvétel";
            this.toolStripMenuItemBetegfelvetel.Click += new System.EventHandler(this.toolStripMenuItemBetegfelvetel_Click);
            // 
            // toolStripMenuItemOrvosok
            // 
            this.toolStripMenuItemOrvosok.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemOrvosok.Image")));
            this.toolStripMenuItemOrvosok.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemOrvosok.Name = "toolStripMenuItemOrvosok";
            this.toolStripMenuItemOrvosok.Size = new System.Drawing.Size(95, 36);
            this.toolStripMenuItemOrvosok.Text = "Orvosok";
            this.toolStripMenuItemOrvosok.Click += new System.EventHandler(this.toolStripMenuItemOrvosok_Click);
            // 
            // toolStripMenuItemOrvosiRendelesek
            // 
            this.toolStripMenuItemOrvosiRendelesek.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemOrvosiRendelesek.Image")));
            this.toolStripMenuItemOrvosiRendelesek.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemOrvosiRendelesek.Name = "toolStripMenuItemOrvosiRendelesek";
            this.toolStripMenuItemOrvosiRendelesek.Size = new System.Drawing.Size(144, 36);
            this.toolStripMenuItemOrvosiRendelesek.Text = "Orvosi rendelések";
            this.toolStripMenuItemOrvosiRendelesek.Click += new System.EventHandler(this.toolStripMenuItemOrvosiRendelesek_Click);
            // 
            // toolStripMenuItemPenzugyek
            // 
            this.toolStripMenuItemPenzugyek.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemPenzugyek.Image")));
            this.toolStripMenuItemPenzugyek.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemPenzugyek.Name = "toolStripMenuItemPenzugyek";
            this.toolStripMenuItemPenzugyek.Size = new System.Drawing.Size(108, 36);
            this.toolStripMenuItemPenzugyek.Text = "Pénzügyek";
            this.toolStripMenuItemPenzugyek.Click += new System.EventHandler(this.toolStripMenuItemPenzugyek_Click);
            // 
            // toolStripMenuItemKilepes
            // 
            this.toolStripMenuItemKilepes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemKilepes.Image")));
            this.toolStripMenuItemKilepes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemKilepes.Name = "toolStripMenuItemKilepes";
            this.toolStripMenuItemKilepes.Size = new System.Drawing.Size(88, 36);
            this.toolStripMenuItemKilepes.Text = "Kilépés";
            this.toolStripMenuItemKilepes.Click += new System.EventHandler(this.toolStripMenuItemKilepes_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medi-2020 Bt. adminisztrációs szoftver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBetegfelvetel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrvosok;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrvosiRendelesek;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKilepes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPenzugyek;
    }
}