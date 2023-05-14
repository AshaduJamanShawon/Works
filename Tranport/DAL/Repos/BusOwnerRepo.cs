using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BusOwnerRepo : Repo, IRepo<BusOwner, int, BusOwner>
    {
        public BusOwner Add(BusOwner obj)
        {
            db.BusOwners.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int Id)
        {
            var dbobj = Get(Id);
            db.BusOwners.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<BusOwner> Get()
        {
            return db.BusOwners.ToList();
        }

        public BusOwner Get(int Id)
        {
            return db.BusOwners.Find(Id);
        }

        public BusOwner Update(BusOwner obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
