using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Data.Entity;
using System.Linq;

namespace PrintProInc.Clasess
{
    class WorkInOperationPrinter : IOperations
    {
        private MetroGrid Dgv { get; set; }
        private MetroComboBox StatusCB { get; set; }

        public void count()
        {
            throw new NotImplementedException();
        }

        public WorkInOperationPrinter(MetroGrid dgv, MetroComboBox statusCB)
        {
            Dgv = dgv;
            StatusCB = statusCB;
        }


        public void load()
        {
            using(ContextModel db = new ContextModel())
            {
                StatusCB.DataSource = db.PrinterStatus.ToList();
                StatusCB.DisplayMember = "PrinterName";
                StatusCB.ValueMember = "PrinterStatusID";



                var operations = from printerOperation in db.PrinterOperation
                                 join printer in db.Printer on printerOperation.PrinterID equals printer.PrinterID
                                 join PrinterStatus in db.PrinterStatus on printerOperation.PrinterStatudID equals PrinterStatus.PrinterStatusID

                                 select new { 
                                   printerOperation.PrinterOperationID,
                                   printer.SerialNamber,
                                   printerOperation.OperationData,
                                   printerOperation.PrinterStatus.PrinterName
                                 };
                                 
                Dgv.DataSource = operations.ToList();

            }
        }



        public void search(string sn)
        {
            
           using(ContextModel db = new ContextModel())
            {
                var PrinterAll = from m in db.Printer.Where(p => p.SerialNamber.Contains(sn))
                                 join op in db.PrinterOperation on m.PrinterID equals op.PrinterID
                                 select new
                                 {
                                     
                                     m.PrinterID,
                                     m.SerialNamber,
                                     PrinterStatus = m.StatisPrinterID
                                                                      
                                 };
                    



                /*
                var PrinterAll = from m in db.Printer.Where(p=>p.SerialNamber==sn)
                                 select new
                                 {
                                     m.PrinterID,
                                     m.SerialNamber,
                                     
                                 };
                                 
                */
                Dgv.DataSource = PrinterAll.ToList();
            } 
           
        }

        public void search()
        {
            throw new NotImplementedException();
        }
    }
}
