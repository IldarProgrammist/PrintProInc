namespace PrintProInc.Forms
{
    partial class PrinterTestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.searchCatrigeTB = new MetroFramework.Controls.MetroTextBox();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.ClearBtn = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.dgvPrinter = new MetroFramework.Controls.MetroGrid();
            this.SnTB = new MetroFramework.Controls.MetroTextBox();
            this.CatrigeModelIDTB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.ModelCatrigeCB = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.LocationTB = new MetroFramework.Controls.MetroTextBox();
            this.dgvLocation = new MetroFramework.Controls.MetroGrid();
            this.LocationIDTB = new MetroFramework.Controls.MetroTextBox();
            this.SearchRoomTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(667, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Серийный номер:";
            // 
            // searchCatrigeTB
            // 
            // 
            // 
            // 
            this.searchCatrigeTB.CustomButton.Image = null;
            this.searchCatrigeTB.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.searchCatrigeTB.CustomButton.Name = "";
            this.searchCatrigeTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchCatrigeTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchCatrigeTB.CustomButton.TabIndex = 1;
            this.searchCatrigeTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchCatrigeTB.CustomButton.UseSelectable = true;
            this.searchCatrigeTB.CustomButton.Visible = false;
            this.searchCatrigeTB.Lines = new string[0];
            this.searchCatrigeTB.Location = new System.Drawing.Point(794, 62);
            this.searchCatrigeTB.MaxLength = 32767;
            this.searchCatrigeTB.Name = "searchCatrigeTB";
            this.searchCatrigeTB.PasswordChar = '\0';
            this.searchCatrigeTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchCatrigeTB.SelectedText = "";
            this.searchCatrigeTB.SelectionLength = 0;
            this.searchCatrigeTB.SelectionStart = 0;
            this.searchCatrigeTB.ShortcutsEnabled = true;
            this.searchCatrigeTB.Size = new System.Drawing.Size(223, 23);
            this.searchCatrigeTB.TabIndex = 27;
            this.searchCatrigeTB.UseSelectable = true;
            this.searchCatrigeTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchCatrigeTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchCatrigeTB.TextChanged += new System.EventHandler(this.searchCatrigeTB_TextChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(387, 254);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(104, 31);
            this.deleteBtn.TabIndex = 26;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(277, 254);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(104, 31);
            this.ClearBtn.TabIndex = 25;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseSelectable = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 31);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvPrinter
            // 
            this.dgvPrinter.AllowUserToResizeRows = false;
            this.dgvPrinter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPrinter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinter.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPrinter.EnableHeadersVisualStyles = false;
            this.dgvPrinter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinter.Location = new System.Drawing.Point(510, 111);
            this.dgvPrinter.Name = "dgvPrinter";
            this.dgvPrinter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinter.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPrinter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinter.Size = new System.Drawing.Size(656, 323);
            this.dgvPrinter.TabIndex = 21;
            this.dgvPrinter.SelectionChanged += new System.EventHandler(this.dgvPrinter_SelectionChanged);
            // 
            // SnTB
            // 
            // 
            // 
            // 
            this.SnTB.CustomButton.Image = null;
            this.SnTB.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.SnTB.CustomButton.Name = "";
            this.SnTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SnTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SnTB.CustomButton.TabIndex = 1;
            this.SnTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SnTB.CustomButton.UseSelectable = true;
            this.SnTB.CustomButton.Visible = false;
            this.SnTB.Lines = new string[0];
            this.SnTB.Location = new System.Drawing.Point(167, 111);
            this.SnTB.MaxLength = 32767;
            this.SnTB.Name = "SnTB";
            this.SnTB.PasswordChar = '\0';
            this.SnTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SnTB.SelectedText = "";
            this.SnTB.SelectionLength = 0;
            this.SnTB.SelectionStart = 0;
            this.SnTB.ShortcutsEnabled = true;
            this.SnTB.Size = new System.Drawing.Size(324, 23);
            this.SnTB.TabIndex = 19;
            this.SnTB.UseSelectable = true;
            this.SnTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SnTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CatrigeModelIDTB
            // 
            this.CatrigeModelIDTB.AutoSize = true;
            this.CatrigeModelIDTB.Location = new System.Drawing.Point(23, 152);
            this.CatrigeModelIDTB.Name = "CatrigeModelIDTB";
            this.CatrigeModelIDTB.Size = new System.Drawing.Size(132, 19);
            this.CatrigeModelIDTB.TabIndex = 18;
            this.CatrigeModelIDTB.Text = "Модель  картриджа:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(167, 62);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 19);
            this.ID.TabIndex = 16;
            this.ID.Text = "0";
            // 
            // ModelCatrigeCB
            // 
            this.ModelCatrigeCB.FormattingEnabled = true;
            this.ModelCatrigeCB.ItemHeight = 23;
            this.ModelCatrigeCB.Location = new System.Drawing.Point(167, 149);
            this.ModelCatrigeCB.Name = "ModelCatrigeCB";
            this.ModelCatrigeCB.Size = new System.Drawing.Size(324, 29);
            this.ModelCatrigeCB.TabIndex = 29;
            this.ModelCatrigeCB.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 199);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Локация:";
            // 
            // LocationTB
            // 
            // 
            // 
            // 
            this.LocationTB.CustomButton.Image = null;
            this.LocationTB.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.LocationTB.CustomButton.Name = "";
            this.LocationTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LocationTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LocationTB.CustomButton.TabIndex = 1;
            this.LocationTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LocationTB.CustomButton.UseSelectable = true;
            this.LocationTB.CustomButton.Visible = false;
            this.LocationTB.Lines = new string[0];
            this.LocationTB.Location = new System.Drawing.Point(167, 195);
            this.LocationTB.MaxLength = 32767;
            this.LocationTB.Name = "LocationTB";
            this.LocationTB.PasswordChar = '\0';
            this.LocationTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LocationTB.SelectedText = "";
            this.LocationTB.SelectionLength = 0;
            this.LocationTB.SelectionStart = 0;
            this.LocationTB.ShortcutsEnabled = true;
            this.LocationTB.Size = new System.Drawing.Size(324, 23);
            this.LocationTB.TabIndex = 32;
            this.LocationTB.UseSelectable = true;
            this.LocationTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LocationTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvLocation
            // 
            this.dgvLocation.AllowUserToResizeRows = false;
            this.dgvLocation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLocation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocation.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvLocation.EnableHeadersVisualStyles = false;
            this.dgvLocation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLocation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLocation.Location = new System.Drawing.Point(154, 353);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocation.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvLocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocation.Size = new System.Drawing.Size(350, 189);
            this.dgvLocation.TabIndex = 33;
            this.dgvLocation.SelectionChanged += new System.EventHandler(this.dgvLocation_SelectionChanged);
            // 
            // LocationIDTB
            // 
            // 
            // 
            // 
            this.LocationIDTB.CustomButton.Image = null;
            this.LocationIDTB.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.LocationIDTB.CustomButton.Name = "";
            this.LocationIDTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LocationIDTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LocationIDTB.CustomButton.TabIndex = 1;
            this.LocationIDTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LocationIDTB.CustomButton.UseSelectable = true;
            this.LocationIDTB.CustomButton.Visible = false;
            this.LocationIDTB.Lines = new string[0];
            this.LocationIDTB.Location = new System.Drawing.Point(167, 195);
            this.LocationIDTB.MaxLength = 32767;
            this.LocationIDTB.Name = "LocationIDTB";
            this.LocationIDTB.PasswordChar = '\0';
            this.LocationIDTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LocationIDTB.SelectedText = "";
            this.LocationIDTB.SelectionLength = 0;
            this.LocationIDTB.SelectionStart = 0;
            this.LocationIDTB.ShortcutsEnabled = true;
            this.LocationIDTB.Size = new System.Drawing.Size(34, 23);
            this.LocationIDTB.TabIndex = 34;
            this.LocationIDTB.UseSelectable = true;
            this.LocationIDTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LocationIDTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchRoomTB
            // 
            // 
            // 
            // 
            this.SearchRoomTB.CustomButton.Image = null;
            this.SearchRoomTB.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.SearchRoomTB.CustomButton.Name = "";
            this.SearchRoomTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchRoomTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchRoomTB.CustomButton.TabIndex = 1;
            this.SearchRoomTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchRoomTB.CustomButton.UseSelectable = true;
            this.SearchRoomTB.CustomButton.Visible = false;
            this.SearchRoomTB.Lines = new string[0];
            this.SearchRoomTB.Location = new System.Drawing.Point(268, 320);
            this.SearchRoomTB.MaxLength = 32767;
            this.SearchRoomTB.Name = "SearchRoomTB";
            this.SearchRoomTB.PasswordChar = '\0';
            this.SearchRoomTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchRoomTB.SelectedText = "";
            this.SearchRoomTB.SelectionLength = 0;
            this.SearchRoomTB.SelectionStart = 0;
            this.SearchRoomTB.ShortcutsEnabled = true;
            this.SearchRoomTB.Size = new System.Drawing.Size(223, 23);
            this.SearchRoomTB.TabIndex = 35;
            this.SearchRoomTB.UseSelectable = true;
            this.SearchRoomTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchRoomTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchRoomTB.TextChanged += new System.EventHandler(this.SearchRoomTB_TextChanged);
           
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(121, 320);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Кабинет:";
            // 
            // PrinterTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 658);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.SearchRoomTB);
            this.Controls.Add(this.LocationIDTB);
            this.Controls.Add(this.dgvLocation);
            this.Controls.Add(this.LocationTB);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ModelCatrigeCB);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.searchCatrigeTB);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPrinter);
            this.Controls.Add(this.SnTB);
            this.Controls.Add(this.CatrigeModelIDTB);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ID);
            this.Name = "PrinterTestForm";
            this.Text = "Принтеры";
            this.Load += new System.EventHandler(this.PrinterTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox searchCatrigeTB;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton ClearBtn;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroGrid dgvPrinter;
        private MetroFramework.Controls.MetroTextBox SnTB;
        private MetroFramework.Controls.MetroLabel CatrigeModelIDTB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroComboBox ModelCatrigeCB;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox LocationTB;
        private MetroFramework.Controls.MetroGrid dgvLocation;
        private MetroFramework.Controls.MetroTextBox LocationIDTB;
        private MetroFramework.Controls.MetroTextBox SearchRoomTB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}