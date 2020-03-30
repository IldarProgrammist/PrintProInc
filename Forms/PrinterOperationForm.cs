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
    public partial class PrinterOperationForm : MetroFramework.Forms.MetroForm
    {
        public PrinterOperationForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            StatusBB.SelectedIndex = -1;
        }
        private void PrinterOperationForm_Load(object sender, EventArgs e)
        {
            WorkInOperationPrinter workInOperationPrinter = new WorkInOperationPrinter(dgvPrinterOperation,StatusBB);
            workInOperationPrinter.load();

        }

       

        private void serchTB_TextChanged(object sender, EventArgs e)
        {
            WorkInOperationPrinter workInOperationPrinter = new WorkInOperationPrinter(dgvSearch, StatusBB); ;
            workInOperationPrinter.search(serchTB.Text);

        }
    }
}
