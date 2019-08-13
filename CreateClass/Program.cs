using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime p1Date = new DateTime(2000, 6, 20);
            DateTime p2Date = new DateTime(2003, 2, 13);

            Person person1 = new Person("Karoly", p1Date, Genders.Male);
            Person person2 = new Person("Peter", p2Date, Genders.Male);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.ReadKey();
        }
    }
}
