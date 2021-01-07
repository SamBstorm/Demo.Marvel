using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class User
    {
        public int Id;
        public string Name;
        public string Firstname;
        public string Pseudo;
        public string Pwd;
        public bool Connecte;
        public List<Team> Equipes;

        public User(DTO.User user)
        {
            Id = user.Id;
            Name = user.LastName;
            Firstname = user.FirstName;
            Pseudo = user.Pseudo;
            Pwd = user.Password;
            Equipes = new List<Team>();
        }
    }
}
