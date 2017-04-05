using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson09
{
    class Human
    {
        private int age;
        private string name;
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 120 && value >= 1)
                {
                    this.age = value;
                    Console.WriteLine("New age setted");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Age invalid");
                    Console.ReadLine();
                }
            }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Human() { }
        public Human(string name, int age)
        {
            Age = age;
            Name = name;
        }
    }
}
