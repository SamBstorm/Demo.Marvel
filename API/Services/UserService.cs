using API.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class UserService
    {
        private UserRepository _repo = new UserRepository();

        public int Insert(Models.User user)
        {
            return _repo.Insert(new DTO.User()
            {
                Id = user.Id,
                FirstName = user.Firstname,
                LastName = user.Name,
                Pseudo = user.Pseudo,
                Password = user.Pwd
            }
            );
        }

        public Models.User Get(int id)
        {
            DTO.User user = _repo.Get(id);
            return (user == null)?null : new Models.User(user);
        }

        public int CheckPassword(string pseudo, string password)
        {
            return _repo.CheckPassword(pseudo, password);
        }
    }
}
