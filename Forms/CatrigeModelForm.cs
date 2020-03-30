using MetroFramework.Controls;
using PrintProInc.Clasess;
using System;
using System.Windows.Forms;

namespace PrintProInc.Forms
{
    public partial class CatrigeModelForm : MetroFramework.Forms.MetroForm
    {
        public CatrigeModelForm()
        {
            InitializeComponent();
        }


        private void Clear()
        {
            ID.Text = "0";
            modelNameTB.Text = string.Empty;
            ColorCB.SelectedIndex = -1;
            PrinterModelCB.SelectedIndex = -1;
        }

        private void CatrigeModelForm_Load(object sender, EventArgs e)
        {
           
            WorkCatrigeModel catrigeModel = new WorkCatrigeModel(dgvCatrigeModel,ID, modelNameTB.Text,ColorCB, PrinterModelCB);
            catrigeModel.Load();
            Clear();
           

        }

        private void dgvCatrigeModel_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvCatrigeModel.SelectedRows.Count > 0)
            {
                selectedRow = dgvCatrigeModel.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            ID.Text = selectedRow.Cells["CatrigeModelID"].Value.ToString();
            modelNameTB.Text = selectedRow.Cells["CatirgeModelName"].Value.ToString();
            ColorCB.SelectedIndex = ColorCB.FindStringExact(selectedRow.Cells["CatrigeColor"].Value.ToString());
            //PrinterModelCB.SelectedIndex = PrinterModelCB.FindStringExact(selectedRow.Cells["PrinterModel"].Value.ToString());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            WorkCatrigeModel workCatrigeModel = new WorkCatrigeModel(dgvCatrigeModel,ID,modelNameTB.Text, ColorCB,PrinterModelCB);
            workCatrigeModel.CreateUpdate();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            WorkCatrigeModel workCatrigeModel = new WorkCatrigeModel(dgvCatrigeModel, ID, modelNameTB.Text, ColorCB, PrinterModelCB);
            workCatrigeModel.Delete();
        }
    }
}
