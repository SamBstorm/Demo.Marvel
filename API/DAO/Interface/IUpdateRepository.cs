using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO.Interface
{
    interface IUpdateRepository<Tentity> where Tentity: class
    {
        bool Update(Tentity entity);
    }
}
