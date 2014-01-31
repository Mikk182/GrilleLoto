using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GrilleLoto.DatabaseLayer
{
    partial class Service : BaseService
    {
        public Partie InsertPartie(Partie partie)
        {
            var dbPartie = DB.Parties.Add(partie);
            DB.SaveChanges();
            return dbPartie;
        }

        public Partie GetPartie(Partie partie)
        {
            return DB.Parties.Single(j => j.Num == partie.Num);
        }

        public IEnumerable<Partie> GetParties()
        {
            return DB.Parties;
        }

        public bool ExistPartie(Partie partie)
        {
            return DB.Parties.Any(j => j.Num == partie.Num);
        }

        public Partie UpdatePartie(Partie partie)
        {
            DB.Entry(partie).State = EntityState.Modified;
            DB.SaveChanges();
            return partie;
        }
    }
}
