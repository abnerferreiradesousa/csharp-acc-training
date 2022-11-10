using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pground
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; } = string.Empty;

        public Person(int age, string name) 
        {
            Age = age;
            Name = name;
        }

        public void Deconstruct(out int age, out string name)
        {
            age = Age;
            name = Name;
        }
    }
}