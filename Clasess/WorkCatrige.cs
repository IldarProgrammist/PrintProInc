﻿using MetroFramework.Controls;
using PrintProInc.Models;
using PrintProInc.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProInc.Clasess
{
    class WorkCatrige : ICRUD
    {
        private string CatrigeID { get; set; }
        private string SerialNamber { get; set; }
        private MetroTextBox CatrigeModelTB { get; set; }
        private MetroGrid Dgv { get; set; }
        public WorkCatrige(MetroGrid dgv)
        {
            Dgv = dgv;
        }


        public WorkCatrige(MetroGrid dgv, string catrigeID, string sn, MetroTextBox catrigeModelTB)
        {
            Dgv = dgv;
            SerialNamber = sn;
            CatrigeID = catrigeID;
            CatrigeModelTB = catrigeModelTB;
        }


        //Инфомация о моделях
        public void Load(MetroGrid dgv)
        {
            using (ContextModel db = new ContextModel())
            {
                var SelectCatrigeAll = from np in db.CatrigeModel
                                       select new
                                       {
                                           
                                           np.CatrigeModelID,
                                           np.CatirgeModelName,
                                       };
                dgv.DataSource = SelectCatrigeAll.ToList();
            }
        }



        //Полная информация о картридже
        public void Load()
        {
            using (ContextModel db = new ContextModel())
            {

                var SelectCatrigeAll = from np in db.Catrige
                                       select new
                                       {
                                           np.CatrigeID,
                                           np.SerialNamber,
                                           np.CatrigeModel.CatirgeModelName,
                                           np.CatrigeModel.CatrigeColor.ColorName,
                                           np.CatrigeModelID
                                       };

                Dgv.DataSource = SelectCatrigeAll.ToList();
            }
        }


        public void search(string sn)
        {

            using (ContextModel db = new ContextModel())
            {
                var SearchCarigeSN = from m in db.Catrige.Where(p => p.SerialNamber.Contains(sn))
                                     select new
                                     {
                                         m.CatrigeID,
                                         m.SerialNamber,
                                         m.CatrigeModel.CatirgeModelName,
                                         m.CatrigeModel.CatrigeColor.ColorName,

                                     };
                Dgv.DataSource = SearchCarigeSN.ToList();
            }
        }


    





        public void CreateUpdate()
        {
            using (ContextModel db = new ContextModel())
            {
                int ID = Convert.ToInt32(CatrigeID);

                if (ID == 0)
                {
                    Catrige catrige = new Catrige
                    {
                        SerialNamber = SerialNamber,
                        CatrigeModelID = Convert.ToInt32(CatrigeModelTB.Text)
                    };
                    db.Catrige.Add(catrige);
                }
                else
                {
                    var mpToUpdate = db.Catrige.SingleOrDefault(pm => pm.CatrigeID == ID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.SerialNamber = SerialNamber;
                        mpToUpdate.CatrigeModelID = Convert.ToInt32(CatrigeModelTB.Text);
                        //mpToUpdate.CatrigeModelID = Convert.ToInt32(CatrigeModelCB.SelectedValue);

                    }
                }
                db.SaveChanges();
                Load();
            }
        }

        public void Delete()
        {
            int ID = Convert.ToInt32(CatrigeID);



            using (ContextModel db = new ContextModel())

            {

                Catrige catrige = db.Catrige

                   .Where(p => p.CatrigeID == ID)

                   .FirstOrDefault();

                db.Catrige.Remove(catrige);

                db.SaveChanges();
            }
        }

    }
}
