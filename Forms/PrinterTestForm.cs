using PrintProInc.Clasess;
using System;
using System.Windows.Forms;

namespace PrintProInc.Forms
{
    public partial class PrinterTestForm : MetroFramework.Forms.MetroForm
    {
        public PrinterTestForm()
        {
            InitializeComponent();
        }


        private void Clear()
        {
            ID.Text = "0";
            SnTB.Text = string.Empty;
            ModelCatrigeCB.SelectedIndex = -1;
            LocationTB.Text = string.Empty;
            LocationIDTB.Text = string.Empty;
        }

        private void PrinterTestForm_Load(object sender, EventArgs e)
        {
            //LocationTB.ReadOnly = true;


            //MetroLabel printerID, MetroTextBox sn, MetroGrid dgv, MetroComboBox catrigeModelCB, MetroTextBox locarionTB, MetroTextBox locationID

            PrinterTest printerTest = new PrinterTest(ID, SnTB, dgvPrinter, ModelCatrigeCB, LocationIDTB);
           
            WorkInLocationPrinter workInLocationPrinter = new WorkInLocationPrinter();
            workInLocationPrinter.Load(dgvLocation);
            printerTest.Load();
            Clear();
        }

        private void dgvPrinter_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            if (dgvPrinter.SelectedRows.Count > 0)
            {
                selectedRow = dgvPrinter.SelectedRows[0];
            }

            if (selectedRow == null)

                return;

            ID.Text = selectedRow.Cells["PrinterID"].Value.ToString();
            SnTB.Text = selectedRow.Cells["SerialNamber"].Value.ToString();
            ModelCatrigeCB.SelectedIndex = ModelCatrigeCB.FindStringExact(selectedRow.Cells["CatirgeModelName"].Value.ToString());
            LocationTB.Text = selectedRow.Cells["Room"].Value.ToString(); 
        }

        private void dgvLocation_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvLocation.SelectedRows.Count > 0)
            {
                selectedRow = dgvLocation.SelectedRows[0];
            }
            if (selectedRow == null)
                return;
              LocationTB.Text = selectedRow.Cells["Room"].Value.ToString();
              LocationIDTB.Text = selectedRow.Cells["LocationID"].Value.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrinterTest printerTest = new PrinterTest(ID, SnTB, dgvPrinter, ModelCatrigeCB, LocationIDTB);
            printerTest.CreateUpdate();   
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            PrinterTest printerTest = new PrinterTest(ID, SnTB, dgvPrinter, ModelCatrigeCB, LocationIDTB);
            printerTest.Delete(); 
        }
    }
}
