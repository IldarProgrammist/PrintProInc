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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCariges = new MetroFramework.Controls.MetroGrid();
            this.snTB = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgvCartrigeOperation = new MetroFramework.Controls.MetroGrid();
            this.CartrugeID = new MetroFramework.Controls.MetroTextBox();
            this.OperationID = new MetroFramework.Controls.MetroLabel();
            this.CartrigeStatusCB = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariges)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartrigeOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCariges
            // 
            this.dgvCariges.AllowUserToResizeRows = false;
            this.dgvCariges.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCariges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCariges.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCariges.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCariges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCariges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCariges.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCariges.EnableHeadersVisualStyles = false;
            this.dgvCariges.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCariges.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCariges.Location = new System.Drawing.Point(35, 251);
            this.dgvCariges.Name = "dgvCariges";
            this.dgvCariges.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCariges.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCariges.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCariges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariges.Size = new System.Drawing.Size(475, 305);
            this.dgvCariges.TabIndex = 6;
            this.dgvCariges.SelectionChanged += new System.EventHandler(this.dgvCariges_SelectionChanged);
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
            this.snTB.Location = new System.Drawing.Point(151, 49);
            this.snTB.MaxLength = 32767;
            this.snTB.Name = "snTB";
            this.snTB.PasswordChar = '\0';
            this.snTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.snTB.SelectedText = "";
            this.snTB.SelectionLength = 0;
            this.snTB.SelectionStart = 0;
            this.snTB.ShortcutsEnabled = true;
            this.snTB.Size = new System.Drawing.Size(164, 23);
            this.snTB.TabIndex = 6;
            this.snTB.UseSelectable = true;
            this.snTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.snTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.snTB.TextChanged += new System.EventHandler(this.snTB_TextChanged);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.snTB);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(35, 74);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(475, 141);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.SaveBtn);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.Controls.Add(this.CartrigeStatusCB);
            this.metroPanel1.Controls.Add(this.dgvCartrigeOperation);
            this.metroPanel1.Controls.Add(this.CartrugeID);
            this.metroPanel1.Controls.Add(this.OperationID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(554, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(601, 504);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgvCartrigeOperation
            // 
            this.dgvCartrigeOperation.AllowUserToResizeRows = false;
            this.dgvCartrigeOperation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCartrigeOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCartrigeOperation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCartrigeOperation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartrigeOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCartrigeOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCartrigeOperation.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCartrigeOperation.EnableHeadersVisualStyles = false;
            this.dgvCartrigeOperation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCartrigeOperation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCartrigeOperation.Location = new System.Drawing.Point(27, 261);
            this.dgvCartrigeOperation.Name = "dgvCartrigeOperation";
            this.dgvCartrigeOperation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartrigeOperation.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCartrigeOperation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCartrigeOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartrigeOperation.Size = new System.Drawing.Size(543, 221);
            this.dgvCartrigeOperation.TabIndex = 10;
            // 
            // CartrugeID
            // 
            // 
            // 
            // 
            this.CartrugeID.CustomButton.Image = null;
            this.CartrugeID.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.CartrugeID.CustomButton.Name = "";
            this.CartrugeID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CartrugeID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CartrugeID.CustomButton.TabIndex = 1;
            this.CartrugeID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CartrugeID.CustomButton.UseSelectable = true;
            this.CartrugeID.CustomButton.Visible = false;
            this.CartrugeID.Lines = new string[0];
            this.CartrugeID.Location = new System.Drawing.Point(90, 49);
            this.CartrugeID.MaxLength = 32767;
            this.CartrugeID.Name = "CartrugeID";
            this.CartrugeID.PasswordChar = '\0';
            this.CartrugeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CartrugeID.SelectedText = "";
            this.CartrugeID.SelectionLength = 0;
            this.CartrugeID.SelectionStart = 0;
            this.CartrugeID.ShortcutsEnabled = true;
            this.CartrugeID.Size = new System.Drawing.Size(200, 23);
            this.CartrugeID.TabIndex = 9;
            this.CartrugeID.UseSelectable = true;
            this.CartrugeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CartrugeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OperationID
            // 
            this.OperationID.AutoSize = true;
            this.OperationID.Location = new System.Drawing.Point(90, 14);
            this.OperationID.Name = "OperationID";
            this.OperationID.Size = new System.Drawing.Size(16, 19);
            this.OperationID.TabIndex = 8;
            this.OperationID.Text = "0";
            // 
            // CartrigeStatusCB
            // 
            this.CartrigeStatusCB.FormattingEnabled = true;
            this.CartrigeStatusCB.ItemHeight = 23;
            this.CartrigeStatusCB.Location = new System.Drawing.Point(90, 92);
            this.CartrigeStatusCB.Name = "CartrigeStatusCB";
            this.CartrigeStatusCB.Size = new System.Drawing.Size(200, 29);
            this.CartrigeStatusCB.TabIndex = 11;
            this.CartrigeStatusCB.UseSelectable = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(90, 139);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 12;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(90, 195);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(115, 39);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseSelectable = true;
            // 
            // CartrigeOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 659);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dgvCariges);
            this.Controls.Add(this.metroPanel2);
            this.Name = "CartrigeOperationForm";
            this.Text = "CartrigeOperationForm";
            this.Load += new System.EventHandler(this.CartrigeOperationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariges)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartrigeOperation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvCariges;
        private MetroFramework.Controls.MetroTextBox snTB;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel OperationID;
        private MetroFramework.Controls.MetroTextBox CartrugeID;
        private MetroFramework.Controls.MetroGrid dgvCartrigeOperation;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroComboBox CartrigeStatusCB;
        private MetroFramework.Controls.MetroButton SaveBtn;
    }
}