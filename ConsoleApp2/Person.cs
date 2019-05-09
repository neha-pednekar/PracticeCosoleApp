using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Person
    {
        public Person(string name) => Name = name;

        //Auto-implemented read-only properties can be initialized using the property initializers
        public String Name { get;  }
    }
}
