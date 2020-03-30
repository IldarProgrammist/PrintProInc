namespace PrintProInc.Forms
{
    partial class PrinterStatusForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StatusNameTB = new MetroFramework.Controls.MetroTextBox();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.dgvStatusPrinter = new MetroFramework.Controls.MetroGrid();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusPrinter)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusNameTB
            // 
            // 
            // 
            // 
            this.StatusNameTB.CustomButton.Image = null;
            this.StatusNameTB.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.StatusNameTB.CustomButton.Name = "";
            this.StatusNameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StatusNameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StatusNameTB.CustomButton.TabIndex = 1;
            this.StatusNameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StatusNameTB.CustomButton.UseSelectable = true;
            this.StatusNameTB.CustomButton.Visible = false;
            this.StatusNameTB.Lines = new string[0];
            this.StatusNameTB.Location = new System.Drawing.Point(91, 98);
            this.StatusNameTB.MaxLength = 32767;
            this.StatusNameTB.Name = "StatusNameTB";
            this.StatusNameTB.PasswordChar = '\0';
            this.StatusNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StatusNameTB.SelectedText = "";
            this.StatusNameTB.SelectionLength = 0;
            this.StatusNameTB.SelectionStart = 0;
            this.StatusNameTB.ShortcutsEnabled = true;
            this.StatusNameTB.Size = new System.Drawing.Size(251, 23);
            this.StatusNameTB.TabIndex = 0;
            this.StatusNameTB.UseSelectable = true;
            this.StatusNameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StatusNameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(91, 64);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 19);
            this.ID.TabIndex = 1;
            this.ID.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvStatusPrinter
            // 
            this.dgvStatusPrinter.AllowUserToResizeRows = false;
            this.dgvStatusPrinter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStatusPrinter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatusPrinter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStatusPrinter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatusPrinter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStatusPrinter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatusPrinter.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStatusPrinter.EnableHeadersVisualStyles = false;
            this.dgvStatusPrinter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvStatusPrinter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStatusPrinter.Location = new System.Drawing.Point(393, 81);
            this.dgvStatusPrinter.Name = "dgvStatusPrinter";
            this.dgvStatusPrinter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatusPrinter.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStatusPrinter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStatusPrinter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatusPrinter.Size = new System.Drawing.Size(262, 150);
            this.dgvStatusPrinter.TabIndex = 3;
            this.dgvStatusPrinter.SelectionChanged += new System.EventHandler(this.dgvStatusPrinter_SelectionChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(264, 147);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(78, 31);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // PrinterStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 295);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dgvStatusPrinter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.StatusNameTB);
            this.Name = "PrinterStatusForm";
            this.Text = "Статус принтера";
            this.Load += new System.EventHandler(this.PrinterStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusPrinter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox StatusNameTB;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroGrid dgvStatusPrinter;
        private MetroFramework.Controls.MetroButton deleteBtn;
    }
}