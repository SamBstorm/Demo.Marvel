using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO.Interface
{
    interface IGetRepository<Tentity, Tid> where Tentity: class where Tid: struct
    {
        IEnumerable<Tentity> Get();
        Tentity Get(Tid id);
    }
}
