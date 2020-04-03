namespace PrintProInc.Forms
{
    partial class CatrigeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.Clea = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SerialNumberTB = new MetroFramework.Controls.MetroTextBox();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.dgvCatruge = new MetroFramework.Controls.MetroGrid();
            this.dgvModelCartige = new MetroFramework.Controls.MetroGrid();
            this.SearchTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CartrigeModelTB = new MetroFramework.Controls.MetroTextBox();
            this.CartrigeModelID = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatruge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelCartige)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.CartrigeModelID);
            this.metroPanel1.Controls.Add(this.CartrigeModelTB);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.deleteBtn);
            this.metroPanel1.Controls.Add(this.Clea);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.SerialNumberTB);
            this.metroPanel1.Controls.Add(this.ID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(43, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(559, 248);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Модель картриджа:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(401, 164);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(108, 40);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Clea
            // 
            this.Clea.Location = new System.Drawing.Point(287, 164);
            this.Clea.Name = "Clea";
            this.Clea.Size = new System.Drawing.Size(108, 40);
            this.Clea.TabIndex = 6;
            this.Clea.Text = "Очистить";
            this.Clea.UseSelectable = true;
            this.Clea.Click += new System.EventHandler(this.Clea_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SerialNumberTB
            // 
            // 
            // 
            // 
            this.SerialNumberTB.CustomButton.Image = null;
            this.SerialNumberTB.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.SerialNumberTB.CustomButton.Name = "";
            this.SerialNumberTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SerialNumberTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SerialNumberTB.CustomButton.TabIndex = 1;
            this.SerialNumberTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SerialNumberTB.CustomButton.UseSelectable = true;
            this.SerialNumberTB.CustomButton.Visible = false;
            this.SerialNumberTB.Lines = new string[0];
            this.SerialNumberTB.Location = new System.Drawing.Point(173, 53);
            this.SerialNumberTB.MaxLength = 32767;
            this.SerialNumberTB.Name = "SerialNumberTB";
            this.SerialNumberTB.PasswordChar = '\0';
            this.SerialNumberTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SerialNumberTB.SelectedText = "";
            this.SerialNumberTB.SelectionLength = 0;
            this.SerialNumberTB.SelectionStart = 0;
            this.SerialNumberTB.ShortcutsEnabled = true;
            this.SerialNumberTB.Size = new System.Drawing.Size(336, 23);
            this.SerialNumberTB.TabIndex = 4;
            this.SerialNumberTB.UseSelectable = true;
            this.SerialNumberTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SerialNumberTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(173, 17);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 19);
            this.ID.TabIndex = 2;
            this.ID.Text = "0";
            // 
            // dgvCatruge
            // 
            this.dgvCatruge.AllowUserToResizeRows = false;
            this.dgvCatruge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatruge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatruge.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCatruge.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatruge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCatruge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatruge.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCatruge.EnableHeadersVisualStyles = false;
            this.dgvCatruge.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCatruge.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatruge.Location = new System.Drawing.Point(618, 119);
            this.dgvCatruge.Name = "dgvCatruge";
            this.dgvCatruge.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatruge.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCatruge.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCatruge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatruge.Size = new System.Drawing.Size(572, 336);
            this.dgvCatruge.TabIndex = 1;
            
            // 
            // dgvModelCartige
            // 
            this.dgvModelCartige.AllowUserToResizeRows = false;
            this.dgvModelCartige.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvModelCartige.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModelCartige.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvModelCartige.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModelCartige.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvModelCartige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModelCartige.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvModelCartige.EnableHeadersVisualStyles = false;
            this.dgvModelCartige.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvModelCartige.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvModelCartige.Location = new System.Drawing.Point(233, 401);
            this.dgvModelCartige.Name = "dgvModelCartige";
            this.dgvModelCartige.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModelCartige.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvModelCartige.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvModelCartige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelCartige.Size = new System.Drawing.Size(369, 233);
            this.dgvModelCartige.TabIndex = 2;
            this.dgvModelCartige.SelectionChanged += new System.EventHandler(this.dgvModelCartige_SelectionChanged);
            // 
            // SearchTB
            // 
            // 
            // 
            // 
            this.SearchTB.CustomButton.Image = null;
            this.SearchTB.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.SearchTB.CustomButton.Name = "";
            this.SearchTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTB.CustomButton.TabIndex = 1;
            this.SearchTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTB.CustomButton.UseSelectable = true;
            this.SearchTB.CustomButton.Visible = false;
            this.SearchTB.Lines = new string[0];
            this.SearchTB.Location = new System.Drawing.Point(233, 362);
            this.SearchTB.MaxLength = 32767;
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.PasswordChar = '\0';
            this.SearchTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTB.SelectedText = "";
            this.SearchTB.SelectionLength = 0;
            this.SearchTB.SelectionStart = 0;
            this.SearchTB.ShortcutsEnabled = true;
            this.SearchTB.Size = new System.Drawing.Size(196, 23);
            this.SearchTB.TabIndex = 3;
            this.SearchTB.UseSelectable = true;
            this.SearchTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 363);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(166, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Найти модель картриджа:";
            // 
            // CartrigeModelTB
            // 
            // 
            // 
            // 
            this.CartrigeModelTB.CustomButton.Image = null;
            this.CartrigeModelTB.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.CartrigeModelTB.CustomButton.Name = "";
            this.CartrigeModelTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CartrigeModelTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CartrigeModelTB.CustomButton.TabIndex = 1;
            this.CartrigeModelTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CartrigeModelTB.CustomButton.UseSelectable = true;
            this.CartrigeModelTB.CustomButton.Visible = false;
            this.CartrigeModelTB.Lines = new string[0];
            this.CartrigeModelTB.Location = new System.Drawing.Point(173, 91);
            this.CartrigeModelTB.MaxLength = 32767;
            this.CartrigeModelTB.Name = "CartrigeModelTB";
            this.CartrigeModelTB.PasswordChar = '\0';
            this.CartrigeModelTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CartrigeModelTB.SelectedText = "";
            this.CartrigeModelTB.SelectionLength = 0;
            this.CartrigeModelTB.SelectionStart = 0;
            this.CartrigeModelTB.ShortcutsEnabled = true;
            this.CartrigeModelTB.Size = new System.Drawing.Size(336, 23);
            this.CartrigeModelTB.TabIndex = 10;
            this.CartrigeModelTB.UseSelectable = true;
            this.CartrigeModelTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CartrigeModelTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CartrigeModelID
            // 
            // 
            // 
            // 
            this.CartrigeModelID.CustomButton.Image = null;
            this.CartrigeModelID.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.CartrigeModelID.CustomButton.Name = "";
            this.CartrigeModelID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CartrigeModelID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CartrigeModelID.CustomButton.TabIndex = 1;
            this.CartrigeModelID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CartrigeModelID.CustomButton.UseSelectable = true;
            this.CartrigeModelID.CustomButton.Visible = false;
            this.CartrigeModelID.Lines = new string[0];
            this.CartrigeModelID.Location = new System.Drawing.Point(173, 120);
            this.CartrigeModelID.MaxLength = 32767;
            this.CartrigeModelID.Name = "CartrigeModelID";
            this.CartrigeModelID.PasswordChar = '\0';
            this.CartrigeModelID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CartrigeModelID.SelectedText = "";
            this.CartrigeModelID.SelectionLength = 0;
            this.CartrigeModelID.SelectionStart = 0;
            this.CartrigeModelID.ShortcutsEnabled = true;
            this.CartrigeModelID.Size = new System.Drawing.Size(75, 23);
            this.CartrigeModelID.TabIndex = 11;
            this.CartrigeModelID.UseSelectable = true;
            this.CartrigeModelID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CartrigeModelID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CatrigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 709);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.dgvModelCartige);
            this.Controls.Add(this.dgvCatruge);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CatrigeForm";
            this.Text = "CatrigeForm";
            this.Load += new System.EventHandler(this.CatrigeForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatruge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelCartige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox SerialNumberTB;
        private MetroFramework.Controls.MetroGrid dgvCatruge;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton Clea;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvModelCartige;
        private MetroFramework.Controls.MetroTextBox SearchTB;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox CartrigeModelTB;
        private MetroFramework.Controls.MetroTextBox CartrigeModelID;
    }
}