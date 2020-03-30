using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Linq;
namespace PrintProInc.Clasess
{
    class FirmPrinter : ICRUD
    {

        private string PrinterFirmID { get; set; }
        private string PrinterFirmName { get; set; }
        public MetroGrid Dgv { get; set; }

        

        public FirmPrinter(MetroGrid dgv, string printerID,string printerFirmName)
        {
            Dgv = dgv;
            PrinterFirmID = printerID;
            PrinterFirmName = printerFirmName;        
        }


        public void CreateUpdate()
        {

            using (ContextModel db = new ContextModel())
            {
                int ID = Convert.ToInt32(PrinterFirmID);

                if (ID == 0)
                {
                    PrinterFirm printerFirm = new PrinterFirm
                    {
                        PrinterFirmName = PrinterFirmName,
                    };
                    db.PrinterFirm.Add(printerFirm);

                }
                else
                {
                    var mpToUpdate = db.PrinterFirm.SingleOrDefault(pm => pm.PrinterFirmID == ID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.PrinterFirmName = PrinterFirmName;
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
                int ID = Convert.ToInt32(PrinterFirmID);


                PrinterFirm printerFirm = db.PrinterFirm
                   .Where(p => p.PrinterFirmID == ID)
                   .FirstOrDefault();
                db.PrinterFirm.Remove(printerFirm);
                db.SaveChanges();
            }
            Load();
        }

        public void Load()
        {
           
           using(ContextModel db = new ContextModel())
            {

                var SelectFirmAll = from np in db.PrinterFirm
                                    select new
                                    {
                                        np.PrinterFirmID,
                                        np.PrinterFirmName
                                    };

                    Dgv.DataSource = SelectFirmAll.ToList();
            }
        }
    }
}
