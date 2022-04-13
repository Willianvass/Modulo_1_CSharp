using System;
namespace Aula_09___LINQ.Model
{
    public class Student
    {
        public Student(int id, string fullName, string document, int grade)
        {
            Id = id;
            FullName = fullName;
            Document = document;
            Grade = grade;
            PhoneNumbers = new List<string> {"12345678910","12344654910","124565878910","12348321910", "123487938910"};
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Document { get; set; }
        public int Grade { set; get; }
        public List<string> PhoneNumbers { get; set; }

    }
}