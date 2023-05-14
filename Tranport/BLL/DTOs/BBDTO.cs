using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BBDTO : BusOwnerDTO
    {
        public virtual List<BusDetailsDTO> BusDetalisS { get; set; }
        public BBDTO()
        {
            BusDetalisS = new List<BusDetailsDTO>();
        }
    }
}
