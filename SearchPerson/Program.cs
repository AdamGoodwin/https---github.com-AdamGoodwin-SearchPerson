using SearchPersonDomain.Classes;
using SearchPersonDomain.DataModel;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<SearchPersonContext>());
            DataHelpers.NewDbWithSeed();

            SimpleQuery();  //Get List according to name.
            GetInterests();

            Console.ReadKey();
        }

        private static void GetInterests()
        {
            using (var context = new SearchPersonContext())
            {
                var people = context.People.Include(n => n.Hobbies).Where(n => n.FirstName.Equals("Manning") || n.LastName.Equals("Manning"));
                
            }
        }

        private static void SimpleQuery()
        {
            using (var context = new SearchPersonContext())
            {
                var people = context.People.Where(p => p.FirstName.Equals("James") || p.LastName.Equals("James")).ToList();

                foreach(var person in people)
                {
                    Console.WriteLine(person.FirstName + " " + person.LastName);
                    Console.WriteLine("Age: " + person.Age);
                    Console.WriteLine("Address: " + person.Address);
                }
            }
        }
    }
}
