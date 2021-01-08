using API.DAO.Interface;
using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Connection;

namespace API.DAO
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public User Get(int id)
        {
            Command command = new Command("SP_GetUserById", true);
            command.AddParameter("id", id);
            Connection connection = new Connection(this.connectionString);
            return connection.ExecuteReader<User>(command, (reader) => new User()
            {
                Id = (int)reader["Id"],
                FirstName = (string)reader["FirstName"],
                LastName = (string)reader["LastName"],
                Pseudo = (string)reader["Pseudo"],
                Password = (string)reader["Password"]
            }).SingleOrDefault();
        }

        public int Insert(User user)
        {
            Command command = new Command("SP_AddUser", true);
            command.AddParameter("fn", user.FirstName);
            command.AddParameter("ln", user.LastName);
            command.AddParameter("pd", user.Pseudo);
            command.AddParameter("pwd", user.Password);
            Connection connection = new Connection(this.connectionString);
            return (int)(connection.ExecuteScalar(command));
        }

        public int CheckPassword(string pseudo, string password)
        {
            Command command = new Command("SP_CheckPasswordUser", true);
            command.AddParameter("pd", pseudo);
            command.AddParameter("pwd", password);
            Connection connection = new Connection(this.connectionString);
            return (int)(connection.ExecuteScalar(command));
        }

        public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }
    }
}
