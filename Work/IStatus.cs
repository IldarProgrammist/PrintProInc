using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProInc.Work
{
    interface IStatus
    {
        string StatusID { get; set; }
        string StatusName { get; set; }

        void load();
        void create();
        void delete();
        

    }
}
