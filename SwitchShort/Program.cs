using System;
#nullable enable
namespace SwitchShort
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new PhoneNumber();
            phone.Number = 1124;
            phone.Code = 444;
            var origin = phone
                switch
            {
                { Number: 112 } => "Emergency",
                { Code: 44 } => "Uk",
                { } => "Indetermine", //if phone != null
                //_ => "Missing" //if phone == null 
                // Indetermine ve Missing serti eyni vaxtda islemir
            };
            Console.WriteLine(origin);

            Student student = new Student("Malik", "Azim");
            var studentOrigin = student switch
            {
                { Name: "Dimitri" } => "Russia",
                { PhoneNumber: { Number: 46 } } => "Arnold",
                { PhoneNumber: { Code: 112 } } => "HollyWood",
                { Name: var name} => $"No Idea where {name} lives"
                //{ } => "Indetermine", //if phone != null
                //_ => "Missing" //if phone == null 

            };
            Console.WriteLine(studentOrigin);
        }
        static string GetName(Student student)
        {
            return (student.Name != null) ? $"{student.Surname} {student.PhoneNumber.Code} {student.PhoneNumber.Number}"
                  : $"student.Surname is null {student.PhoneNumber.Code} {student.PhoneNumber.Number}";
        }

    }
    public struct PhoneNumber
    {
        public int Code, Number;
    }
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Student(string name, string surname)
            => (Name, Surname) = (name, surname);
    }

}

