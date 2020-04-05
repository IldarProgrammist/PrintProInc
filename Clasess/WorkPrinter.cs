using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintProInc.Clasess
{
    public class WorkPrinter : ICRUD
    {

        public string PrinterID { get; set; }
        private MetroGrid Dgv { get; set; }
        private string SerialNamber { get; set; }
        private MetroComboBox CatrigeModelCB { get; set; }
        private MetroComboBox LocarionCB { get; set; }

        public WorkPrinter(string printerID,string sn, MetroGrid dgv, MetroComboBox catrigeModelCB, MetroComboBox locarionCB)
        {

            PrinterID = printerID;
            Dgv = dgv;
            SerialNamber = sn;
            CatrigeModelCB = catrigeModelCB;
            LocarionCB = locarionCB;

        }


        public void Load()
        {
            using (ContextModel db = new ContextModel())
            {
               CatrigeModelCB.DataSource = db.CatrigeModel.ToList();
               CatrigeModelCB.DisplayMember = "CatirgeModelName";
               CatrigeModelCB.ValueMember = "CatrigeModelID";

                var SelectPrinerAll = from p in db.Printer
                                      select new
                                      {
                                          p.PrinterID,
                                          p.SerialNamber,
                                          
                                          p.CatrigeModel.CatirgeModelName,
                                          p.LocationRoom.Titul.TitulName,
                                          p.LocationRoom.Room
                                    
                                      };
                Dgv.DataSource = SelectPrinerAll.ToList();
            }
        }

        public void CreateUpdate()
        {
            using (ContextModel db = new ContextModel())
            {
                int ID = Convert.ToInt32(PrinterID);

                if (ID == 0)
                {
                     Printer printer = new Printer
                    {
                       SerialNamber = SerialNamber,
                       CatrigeModelID = Convert.ToInt32(CatrigeModelCB.SelectedValue)
                       
                     };
                    db.Printer.Add(printer);
                }
                else
                {
                    var mpToUpdate = db.Catrige.SingleOrDefault(pm => pm.CatrigeID == ID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.SerialNamber = SerialNamber;
                        mpToUpdate.CatrigeModelID = Convert.ToInt32(CatrigeModelCB.SelectedValue);



                        //mpToUpdate.CatrigeModelID = Convert.ToInt32(CatrigeModelCB.SelectedValue);

                    }
                }
                db.SaveChanges();
                Load();
            }
        }

























        public void Delete()
        {

            int ID = Convert.ToInt32(PrinterID);

            using (ContextModel db = new ContextModel())
            {
                Printer printer = db.Printer
                   .Where(p => p.PrinterID == ID)
                   .FirstOrDefault();
                db.Printer.Remove(printer);
                db.SaveChanges();
            }
            Load();
        }

        
    }
}
