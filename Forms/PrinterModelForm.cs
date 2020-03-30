using PrintProInc.Clasess;
using System;
using System.Windows.Forms;

namespace PrintProInc.Forms
{
    public partial class PrinterModelForm : MetroFramework.Forms.MetroForm
    {
        public PrinterModelForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            ID.Text = "0";
            PrinterFirmCB.SelectedIndex = -1;
            PrinterModelTB.Text = string.Empty;
        }

        private void PrinterModelForm_Load(object sender, EventArgs e)
        {
            ModelPrinter modelPrinter = new ModelPrinter(dgvPrinterModel,ID.Text,PrinterModelTB.Text, PrinterFirmCB);
            modelPrinter.Load();
            Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ModelPrinter modelPrinter = new ModelPrinter(dgvPrinterModel, ID.Text, PrinterModelTB.Text, PrinterFirmCB);
            modelPrinter.CreateUpdate();
            Clear();
        }

        private void dgvPrinterModel_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = null;

            if (dgvPrinterModel.SelectedRows.Count > 0)
            {
                selectedRow = dgvPrinterModel.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            ID.Text = selectedRow.Cells["PrinterModelID"].Value.ToString();
            PrinterModelTB.Text = selectedRow.Cells["PrinterModelName"].Value.ToString();
            PrinterFirmCB.SelectedIndex = PrinterFirmCB.FindStringExact(selectedRow.Cells["PrinterFirm"].Value.ToString());


        }

        private void deletBtn_Click(object sender, EventArgs e)
        {
            ModelPrinter modelPrinter = new ModelPrinter(dgvPrinterModel, ID.Text, PrinterModelTB.Text, PrinterFirmCB);
            modelPrinter.Delete();
            Clear();
        }

        private void ClerarBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
