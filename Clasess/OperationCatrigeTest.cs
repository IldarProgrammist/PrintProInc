using MetroFramework.Controls;
using PrintProInc.Models;
using System.Linq;
namespace PrintProInc.Clasess
{
    public class OperationCatrigeTest
    {

        public void Load( MetroGrid dgv, MetroComboBox cb)
        {
            using (ContextModel db = new ContextModel())
            {
                cb.DataSource = db.CatrigeStatus.ToList();
                cb.ValueMember = "CatrigeStatusID";
                cb.DisplayMember = "CatrigeStatusName";

                var CartrigeOperation = from np in db.CatrigeOperation
                                        join catrige in db.Catrige on np.CatrigeID  equals catrige.CatrigeID
                                        select new
                                        {               
                                            np.CatrigeOperation1,
                                            catrige.SerialNamber,
                                            np.CatrigeID,
                                            np.CatrigeStatus.CatrigeStatusName,
                                            np.OperationDate
                                        };
               dgv.DataSource = CartrigeOperation.ToList();
            }
        }


        public void searchCartrigeSN(string catrigeSN, MetroGrid dgv)

        {
            using (ContextModel db = new ContextModel())

            {
                var SearchCarigeMN = from m in db.Catrige.Where(p => p.SerialNamber.Contains(catrigeSN))

                                     select new

                                     {
                                         m.CatrigeID,
                                         m.SerialNamber,
                                         m.CatrigeModel.CatirgeModelName,
                                         m.CatrigeModel.CatrigeColor.ColorName, 
                                     };

               dgv.DataSource = SearchCarigeMN.ToList();

            }

        }




    }
}
