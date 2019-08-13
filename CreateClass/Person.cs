using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public enum Genders { Male, Female };

    class Person
    {
        private string name;
        private DateTime birtDate;
        private Genders gender;
        

        public Person(string name, DateTime birtDate, Genders gender)
        {
            this.name = name;
            this.birtDate = birtDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return "Person: " + name + " " + birtDate.ToString() + " " + gender;
        }
    }
}
