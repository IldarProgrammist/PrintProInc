namespace PrintProInc.Forms
{
    partial class PrinterOperationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.OpID = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.DateDP = new MetroFramework.Controls.MetroDateTime();
            this.StatusCB = new MetroFramework.Controls.MetroComboBox();
            this.PrinterIDTB = new MetroFramework.Controls.MetroTextBox();
            this.dgvSearch = new MetroFramework.Controls.MetroGrid();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.dgvPrinterOperation = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.serchTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.OpID);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.DateDP);
            this.metroPanel1.Controls.Add(this.StatusCB);
            this.metroPanel1.Controls.Add(this.PrinterIDTB);
            this.metroPanel1.Controls.Add(this.dgvSearch);
            this.metroPanel1.Controls.Add(this.ID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(412, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(752, 607);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(329, 222);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 40);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Text = "Очистить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "ID Операции:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Серийный номер:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 154);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Дата :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Статус:";
            // 
            // OpID
            // 
            this.OpID.AutoSize = true;
            this.OpID.Location = new System.Drawing.Point(176, 90);
            this.OpID.Name = "OpID";
            this.OpID.Size = new System.Drawing.Size(16, 19);
            this.OpID.TabIndex = 11;
            this.OpID.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(176, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DateDP
            // 
            this.DateDP.Location = new System.Drawing.Point(176, 171);
            this.DateDP.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateDP.Name = "DateDP";
            this.DateDP.Size = new System.Drawing.Size(270, 29);
            this.DateDP.TabIndex = 9;
            // 
            // StatusCB
            // 
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.ItemHeight = 23;
            this.StatusCB.Location = new System.Drawing.Point(176, 124);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(270, 29);
            this.StatusCB.TabIndex = 8;
            this.StatusCB.UseSelectable = true;
            // 
            // PrinterIDTB
            // 
            // 
            // 
            // 
            this.PrinterIDTB.CustomButton.Image = null;
            this.PrinterIDTB.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.PrinterIDTB.CustomButton.Name = "";
            this.PrinterIDTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrinterIDTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrinterIDTB.CustomButton.TabIndex = 1;
            this.PrinterIDTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrinterIDTB.CustomButton.UseSelectable = true;
            this.PrinterIDTB.CustomButton.Visible = false;
            this.PrinterIDTB.Lines = new string[0];
            this.PrinterIDTB.Location = new System.Drawing.Point(176, 86);
            this.PrinterIDTB.MaxLength = 32767;
            this.PrinterIDTB.Name = "PrinterIDTB";
            this.PrinterIDTB.PasswordChar = '\0';
            this.PrinterIDTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrinterIDTB.SelectedText = "";
            this.PrinterIDTB.SelectionLength = 0;
            this.PrinterIDTB.SelectionStart = 0;
            this.PrinterIDTB.ShortcutsEnabled = true;
            this.PrinterIDTB.Size = new System.Drawing.Size(60, 23);
            this.PrinterIDTB.TabIndex = 7;
            this.PrinterIDTB.UseSelectable = true;
            this.PrinterIDTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrinterIDTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearch.EnableHeadersVisualStyles = false;
            this.dgvSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearch.Location = new System.Drawing.Point(36, 307);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(651, 282);
            this.dgvSearch.TabIndex = 3;
            this.dgvSearch.SelectionChanged += new System.EventHandler(this.dgvSearch_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(176, 49);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 19);
            this.ID.TabIndex = 2;
            this.ID.Text = "0";
            // 
            // dgvPrinterOperation
            // 
            this.dgvPrinterOperation.AllowUserToResizeRows = false;
            this.dgvPrinterOperation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinterOperation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinterOperation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrinterOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinterOperation.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrinterOperation.EnableHeadersVisualStyles = false;
            this.dgvPrinterOperation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinterOperation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterOperation.Location = new System.Drawing.Point(23, 173);
            this.dgvPrinterOperation.Name = "dgvPrinterOperation";
            this.dgvPrinterOperation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterOperation.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrinterOperation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinterOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinterOperation.Size = new System.Drawing.Size(362, 257);
            this.dgvPrinterOperation.TabIndex = 4;
            this.dgvPrinterOperation.SelectionChanged += new System.EventHandler(this.dgvPrinterOperation_SelectionChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // serchTB
            // 
            // 
            // 
            // 
            this.serchTB.CustomButton.Image = null;
            this.serchTB.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.serchTB.CustomButton.Name = "";
            this.serchTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.serchTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serchTB.CustomButton.TabIndex = 1;
            this.serchTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serchTB.CustomButton.UseSelectable = true;
            this.serchTB.CustomButton.Visible = false;
            this.serchTB.Lines = new string[0];
            this.serchTB.Location = new System.Drawing.Point(159, 102);
            this.serchTB.MaxLength = 32767;
            this.serchTB.Name = "serchTB";
            this.serchTB.PasswordChar = '\0';
            this.serchTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serchTB.SelectedText = "";
            this.serchTB.SelectionLength = 0;
            this.serchTB.SelectionStart = 0;
            this.serchTB.ShortcutsEnabled = true;
            this.serchTB.Size = new System.Drawing.Size(164, 23);
            this.serchTB.TabIndex = 8;
            this.serchTB.UseSelectable = true;
            this.serchTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serchTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.serchTB.TextChanged += new System.EventHandler(this.serchTB_TextChanged_1);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 149);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(174, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Выбор серийного номера:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(36, 284);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(237, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Информация о состоянии принтера:";
            // 
            // PrinterOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 675);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.serchTB);
            this.Controls.Add(this.dgvPrinterOperation);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PrinterOperationForm";
            this.Text = "Операция с принтерами";
            this.Load += new System.EventHandler(this.PrinterOperationForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvSearch;
        private MetroFramework.Controls.MetroGrid dgvPrinterOperation;
        private MetroFramework.Controls.MetroTextBox PrinterIDTB;
        private MetroFramework.Controls.MetroDateTime DateDP;
        private MetroFramework.Controls.MetroComboBox StatusCB;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroLabel OpID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox serchTB;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}