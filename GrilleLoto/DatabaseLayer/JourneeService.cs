using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrilleLoto.DatabaseLayer
{
    partial class Service : BaseService
    {
        public Journee InsertJournee(Journee journee)
        {
            var DBjournee = DB.Journees.Add(journee);
            DB.SaveChanges();
            return DBjournee;
        }

        public Journee GetJournee(Journee journee)
        {
            return DB.Journees.Single(j => j.Num == journee.Num);
        }

        public IEnumerable<Journee> GetJournees()
        {
            return DB.Journees;
        }

        public bool ExistJournee(Journee journee)
        {
            return DB.Journees.Any(j => j.Num == journee.Num);
        }
    }
}
