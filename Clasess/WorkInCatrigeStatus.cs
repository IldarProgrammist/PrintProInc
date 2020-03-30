using MetroFramework.Controls;
using PrintProInc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProInc.Clasess
{
   public class WorkInCatrigeStatus
    {


        public string StatusID { get; set; }
        public string StatusName { get; set; }
        private MetroGrid Dgv;

        public WorkInCatrigeStatus(MetroGrid dgv, string statusID, string statusName)
        {
            Dgv = dgv;
            StatusID = statusID;
            StatusName = statusName;
        }

        public void load()
        {
            using (ContextModel db = new ContextModel())
            {

                var CatrigeStatus = from mp in db.CatrigeStatus
                                    select new
                                    {
                                        mp.CatrigeStatusID,
                                        mp.CatrigeStatusName
                                    };
                Dgv.DataSource = CatrigeStatus.ToList();
            }
        }

        public void create()
        {


            int starusID = Convert.ToInt32(StatusID);

            using (ContextModel db = new ContextModel())
            {
                if (starusID == 0)
                {
                    CatrigeStatus catrigeStatus = new CatrigeStatus
                    {
                        CatrigeStatusName = StatusName
                    };
                    db.CatrigeStatus.Add(catrigeStatus);
                }
                else
                {
                    var mpToUpdate = db.CatrigeStatus.SingleOrDefault(pm => pm.CatrigeStatusID == starusID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.CatrigeStatusName = StatusName;

                    }
                }
                db.SaveChanges();

                load();
            }
        }


        public void delete()
        {
            int CatrigeStatusID = Convert.ToInt32(StatusID);

            using (ContextModel db = new ContextModel())
            {
                CatrigeStatus catrigeStatus = db.CatrigeStatus
                   .Where(p => p.CatrigeStatusID == CatrigeStatusID)
                   .FirstOrDefault();
                db.CatrigeStatus.Remove(catrigeStatus);
                db.SaveChanges();
                load();
            }

        }


    }


}

