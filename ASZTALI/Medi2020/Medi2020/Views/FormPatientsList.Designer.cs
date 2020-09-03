namespace Medi2020.Views
{
    partial class FormPatientsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientsList));
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hozzáadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OsszesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PrevButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSearch = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.Tajszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vezeteknev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keresztnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iranyitoszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telepules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lakcim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AllowUserToOrderColumns = true;
            this.dataGridViewPatients.AllowUserToResizeRows = false;
            this.dataGridViewPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tajszam,
            this.Vezeteknev,
            this.Keresztnev,
            this.Iranyitoszam,
            this.Telepules,
            this.Lakcim,
            this.Email,
            this.Telefon});
            this.dataGridViewPatients.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewPatients.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(760, 520);
            this.dataGridViewPatients.TabIndex = 0;
            this.dataGridViewPatients.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPatients_ColumnHeaderMouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hozzáadásToolStripMenuItem,
            this.szerkesztésToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(133, 70);
            // 
            // hozzáadásToolStripMenuItem
            // 
            this.hozzáadásToolStripMenuItem.Name = "hozzáadásToolStripMenuItem";
            this.hozzáadásToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.hozzáadásToolStripMenuItem.Text = "Hozzáadás";
            this.hozzáadásToolStripMenuItem.Click += new System.EventHandler(this.hozzáadásToolStripMenuItem_Click);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.Click += new System.EventHandler(this.szerkesztésToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OsszesLabel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 568);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 43);
            this.panel1.TabIndex = 12;
            // 
            // OsszesLabel
            // 
            this.OsszesLabel.AutoSize = true;
            this.OsszesLabel.Location = new System.Drawing.Point(12, 12);
            this.OsszesLabel.Name = "OsszesLabel";
            this.OsszesLabel.Size = new System.Drawing.Size(59, 13);
            this.OsszesLabel.TabIndex = 3;
            this.OsszesLabel.Text = "Összesen: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PrevButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(201, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 42);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevButton.Location = new System.Drawing.Point(86, 9);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(58, 23);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstButton.Location = new System.Drawing.Point(9, 9);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(58, 23);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastButton.Location = new System.Drawing.Point(318, 9);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(58, 23);
            this.LastButton.TabIndex = 3;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.Location = new System.Drawing.Point(240, 9);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(58, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0/0";
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearch,
            this.toolStripButtonSearch,
            this.toolStripButtonSave});
            this.toolStripSearch.Location = new System.Drawing.Point(0, 0);
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(784, 39);
            this.toolStripSearch.TabIndex = 13;
            this.toolStripSearch.Text = "toolStrip1";
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 39);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(82, 36);
            this.toolStripButtonSearch.Text = "Keresés";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(74, 36);
            this.toolStripButtonSave.Text = "Mentés";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // Tajszam
            // 
            this.Tajszam.DataPropertyName = "Taj";
            this.Tajszam.HeaderText = "TAJ szám";
            this.Tajszam.Name = "Tajszam";
            this.Tajszam.ReadOnly = true;
            // 
            // Vezeteknev
            // 
            this.Vezeteknev.DataPropertyName = "Vezeteknev";
            this.Vezeteknev.HeaderText = "Vezetéknév";
            this.Vezeteknev.Name = "Vezeteknev";
            this.Vezeteknev.ReadOnly = true;
            // 
            // Keresztnev
            // 
            this.Keresztnev.DataPropertyName = "Keresztnev";
            this.Keresztnev.HeaderText = "Keresztnév";
            this.Keresztnev.Name = "Keresztnev";
            this.Keresztnev.ReadOnly = true;
            // 
            // Iranyitoszam
            // 
            this.Iranyitoszam.DataPropertyName = "Iranyitoszam";
            this.Iranyitoszam.HeaderText = "Iranyítószám";
            this.Iranyitoszam.Name = "Iranyitoszam";
            this.Iranyitoszam.ReadOnly = true;
            // 
            // Telepules
            // 
            this.Telepules.DataPropertyName = "Telepules";
            this.Telepules.HeaderText = "Település";
            this.Telepules.Name = "Telepules";
            this.Telepules.ReadOnly = true;
            // 
            // Lakcim
            // 
            this.Lakcim.DataPropertyName = "Lakcim";
            this.Lakcim.HeaderText = "Lakcím";
            this.Lakcim.Name = "Lakcim";
            this.Lakcim.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail cím";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // FormPatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.toolStripSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewPatients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPatientsList";
            this.Text = "Betegfelvétel";
            this.Load += new System.EventHandler(this.FormPatiens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripSearch.ResumeLayout(false);
            this.toolStripSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OsszesLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripSearch;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem hozzáadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tajszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vezeteknev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keresztnev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iranyitoszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telepules;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lakcim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
    }
}