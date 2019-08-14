using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public enum Genders { Male, Female };

    public class Person
    {
        private string _name;
        private DateTime _birthDate;
        private Genders _gender;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }
        public Genders Genders
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public override string ToString()
        {
            return "Person: " + Name + " " + BirthDate.ToString() + " " + Genders;
        }
    }
}
