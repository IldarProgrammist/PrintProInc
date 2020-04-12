namespace PrintProInc.Forms
{
    partial class MainForm
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
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton5
            // 
            this.metroButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton5.Location = new System.Drawing.Point(20, 60);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(478, 85);
            this.metroButton5.TabIndex = 7;
            this.metroButton5.Text = "Принтеры";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton1.Location = new System.Drawing.Point(20, 145);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(478, 85);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Картриджи";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 288);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton5);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}