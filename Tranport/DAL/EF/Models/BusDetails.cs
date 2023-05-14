using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class BusDetails
    {
        public int Id { get; set; }

        [Required]
        public int BusNumber { get; set; }


     
        [ForeignKey("BusOwner")]
        public int BusOwnerId { get; set; }
       public virtual BusOwner BusOwner { get; set; }


    }
}
