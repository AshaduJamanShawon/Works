using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        public string password { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        public virtual Driver Admin { get; set; }
    }
}
