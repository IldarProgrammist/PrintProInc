using MetroFramework.Controls;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProInc.Clasess
{
   public  class Search
    {
        private MetroGrid Dgv { get; set; }

        public Search(MetroGrid dgv)
        {
            Dgv = dgv;
        }
        
        public void search(string sn)
        {
            SqlConnection con = new SqlConnection(@"Data Source =.\;Initial Catalog = CatrigesDB; Integrated Security = True");
            con.Open();
            
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SearchPrinter", con);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@SN", sn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            Dgv.DataSource = dtbl;
            Dgv.Columns[0].Visible = false;

            con.Close();
        }



    }
}
