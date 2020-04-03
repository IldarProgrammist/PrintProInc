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
    public partial class CatrigeForm : MetroFramework.Forms.MetroForm
    {
        public CatrigeForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            ID.Text = "0";
            SerialNumberTB.Text = string.Empty;
            //  CatrigeModelCB.SelectedIndex = -1;
            CartrigeModelTB.Text = string.Empty;
        }

        private void CatrigeForm_Load(object sender, EventArgs e)
        {
            WorkCatrige workCatrige = new WorkCatrige(dgvCatruge, ID.Text, SerialNumberTB.Text, CartrigeModelTB);
            workCatrige.Load();
            workCatrige.Load(dgvModelCartige);
            Clear();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            WorkCatrige workCatrige = new WorkCatrige(dgvCatruge,ID.Text, SerialNumberTB.Text, CartrigeModelTB);
            workCatrige.CreateUpdate();
            Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            WorkCatrige workCatrige = new WorkCatrige(dgvCatruge, ID.Text, SerialNumberTB.Text, CartrigeModelTB);
            workCatrige.Delete();
            Clear();
        }


        private void Clea_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvModelCartige_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvModelCartige.SelectedRows.Count > 0)
            {
                selectedRow = dgvModelCartige.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            
            // SerialNumberTB.Text = selectedRow.Cells["SerialNamber"].Value.ToString();
               CartrigeModelID.Text = selectedRow.Cells["CatrigeModelID"].Value.ToString();
           // CartrigeModelTB.Text = selectedRow.Cells["CatirgeModelName"].Value.ToString();

        }
    }
}
