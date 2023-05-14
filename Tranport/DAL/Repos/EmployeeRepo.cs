using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeRepo : Repo, IRepo<Employee, int, Employee>
    {
        public Employee Add(Employee obj)
        {
            db.Employees.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int Id)
        {
            var dbobj = Get(Id);
            db.Employees.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public Employee Get(int Id)
        {
            return db.Employees.Find(Id);
        }

        public Employee Update(Employee obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
