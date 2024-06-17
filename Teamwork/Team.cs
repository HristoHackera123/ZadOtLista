using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam = new List<Person>();
        private List<Person> reserveTeam = new List<Person>();

        public string Name { get { return name; } set {  name = value; } }
        public List<Person> FirstTeam { get {  return firstTeam; }}
        public List<Person> ReserveTeam { get { return reserveTeam;}}

        public Team(string name) 
        {
            this.Name = name;
        }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }
    }
}
