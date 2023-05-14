using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int age { get; set; }
        [StringLength(50)]
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual List<TicketCounter> TicketCounters { get; set; }
        public Admin()
        {
          
            Users = new List<User>();
            TicketCounters=new List<TicketCounter>();   
        }
    }
}
