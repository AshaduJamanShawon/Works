using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BusDetailsRepo : Repo, IRepo<BusDetails, int, BusDetails>
    {
        public BusDetails Add(BusDetails obj)
        {
            db.BusDetails.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int Id)
        {
            var dbobj = Get(Id);
            db.BusDetails.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<BusDetails> Get()
        {
            return db.BusDetails.ToList();
        }

        public BusDetails Get(int Id)
        {
            return db.BusDetails.Find(Id);
        }

        public BusDetails Update(BusDetails obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
