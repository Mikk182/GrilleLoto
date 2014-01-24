using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrilleLoto.DatabaseLayer
{
    partial class Service : BaseService
    {
        public Partie InsertPartie(Partie partie)
        {
            var DBPartie = DB.Parties.Add(partie);
            DB.SaveChanges();
            return DBPartie;
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
    }
}
