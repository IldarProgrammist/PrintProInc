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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PrinterFirmForm printerFirmForm = new PrinterFirmForm();
            printerFirmForm.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            PrinterModelForm printerModelForm = new PrinterModelForm();
            printerModelForm.Show();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            LocationForm locationForm = new LocationForm();
            locationForm.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            PrinterStatusForm printerStatusForm = new PrinterStatusForm();
            printerStatusForm.Show();
        }
    }
}
