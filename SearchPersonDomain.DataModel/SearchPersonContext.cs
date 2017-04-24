using System;
using System.Collections.Generic;
using SearchPersonDomain.Classes;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPersonDomain.DataModel
{
    public class SearchPersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Interests> Hobbies { get; set; }
    }
}
