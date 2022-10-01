using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Paper
    {
        public string title { get; set; }
        public Person author { get; set; }
        public DateTime data { get; set; }
        public Paper(string title, Person author, DateTime data)
        {
            this.title = title;
            this.author = author;
            this.data = data;
        }
        public Paper() : this("Try programming", new Person(), new DateTime(2003, 8, 8)) { }
        public override string ToString()
        {
            return "Title:\t" + title + "\nAuthor:\n" + author.ToShortString() + "\nData:\t" + data.ToShortDateString() + '\n';
        }
        public virtual object DeepCopy()
        {
            Paper tmp = new Paper();
            tmp.title = title;
            tmp.author = author;
            tmp.data = data;
            return tmp;
        }
    }
}
