namespace PrintProInc.Forms
{
    partial class CatrigeStatusForm
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
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.dgvStatusCatrige = new MetroFramework.Controls.MetroGrid();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.CatrigeStatusNameTB = new MetroFramework.Controls.MetroTextBox();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusCatrige)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(206, 149);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(78, 31);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dgvStatusCatrige
            // 
            this.dgvStatusCatrige.AllowUserToResizeRows = false;
            this.dgvStatusCatrige.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStatusCatrige.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatusCatrige.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStatusCatrige.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatusCatrige.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatusCatrige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatusCatrige.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStatusCatrige.EnableHeadersVisualStyles = false;
            this.dgvStatusCatrige.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvStatusCatrige.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStatusCatrige.Location = new System.Drawing.Point(335, 83);
            this.dgvStatusCatrige.Name = "dgvStatusCatrige";
            this.dgvStatusCatrige.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatusCatrige.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStatusCatrige.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStatusCatrige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatusCatrige.Size = new System.Drawing.Size(262, 150);
            this.dgvStatusCatrige.TabIndex = 8;
            this.dgvStatusCatrige.SelectionChanged += new System.EventHandler(this.dgvStatusCatrige_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(33, 66);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 19);
            this.ID.TabIndex = 6;
            this.ID.Text = "0";
            // 
            // CatrigeStatusNameTB
            // 
            // 
            // 
            // 
            this.CatrigeStatusNameTB.CustomButton.Image = null;
            this.CatrigeStatusNameTB.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.CatrigeStatusNameTB.CustomButton.Name = "";
            this.CatrigeStatusNameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CatrigeStatusNameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CatrigeStatusNameTB.CustomButton.TabIndex = 1;
            this.CatrigeStatusNameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CatrigeStatusNameTB.CustomButton.UseSelectable = true;
            this.CatrigeStatusNameTB.CustomButton.Visible = false;
            this.CatrigeStatusNameTB.Lines = new string[0];
            this.CatrigeStatusNameTB.Location = new System.Drawing.Point(33, 100);
            this.CatrigeStatusNameTB.MaxLength = 32767;
            this.CatrigeStatusNameTB.Name = "CatrigeStatusNameTB";
            this.CatrigeStatusNameTB.PasswordChar = '\0';
            this.CatrigeStatusNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CatrigeStatusNameTB.SelectedText = "";
            this.CatrigeStatusNameTB.SelectionLength = 0;
            this.CatrigeStatusNameTB.SelectionStart = 0;
            this.CatrigeStatusNameTB.ShortcutsEnabled = true;
            this.CatrigeStatusNameTB.Size = new System.Drawing.Size(251, 23);
            this.CatrigeStatusNameTB.TabIndex = 5;
            this.CatrigeStatusNameTB.UseSelectable = true;
            this.CatrigeStatusNameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CatrigeStatusNameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(122, 149);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(78, 31);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseSelectable = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // CatrigeStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 335);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dgvStatusCatrige);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.CatrigeStatusNameTB);
            this.Name = "CatrigeStatusForm";
            this.Text = "CatrigeStatusForm";
            this.Load += new System.EventHandler(this.CatrigeStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusCatrige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroGrid dgvStatusCatrige;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroTextBox CatrigeStatusNameTB;
        private MetroFramework.Controls.MetroButton clearBtn;
    }
}