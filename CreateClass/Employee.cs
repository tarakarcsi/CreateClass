using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {
        private int _salary;
        private string _profession;

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        public string Profession
        {
            get
            {
                return _profession;
            }
            set
            {
                _profession = value;
            }
        }
        public Room Room { get; set; }

        public Employee(string name, DateTime birthDate, Genders gender, int salary, string profession)
        {
            Name = name;
            BirthDate = birthDate;
            Genders = gender;
            Salary = salary;
            Profession = profession;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;

        }

        public override string ToString()
        {
            string result = "Employee: " + Name + " " + BirthDate + " " + Genders + " " + Salary + " " + Profession + " " + Room.RoomNumber;
            return result;
        }
    }
}
