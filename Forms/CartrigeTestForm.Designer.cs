namespace PrintProInc.Forms
{
    partial class CartrigeTestForm
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
            this.dgvCartrigeModel = new MetroFramework.Controls.MetroGrid();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CatrigeModelIDTB = new MetroFramework.Controls.MetroLabel();
            this.SnTB = new MetroFramework.Controls.MetroTextBox();
            this.CartrigeModelTB = new MetroFramework.Controls.MetroTextBox();
            this.dgvCatriges = new MetroFramework.Controls.MetroGrid();
            this.searchTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.ClearBtn = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.searchCatrigeTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CatrigeCount = new MetroFramework.Controls.MetroLabel();
            this.CountForModelTB = new MetroFramework.Controls.MetroTextBox();
            this.CountModelLab = new MetroFramework.Controls.MetroLabel();
            this.CountCatrigeModelLab = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.WarningLab = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartrigeModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatriges)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCartrigeModel
            // 
            this.dgvCartrigeModel.AllowUserToResizeRows = false;
            this.dgvCartrigeModel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCartrigeModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCartrigeModel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCartrigeModel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartrigeModel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCartrigeModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCartrigeModel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCartrigeModel.EnableHeadersVisualStyles = false;
            this.dgvCartrigeModel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCartrigeModel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCartrigeModel.Location = new System.Drawing.Point(131, 284);
            this.dgvCartrigeModel.Name = "dgvCartrigeModel";
            this.dgvCartrigeModel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartrigeModel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCartrigeModel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCartrigeModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartrigeModel.Size = new System.Drawing.Size(308, 186);
            this.dgvCartrigeModel.TabIndex = 0;
            this.dgvCartrigeModel.SelectionChanged += new System.EventHandler(this.dgvCartrigeModel_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(210, 48);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 19);
            this.ID.TabIndex = 1;
            this.ID.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(66, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // CatrigeModelIDTB
            // 
            this.CatrigeModelIDTB.AutoSize = true;
            this.CatrigeModelIDTB.Location = new System.Drawing.Point(66, 138);
            this.CatrigeModelIDTB.Name = "CatrigeModelIDTB";
            this.CatrigeModelIDTB.Size = new System.Drawing.Size(75, 19);
            this.CatrigeModelIDTB.TabIndex = 3;
            this.CatrigeModelIDTB.Text = "Модель ID:";
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
            this.SnTB.Location = new System.Drawing.Point(210, 97);
            this.SnTB.MaxLength = 32767;
            this.SnTB.Name = "SnTB";
            this.SnTB.PasswordChar = '\0';
            this.SnTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SnTB.SelectedText = "";
            this.SnTB.SelectionLength = 0;
            this.SnTB.SelectionStart = 0;
            this.SnTB.ShortcutsEnabled = true;
            this.SnTB.Size = new System.Drawing.Size(324, 23);
            this.SnTB.TabIndex = 4;
            this.SnTB.UseSelectable = true;
            this.SnTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SnTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CartrigeModelTB
            // 
            // 
            // 
            // 
            this.CartrigeModelTB.CustomButton.Image = null;
            this.CartrigeModelTB.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.CartrigeModelTB.CustomButton.Name = "";
            this.CartrigeModelTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CartrigeModelTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CartrigeModelTB.CustomButton.TabIndex = 1;
            this.CartrigeModelTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CartrigeModelTB.CustomButton.UseSelectable = true;
            this.CartrigeModelTB.CustomButton.Visible = false;
            this.CartrigeModelTB.Lines = new string[0];
            this.CartrigeModelTB.Location = new System.Drawing.Point(210, 138);
            this.CartrigeModelTB.MaxLength = 32767;
            this.CartrigeModelTB.Name = "CartrigeModelTB";
            this.CartrigeModelTB.PasswordChar = '\0';
            this.CartrigeModelTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CartrigeModelTB.SelectedText = "";
            this.CartrigeModelTB.SelectionLength = 0;
            this.CartrigeModelTB.SelectionStart = 0;
            this.CartrigeModelTB.ShortcutsEnabled = true;
            this.CartrigeModelTB.Size = new System.Drawing.Size(324, 23);
            this.CartrigeModelTB.TabIndex = 5;
            this.CartrigeModelTB.UseSelectable = true;
            this.CartrigeModelTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CartrigeModelTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvCatriges
            // 
            this.dgvCatriges.AllowUserToResizeRows = false;
            this.dgvCatriges.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatriges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatriges.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCatriges.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatriges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCatriges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatriges.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCatriges.EnableHeadersVisualStyles = false;
            this.dgvCatriges.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCatriges.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatriges.Location = new System.Drawing.Point(553, 97);
            this.dgvCatriges.Name = "dgvCatriges";
            this.dgvCatriges.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatriges.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCatriges.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCatriges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatriges.Size = new System.Drawing.Size(656, 323);
            this.dgvCatriges.TabIndex = 6;
            this.dgvCatriges.SelectionChanged += new System.EventHandler(this.dgvCatriges_SelectionChanged);
            // 
            // searchTB
            // 
            // 
            // 
            // 
            this.searchTB.CustomButton.Image = null;
            this.searchTB.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.searchTB.CustomButton.Name = "";
            this.searchTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTB.CustomButton.TabIndex = 1;
            this.searchTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTB.CustomButton.UseSelectable = true;
            this.searchTB.CustomButton.Visible = false;
            this.searchTB.Lines = new string[0];
            this.searchTB.Location = new System.Drawing.Point(131, 242);
            this.searchTB.MaxLength = 32767;
            this.searchTB.Name = "searchTB";
            this.searchTB.PasswordChar = '\0';
            this.searchTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTB.SelectedText = "";
            this.searchTB.SelectionLength = 0;
            this.searchTB.SelectionStart = 0;
            this.searchTB.ShortcutsEnabled = true;
            this.searchTB.Size = new System.Drawing.Size(308, 23);
            this.searchTB.TabIndex = 7;
            this.searchTB.UseSelectable = true;
            this.searchTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(66, 243);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Найти:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(320, 180);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(104, 31);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseSelectable = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(430, 180);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(104, 31);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.searchCatrigeTB.Location = new System.Drawing.Point(837, 48);
            this.searchCatrigeTB.MaxLength = 32767;
            this.searchCatrigeTB.Name = "searchCatrigeTB";
            this.searchCatrigeTB.PasswordChar = '\0';
            this.searchCatrigeTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchCatrigeTB.SelectedText = "";
            this.searchCatrigeTB.SelectionLength = 0;
            this.searchCatrigeTB.SelectionStart = 0;
            this.searchCatrigeTB.ShortcutsEnabled = true;
            this.searchCatrigeTB.Size = new System.Drawing.Size(223, 23);
            this.searchCatrigeTB.TabIndex = 13;
            this.searchCatrigeTB.UseSelectable = true;
            this.searchCatrigeTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchCatrigeTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchCatrigeTB.TextChanged += new System.EventHandler(this.searchCatrigeTB_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(710, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Серийный номер:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(553, 463);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(136, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Общее колличество:";
            // 
            // CatrigeCount
            // 
            this.CatrigeCount.AutoSize = true;
            this.CatrigeCount.Location = new System.Drawing.Point(710, 463);
            this.CatrigeCount.Name = "CatrigeCount";
            this.CatrigeCount.Size = new System.Drawing.Size(16, 19);
            this.CatrigeCount.TabIndex = 16;
            this.CatrigeCount.Text = "0";
            // 
            // CountForModelTB
            // 
            // 
            // 
            // 
            this.CountForModelTB.CustomButton.Image = null;
            this.CountForModelTB.CustomButton.Location = new System.Drawing.Point(-6, 1);
            this.CountForModelTB.CustomButton.Name = "";
            this.CountForModelTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CountForModelTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CountForModelTB.CustomButton.TabIndex = 1;
            this.CountForModelTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CountForModelTB.CustomButton.UseSelectable = true;
            this.CountForModelTB.CustomButton.Visible = false;
            this.CountForModelTB.Lines = new string[0];
            this.CountForModelTB.Location = new System.Drawing.Point(509, 422);
            this.CountForModelTB.MaxLength = 32767;
            this.CountForModelTB.Name = "CountForModelTB";
            this.CountForModelTB.PasswordChar = '\0';
            this.CountForModelTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CountForModelTB.SelectedText = "";
            this.CountForModelTB.SelectionLength = 0;
            this.CountForModelTB.SelectionStart = 0;
            this.CountForModelTB.ShortcutsEnabled = true;
            this.CountForModelTB.Size = new System.Drawing.Size(16, 23);
            this.CountForModelTB.TabIndex = 17;
            this.CountForModelTB.UseSelectable = true;
            this.CountForModelTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CountForModelTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CountForModelTB.TextChanged += new System.EventHandler(this.CountForModelTB_TextChanged);
            // 
            // CountModelLab
            // 
            this.CountModelLab.AutoSize = true;
            this.CountModelLab.Location = new System.Drawing.Point(815, 427);
            this.CountModelLab.Name = "CountModelLab";
            this.CountModelLab.Size = new System.Drawing.Size(16, 19);
            this.CountModelLab.TabIndex = 18;
            this.CountModelLab.Text = "0";
            // 
            // CountCatrigeModelLab
            // 
            this.CountCatrigeModelLab.AutoSize = true;
            this.CountCatrigeModelLab.Location = new System.Drawing.Point(726, 426);
            this.CountCatrigeModelLab.Name = "CountCatrigeModelLab";
            this.CountCatrigeModelLab.Size = new System.Drawing.Size(83, 19);
            this.CountCatrigeModelLab.TabIndex = 19;
            this.CountCatrigeModelLab.Text = "metroLabel5";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(553, 427);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(167, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Колличество по моделям:";
            // 
            // WarningLab
            // 
            this.WarningLab.AutoSize = true;
            this.WarningLab.Location = new System.Drawing.Point(891, 427);
            this.WarningLab.Name = "WarningLab";
            this.WarningLab.Size = new System.Drawing.Size(83, 19);
            this.WarningLab.TabIndex = 21;
            this.WarningLab.Text = "metroLabel6";
            // 
            // CartrigeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 548);
            this.Controls.Add(this.WarningLab);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.CountCatrigeModelLab);
            this.Controls.Add(this.CountModelLab);
            this.Controls.Add(this.CountForModelTB);
            this.Controls.Add(this.CatrigeCount);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.searchCatrigeTB);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.dgvCatriges);
            this.Controls.Add(this.CartrigeModelTB);
            this.Controls.Add(this.SnTB);
            this.Controls.Add(this.CatrigeModelIDTB);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dgvCartrigeModel);
            this.Name = "CartrigeTestForm";
            this.Text = "Картриджи";
            this.Load += new System.EventHandler(this.CartrigeTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartrigeModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatriges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvCartrigeModel;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel CatrigeModelIDTB;
        private MetroFramework.Controls.MetroTextBox SnTB;
        private MetroFramework.Controls.MetroTextBox CartrigeModelTB;
        private MetroFramework.Controls.MetroGrid dgvCatriges;
        private MetroFramework.Controls.MetroTextBox searchTB;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton ClearBtn;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroTextBox searchCatrigeTB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel CatrigeCount;
        private MetroFramework.Controls.MetroTextBox CountForModelTB;
        private MetroFramework.Controls.MetroLabel CountModelLab;
        private MetroFramework.Controls.MetroLabel CountCatrigeModelLab;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel WarningLab;
    }
}