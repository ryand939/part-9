using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student person = new Student("ryan", "daer");
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person);
        }
    }
}
