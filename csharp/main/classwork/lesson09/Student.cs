using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson09
{
    class Student
    {
        //private String university;
        private String response = "Ehhhh, what was the question?";
        private int age;
        private String faculty;

        public String GetResponse() {
            return response;
        }
        public void SetResponse(string response) {
            if (!response.Equals("")) {
                this.response = response;
            }
        }
        public String GetFaculty()
        {
            return faculty;
        }
        public void SetFaculty(string faculty)
        {
            if (!response.Equals(""))
            {
                this.faculty = faculty;
            }
        }

        public Int32 GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            if (!age.Equals(null))
            {
                this.age = age;
            }
        } 
    }
}
