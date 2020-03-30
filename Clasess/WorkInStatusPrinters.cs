using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Linq;

namespace PrintProInc.Clasess
{
    class WorkInStatusPrinters : IStatus
    {
       public string StatusID { get; set;}
       public string StatusName { get; set;}
       private MetroGrid Dgv;

        public WorkInStatusPrinters(MetroGrid dgv, string statusID, string statusName)
        {
            Dgv = dgv;
            StatusID = statusID;
            StatusName = statusName;
        }

        public void load()
        {
            using (ContextModel db = new ContextModel())
            {

                var PrinterStatus = from mp in db.PrinterStatus
                               select new
                               {
                                   mp.PrinterStatusID,
                                   mp.PrinterName 
                               };
                Dgv.DataSource = PrinterStatus.ToList();
            }
        }

        public void create()
        {
          

            int starusID = Convert.ToInt32(StatusID);

            using (ContextModel db = new ContextModel())
            {
                if (starusID == 0)
                {
                    PrinterStatus printerStatus = new PrinterStatus
                    {
                       PrinterName = StatusName
                    };
                    db.PrinterStatus.Add(printerStatus);
                }
                else
                {
                    var mpToUpdate = db.PrinterStatus.SingleOrDefault(pm => pm.PrinterStatusID == starusID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.PrinterName = StatusName;
                       
                    }
                }
                db.SaveChanges();
                
                load();
            }
        }


        public void delete()
        {
            int PrinterStatusID = Convert.ToInt32(StatusID);

            using (ContextModel db = new ContextModel())
            {
                PrinterStatus printerStatus = db.PrinterStatus
                   .Where(p => p.PrinterStatusID == PrinterStatusID)
                   .FirstOrDefault();
                db.PrinterStatus.Remove(printerStatus);
                db.SaveChanges();
                load();
            }

        }

       
    }
}
