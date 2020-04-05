using PrintProInc.Clasess;
using PrintProInc.Models;
using System;
using System.Windows.Forms;

namespace PrintProInc.Forms
{
    public partial class CartrigeOperationForm : MetroFramework.Forms.MetroForm
    {
        public CartrigeOperationForm()
        {
            InitializeComponent();
        }


        private void Clear()
        {
            OperationID.Text = "0";
            CartrigeStatusCB.SelectedIndex = -1;
            SNLab.Text = "0";
            

        }
        private void CartrigeOperationForm_Load(object sender, EventArgs e)
        {
    
            CartrigeTest cartrigeTest = new CartrigeTest(dgvCartrige);
            cartrigeTest.CatrigeLoad(dgvCartrige);
            WorkInOperationCartrige workInOperationCartrige = new WorkInOperationCartrige(dgvCartrigeOperation, CartrugeID, CartrigeStatusCB);
            workInOperationCartrige.Load();

            CartrugeID.Visible = false;

            OperationCatrigeTest operationCatrigeTest = new OperationCatrigeTest();
            operationCatrigeTest.Load(dgvCartrigeOperation, CartrigeStatusCB);
            CartrigeStatusCB.SelectedIndex = -1;
            Clear();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            WorkInOperationCartrige workInOperationCartrige = new WorkInOperationCartrige(dgvCartrigeOperation, CartrugeID,CartrigeStatusCB);
            workInOperationCartrige.CreateUpdate();
        }

        private void dgvCartrige_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = null;

            if (dgvCartrige.SelectedRows.Count > 0)
            {
                selectedRow = dgvCartrige.SelectedRows[0];
            }

            if (selectedRow == null)

                return;
            CartrugeID.Text = selectedRow.Cells["CatrigeID"].Value.ToString();
            SNLab.Text = selectedRow.Cells["SerialNamber"].Value.ToString();


        }

        private void dgvCartrigeOperation_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvCartrigeOperation.SelectedRows.Count > 0)
            {
                selectedRow = dgvCartrigeOperation.SelectedRows[0];
            }

            if (selectedRow == null)

                return;
            OperationID.Text = selectedRow.Cells["CatrigeOperation1"].Value.ToString();
            CartrigeStatusCB.SelectedIndex = CartrigeStatusCB.FindStringExact(selectedRow.Cells["CatrigeStatusName"].Value.ToString());
            
        }

        private void snTB_TextChanged(object sender, EventArgs e)
        {
            OperationCatrigeTest operationCatrigeTest = new OperationCatrigeTest();
            operationCatrigeTest.searchCartrigeSN(snTB.Text, dgvCartrige);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
          Clear();
        }
    }
}
