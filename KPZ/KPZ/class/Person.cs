using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ
{
    [Serializable]
    public class Person
    {
        public string name;
        public string surname;
        public string email;

        public Person(string name, string surname, string email) {
            this.name = name;
            this.surname = surname;
            this.email = email;
        }
        public Person() {
            this.name = null;
            this.surname = null;
            this.email = null;
        }
    }
}
