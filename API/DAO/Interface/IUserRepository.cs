using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO.Interface
{
    interface IUserRepository : IGetRepository<User, int>, IInsertRepository<User, int>
    {
        int CheckPassword(string login, string password);
    }
}
