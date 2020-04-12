namespace PrintProInc.Forms
{
    partial class PrinterModelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.deletBtn = new MetroFramework.Controls.MetroButton();
            this.ClerarBtn = new MetroFramework.Controls.MetroButton();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.PrinterFirmCB = new MetroFramework.Controls.MetroComboBox();
            this.PrinterModelTB = new MetroFramework.Controls.MetroTextBox();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.dgvPrinterModel = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterModel)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.deletBtn);
            this.metroPanel1.Controls.Add(this.ClerarBtn);
            this.metroPanel1.Controls.Add(this.saveBtn);
            this.metroPanel1.Controls.Add(this.PrinterFirmCB);
            this.metroPanel1.Controls.Add(this.PrinterModelTB);
            this.metroPanel1.Controls.Add(this.ID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(57, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(494, 205);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // deletBtn
            // 
            this.deletBtn.Location = new System.Drawing.Point(284, 132);
            this.deletBtn.Name = "deletBtn";
            this.deletBtn.Size = new System.Drawing.Size(116, 34);
            this.deletBtn.TabIndex = 7;
            this.deletBtn.Text = "Удалить";
            this.deletBtn.UseSelectable = true;
            this.deletBtn.Click += new System.EventHandler(this.deletBtn_Click);
            // 
            // ClerarBtn
            // 
            this.ClerarBtn.Location = new System.Drawing.Point(162, 132);
            this.ClerarBtn.Name = "ClerarBtn";
            this.ClerarBtn.Size = new System.Drawing.Size(116, 34);
            this.ClerarBtn.TabIndex = 6;
            this.ClerarBtn.Text = "Очистить";
            this.ClerarBtn.UseSelectable = true;
            this.ClerarBtn.Click += new System.EventHandler(this.ClerarBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(40, 132);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 34);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // PrinterFirmCB
            // 
            this.PrinterFirmCB.FormattingEnabled = true;
            this.PrinterFirmCB.ItemHeight = 23;
            this.PrinterFirmCB.Location = new System.Drawing.Point(40, 81);
            this.PrinterFirmCB.Name = "PrinterFirmCB";
            this.PrinterFirmCB.Size = new System.Drawing.Size(360, 29);
            this.PrinterFirmCB.TabIndex = 4;
            this.PrinterFirmCB.UseSelectable = true;
            // 
            // PrinterModelTB
            // 
            // 
            // 
            // 
            this.PrinterModelTB.CustomButton.Image = null;
            this.PrinterModelTB.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.PrinterModelTB.CustomButton.Name = "";
            this.PrinterModelTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrinterModelTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrinterModelTB.CustomButton.TabIndex = 1;
            this.PrinterModelTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrinterModelTB.CustomButton.UseSelectable = true;
            this.PrinterModelTB.CustomButton.Visible = false;
            this.PrinterModelTB.Lines = new string[0];
            this.PrinterModelTB.Location = new System.Drawing.Point(40, 35);
            this.PrinterModelTB.MaxLength = 32767;
            this.PrinterModelTB.Name = "PrinterModelTB";
            this.PrinterModelTB.PasswordChar = '\0';
            this.PrinterModelTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrinterModelTB.SelectedText = "";
            this.PrinterModelTB.SelectionLength = 0;
            this.PrinterModelTB.SelectionStart = 0;
            this.PrinterModelTB.ShortcutsEnabled = true;
            this.PrinterModelTB.Size = new System.Drawing.Size(360, 23);
            this.PrinterModelTB.TabIndex = 3;
            this.PrinterModelTB.UseSelectable = true;
            this.PrinterModelTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrinterModelTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(40, 13);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 19);
            this.ID.TabIndex = 2;
            this.ID.Text = "0";
            // 
            // dgvPrinterModel
            // 
            this.dgvPrinterModel.AllowUserToResizeRows = false;
            this.dgvPrinterModel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinterModel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinterModel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterModel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrinterModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinterModel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrinterModel.EnableHeadersVisualStyles = false;
            this.dgvPrinterModel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinterModel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterModel.Location = new System.Drawing.Point(57, 308);
            this.dgvPrinterModel.Name = "dgvPrinterModel";
            this.dgvPrinterModel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterModel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrinterModel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinterModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinterModel.Size = new System.Drawing.Size(494, 172);
            this.dgvPrinterModel.TabIndex = 1;
            this.dgvPrinterModel.SelectionChanged += new System.EventHandler(this.dgvPrinterModel_SelectionChanged);
            // 
            // PrinterModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 503);
            this.Controls.Add(this.dgvPrinterModel);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PrinterModelForm";
            this.Text = "Молель принтера";
            this.Load += new System.EventHandler(this.PrinterModelForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvPrinterModel;
        private MetroFramework.Controls.MetroComboBox PrinterFirmCB;
        private MetroFramework.Controls.MetroTextBox PrinterModelTB;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroButton deletBtn;
        private MetroFramework.Controls.MetroButton ClerarBtn;
    }
}