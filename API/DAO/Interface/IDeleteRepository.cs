using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO.Interface
{
    interface IDeleteRepository<Tid> where Tid : struct
    {
        bool Delete(Tid id);
    }
}
