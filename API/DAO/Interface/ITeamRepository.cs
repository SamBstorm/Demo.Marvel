using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO.Interface
{
    interface ITeamRepository: IRepository<Team, Guid>
    {
        Team Get(string name);
    }
}
