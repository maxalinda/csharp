using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson09
{
    class WhiteCollar : Human
    {
        private string companyName;
        public string CompanyName
        {
            set
            {
                if (Regex.IsMatch(value, @"^[A-z,a-z \s-]+$"))
                {
                    this.companyName = value;
                    Console.WriteLine("Company name is setted");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Company name is invalid");
                    Console.ReadLine();
                }
            }
        }
        public WhiteCollar(string name, int age, string companyName) 
            : base(name, age)
        {
            CompanyName = companyName;
        }
    }
}
