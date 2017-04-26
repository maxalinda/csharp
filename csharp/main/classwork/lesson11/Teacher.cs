using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Teacher : Person
    {
        private String univercity;
        public Teacher(String name, String univercity)
            : base(name)
        {
            this.univercity = univercity;
        }

        public String LessonFinished() {
            return "Do not forget to make homework!";
        }
    }
}
