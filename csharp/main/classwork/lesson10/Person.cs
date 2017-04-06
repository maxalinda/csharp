using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson10
{
    class Person
    {
        protected String name;
        protected String city;
        public Person(String name, String city) {
            this.name = name;
            this.city = city;
        }

        public String GetName() {
            return name;
        }

        public String GetCity()
        {
            return city;
        }
    }
}
