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
    public partial class WorkCatrigeForms : MetroFramework.Forms.MetroForm
    {
        public WorkCatrigeForms()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CartrigeTestForm catrigeTestForm = new CartrigeTestForm();
            catrigeTestForm.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            CatrigeStatusForm catrigeStatusForm = new CatrigeStatusForm();
            catrigeStatusForm.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            CatrigeModelForm catrigeModelForm = new CatrigeModelForm();
            catrigeModelForm.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            CartrigeOperationForm cartrigeOperationForm = new CartrigeOperationForm();
            cartrigeOperationForm.Show();
        }
    }
}
