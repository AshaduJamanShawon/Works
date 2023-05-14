using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class CompanyContext : DbContext

    {
        public DbSet<BusOwner> BusOwners { get; set; }
        public DbSet<BusDetails> BusDetails { get; set; }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }


        public DbSet<Admin> Admins { get; set; }
     
        public DbSet<User> Users { get; set; }
        public DbSet<TicketCounter> TicketCounters { get; set; }


    }
}
