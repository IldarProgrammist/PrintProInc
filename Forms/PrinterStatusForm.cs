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

namespace PrintProInc.Forms
{
    public partial class PrinterStatusForm : MetroFramework.Forms.MetroForm
    {
        public PrinterStatusForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            ID.Text = "0";
            StatusNameTB.Text = string.Empty;
        }

        private void PrinterStatusForm_Load(object sender, EventArgs e)
        {
            WorkInStatusPrinters workInStatusPrinters = new WorkInStatusPrinters(dgvStatusPrinter, ID.Text, StatusNameTB.Text);
            workInStatusPrinters.load();
            Clear();
        }

        private void dgvStatusPrinter_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvStatusPrinter.SelectedRows.Count > 0)
            {
                selectedRow = dgvStatusPrinter.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            ID.Text = selectedRow.Cells["PrinterStatusID"].Value.ToString();
            StatusNameTB.Text = selectedRow.Cells["PrinterName"].Value.ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WorkInStatusPrinters workInStatusPrinters = new WorkInStatusPrinters(dgvStatusPrinter, ID.Text, StatusNameTB.Text);
            workInStatusPrinters.create();
            Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            WorkInStatusPrinters workInStatusPrinters = new WorkInStatusPrinters(dgvStatusPrinter, ID.Text, StatusNameTB.Text);
            workInStatusPrinters.delete();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
