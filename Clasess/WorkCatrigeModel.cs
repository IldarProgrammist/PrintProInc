using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Linq;

namespace PrintProInc.Clasess
{
    public class WorkCatrigeModel : ICRUD
    {
        private MetroLabel CatrigeModelID { get; set; }
        private string CatrigeModelName { get; set; }
        private MetroGrid Dgv { get; set; }
        private MetroComboBox CatrigeColorCB { get; set; }
   
        private MetroComboBox PrinterModelCB { get; set; } 

        public WorkCatrigeModel(MetroGrid dgv, MetroLabel catrtrigeModelID, string modelName,MetroComboBox catrigeColorCb, MetroComboBox  printerModelCb)
        {
            Dgv = dgv;
            CatrigeModelID = catrtrigeModelID;
            CatrigeModelName = modelName;
            CatrigeColorCB = catrigeColorCb;
            PrinterModelCB = printerModelCb;
        }



        public void CartigeModelLoad()
        {


        }





        public void Load()
        {

            using (ContextModel db = new ContextModel())
            {
                CatrigeColorCB.DataSource = db.CatrigeColor.ToList();
                CatrigeColorCB.ValueMember = "CatrigeColorID";
                CatrigeColorCB.DisplayMember = "ColorName";

                PrinterModelCB.DataSource = db.PrinterModel.ToList();
                PrinterModelCB.ValueMember = "PrinterModelID";
                PrinterModelCB.DisplayMember = "PrinterModelName";


                var catrigeModel = from mp in db.CatrigeModel
                                   select new
                                   {
                                       mp.CatrigeModelID,
                                       mp.CatirgeModelName,
                                       CatrigeColor = mp.CatrigeColor.ColorName,
                                       PrinterModel = mp.PrinterModelID
                                   };
                Dgv.DataSource = catrigeModel.ToList();

            }
        }


        public void CreateUpdate()
        {
            
            using (ContextModel db = new ContextModel())
            {

                int ID = Convert.ToInt32(CatrigeModelID.Text);



                if (ID == 0)
                {
                    CatrigeModel catrigeModel = new CatrigeModel
                    {


                        CatirgeModelName = CatrigeModelName,
                        ColorID = Convert.ToInt32(CatrigeColorCB.SelectedValue),
                        CatrigeModelID = Convert.ToInt32(PrinterModelCB.SelectedValue)
                    };
                    db.CatrigeModel.Add(catrigeModel);
                }
                else
                {
                    var mpToUpdate = db.CatrigeModel.SingleOrDefault(pm => pm.CatrigeModelID == ID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.CatirgeModelName = CatrigeModelName;
                        mpToUpdate.ColorID = Convert.ToInt32(CatrigeColorCB.SelectedValue);
                    }
                }
                db.SaveChanges();
            }

            Load();

        }

        public void Delete()
        {

               int ID = Convert.ToInt32(CatrigeModelID.Text);

                using (ContextModel db = new ContextModel())
                {
                    CatrigeModel catrigeModel = db.CatrigeModel
                       .Where(p => p.CatrigeModelID == ID)
                       .FirstOrDefault();
                    db.CatrigeModel.Remove(catrigeModel);
                    db.SaveChanges();
                }


            Load();
        }
    }
}
