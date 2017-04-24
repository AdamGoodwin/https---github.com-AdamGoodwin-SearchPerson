using System;
using System.Collections.Generic;
using System.Data.Entity;
using SearchPersonDomain.Classes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPersonDomain.DataModel
{
    public class DataHelpers
    {
        public static void NewDbWithSeed()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SearchPersonContext>());
            using (var context = new SearchPersonContext())
            {
                if(context.People.Any())
                {
                    return;
                }
                var basketballprofession = context.Professions.Add(new Profession { Id = 1, ProfessionName = "Basketball" });
                var footballprofession = context.Professions.Add(new Profession { Id = 2, ProfessionName = "Football" });
                var musicprofession = context.Professions.Add(new Profession { Id = 3, ProfessionName = "Music" });

                var MJ = new Person
                {
                    Id = 1,
                    FirstName = "Michael",
                    LastName = "Jordan",
                    Address = "123 Chicago Way",
                    Profession = basketballprofession,
                    Age = 54,
                };
                var basketball = new Interests
                {
                    Name = "Basketball",
                    Type = InterestType.Sports
                };
                var nike = new Interests
                {
                    Name = "Nike",
                    Type = InterestType.Other
                };
                var spacejam = new Interests
                {
                    Name = "Space Jam",
                    Type = InterestType.Movies
                };

                MJ.Hobbies.Add(basketball);
                MJ.Hobbies.Add(nike);
                MJ.Hobbies.Add(spacejam);
                context.People.Add(MJ);

                var jackson = new Person
                {
                    Id = 2,
                    FirstName = "Michael",
                    LastName = "Jackson",
                    Address = "123 Thriller Way",
                    Profession = musicprofession,
                    Age = 58
                };
                var singing = new Interests
                {
                    Name = "Singing",
                    Type = InterestType.Other
                };
                var music = new Interests
                {
                    Name = "Music",
                    Type = InterestType.Other
                };
                jackson.Hobbies.Add(singing);
                jackson.Hobbies.Add(music);
                context.People.Add(jackson);

                var CM = new Person
                {
                    Id = 3,
                    FirstName = "Christine",
                    LastName = "Michael",
                    Address = "123 Seattle Way",
                    Profession = footballprofession,
                    Age = 26
                };
                var football = new Interests
                {
                    Name = "Football",
                    Type = InterestType.Sports
                };
                var seahawks = new Interests
                {
                    Name = "Seattle Seahawks",
                    Type = InterestType.Sports
                };
                CM.Hobbies.Add(football);
                CM.Hobbies.Add(seahawks);
                context.People.Add(CM);

                var JH = new Person
                {
                    Id = 4,
                    FirstName = "James",
                    LastName = "Harden",
                    Address = "123 Houston Way",
                    Profession = basketballprofession,
                    Age = 27
                };
                var rockets = new Interests
                {
                    Name = "Houston Rockets",
                    Type = InterestType.Sports
                };
                var hobbit = new Interests
                {
                    Name = "The Hobbit",
                    Type = InterestType.Books
                };
                var chess = new Interests
                {
                    Name = "Chess",
                    Type = InterestType.Games
                };
                JH.Hobbies.Add(rockets);
                JH.Hobbies.Add(hobbit);
                JH.Hobbies.Add(chess);
                context.People.Add(JH);

                var LJ = new Person
                {
                    Id = 5,
                    FirstName = "LeBron",
                    LastName = "James",
                    Address = "123 Cleveland Way",
                    Profession = basketballprofession,
                    Age = 32
                };
                var nba = new Interests
                {
                    Name = "NBA Finals",
                    Type = InterestType.TVShows
                };
                var cavs = new Interests
                {
                    Name = "Cleveland Cavaliers",
                    Type = InterestType.Sports
                };
                LJ.Hobbies.Add(nba);
                LJ.Hobbies.Add(cavs);
                context.People.Add(LJ);

                var PM = new Person
                {
                    Id = 6,
                    FirstName = "Peyton",
                    LastName = "Manning",
                    Address = "1 Indianapolis Blvd",
                    Profession = footballprofession,
                    Age = 41
                };
                var colts = new Interests
                {
                    Name = "Indianapolis Colts",
                    Type = InterestType.Sports
                };
                var broncos = new Interests
                {
                    Name = "Denver Broncos",
                    Type = InterestType.Sports
                };
                PM.Hobbies.Add(colts);
                PM.Hobbies.Add(broncos);
                context.People.Add(PM);

                var EM = new Person
                {
                    Id = 7,
                    FirstName = "Eli",
                    LastName = "Manning",
                    Age = 36,
                    Address = "1 Giants Facility Blvd",
                    Profession = footballprofession,
                };
                var giants = new Interests
                {
                    Name = "New York Giants",
                    Type = InterestType.Sports
                };
                EM.Hobbies.Add(giants);
                context.People.Add(EM);

                context.SaveChanges();
            }
        }
    }
}
