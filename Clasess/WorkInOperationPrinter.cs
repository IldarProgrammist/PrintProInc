using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Linq;

namespace PrintProInc.Clasess
{
    class WorkInOperationPrinter : IOperations, ICRUD
    {
        private MetroGrid Dgv { get; set; }
        private MetroComboBox StatusCB { get; set; }
        private string ID { get; set; }
        private MetroDateTime Date;
        private MetroTextBox PrinterIDTB { get; set; }
        public void count()
        {
            throw new NotImplementedException();
        }

        public WorkInOperationPrinter(MetroGrid dgv, MetroTextBox printerIDTB, MetroComboBox statusCB, MetroDateTime date)
        {
            Dgv = dgv;
            PrinterIDTB = printerIDTB;
            StatusCB = statusCB;
            Date = date;
            
        }

        
        public void load()
        {
            using (ContextModel db = new ContextModel())
            {
                StatusCB.DataSource = db.PrinterStatus.ToList();
                StatusCB.DisplayMember = "PrinterName";
                StatusCB.ValueMember = "PrinterStatusID";

                var operations = from printerOperation in db.PrinterOperation
                                 join printer in db.Printer on printerOperation.PrinterID equals printer.PrinterID
                                 join PrinterStatus in db.PrinterStatus on printerOperation.PrinterStatudID equals PrinterStatus.PrinterStatusID

                                 select new
                                 {
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

            using (ContextModel db = new ContextModel())
            {
                var PrinterAll = from m in db.Printer.Where(p => p.SerialNamber.Contains(sn))
                                 select new
                                 {
                                     m.PrinterID,
                                     m.SerialNamber,
                                 };
                Dgv.DataSource = PrinterAll.ToList();
            }
        }

        public void search()
        {
            throw new NotImplementedException();
        }

        public void CreateUpdate()
        {

            int PrinterOperationID = Convert.ToInt32(ID);
          
            using (ContextModel db = new ContextModel())

            {
                if (PrinterOperationID == 0)
                {
                    PrinterOperation printer = new PrinterOperation
                    {
                        PrinterOperationID = Convert.ToInt32(ID),
                        PrinterID = Convert.ToInt32(PrinterIDTB.Text),
                        PrinterStatudID = Convert.ToInt32(StatusCB.SelectedValue),
                        OperationData = DateTime.Now
                    };

                    db.PrinterOperation.Add(printer);
                }

                else
                {
                    var mpToUpdate = db.PrinterOperation.SingleOrDefault(pm => pm.PrinterOperationID == PrinterOperationID);

                    if (mpToUpdate != null)
                    {
                        mpToUpdate.PrinterID = Convert.ToInt32(PrinterIDTB.Text);
                        mpToUpdate.PrinterStatudID = Convert.ToInt32(StatusCB.SelectedValue);

                        mpToUpdate.OperationData = Convert.ToDateTime(DateTime.Now);
                    }
                }
                db.SaveChanges();
            }
        }

        public void Load()
        {
            using (ContextModel db = new ContextModel())

            {
                StatusCB.DataSource = db.PrinterStatus.ToList();

                StatusCB.DisplayMember = "PrinterName";

               StatusCB.ValueMember = "PrinterStatusID";

               StatusCB.SelectedIndex = -1;

            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
