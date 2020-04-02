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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.Clea = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SerialNumberTB = new MetroFramework.Controls.MetroTextBox();
            this.CatrigeModelCB = new MetroFramework.Controls.MetroComboBox();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.dgvCatruge = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatruge)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.deleteBtn);
            this.metroPanel1.Controls.Add(this.Clea);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.SerialNumberTB);
            this.metroPanel1.Controls.Add(this.CatrigeModelCB);
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
            this.deleteBtn.Location = new System.Drawing.Point(401, 146);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(108, 40);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Clea
            // 
            this.Clea.Location = new System.Drawing.Point(287, 146);
            this.Clea.Name = "Clea";
            this.Clea.Size = new System.Drawing.Size(108, 40);
            this.Clea.TabIndex = 6;
            this.Clea.Text = "Очистить";
            this.Clea.UseSelectable = true;
            this.Clea.Click += new System.EventHandler(this.Clea_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 146);
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
            // CatrigeModelCB
            // 
            this.CatrigeModelCB.FormattingEnabled = true;
            this.CatrigeModelCB.ItemHeight = 23;
            this.CatrigeModelCB.Location = new System.Drawing.Point(173, 92);
            this.CatrigeModelCB.Name = "CatrigeModelCB";
            this.CatrigeModelCB.Size = new System.Drawing.Size(336, 29);
            this.CatrigeModelCB.TabIndex = 3;
            this.CatrigeModelCB.UseSelectable = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatruge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatruge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatruge.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatruge.EnableHeadersVisualStyles = false;
            this.dgvCatruge.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCatruge.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatruge.Location = new System.Drawing.Point(647, 115);
            this.dgvCatruge.Name = "dgvCatruge";
            this.dgvCatruge.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatruge.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatruge.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCatruge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatruge.Size = new System.Drawing.Size(407, 336);
            this.dgvCatruge.TabIndex = 1;
            this.dgvCatruge.SelectionChanged += new System.EventHandler(this.dgvCatruge_SelectionChanged);
            // 
            // CatrigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 518);
            this.Controls.Add(this.dgvCatruge);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CatrigeForm";
            this.Text = "CatrigeForm";
            this.Load += new System.EventHandler(this.CatrigeForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatruge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox SerialNumberTB;
        private MetroFramework.Controls.MetroComboBox CatrigeModelCB;
        private MetroFramework.Controls.MetroGrid dgvCatruge;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton Clea;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}