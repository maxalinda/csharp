using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Person
    {
        protected String name;
        protected int age;

        public Person(String name, int age) {
            this.name = name;
            this.age = age;
        }
       
        public Person(String name)
        {
            this.name = name;            
        }

        public virtual String GetResponse()
        {
            return "My name is " + name;
        }

        public override string ToString()
        {
            return "Person name is " + name + " and age is " + age;
        }

    }
}
