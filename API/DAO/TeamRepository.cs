using API.DAO.Interface;
using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO
{
    public class TeamRepository : RepositoryBase, ITeamRepository
    {
        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Team Get(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Team> Get()
        {
            throw new NotImplementedException();
        }

        public Team Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Insert(Team entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Team entity)
        {
            throw new NotImplementedException();
        }
    }
}
