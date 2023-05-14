using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TicketCounterRepo : Repo, IRepo<TicketCounter, int, TicketCounter>
    {
        public TicketCounter Add(TicketCounter obj)
        {
            db.TicketCounters.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TicketCounter> Get()
        {
            throw new NotImplementedException();
        }

        public TicketCounter Get(int id)
        {
            throw new NotImplementedException();
        }

        public TicketCounter Update(TicketCounter obj)
        {
            throw new NotImplementedException();
        }
    }
}
