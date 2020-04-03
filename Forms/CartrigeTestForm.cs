﻿using PrintProInc.Clasess;
using System;
using System.Windows.Forms;
namespace PrintProInc.Forms
{
    public partial class CartrigeTestForm : MetroFramework.Forms.MetroForm
    {
        public CartrigeTestForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            ID.Text = "0";
            SnTB.Text = string.Empty;
            CartrigeModelTB.Text = string.Empty;
        }

        private void CartrigeTestForm_Load(object sender, EventArgs e)
        {

            CartrigeTest cartrigeTest = new CartrigeTest(dgvCartrigeModel);
            cartrigeTest.Load();
            WorkCatrige workCatrige = new WorkCatrige(dgvCatriges);
            workCatrige.Load();
            Clear();
        }

        private void dgvCartrigeModel_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = null;

            if (dgvCartrigeModel.SelectedRows.Count > 0)
            {
                selectedRow = dgvCartrigeModel.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            CartrigeModelTB.Text = selectedRow.Cells["CatrigeModelID"].Value.ToString();

        }

        //Картриджи
        private void dgvCatriges_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvCatriges.SelectedRows.Count > 0)
            {
                selectedRow = dgvCatriges.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            ID.Text = selectedRow.Cells["CatrigeID"].Value.ToString();
            SnTB.Text= selectedRow.Cells["SerialNamber"].Value.ToString();
            CartrigeModelTB.Text = selectedRow.Cells["CatrigeModelID"].Value.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {  
            WorkCatrige workCatrige = new WorkCatrige(dgvCatriges, ID.Text, SnTB.Text, CartrigeModelTB);
            workCatrige.CreateUpdate();
            workCatrige.Load();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            WorkCatrige workCatrige = new WorkCatrige(dgvCatriges, ID.Text, SnTB.Text, CartrigeModelTB);
            workCatrige.Delete();
            workCatrige.Load();
            Clear();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {   
            CartrigeTest cartrigeTest = new CartrigeTest(dgvCartrigeModel);
            cartrigeTest.searchCartrigeModel(searchTB.Text);  
        }
    }
}
