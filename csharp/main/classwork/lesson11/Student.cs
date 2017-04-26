using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Student : Person
    {
        private String university;       
        private String response = "Ehhhh, what was the question?";

        public readonly double pi = 3.14;


        public Student(String name, String university)
            : base(name)
        {
            this.university = university;          
        }

        public override String GetResponse()
        {
            return response;
        }

    }
}
