using PrintProInc.Clasess;
using PrintProInc.Models;
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
    public partial class CartrigeOperationForm : MetroFramework.Forms.MetroForm
    {
        public CartrigeOperationForm()
        {
            InitializeComponent();
        }


        private void Clear()
        {
            OperationID.Text = "0";
            CartrugeID.Text = string.Empty;
            CartrigeStatusCB.SelectedIndex = -1;
        }
        private void CartrigeOperationForm_Load(object sender, EventArgs e)
        {
          WorkCatrige workCatrige = new WorkCatrige(dgvCariges);
          workCatrige.Load(dgvCariges);
            WorkInOperationCartrige workInOperationCartrige = new WorkInOperationCartrige(dgvCartrigeOperation, CartrigeStatusCB);
            workInOperationCartrige.Load();
            Clear();
          
        
        }

        private void snTB_TextChanged(object sender, EventArgs e)
        {
            WorkCatrige workCatrige = new WorkCatrige(dgvCariges);
            workCatrige.search(snTB.Text);
        }

        private void dgvCariges_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvCariges.SelectedRows.Count > 0)
            {
                selectedRow = dgvCariges.SelectedRows[0];
            }
            if (selectedRow == null)
                return;

            CartrugeID.Text = selectedRow.Cells["CatrigeID"].Value.ToString();
            //PrinterIDTB.Text = selectedRow.Cells["PrinterID"].Value.ToString();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CatrigeForm catrigeForm = new CatrigeForm();
            catrigeForm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            dgvCariges.Refresh();
        }
    }
}
