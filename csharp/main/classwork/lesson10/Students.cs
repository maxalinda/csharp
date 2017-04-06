using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson10
{
    class Students : Person
    {
        private String university;
        private String faculty;
        private String response = "Ehhhh, what was the question?";

        public Students(String name, String city, String university, String faculty)
            : base(name, city)
        {
            this.university = university;
            this.faculty = faculty;
        }

        public String GetUnivercity() {
            return university;
        }

        public String GetFaculty()
        {
            return faculty;
        }

        public String GetResponse() {
            return response;
        }

        

    }
}
