using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Team
    {
        public int Id;
        public string Name;
        public List<Hero> Heroes;
    }
}
