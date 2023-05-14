using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo <CLASS,ID,RET>
    {
        List<CLASS> Get();
        CLASS Get(ID Id);

        RET Add(CLASS obj);
        RET Update(CLASS obj);
        bool Delete(ID Id);

    }
}
