using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO
{
    public abstract class RepositoryBase
    {
        protected string connectionString = "Data Source=desktop-lgurcco;Initial Catalog=MarvelDB;Integrated Security=True";
    }
}
