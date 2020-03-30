using PrintProInc.Clasess;
using System;
using System.Windows.Forms;

namespace PrintProInc.Forms
{
    public partial class PrinterForm : MetroFramework.Forms.MetroForm
    {
        public PrinterForm()
        {
            InitializeComponent();
        }



        private void Clear()
        {
            ID.Text = "0";
            SerialNamberTB.Text = string.Empty;
            CatrigeModelCB.SelectedIndex = -1;
            LacationCB.SelectedIndex = -1;
        }


        private void PrinterForm_Load(object sender, EventArgs e)
        {
           WorkPrinter workPrinter = new WorkPrinter(ID.Text, SerialNamberTB.Text, dgvPrinter, CatrigeModelCB, LacationCB);
           workPrinter.Load();
            Clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
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
           SerialNamberTB.Text = selectedRow.Cells["SerialNamber"].Value.ToString();
           CatrigeModelCB.SelectedIndex = CatrigeModelCB.FindStringExact(selectedRow.Cells["CatirgeModelName"].Value.ToString());
           LacationCB.SelectedIndex = LacationCB.FindStringExact(selectedRow.Cells["Room"].Value.ToString());



        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            WorkPrinter workPrinter = new WorkPrinter(ID.Text, SerialNamberTB.Text, dgvPrinter, LacationCB, LacationCB);
            workPrinter.CreateUpdate();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            WorkPrinter workPrinter = new WorkPrinter(ID.Text, SerialNamberTB.Text, dgvPrinter, LacationCB, LacationCB);
            workPrinter.Delete();
            Clear();
        }
    }
}
