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
    public partial class LocationForm : MetroFramework.Forms.MetroForm
    {

        private void Clear()
        {
            ID.Text = "0";
            RoomTB.Text = string.Empty;
            TitulCB.SelectedIndex = -1;

        }
        public LocationForm()
        {
            InitializeComponent();
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            WorkInLocationPrinter workInLocationPrinter = new WorkInLocationPrinter(dgvLocation, RoomTB.Text, TitulCB, ID.Text);
            workInLocationPrinter.Load();
            Clear();
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
            ID.Text = selectedRow.Cells["LocationID"].Value.ToString();
            RoomTB.Text = selectedRow.Cells["Room"].Value.ToString();
            TitulCB.SelectedIndex = TitulCB.FindStringExact(selectedRow.Cells["Titul"].Value.ToString());

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            WorkInLocationPrinter workInLocationPrinter = new WorkInLocationPrinter(dgvLocation, RoomTB.Text, TitulCB, ID.Text);
            workInLocationPrinter.CreateUpdate();
            workInLocationPrinter.Load();

        }



        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            WorkInLocationPrinter workInLocationPrinter = new WorkInLocationPrinter(dgvLocation, RoomTB.Text, TitulCB, ID.Text);
            workInLocationPrinter.Delete();
            workInLocationPrinter.Load();
        }
    }
}
