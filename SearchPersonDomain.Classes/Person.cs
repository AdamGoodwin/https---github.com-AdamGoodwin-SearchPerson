using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPersonDomain.Classes
{
    public class Person
    {
        public Person()
        {
            Hobbies = new List<Interests>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Profession Profession { get; set; }
        public int ProfessionId { get; set; }
        public virtual List<Interests> Hobbies { get; set; }
        public int Age { get; set; }
    }
}
