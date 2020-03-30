using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintProInc.Clasess
{
    public class WorkInLocationPrinter : ICRUD
    {
        private MetroGrid Dgv { get; set; }
        private MetroComboBox TitulCB { get; set; }
        private string  RoomNumber { get; set; }
        private string ID { get; set; }

        public WorkInLocationPrinter(MetroGrid dgv, string roomNamber, MetroComboBox titulCB, string id)
        {
            ID = id;
            RoomNumber = roomNamber;
            Dgv = dgv;
            TitulCB = titulCB;
        }

        public void Load()
        {
            using (ContextModel db = new ContextModel())
            {
                TitulCB.DataSource = db.Titul.ToList();
                TitulCB.DisplayMember = "TitulName";
                TitulCB.ValueMember = "TitulID";


                var location = from mp in db.LocationRoom
                               select new
                               {

                                   mp.LocationID,
                                   mp.Room,
                                  Titul = mp.Titul.TitulName
                               };
               Dgv.DataSource = location.ToList();

            }
        }

        public void CreateUpdate()
        {
            int LocationID = Convert.ToInt32(ID);

            using (ContextModel db = new ContextModel())
            {
                if (LocationID == 0)
                {
                    LocationRoom location = new LocationRoom
                    {
                        Room = RoomNumber,
                        TitulID = Convert.ToInt32(TitulCB.SelectedValue)
                    };
                    db.LocationRoom.Add(location);
                }
                else
                {
                    var mpToUpdate = db.LocationRoom.SingleOrDefault(pm => pm.LocationID == LocationID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.Room = RoomNumber;
                        mpToUpdate.TitulID = Convert.ToInt32(TitulCB.SelectedValue);
                    }
                }
                db.SaveChanges();
            }
        }    
    
 




    public void Delete()
        {
            int LocationID = Convert.ToInt32(ID);

            using (ContextModel db = new ContextModel())
            {
                LocationRoom location = db.LocationRoom
                   .Where(p => p.LocationID == LocationID)
                   .FirstOrDefault();
                db.LocationRoom.Remove(location);
                db.SaveChanges();
            }
        }

       
    }
}
