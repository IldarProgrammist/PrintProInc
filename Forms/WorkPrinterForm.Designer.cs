namespace PrintProInc.Forms
{
    partial class WorkPrinterForm
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
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.PrintersBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton4
            // 
            this.metroButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton4.Location = new System.Drawing.Point(20, 400);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(760, 85);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "Стутус";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton3.Location = new System.Drawing.Point(20, 315);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(760, 85);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Локация";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton2.Location = new System.Drawing.Point(20, 230);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(760, 85);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Модели принтеров";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton1.Location = new System.Drawing.Point(20, 145);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(760, 85);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Фирмы принтеров";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PrintersBtn
            // 
            this.PrintersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrintersBtn.Location = new System.Drawing.Point(20, 60);
            this.PrintersBtn.Name = "PrintersBtn";
            this.PrintersBtn.Size = new System.Drawing.Size(760, 85);
            this.PrintersBtn.TabIndex = 5;
            this.PrintersBtn.Text = "Принтеры";
            this.PrintersBtn.UseSelectable = true;
            this.PrintersBtn.Click += new System.EventHandler(this.PrintersBtn_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton5.Location = new System.Drawing.Point(20, 485);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(760, 85);
            this.metroButton5.TabIndex = 10;
            this.metroButton5.Text = "Информация о принтерах";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // WorkPrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.PrintersBtn);
            this.Name = "WorkPrinterForm";
            this.Text = "Работа с прнтерами";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton PrintersBtn;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}