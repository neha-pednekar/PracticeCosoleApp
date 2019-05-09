using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Person1
    {
        public Person1(String firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }

        //Expression-Bodies Properties
        public string FullName => $"{FirstName} {LastName}";
    }
}
