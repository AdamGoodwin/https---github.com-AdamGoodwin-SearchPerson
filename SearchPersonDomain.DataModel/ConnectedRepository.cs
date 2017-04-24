using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using SearchPersonDomain.Classes;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SearchPersonDomain.DataModel
{
    public class ConnectedRepository
    {
        private readonly SearchPersonContext _context = new SearchPersonContext();

        public Person GetPersonWithInterests(int id)
        {
            return _context.People.Include(p => p.Hobbies).FirstOrDefault(p => p.Id == id);
        }

        public Person GetPersonById(int id)
        {
            return _context.People.Find(id);
        }

        public List<Person> GetPeople()
        {
            return _context.People.ToList();
        }

        public ObservableCollection<Person> PeopleInMemory()
        {
            if(_context.People.Local.Count == 0)
            {
                GetPeople();
            }
            return _context.People.Local;
        }
    }
}
