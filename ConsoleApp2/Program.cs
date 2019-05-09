using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person1 p = new Person1("Neha", "Pednekar");
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.FullName);
            //Console.ReadKey();

            var personAnony = new
            {
                p.FirstName,
                p.LastName,
                p.FullName
            };

            Console.WriteLine(personAnony.FirstName);
            Console.WriteLine(personAnony.LastName);
            Console.WriteLine(personAnony.FullName);

            Console.WriteLine(isTrue().ToString().ToLower());

            //Print PI value
            Console.WriteLine(Math.Round(Math.PI, 2));

            Console.ReadKey();
        }

        private static bool isTrue() => true;
    }
}
