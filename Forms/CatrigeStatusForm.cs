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
    public partial class CatrigeStatusForm : MetroFramework.Forms.MetroForm
    {
        public CatrigeStatusForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            ID.Text = "0";
            CatrigeStatusNameTB.Text = string.Empty;
        }

        private void CatrigeStatusForm_Load(object sender, EventArgs e)
        {

            WorkInCatrigeStatus workInCatrigeStatus = new WorkInCatrigeStatus(dgvStatusCatrige, ID.Text, CatrigeStatusNameTB.Text);
            workInCatrigeStatus.load();
            Clear();

        }

        private void dgvStatusCatrige_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvStatusCatrige.SelectedRows.Count > 0)
            {
                selectedRow = dgvStatusCatrige.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            ID.Text = selectedRow.Cells["CatrigeStatusID"].Value.ToString();
            CatrigeStatusNameTB.Text = selectedRow.Cells["CatrigeStatusName"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            WorkInCatrigeStatus workInCatrigeStatus = new WorkInCatrigeStatus(dgvStatusCatrige, ID.Text, CatrigeStatusNameTB.Text);
            workInCatrigeStatus.create();
            Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            WorkInCatrigeStatus workInCatrigeStatus = new WorkInCatrigeStatus(dgvStatusCatrige, ID.Text, CatrigeStatusNameTB.Text);
            workInCatrigeStatus.delete();
            Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
