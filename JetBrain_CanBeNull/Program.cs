using JetBrains.Annotations;
using System;

namespace JetBrain_CanBeNull
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Adam", "Smith", null);
            var fulName = person.FullName;
            string a = person.FirstName;
            string b = person.MiddleName;
            string c = person.LastName;
            Console.WriteLine(fulName);
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [CanBeNull]
        public string MiddleName { get; set; }
        public Person(string first, string last, [CanBeNull] string middle)
            => (FirstName, LastName, MiddleName) = (first, last, middle);

        public string FullName => $"{FirstName} {MiddleName?[0]} {LastName}";
    }
}
