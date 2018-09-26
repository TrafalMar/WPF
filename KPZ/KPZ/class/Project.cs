using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Schema;
namespace KPZ
{
    [Serializable]
    public class Project
    {
        public string name { get; set; }
        public string task { get; set; }
        public string state { get; set; }
        public List<Person> person = new List<Person>();
        
        public Project(string name,string task,string state,List<Person> person) {
            this.name = name;
            this.task = task;
            this.state = state;
            this.person = person;
        }
        public Project(string name, string task, string state)
        {
            this.name = name;
            this.task = task;
            this.state = state;
        }
        public Project()
        {
            this.name = null;
            this.task = null;
            this.state = null;
        }
    }
}
