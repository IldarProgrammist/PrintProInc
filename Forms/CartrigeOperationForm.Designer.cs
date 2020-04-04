namespace PrintProInc.Forms
{
    partial class CartrigeOperationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.CartrigeStatusCB = new MetroFramework.Controls.MetroComboBox();
            this.dgvCartrigeOperation = new MetroFramework.Controls.MetroGrid();
            this.CartrugeID = new MetroFramework.Controls.MetroTextBox();
            this.OperationID = new MetroFramework.Controls.MetroLabel();
            this.dgvCartrige = new MetroFramework.Controls.MetroGrid();
            this.SNLab = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.snTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartrigeOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartrige)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.SNLab);
            this.metroPanel1.Controls.Add(this.SaveBtn);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.Controls.Add(this.CartrigeStatusCB);
            this.metroPanel1.Controls.Add(this.dgvCartrigeOperation);
            this.metroPanel1.Controls.Add(this.CartrugeID);
            this.metroPanel1.Controls.Add(this.OperationID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(643, 34);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(661, 544);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(149, 187);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(115, 39);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(149, 132);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(279, 29);
            this.metroDateTime1.TabIndex = 12;
            // 
            // CartrigeStatusCB
            // 
            this.CartrigeStatusCB.FormattingEnabled = true;
            this.CartrigeStatusCB.ItemHeight = 23;
            this.CartrigeStatusCB.Location = new System.Drawing.Point(149, 85);
            this.CartrigeStatusCB.Name = "CartrigeStatusCB";
            this.CartrigeStatusCB.Size = new System.Drawing.Size(279, 29);
            this.CartrigeStatusCB.TabIndex = 11;
            this.CartrigeStatusCB.UseSelectable = true;
            // 
            // dgvCartrigeOperation
            // 
            this.dgvCartrigeOperation.AllowUserToResizeRows = false;
            this.dgvCartrigeOperation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCartrigeOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCartrigeOperation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCartrigeOperation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartrigeOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvCartrigeOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCartrigeOperation.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvCartrigeOperation.EnableHeadersVisualStyles = false;
            this.dgvCartrigeOperation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCartrigeOperation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCartrigeOperation.Location = new System.Drawing.Point(17, 261);
            this.dgvCartrigeOperation.Name = "dgvCartrigeOperation";
            this.dgvCartrigeOperation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartrigeOperation.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvCartrigeOperation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCartrigeOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartrigeOperation.Size = new System.Drawing.Size(618, 221);
            this.dgvCartrigeOperation.TabIndex = 10;
            this.dgvCartrigeOperation.SelectionChanged += new System.EventHandler(this.dgvCartrigeOperation_SelectionChanged);
            // 
            // CartrugeID
            // 
            // 
            // 
            // 
            this.CartrugeID.CustomButton.Image = null;
            this.CartrugeID.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.CartrugeID.CustomButton.Name = "";
            this.CartrugeID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CartrugeID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CartrugeID.CustomButton.TabIndex = 1;
            this.CartrugeID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CartrugeID.CustomButton.UseSelectable = true;
            this.CartrugeID.CustomButton.Visible = false;
            this.CartrugeID.Lines = new string[0];
            this.CartrugeID.Location = new System.Drawing.Point(149, 85);
            this.CartrugeID.MaxLength = 32767;
            this.CartrugeID.Name = "CartrugeID";
            this.CartrugeID.PasswordChar = '\0';
            this.CartrugeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CartrugeID.SelectedText = "";
            this.CartrugeID.SelectionLength = 0;
            this.CartrugeID.SelectionStart = 0;
            this.CartrugeID.ShortcutsEnabled = true;
            this.CartrugeID.Size = new System.Drawing.Size(279, 23);
            this.CartrugeID.TabIndex = 9;
            this.CartrugeID.UseSelectable = true;
            this.CartrugeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CartrugeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OperationID
            // 
            this.OperationID.AutoSize = true;
            this.OperationID.Location = new System.Drawing.Point(149, 11);
            this.OperationID.Name = "OperationID";
            this.OperationID.Size = new System.Drawing.Size(16, 19);
            this.OperationID.TabIndex = 8;
            this.OperationID.Text = "0";
            // 
            // dgvCartrige
            // 
            this.dgvCartrige.AllowUserToResizeRows = false;
            this.dgvCartrige.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCartrige.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCartrige.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCartrige.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartrige.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvCartrige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCartrige.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvCartrige.EnableHeadersVisualStyles = false;
            this.dgvCartrige.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCartrige.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCartrige.Location = new System.Drawing.Point(41, 145);
            this.dgvCartrige.Name = "dgvCartrige";
            this.dgvCartrige.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartrige.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvCartrige.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCartrige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartrige.Size = new System.Drawing.Size(553, 273);
            this.dgvCartrige.TabIndex = 8;
            this.dgvCartrige.SelectionChanged += new System.EventHandler(this.dgvCartrige_SelectionChanged);
            // 
            // SNLab
            // 
            this.SNLab.AutoSize = true;
            this.SNLab.Location = new System.Drawing.Point(149, 54);
            this.SNLab.Name = "SNLab";
            this.SNLab.Size = new System.Drawing.Size(83, 19);
            this.SNLab.TabIndex = 14;
            this.SNLab.Text = "metroLabel2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // snTB
            // 
            // 
            // 
            // 
            this.snTB.CustomButton.Image = null;
            this.snTB.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.snTB.CustomButton.Name = "";
            this.snTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.snTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.snTB.CustomButton.TabIndex = 1;
            this.snTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.snTB.CustomButton.UseSelectable = true;
            this.snTB.CustomButton.Visible = false;
            this.snTB.Lines = new string[0];
            this.snTB.Location = new System.Drawing.Point(177, 88);
            this.snTB.MaxLength = 32767;
            this.snTB.Name = "snTB";
            this.snTB.PasswordChar = '\0';
            this.snTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.snTB.SelectedText = "";
            this.snTB.SelectionLength = 0;
            this.snTB.SelectionStart = 0;
            this.snTB.ShortcutsEnabled = true;
            this.snTB.Size = new System.Drawing.Size(164, 23);
            this.snTB.TabIndex = 10;
            this.snTB.UseSelectable = true;
            this.snTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.snTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.snTB.TextChanged += new System.EventHandler(this.snTB_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Серийный номер:";
            // 
            // CartrigeOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 688);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.snTB);
            this.Controls.Add(this.dgvCartrige);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CartrigeOperationForm";
            this.Text = "CartrigeOperationForm";
            this.Load += new System.EventHandler(this.CartrigeOperationForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartrigeOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartrige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel OperationID;
        private MetroFramework.Controls.MetroTextBox CartrugeID;
        private MetroFramework.Controls.MetroGrid dgvCartrigeOperation;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroComboBox CartrigeStatusCB;
        private MetroFramework.Controls.MetroButton SaveBtn;
        private MetroFramework.Controls.MetroGrid dgvCartrige;
        private MetroFramework.Controls.MetroLabel SNLab;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox snTB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}