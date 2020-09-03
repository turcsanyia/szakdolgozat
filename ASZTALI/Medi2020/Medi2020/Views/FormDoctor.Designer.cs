namespace Medi2020.Views
{
    partial class FormDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctor));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVezeteknev = new System.Windows.Forms.TextBox();
            this.textBoxKeresztnev = new System.Windows.Forms.TextBox();
            this.comboBoxSzakterulet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMegse = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVezeteknev, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKeresztnev, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSzakterulet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 334);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vezetéknév";
            // 
            // textBoxVezeteknev
            // 
            this.textBoxVezeteknev.Location = new System.Drawing.Point(176, 3);
            this.textBoxVezeteknev.Name = "textBoxVezeteknev";
            this.textBoxVezeteknev.Size = new System.Drawing.Size(255, 20);
            this.textBoxVezeteknev.TabIndex = 1;
            // 
            // textBoxKeresztnev
            // 
            this.textBoxKeresztnev.Location = new System.Drawing.Point(176, 114);
            this.textBoxKeresztnev.Name = "textBoxKeresztnev";
            this.textBoxKeresztnev.Size = new System.Drawing.Size(255, 20);
            this.textBoxKeresztnev.TabIndex = 2;
            // 
            // comboBoxSzakterulet
            // 
            this.comboBoxSzakterulet.DisplayMember = "Nev";
            this.comboBoxSzakterulet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSzakterulet.FormattingEnabled = true;
            this.comboBoxSzakterulet.Location = new System.Drawing.Point(176, 225);
            this.comboBoxSzakterulet.Name = "comboBoxSzakterulet";
            this.comboBoxSzakterulet.Size = new System.Drawing.Size(255, 21);
            this.comboBoxSzakterulet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Szakterület";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Keresztnév";
            // 
            // buttonMegse
            // 
            this.buttonMegse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMegse.Location = new System.Drawing.Point(371, 352);
            this.buttonMegse.Name = "buttonMegse";
            this.buttonMegse.Size = new System.Drawing.Size(75, 23);
            this.buttonMegse.TabIndex = 7;
            this.buttonMegse.Text = "Mégse";
            this.buttonMegse.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 352);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 387);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonMegse);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orvos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVezeteknev;
        private System.Windows.Forms.TextBox textBoxKeresztnev;
        private System.Windows.Forms.ComboBox comboBoxSzakterulet;
        private System.Windows.Forms.Button buttonMegse;
        private System.Windows.Forms.Button buttonOk;
    }
}