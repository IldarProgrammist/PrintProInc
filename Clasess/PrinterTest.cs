using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Linq;

namespace PrintProInc.Clasess
{
    public class PrinterTest : ICRUD
    {
        public MetroLabel PrinterID { get; set; }
        private MetroGrid Dgv { get; set; }
        private MetroTextBox SerialNamber { get; set; }
        private MetroComboBox CatrigeModelCB { get; set; }
        private MetroTextBox LocarionTB { get; set; }
        private MetroTextBox LocationID { get; set; }


        public PrinterTest(MetroLabel printerID, MetroTextBox sn, MetroGrid dgv, MetroComboBox catrigeModelCB, MetroTextBox locationID)
        {
            PrinterID = printerID;
            SerialNamber = sn;
            Dgv = dgv;
            CatrigeModelCB = catrigeModelCB;
            LocarionTB = locationID; 
        }

       public PrinterTest(MetroLabel printerID, MetroTextBox sn, MetroGrid dgv, MetroComboBox catrigeModelCB, MetroTextBox locarionTB, MetroTextBox locationID)
        {
            PrinterID = printerID;
            Dgv = dgv;
            SerialNamber = sn;
            CatrigeModelCB = catrigeModelCB;
            LocarionTB = locarionTB;
        }


      
        public void CreateUpdate()
        {
            using (ContextModel db = new ContextModel())
            {
                int ID = Convert.ToInt32(PrinterID.Text);                
                if (ID == 0)
                {
                    Printer printer = new Printer
                    {  
                        SerialNamber = SerialNamber.Text,
                        CatrigeModelID = Convert.ToInt32(CatrigeModelCB.SelectedValue),
                        LocarionRoomID = Convert.ToInt32(LocarionTB.Text)
                    };
                    db.Printer.Add(printer);
                }
                else
                {
                    var mpToUpdate = db.Printer.SingleOrDefault(pm => pm.PrinterID == ID);
                    if (mpToUpdate != null)
                    {
                        
                        mpToUpdate.PrinterID = Convert.ToInt32(PrinterID.Text);
                        mpToUpdate.SerialNamber = SerialNamber.Text;
                        mpToUpdate.CatrigeModelID = Convert.ToInt32(CatrigeModelCB.SelectedValue);
                        mpToUpdate.LocarionRoomID = Convert.ToInt32(LocarionTB.Text);
                    }  
                }
                db.SaveChanges();
                Load();
            }
        }


        public void Delete()
        {
            using (ContextModel db = new ContextModel())
            {
                int ID = Convert.ToInt32(PrinterID.Text);


                Printer printer = db.Printer

                   .Where(p => p.PrinterID == ID)
                   .FirstOrDefault();
                db.Printer.Remove(printer);
                db.SaveChanges();
                Load();
            }
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
                                          p.LocationRoom.Room,
                                      };
                Dgv.DataSource = SelectPrinerAll.ToList();
            }
        }
    }
}
