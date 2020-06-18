using System;
namespace Switch_Based_Validations
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Dimitrina","Nana");
            Person person1 = null;
            var error = person switch
            {
                null => "Object Missing",
                { PhoneNumber :{ Number: 112} } => "Number is verifed",
                { PhoneNumber : { Code:400} } => "Code is verifed",
                { PhoneNumber : { Code:0} } => "Actually code missing",
                { PhoneNumber: null} => "Phone Number missing entirely",
                { PhoneNumber : { Code: var code} } when code < 0 => "WTF?",
                { } => null //no error
            };
            //if (error != null)
            //{
            //    throw new ArgumentException(error);
            //}
            if (error != null)
            {
                Console.WriteLine(error);
            }
        }
    }
    public struct PhoneNumber
    {
        public int Code, Number;
    }
    public class Person 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public PhoneNumber? PhoneNumber { get; set; }
        public Person(string name, string surname)
            => (Name, Surname) = (name, surname);
    }
}
