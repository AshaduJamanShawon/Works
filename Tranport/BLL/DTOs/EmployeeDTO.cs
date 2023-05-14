using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EmployeeDTO
    {

        public int Id { get; set; }


       
        public string EmployeeName { get; set; }


        public string Address { get; set; }



        public DateTime Birthdate { get; set; }

        public string Gender { get; set; }



        public int PhoneNumber { get; set; }


        public string Email { get; set; }

        public int Password { get; set; }

    }
}
