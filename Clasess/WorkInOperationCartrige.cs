using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Linq;

namespace PrintProInc.Clasess
{
    public class WorkInOperationCartrige:ICRUD
    {
        private MetroGrid Dgv { get; set; }
        private string ID { get; set; }
        private MetroTextBox CartrigeIDTB { get; set; }
        private string SerialNamber { get; set; }
        private MetroComboBox StatusCB { get; set; }

        public WorkInOperationCartrige(MetroGrid dgv)
        {
            Dgv = dgv;
        }

        public WorkInOperationCartrige(MetroGrid dgv, MetroTextBox cartrigeIDTB, MetroComboBox catrigeModelCB)
        {
            Dgv = dgv;
            CartrigeIDTB = cartrigeIDTB;
            StatusCB = catrigeModelCB;
        }

        public void Load()
        {
            using (ContextModel db = new ContextModel())
            {
                StatusCB.DataSource = db.CatrigeStatus.ToList();
                StatusCB.ValueMember = "CatrigeStatusID";
                StatusCB.DisplayMember = "CatrigeStatusName";

                var CartrigeOperation = from np in db.CatrigeOperation
                                        select new
                                       {
                                           np.CatrigeOperation1,
                                           np.CatrigeID,
                                           np.CatrigeStatus.CatrigeStatusName,
                                           np.OperationDate
                                       };

                Dgv.DataSource = CartrigeOperation.ToList();
               
            }
        }

       


        public void CreateUpdate()
        {
           int CartrigeOperationID = Convert.ToInt32(ID);

            using (ContextModel db = new ContextModel())

            {
                if (CartrigeOperationID == 0)
                {
                    CatrigeOperation catrigeOperation = new CatrigeOperation
                    {
                        CatrigeOperation1 = Convert.ToInt32(ID),
                        CatrigeID = Convert.ToInt32(CartrigeIDTB.Text),
                        CatrigeStatusID = Convert.ToInt32(StatusCB.SelectedValue),
                        OperationDate = DateTime.Now
                    };

                    db.CatrigeOperation.Add(catrigeOperation);
                }

                else
                {
                    var mpToUpdate = db.CatrigeOperation.SingleOrDefault(pm => pm.CatrigeOperation1 == CartrigeOperationID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.CatrigeID = Convert.ToInt32(CartrigeIDTB.Text);
                        mpToUpdate.CatrigeStatusID = Convert.ToInt32(StatusCB.SelectedValue);
                        mpToUpdate.OperationDate = Convert.ToDateTime(DateTime.Now);
                    }
                }
                db.SaveChanges();
                Load();
            }
        }


        public void searchInStatus(MetroComboBox status )
        {
            /*
            using (ContextModel db = new ContextModel())
            {
                var SearchCarigeStatus = from m in db.CatrigeOperation.Where(p => p.CatrigeStatusID.Contains(status.SelectedValue))
                                     select new
                                     {
                                         m.CatrigeModelID,
                                         m.CatirgeModelName,
                                     };
                Dgv.DataSource = SearchCarigeStatus.ToList();
            }
            */


        }




        public int Count()
        {

            using (var db = new ContextModel())
            {
              
               
                
                
                // return db.CatrigeOperation.Where(c => c.CatrigeStatus.CatrigeStatusID == status.SelectedIndex).Count();
            }

            return 0;
        }



        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
