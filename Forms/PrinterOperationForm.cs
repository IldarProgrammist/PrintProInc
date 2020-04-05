using PrintProInc.Clasess;
using System;
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
            ID.Text = "0";
            StatusCB.SelectedIndex = -1;


        }
        private void PrinterOperationForm_Load(object sender, EventArgs e)
        {
            WorkInOperationPrinter workInOperationPrinter = new WorkInOperationPrinter(dgvSearch,PrinterIDTB, StatusCB, DateDP);
          //  workInOperationPrinter.SearchLoad(dgvSearch);
            workInOperationPrinter.Load();

            Clear();
           //OpID.Visible = false;
           PrinterIDTB.Visible = false;
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

            OpID.Text = selectedRow.Cells["SerialNamber"].Value.ToString();
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

            ID.Text = selectedRow.Cells["PrinterOperationID"].Value.ToString();
          //t  StatusCB.SelectedIndex = StatusCB.FindStringExact(selectedRow.Cells["PrinterStatusName"].Value.ToString());




        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void serchTB_TextChanged_1(object sender, EventArgs e)
        {
            WorkInOperationPrinter workInOperationPrinter = new WorkInOperationPrinter(dgvPrinterOperation, PrinterIDTB, StatusCB, DateDP);
            workInOperationPrinter.search(serchTB.Text);
            
        }
    }
}
