using MetroFramework.Controls;
using PrintProInc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProInc.Clasess
{
    public class PrinterWork
    {
        private MetroGrid Dgv { get; set; }
        // ID операции
        private int ID { get; set; }
        private MetroTextBox PrinterIDTB { get; set; }
        private MetroComboBox StatusCB { get; set; }
        private MetroDateTime Data { get; set; }


        public void Load()
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
                                     printer.PrinterID,
                                     printer.SerialNamber,
                                     printerOperation.OperationData,
                                     printerOperation.PrinterStatus.PrinterName
                                 };

                Dgv.DataSource = operations.ToList();

            }

        }




       

        public PrinterWork(MetroGrid dgv, MetroTextBox printerIDTB, MetroComboBox stausCB)
        {
            Dgv = dgv;
            PrinterIDTB = printerIDTB;
            StatusCB = stausCB;

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
    }
}
