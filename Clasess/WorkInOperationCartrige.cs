using MetroFramework.Controls;
using PrintProInc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProInc.Clasess
{
    public class WorkInOperationCartrige
    {
        private MetroGrid Dgv { get; set; }
        private string CartrigeID { get; set; }
        private string SerialNamber { get; set; }
        private MetroComboBox CatrigeModelCB { get; set; }

        public WorkInOperationCartrige(MetroGrid dgv)
        {
            Dgv = dgv;
        }

        public WorkInOperationCartrige(MetroGrid dgv, MetroComboBox catrigeModelCB)
        {
            Dgv = dgv;
            CatrigeModelCB = catrigeModelCB;
        }


        public void Load()
        {
            using (ContextModel db = new ContextModel())
            {
                CatrigeModelCB.DataSource = db.CatrigeStatus.ToList();
                CatrigeModelCB.ValueMember = "CatrigeStatusID";
                CatrigeModelCB.DisplayMember = "CatrigeStatusName";


               
                var CartrigeOperation = from np in db.CatrigeOperation
                                       
                                       select new
                                       {
                                           np.CatrigeOperation1,
                                           np.CatrigeID,
                                           np.CatrigeStatus.CatrigeStatusName,
                                           
                                       };

                Dgv.DataSource = CartrigeOperation.ToList();
               
            }

        }

    }
}
