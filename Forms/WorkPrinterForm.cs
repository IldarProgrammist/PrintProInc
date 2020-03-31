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
    public partial class WorkPrinterForm : MetroFramework.Forms.MetroForm
    {
        public WorkPrinterForm()
        {
            InitializeComponent();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            PrinterOperationForm printerOperationForm = new PrinterOperationForm();
            printerOperationForm.Show();
        }

        private void PrintersBtn_Click(object sender, EventArgs e)
        {
            PrinterForm printerForm = new PrinterForm();
            printerForm.Show();
        }
    }
}
