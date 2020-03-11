using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_9
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int studentNumber;

        public Student(string firstName, string lastName)
        {
            Random random = new Random();
            studentNumber = random.Next(1, 999) + 555000;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public int StudentNumber
        {
            get
            {
                return studentNumber;
            }
            set
            {
                Random random = new Random();
                studentNumber = random.Next(1, 999) + 555000;
            }
        }
    }
}
