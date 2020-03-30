using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Linq;

namespace PrintProInc.Clasess
{
    class WorkInOperationPrinter : IOperations
    {
        private MetroGrid Dgv { get; set; }

        public void count()
        {
            throw new NotImplementedException();
        }

        public WorkInOperationPrinter(MetroGrid dgv)
        {
            Dgv = dgv;
        }


        public void load()
        {
            using(ContextModel db = new ContextModel())
            {

                var OperatonInfo = from op in db.PrinterOperation
                                    select new
                                    {
                                        op.PrinterID,
                                        op.Printer.SerialNamber,
                                        op.PrinterStatus.PrinterName,
                                        
                                    };
                Dgv.DataSource = OperatonInfo.ToList();

            }
            

        }

        public void search()
        {
            throw new NotImplementedException();
        }



    }
}
