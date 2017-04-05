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
        private String response = "Ehhhh, what was the question?";

        public Students(String name, String university)
            : base(name)
        {
            this.university = university;
        }

        public String GetResponse() {
            return response;
        }

        

    }
}
