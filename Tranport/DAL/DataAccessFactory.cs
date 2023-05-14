using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {

        public static IRepo<BusOwner, int, BusOwner> BusOwnerDataAccess()
        {
            return new BusOwnerRepo();

        }
        public static IRepo<BusDetails, int, BusDetails>BusDataAccess()
        {
            return new BusDetailsRepo();
        }

        public static IRepo<Employee, int, Employee> EmployeeDataAccess()
        {
            return new EmployeeRepo();
        }
        public static IRepo<Driver, int, Driver> DriverDataAccess()
        {
            return new DriverRepo();
        }



        public static IRepo<Admin, int, Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }
       
        public static IRepo<TicketCounter, int, TicketCounter> TicketCounterDataAccess()
        {
            return new TicketCounterRepo();
        }
        public static IRepo<User, int, User> UserDataAccess()
        {
            return new UserRepo();
        }

    }
}
