namespace PrintProInc.Forms
{
    partial class PrinterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrinter = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.ClearBtn = new MetroFramework.Controls.MetroButton();
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            this.LacationCB = new MetroFramework.Controls.MetroComboBox();
            this.CatrigeModelCB = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SerialNamberTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ID = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinter)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrinter
            // 
            this.dgvPrinter.AllowUserToResizeRows = false;
            this.dgvPrinter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPrinter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinter.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPrinter.EnableHeadersVisualStyles = false;
            this.dgvPrinter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinter.Location = new System.Drawing.Point(540, 119);
            this.dgvPrinter.Name = "dgvPrinter";
            this.dgvPrinter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinter.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPrinter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinter.Size = new System.Drawing.Size(595, 355);
            this.dgvPrinter.TabIndex = 0;
            this.dgvPrinter.SelectionChanged += new System.EventHandler(this.dgvPrinter_SelectionChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.DeleteBtn);
            this.metroPanel1.Controls.Add(this.ClearBtn);
            this.metroPanel1.Controls.Add(this.SaveBtn);
            this.metroPanel1.Controls.Add(this.LacationCB);
            this.metroPanel1.Controls.Add(this.CatrigeModelCB);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.SerialNamberTB);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.ID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(485, 339);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 158);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Локация:";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(330, 230);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(80, 38);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseSelectable = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(244, 230);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(80, 38);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseSelectable = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(158, 230);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(80, 38);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LacationCB
            // 
            this.LacationCB.FormattingEnabled = true;
            this.LacationCB.ItemHeight = 23;
            this.LacationCB.Location = new System.Drawing.Point(158, 148);
            this.LacationCB.Name = "LacationCB";
            this.LacationCB.Size = new System.Drawing.Size(252, 29);
            this.LacationCB.TabIndex = 10;
            this.LacationCB.UseSelectable = true;
            // 
            // CatrigeModelCB
            // 
            this.CatrigeModelCB.FormattingEnabled = true;
            this.CatrigeModelCB.ItemHeight = 23;
            this.CatrigeModelCB.Location = new System.Drawing.Point(158, 96);
            this.CatrigeModelCB.Name = "CatrigeModelCB";
            this.CatrigeModelCB.Size = new System.Drawing.Size(252, 29);
            this.CatrigeModelCB.TabIndex = 9;
            this.CatrigeModelCB.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Модель картриджа:";
            // 
            // SerialNamberTB
            // 
            // 
            // 
            // 
            this.SerialNamberTB.CustomButton.Image = null;
            this.SerialNamberTB.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.SerialNamberTB.CustomButton.Name = "";
            this.SerialNamberTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SerialNamberTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SerialNamberTB.CustomButton.TabIndex = 1;
            this.SerialNamberTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SerialNamberTB.CustomButton.UseSelectable = true;
            this.SerialNamberTB.CustomButton.Visible = false;
            this.SerialNamberTB.Lines = new string[0];
            this.SerialNamberTB.Location = new System.Drawing.Point(158, 56);
            this.SerialNamberTB.MaxLength = 32767;
            this.SerialNamberTB.Name = "SerialNamberTB";
            this.SerialNamberTB.PasswordChar = '\0';
            this.SerialNamberTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SerialNamberTB.SelectedText = "";
            this.SerialNamberTB.SelectionLength = 0;
            this.SerialNamberTB.SelectionStart = 0;
            this.SerialNamberTB.ShortcutsEnabled = true;
            this.SerialNamberTB.Size = new System.Drawing.Size(252, 23);
            this.SerialNamberTB.TabIndex = 7;
            this.SerialNamberTB.UseSelectable = true;
            this.SerialNamberTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SerialNamberTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(158, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 19);
            this.ID.TabIndex = 5;
            this.ID.Text = "0";
            // 
            // PrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 556);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dgvPrinter);
            this.Name = "PrinterForm";
            this.Text = "Принтеры";
            this.Load += new System.EventHandler(this.PrinterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinter)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvPrinter;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton ClearBtn;
        private MetroFramework.Controls.MetroButton SaveBtn;
        private MetroFramework.Controls.MetroComboBox LacationCB;
        private MetroFramework.Controls.MetroComboBox CatrigeModelCB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox SerialNamberTB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel ID;
    }
}