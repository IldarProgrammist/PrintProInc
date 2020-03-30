namespace PrintProInc
{
    partial class PrinterFirmForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrinterFirmID = new System.Windows.Forms.Label();
            this.DgvPrinterFirm = new MetroFramework.Controls.MetroGrid();
            this.PrinterFirmNameTB = new MetroFramework.Controls.MetroTextBox();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.Clear = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrinterFirm)).BeginInit();
            this.SuspendLayout();
            // 
            // PrinterFirmID
            // 
            this.PrinterFirmID.AutoSize = true;
            this.PrinterFirmID.Location = new System.Drawing.Point(137, 61);
            this.PrinterFirmID.Name = "PrinterFirmID";
            this.PrinterFirmID.Size = new System.Drawing.Size(13, 13);
            this.PrinterFirmID.TabIndex = 1;
            this.PrinterFirmID.Text = "0";
            // 
            // DgvPrinterFirm
            // 
            this.DgvPrinterFirm.AllowUserToResizeRows = false;
            this.DgvPrinterFirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvPrinterFirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPrinterFirm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvPrinterFirm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPrinterFirm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPrinterFirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPrinterFirm.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPrinterFirm.EnableHeadersVisualStyles = false;
            this.DgvPrinterFirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvPrinterFirm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvPrinterFirm.Location = new System.Drawing.Point(140, 247);
            this.DgvPrinterFirm.Name = "DgvPrinterFirm";
            this.DgvPrinterFirm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPrinterFirm.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPrinterFirm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvPrinterFirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrinterFirm.Size = new System.Drawing.Size(256, 150);
            this.DgvPrinterFirm.TabIndex = 3;
            this.DgvPrinterFirm.SelectionChanged += new System.EventHandler(this.DgvPrinterFirm_SelectionChanged);
            // 
            // PrinterFirmNameTB
            // 
            // 
            // 
            // 
            this.PrinterFirmNameTB.CustomButton.Image = null;
            this.PrinterFirmNameTB.CustomButton.Location = new System.Drawing.Point(367, 1);
            this.PrinterFirmNameTB.CustomButton.Name = "";
            this.PrinterFirmNameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrinterFirmNameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrinterFirmNameTB.CustomButton.TabIndex = 1;
            this.PrinterFirmNameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrinterFirmNameTB.CustomButton.UseSelectable = true;
            this.PrinterFirmNameTB.CustomButton.Visible = false;
            this.PrinterFirmNameTB.Lines = new string[0];
            this.PrinterFirmNameTB.Location = new System.Drawing.Point(140, 105);
            this.PrinterFirmNameTB.MaxLength = 32767;
            this.PrinterFirmNameTB.Name = "PrinterFirmNameTB";
            this.PrinterFirmNameTB.PasswordChar = '\0';
            this.PrinterFirmNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrinterFirmNameTB.SelectedText = "";
            this.PrinterFirmNameTB.SelectionLength = 0;
            this.PrinterFirmNameTB.SelectionStart = 0;
            this.PrinterFirmNameTB.ShortcutsEnabled = true;
            this.PrinterFirmNameTB.Size = new System.Drawing.Size(389, 23);
            this.PrinterFirmNameTB.TabIndex = 4;
            this.PrinterFirmNameTB.UseSelectable = true;
            this.PrinterFirmNameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrinterFirmNameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(140, 155);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(118, 42);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(278, 155);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(118, 42);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Очистить";
            this.Clear.UseSelectable = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(411, 155);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 42);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Удалить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PrinterFirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.PrinterFirmNameTB);
            this.Controls.Add(this.DgvPrinterFirm);
            this.Controls.Add(this.PrinterFirmID);
            this.Name = "PrinterFirmForm";
            this.Text = "Фирмы принтеров";
            this.Load += new System.EventHandler(this.PrinterFirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrinterFirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PrinterFirmID;
        private MetroFramework.Controls.MetroGrid DgvPrinterFirm;
        private MetroFramework.Controls.MetroTextBox PrinterFirmNameTB;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton Clear;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

