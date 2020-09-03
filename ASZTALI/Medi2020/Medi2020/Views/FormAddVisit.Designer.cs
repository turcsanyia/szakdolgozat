namespace Medi2020.Views
{
    partial class FormAddVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddVisit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOrvos = new System.Windows.Forms.ComboBox();
            this.comboBoxBeteg = new System.Windows.Forms.ComboBox();
            this.comboBoxSzolgaltatas = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIdopont = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonMegse = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxOrvos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBeteg, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSzolgaltatas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerIdopont, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 334);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beteg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Orvos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Szolgáltatás";
            // 
            // comboBoxOrvos
            // 
            this.comboBoxOrvos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrvos.FormattingEnabled = true;
            this.comboBoxOrvos.Location = new System.Drawing.Point(176, 86);
            this.comboBoxOrvos.Name = "comboBoxOrvos";
            this.comboBoxOrvos.Size = new System.Drawing.Size(254, 21);
            this.comboBoxOrvos.TabIndex = 2;
            // 
            // comboBoxBeteg
            // 
            this.comboBoxBeteg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBeteg.FormattingEnabled = true;
            this.comboBoxBeteg.Location = new System.Drawing.Point(176, 3);
            this.comboBoxBeteg.Name = "comboBoxBeteg";
            this.comboBoxBeteg.Size = new System.Drawing.Size(254, 21);
            this.comboBoxBeteg.TabIndex = 1;
            // 
            // comboBoxSzolgaltatas
            // 
            this.comboBoxSzolgaltatas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSzolgaltatas.FormattingEnabled = true;
            this.comboBoxSzolgaltatas.Location = new System.Drawing.Point(176, 169);
            this.comboBoxSzolgaltatas.Name = "comboBoxSzolgaltatas";
            this.comboBoxSzolgaltatas.Size = new System.Drawing.Size(254, 21);
            this.comboBoxSzolgaltatas.TabIndex = 3;
            // 
            // dateTimePickerIdopont
            // 
            this.dateTimePickerIdopont.Location = new System.Drawing.Point(176, 252);
            this.dateTimePickerIdopont.Name = "dateTimePickerIdopont";
            this.dateTimePickerIdopont.Size = new System.Drawing.Size(254, 20);
            this.dateTimePickerIdopont.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Időpont";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 352);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonMegse
            // 
            this.buttonMegse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMegse.Location = new System.Drawing.Point(371, 352);
            this.buttonMegse.Name = "buttonMegse";
            this.buttonMegse.Size = new System.Drawing.Size(75, 23);
            this.buttonMegse.TabIndex = 6;
            this.buttonMegse.Text = "Mégse";
            this.buttonMegse.UseVisualStyleBackColor = true;
            // 
            // FormVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 387);
            this.Controls.Add(this.buttonMegse);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orvosi rendelés";
            this.Load += new System.EventHandler(this.FormVisit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonMegse;
        private System.Windows.Forms.DateTimePicker dateTimePickerIdopont;
        private System.Windows.Forms.ComboBox comboBoxOrvos;
        private System.Windows.Forms.ComboBox comboBoxBeteg;
        private System.Windows.Forms.ComboBox comboBoxSzolgaltatas;
    }
}