using PrintProInc.Clasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintProInc
{
    public partial class PrinterFirmForm : MetroFramework.Forms.MetroForm
    {
        public PrinterFirmForm()
        {
            InitializeComponent();
        }

        private void PrinterFirmForm_Load(object sender, EventArgs e)
        {
            FirmPrinter firmPrinter = new FirmPrinter(DgvPrinterFirm, PrinterFirmID.Text,PrinterFirmNameTB.Text);
            
            firmPrinter.Load();
        }

        
        private void DgvPrinterFirm_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (DgvPrinterFirm.SelectedRows.Count > 0)
            {
                selectedRow = DgvPrinterFirm.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            PrinterFirmID.Text = selectedRow.Cells["PrinterFirmID"].Value.ToString();
            PrinterFirmNameTB.Text = selectedRow.Cells["PrinterFirmName"].Value.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PrinterFirmID.Text = "0";
            PrinterFirmNameTB.Text = string.Empty;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FirmPrinter firmPrinter = new FirmPrinter(DgvPrinterFirm, PrinterFirmID.Text, PrinterFirmNameTB.Text);
            firmPrinter.CreateUpdate();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            FirmPrinter firmPrinter = new FirmPrinter(DgvPrinterFirm, PrinterFirmID.Text, PrinterFirmNameTB.Text);
            firmPrinter.Delete();
        }
    }
}
