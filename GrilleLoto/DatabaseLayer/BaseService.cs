using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrilleLoto.DatabaseLayer
{
    class BaseService
    {
        public BDDEntities DB { get; private set; }
        public BaseService()
        {
            DB = new BDDEntities();
        }

    }
}
