using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DriverRepo : Repo, IRepo<Driver, int, Driver>
    {
        public Driver Add(Driver obj)
        {
            db.Drivers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int Id)
        {
            var dbobj = Get(Id);
            db.Drivers.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Driver> Get()
        {
            return db.Drivers.ToList();
        }

        public Driver Get(int Id)
        {
            return db.Drivers.Find(Id);
        }

        public Driver Update(Driver obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
