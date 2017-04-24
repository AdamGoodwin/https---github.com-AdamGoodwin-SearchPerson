using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPersonDomain.Classes
{
    public class Profession
    {
        public Profession()
        {
            People = new List<Person>();
        }
        public int Id { get; set; }
        public string ProfessionName { get; set; }
        public List<Person> People { get; set; }
    }
}
