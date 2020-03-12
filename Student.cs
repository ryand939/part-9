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
            this.firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);;
            this.lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);

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
                this.firstName = char.ToUpper(value[0]) + value.Substring(1);
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
                this.lastName = value;
            }
        }
        public int StudentNumber
        {
            get
            {
                return studentNumber;
            }
        }
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
        public void reset(){
            Random random = new Random();
            studentNumber = random.Next(1,999) + 555000;
        }                          
    }
}
