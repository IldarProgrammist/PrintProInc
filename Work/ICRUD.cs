using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProInc.Work
{
    interface ICRUD
    {
        void CreateUpdate();

        void Load();
        void Delete();
    }
}
