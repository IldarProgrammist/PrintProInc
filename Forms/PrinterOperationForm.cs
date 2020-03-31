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
          
        }
        private void PrinterOperationForm_Load(object sender, EventArgs e)
        {
            WorkInOperationPrinter workInOperationPrinter = new WorkInOperationPrinter(dgvSearch,PrinterIDTB, StatusCB, DateDP);
            workInOperationPrinter.Load();    
        }



        private void serchTB_TextChanged(object sender, EventArgs e)
        {
            WorkInOperationPrinter workInOperationPrinter = new WorkInOperationPrinter(dgvPrinterOperation, PrinterIDTB, StatusCB, DateDP); 
            workInOperationPrinter.search(serchTB.Text);

        }

        private void dgvPrinterOperation_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvPrinterOperation.SelectedRows.Count > 0)
            {
                selectedRow = dgvPrinterOperation.SelectedRows[0];
            }
            if (selectedRow == null)

                return;

            ID.Text = selectedRow.Cells["SerialNamber"].Value.ToString();
            PrinterIDTB.Text = selectedRow.Cells["PrinterID"].Value.ToString();

        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {

            PrinterWork printerWork = new PrinterWork(dgvSearch, PrinterIDTB, StatusCB);
            printerWork.CreateUpdate();
            printerWork.Load();
            
            
           
        }

        private void dgvSearch_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            if (dgvSearch.SelectedRows.Count > 0)
            {
                selectedRow = dgvSearch.SelectedRows[0];
            }

            if (selectedRow == null)

                return;

            OpID.Text = selectedRow.Cells["PrinterOperationID"].Value.ToString();
            ID.Text = selectedRow.Cells["PrinterID"].Value.ToString();
          //t  StatusCB.SelectedIndex = StatusCB.FindStringExact(selectedRow.Cells["PrinterStatusName"].Value.ToString());




        }
    }
}
