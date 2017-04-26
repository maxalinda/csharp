using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Result2
    {
        public void Result() {
            Person per = new Person("Kolya", 32);
            Console.WriteLine(per.ToString());

            Student student = new Student("Egor", "KPI");
            Console.WriteLine(student.GetResponse());

            Teacher teacher = new Teacher("Ivan", "NAU");
            Console.WriteLine(teacher.GetResponse());

            Person person = new Student("Vova", "LNU");
            Console.WriteLine(person.GetResponse());

            person = new Teacher("Eugene", "HPI");
            Console.WriteLine(person.GetResponse());

            Console.ReadLine();
        }
    }
}
