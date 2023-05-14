using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string BusName { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
        public int password { get; set; }
        public int AdminId { get; set; }

    }
}
