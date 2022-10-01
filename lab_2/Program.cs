using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ResearchTeam team1 = new ResearchTeam();
            ResearchTeam team2 = new ResearchTeam();
            Person person1 = new Person();
            Person person2 = new Person();
            person2.Name = "Billy";
            Person person3 = new Person();
            Console.WriteLine(team1.GetHashCode());
            Console.WriteLine(team2.GetHashCode());
            Console.WriteLine(team1 == null);
            Console.WriteLine(team2 != null);
            team1.AddPersons(person1);
            team1.AddPersons(person2);
            team1.AddPersons(person3);
            Console.WriteLine("=================");
            foreach (Person person in team1)
            {
                Console.WriteLine(person.GetHashCode());
            }
            Console.WriteLine("=================");
            Console.WriteLine(team1 == team2);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
