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
            CatrigeModelCB.SelectedIndex = -1;
        }

        private void CatrigeForm_Load(object sender, EventArgs e)
        {
            WorkCatrige workCatrige = new WorkCatrige(dgvCatruge, ID.Text, SerialNumberTB.Text, CatrigeModelCB);
            workCatrige.Load();
            Clear();

        }

        private void dgvCatruge_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = null;

            if (dgvCatruge.SelectedRows.Count > 0)
            {
                selectedRow = dgvCatruge.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            ID.Text = selectedRow.Cells["CatrigeID"].Value.ToString();
            SerialNumberTB.Text = selectedRow.Cells["SerialNamber"].Value.ToString();
            CatrigeModelCB.SelectedIndex = CatrigeModelCB.FindStringExact(selectedRow.Cells["CatirgeModelName"].Value.ToString());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WorkCatrige workCatrige = new WorkCatrige(dgvCatruge,ID.Text, SerialNumberTB.Text,CatrigeModelCB);
            workCatrige.CreateUpdate();
            Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            WorkCatrige workCatrige = new WorkCatrige(dgvCatruge, ID.Text, SerialNumberTB.Text, CatrigeModelCB);
            workCatrige.Delete();
            Clear();
        }


        private void Clea_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
