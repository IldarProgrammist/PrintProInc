using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProInc.Clasess
{
    class ModelPrinter : ICRUD
    {
        private string PrinterModelID { get; set; }
        private string PrinterModelName { get; set; } 
        private MetroComboBox PrinterFirmCb { get; set; }
        MetroGrid Dgv { get; set; }




        public ModelPrinter(MetroGrid dgv, string printerID, string printerModelName, MetroComboBox pintrerFirmCb)
        {
            PrinterModelID = printerID;
            PrinterModelName = printerModelName;
            PrinterFirmCb = pintrerFirmCb;
            Dgv = dgv;
        }

        public void Load()
        {

            using (ContextModel db = new ContextModel())
            {
                PrinterFirmCb.DataSource = db.PrinterFirm.ToList();
                PrinterFirmCb.DisplayMember = "PrinterFirmName";
                PrinterFirmCb.ValueMember = "PrinterFirmID";


                var printerModel = from mp in db.PrinterModel
                                   select new
                                   {
                                       mp.PrinterModelID,
                                       mp.PrinterModelName,
                                       PrinterFirm = mp.PrinterFirm.PrinterFirmName
                                   };
                Dgv.DataSource = printerModel.ToList();

            }

        }


        public void CreateUpdate()
        {
            int ID = Convert.ToInt32(PrinterModelID);
            using (ContextModel db = new ContextModel())
            {
                if (ID == 0)
                {
                    PrinterModel printerModels = new PrinterModel
                    {
                        PrinterModelName = PrinterModelName,
                        PrinterFirmID = Convert.ToInt32(PrinterFirmCb.SelectedValue)
                    };
                    db.PrinterModel.Add(printerModels);
                }
                else
                {
                    var mpToUpdate = db.PrinterModel.SingleOrDefault(pm => pm.PrinterModelID == ID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.PrinterModelName = PrinterModelName;
                        mpToUpdate.PrinterFirmID = Convert.ToInt32(PrinterFirmCb.SelectedValue);
                    }
                }
                db.SaveChanges();
                Load();
            }





        }

        public void Delete()
        {

            int  ID = Convert.ToInt32(PrinterModelID);

            using (ContextModel db = new ContextModel())
            {
                PrinterModel printerModel = db.PrinterModel
                   .Where(p => p.PrinterModelID == ID)
                   .FirstOrDefault();
                db.PrinterModel.Remove(printerModel);
                db.SaveChanges();

            }
            Load();
        }

    }
}
