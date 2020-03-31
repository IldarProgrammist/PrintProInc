using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintProInc.Forms
{
    public partial class StatusessForm :MetroFramework.Forms.MetroForm
    {
        public StatusessForm()
        {
            InitializeComponent();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            PrinterStatusForm printerStatusForm = new PrinterStatusForm();
            printerStatusForm.Show();
            
        }
    }
}
