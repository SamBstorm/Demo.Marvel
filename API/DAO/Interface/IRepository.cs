using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO.Interface
{
    interface IRepository<Tentity, Tid> : 
        IGetRepository<Tentity,Tid>, 
        IInsertRepository<Tentity, Tid>, 
        IDeleteRepository<Tid>, 
        IUpdateRepository<Tentity> 
        where Tentity : class
        where Tid: struct
    {
    }
}
