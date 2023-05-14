using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Employee
    {
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }


        [Required]
        [StringLength(50)]
        public string Address { get; set; }


        [Required]
        public DateTime Birthdate { get; set; }

        [Required]
        public string Gender { get; set; }



        [Required]
        public int PhoneNumber { get; set; }


        [Required]
        public string Email { get; set; }

        [Required]
        public int Password { get; set; }

    

    }
}
