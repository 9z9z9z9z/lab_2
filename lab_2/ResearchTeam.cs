using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class ResearchTeam : Team, IEnumerable
    {
        private string theme; 
        private TimeFrame timeLong;
        private ArrayList persons;
        private ArrayList papers;
        public ResearchTeam() : this("Try programming", "Homyzhenko", TimeFrame.Long) { }
        public ResearchTeam(string theme, string name, TimeFrame timeFrame)
        {
            this.theme = theme;
            this.name = name;
            this.timeLong = timeFrame;
            this.persons = new ArrayList();
            this.papers = new ArrayList();
        }
        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }
        public Team team
        {
            get
            {
                Team team = new Team(this.name, this.number);
                return team;
            }
            set
            {
                this.name = value.Name;
                this.number = value.Number;
            }
        }
        public TimeFrame GetTime()
        {
            return timeLong;
        }
        public Paper findPaper()
        {
            if (papers == null) return null;
            Paper answer = new Paper();
            foreach (Paper point in papers)
            {
                if (DateTime.Compare(point.data, answer.data) == 1)
                {
                    answer = point;
                }
            }
            return answer;
        }
        public ArrayList Papers() { return papers; }
        public ArrayList Persons() { return persons; }
        public void AddPersons(params Person[] items)
        {
            foreach (Person person in items)
            {
                persons.Add(person);
            }
        }
        public bool this[TimeFrame frame]
        {
            get { return (frame == timeLong); }
        }
        public void addPapers(params Paper[] items)
        {
            foreach (Paper paper in items)
            {
                papers.Add(paper);
            }
        }
        public override string ToString()
        {
            string list = "---------------------------------\n";
            foreach (Paper paper in papers)
            {
                list += paper.ToString() + "---------------------------------\n";
            }

            return "Thheme:\t" + theme + "\nAuthor:\t" + name + "\nNumber:\t" + number
                + '\n' + list + "=================================\n";
        }
        public string ToShortString()
        {
            return "Thheme:\t" + theme + "\nAuthor:\t" + name + "\nNumber:\t" + number
                + "\n=================================\n";
        }
        public object DeepCopy()
        {
            ResearchTeam tmp = new ResearchTeam();
            tmp.theme = theme;
            tmp.name = name;
            tmp.number = number;
            tmp.timeLong = timeLong;
            tmp.papers = papers;
            return tmp;
        }
        IEnumerable<Person> GetEnumerator()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                bool flag = false;
                Person tmp_person = (Person)persons[i];
                for (int j = 0; j < papers.Count; j++)
                {
                    Paper tmp_paper = (Paper)papers[j];
                    if (tmp_person == tmp_paper.author) flag = true;
                }
                if (!flag) {
                    yield return tmp_person; 
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return persons.GetEnumerator();
        }
    }
}
