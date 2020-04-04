using MetroFramework.Controls;
using PrintProInc.Models;
using System;
using System.Linq;

namespace PrintProInc.Clasess
{
    public class CartrigeTest 
    {
        private MetroGrid DgvModel { get; set; }
        private MetroGrid DgvCatr { get; set; }
        private MetroTextBox SerialNumber { get; set; }
        private MetroTextBox CatrigeModel { get; set; }
        private MetroLabel CatrigeID { get; set; }


        public CartrigeTest(MetroGrid dgvModel)
        {
            DgvModel = dgvModel;
        }

        public CartrigeTest(MetroGrid dgvModel,MetroLabel catrigeID,  MetroTextBox serialNumber, MetroTextBox catrigeModel)
        {
            DgvModel = dgvModel;
            SerialNumber = serialNumber;
            CatrigeModel = catrigeModel;
            CatrigeID = catrigeID;
        }



        public void CreateUpdate()
        {
            using(ContextModel db = new ContextModel())
            {
                int ID = Convert.ToInt32(CatrigeID.Text);

                if(ID==0)
                {
                    Catrige catrige = new Catrige
                    {
                        //CatrigeID = Convert.ToInt32(CatrigeID.Text),
                        SerialNamber = SerialNumber.Text,
                        CatrigeModelID = Convert.ToInt32(CatrigeModel.Text),

                    };
                    db.Catrige.Add(catrige);
                }
                else
                {
                    var mpToUpdate = db.Catrige.SingleOrDefault(pm => pm.CatrigeID == ID);

                    if (mpToUpdate != null)

                    {
                        //mpToUpdate.CatrigeID = Convert.ToInt32(CatrigeID.Text);
                        mpToUpdate.SerialNamber = SerialNumber.Text;
                        mpToUpdate.CatrigeModelID = Convert.ToInt32(CatrigeModel.Text);
                    }
                    db.SaveChanges();
                }

            }
        }

        public void Delete(MetroLabel catrigeID)
        {
            
            using (ContextModel db = new ContextModel())
            {
                int ID = Convert.ToInt32(catrigeID.Text);


                Catrige catrige = db.Catrige

                   .Where(p => p.CatrigeID == ID)
                   .FirstOrDefault();
                db.Catrige.Remove(catrige);
                db.SaveChanges();
            }
        }

        public void Load()
        {
            using(ContextModel db = new ContextModel())
            {
                var catrigeModel = from mp in db.CatrigeModel
                                   select new
                                   {
                                       
                                       mp.CatrigeModelID,
                                       mp.CatirgeModelName,
                                   };
                DgvModel.DataSource = catrigeModel.ToList();

            }
        }



        public void CatrigeLoad(MetroGrid dgv)
        {

            using (ContextModel db = new ContextModel())
            {
                var catrige = from mp in db.Catrige
                              select new
                              {
                                  mp.CatrigeID,
                                  mp.SerialNamber,
                                  mp.CatrigeModel.CatirgeModelName,
                                  mp.CatrigeModel.CatrigeColor.ColorName,
                                  mp.CatrigeModelID

                              };
                dgv.DataSource = catrige.ToList();

            }
        }


        public void searchCartrigeModel(string catrigeModelName)
        {

            using (ContextModel db = new ContextModel())
            {
                var SearchCarigeMN = from m in db.CatrigeModel.Where(p => p.CatirgeModelName.Contains(catrigeModelName))
                                     select new
                                     {
                                         m.CatrigeModelID,
                                         m.CatirgeModelName,
                                     };
                DgvModel.DataSource = SearchCarigeMN.ToList();
            }
        }

        public void searchCatrigeSN(string catrigeSerialNamber)
        {
            using (ContextModel db = new ContextModel())
            {
                var SearchCarigeMN = from m in db.Catrige.Where(p => p.SerialNamber.Contains(catrigeSerialNamber))
                                     select new
                                     {   
                                         m.CatrigeID,
                                         m.SerialNamber,
                                         m.CatrigeModel.CatirgeModelName,
                                         m.CatrigeModel.CatrigeColor.ColorName
                                        
                                     };
                DgvModel.DataSource = SearchCarigeMN.ToList();
            }

        }

    }
}
