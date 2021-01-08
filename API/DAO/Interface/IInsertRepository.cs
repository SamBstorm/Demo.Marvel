using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO.Interface
{
    interface IInsertRepository<Tentity, Tid> where Tentity: class where Tid: struct
    {
        Tid Insert(Tentity entity);
    }
}
