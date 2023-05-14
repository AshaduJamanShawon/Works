using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class BusOwner
    {
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string OwnerName { get; set; }


        [Required]
        [StringLength(50)]
        public string Address { get; set; }



        [Required]
        public int PhoneNumber { get; set; }


        [Required]
        public string Email { get; set; }


        [Required]
        public int TradelicenseNumber { get; set; }


        [Required]
        public int Password { get; set; }

        public virtual List<BusDetails> BusDetailsS { get; set; }

        public BusOwner()
        {
            BusDetailsS = new List<BusDetails>();
        }

    }
}
