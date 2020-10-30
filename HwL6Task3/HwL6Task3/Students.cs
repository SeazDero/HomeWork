using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL6Task3
{
    class Students
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string departament;
        public int group;
        public string city;
        public int age;
        public Students(string firstName, string lastName, string university, string faculty, string departament, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.departament = departament;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    } 
}
