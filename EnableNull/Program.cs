using System;
using System.Threading.Tasks;
#nullable enable
namespace EnableNull
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Adam", "Smith", null, null);
            var fulName = person.FullName;
            string a = person.FirstName;
            string? b = person.MiddleName;
            string c = person.LastName;
            Console.WriteLine(fulName);
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public string Klicka { get; set; }
        public Person(string first, string last, string? middle, string? klicka)
            => (FirstName, LastName, MiddleName, Klicka) = (first, last, middle, klicka);
        public string FullName => $"{FirstName} {MiddleName} {LastName} {Klicka?[0]}";
    }
}
//Bizim yazdigimiz public string Klicka { get; set; } bu kodu C#-in Kompilyatoru 
//asagidaki varianta kecirir
//public string? Klicka { get; set; }
#region
//namespace SwitchShort
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person person = new Person("Adam", "Smith", null);
//            var fulName = person.FullName;
//            string a = person.FirstName;
//            string b = person.MiddleName;
//            string c = person.LastName;
//            Console.WriteLine(fulName);
//        }
//    }

//    public class Person
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public string MiddleName { get; set; }

//        public Person(string first, string last, string middle)
//            => (FirstName, LastName, MiddleName) = (first, last, middle);

//        public string FullName => $"{FirstName} {MiddleName} {LastName}";
//    }
//}
#endregion